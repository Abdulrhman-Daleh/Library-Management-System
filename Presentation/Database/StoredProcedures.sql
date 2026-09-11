CREATE PROCEDURE [dbo].[SP_BorrowBook]
    @BookCopyID INT,
    @MemberID INT,
    @PolicyID INT,
    @BorrowStatusID INT,
    @BorrowDate DATETIME,
    @DueDate DATETIME,
    @ReturnDate DATETIME,
    @LostDate DATETIME,
    @BorrowID INT OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        DECLARE @Result BIT;

        EXEC SP_IsMembershipExpired
            @MemberID = @MemberID,
            @Expired = @Result OUTPUT;

        IF @Result > 0
            THROW 50001, 'Membership expired', 1;

        EXEC SP_HasReachedBorrowLimit
            @MemberID = @MemberID,
            @LimitReached = @Result OUTPUT;

        IF @Result > 0
            THROW 50002, 'Member reached borrow limit', 1;

        INSERT INTO BorrowTransactions
        (
            BookCopyID,
            MemberID,
            PolicyID,
            BorrowStatusID,
            BorrowDate,
            DueDate,
            ReturnDate,
            LostDate
        )
        VALUES
        (
            @BookCopyID,
            @MemberID,
            @PolicyID,
            @BorrowStatusID,
            @BorrowDate,
            @DueDate,
            @ReturnDate,
            @LostDate
        );

        SET @BorrowID = SCOPE_IDENTITY();

        UPDATE BookCopies
        SET StatusID = 3
        WHERE BookCopyID = @BookCopyID;

        COMMIT TRANSACTION
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH
END
GO


CREATE PROCEDURE [dbo].[SP_CalculateBorrowFines]
    @BookCopyID INT,
    @DueDate DATETIME,
    @PolicyID INT,
    @TotalFees DECIMAL(10,2) OUTPUT
AS
BEGIN
    DECLARE @LateDays INT =
        DATEDIFF(DAY, @DueDate, GETDATE())
        -
        (
            SELECT GracePeriodDays
            FROM LibraryPolicy
            WHERE PolicyID = @PolicyID
        );

    IF @LateDays <= 0
    BEGIN
        SET @TotalFees = 0;
        RETURN;
    END

    SET @TotalFees =
        @LateDays *
        (
            SELECT FeesPerLateDay
            FROM LibraryPolicy
            WHERE PolicyID = @PolicyID
        );
END
GO


CREATE PROCEDURE [dbo].[SP_CheckCopyIfAvilable]
    @BookCopyID INT,
    @IsAvailable BIT OUTPUT
AS
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM BookCopies
        WHERE BookCopyID = @BookCopyID
    )
    BEGIN
        SET @IsAvailable = 0;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM BookCopies
        WHERE BookCopyID = @BookCopyID
            AND StatusID = 1
    )
    BEGIN
        SET @IsAvailable = 0;
        RETURN;
    END

    SET @IsAvailable = 1;
END
GO


CREATE PROCEDURE [dbo].[SP_DamagedBook]
    @BookCopyID INT,
    @BorrowID INT,
    @NewConditionID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        DECLARE @CurrentConditionFees DECIMAL(10,2) =
        (
            SELECT ConditionFees
            FROM BookConditions AS BookC
            INNER JOIN BookCopies AS BCopy
                ON BookC.ConditionID = BCopy.ConditionID
            WHERE BCopy.BookCopyID = @BookCopyID
        );

        DECLARE @NewConditionFees DECIMAL(10,2) =
        (
            SELECT ConditionFees
            FROM BookConditions
            WHERE ConditionID = @NewConditionID
        );

        DECLARE @DamageFees DECIMAL(10,2) =
            @NewConditionFees - @CurrentConditionFees;

        IF @DamageFees > 0
        BEGIN
            INSERT INTO Fines
            (
                BorrowID,
                FineStatusID,
                FineAmount,
                Reason,
                CreatedDate,
                ClosedDate,
                RenewID
            )
            VALUES
            (
                @BorrowID,
                2,
                @DamageFees,
                'Damaged Book',
                GETDATE(),
                NULL,
                NULL
            );
        END

        UPDATE BookCopies
        SET
            StatusID = 1,
            ConditionID = @NewConditionID
        WHERE BookCopyID = @BookCopyID;

        UPDATE BorrowTransactions
        SET
            BorrowStatusID = 3,
            ReturnDate = GETDATE()
        WHERE BorrowID = @BorrowID;

        COMMIT TRANSACTION
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH
END
GO


CREATE PROCEDURE [dbo].[SP_DoesBorrowHasFees]
    @BorrowID INT,
    @HasFees BIT OUTPUT
AS
BEGIN
    DECLARE @BorrowFees DECIMAL(10,2) =
    (
        SELECT FineAmount
        FROM Fines
        WHERE BorrowID = @BorrowID
    );

    DECLARE @PaidAmount DECIMAL(10,2) =
    ISNULL
    (
        (
            SELECT SUM(AmountPaid)
            FROM FinePayments AS FPayment
            INNER JOIN Fines AS F
                ON F.FineID = FPayment.FineID
            WHERE F.BorrowID = @BorrowID
        ),
        0
    );

    DECLARE @Remaining DECIMAL(10,2) =
        @BorrowFees - @PaidAmount;

    IF @Remaining > 0
        SET @HasFees = 1;
    ELSE
        SET @HasFees = 0;
END
GO


CREATE PROCEDURE [dbo].[SP_DoesRenewHasFees]
    @RenewID INT,
    @HasFees BIT OUTPUT
AS
BEGIN
    DECLARE @BorrowFees DECIMAL(10,2) =
    (
        SELECT FineAmount
        FROM Fines
        WHERE RenewID = @RenewID
    );

    DECLARE @PaidAmount DECIMAL(10,2) =
    ISNULL
    (
        (
            SELECT SUM(AmountPaid)
            FROM FinePayments AS FPayment
            INNER JOIN Fines AS F
                ON F.FineID = FPayment.FineID
            WHERE F.RenewID = @RenewID
        ),
        0
    );

    DECLARE @Remaining DECIMAL(10,2) =
        @BorrowFees - @PaidAmount;

    IF @Remaining > 0
        SET @HasFees = 1;
    ELSE
        SET @HasFees = 0;
END
GO


CREATE PROCEDURE [dbo].[SP_FinePayment]
    @FineID INT,
    @RenewID INT,
    @AmountPaid DECIMAL(10,2),
    @PaymentMethod NVARCHAR(100),
    @PaymentID INT OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        INSERT INTO FinePayments
        (
            FineID,
            AmountPaid,
            PaymentDate,
            PaymentMethod
        )
        VALUES
        (
            @FineID,
            @AmountPaid,
            GETDATE(),
            @PaymentMethod
        );

        SET @PaymentID = SCOPE_IDENTITY();

        DECLARE @Result BIT;

        DECLARE @BorrowId INT =
        (
            SELECT BorrowID
            FROM Fines
            WHERE FineID = @FineID
        );

        EXEC SP_DoesBorrowHasFees
            @BorrowID = @BorrowId,
            @HasFees = @Result OUTPUT;

        IF @Result = 0
        BEGIN
            UPDATE Fines
            SET
                ClosedDate = GETDATE(),
                RenewID = @RenewID,
                FineStatusID = 1
            WHERE FineID = @FineID;

            IF @RenewID IS NOT NULL
            BEGIN
                EXEC SP_DoesRenewHasFees
                    @RenewID = @RenewID,
                    @HasFees = @Result OUTPUT;

                IF @Result = 0
                BEGIN
                    UPDATE Renew
                    SET Renew.IsPaid = 1
                    FROM MembershipRenews AS Renew
                    INNER JOIN Fines AS F
                        ON F.RenewID = Renew.RenewID
                    WHERE F.FineID = @FineID;
                END
            END
        END

        COMMIT TRANSACTION
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH
END
GO


CREATE PROCEDURE [dbo].[SP_getTotalMembershipTypeFees]
    @MembershipTypeID int,    
    @FinesAmount decimal(10, 2) output  
    as     
begin    
    declare @MembershipFees decimal(13,2);    
    declare @PaidAmount decimal(13,2);    
    
    set @MembershipFees = (IsNull((select Sum(f.FineAmount) from MembershipType as mtype    
                    inner join Members as m on m.MembershipTypeID = mtype.MembershipTypeID    
                    inner join BorrowTransactions as borrowT on borrowT.MemberID = m.MemberID    
                    inner join Fines as f on f.BorrowID = borrowT.BorrowID WHERE mtype.MembershipTypeID = @MembershipTypeID), 0));    
    
     set @PaidAmount = (ISNULL((select Sum(fineP.AmountPaid) from MembershipType as mtype    
                    inner join Members as m on m.MembershipTypeID = mtype.MembershipTypeID    
                    inner join BorrowTransactions as borrowT on borrowT.MemberID = m.MemberID    
                    inner join Fines as f on f.BorrowID = borrowT.BorrowID    
                    inner join FinePayments fineP on fineP.FineID = f.FineID WHERE mtype.MembershipTypeID = @MembershipTypeID), 0))    
    
    
        set @FinesAmount = @MembershipFees - @PaidAmount;    
    
End
GO


CREATE PROCEDURE [dbo].[SP_HasGeneralFees]
    @MemberID INT,
    @HasGeneralFees BIT OUTPUT
AS
BEGIN
    IF EXISTS
    (
        SELECT 1
        FROM Fines AS F
        INNER JOIN BorrowTransactions AS Borrow
            ON F.BorrowID = Borrow.BorrowID
        WHERE Borrow.MemberID = @MemberID
            AND F.ClosedDate IS NULL
    )
    BEGIN
        SET @HasGeneralFees = 1;
        RETURN;
    END

    IF EXISTS
    (
        SELECT 1
        FROM Fines AS F
        INNER JOIN MembershipRenews AS MR
            ON MR.RenewID = F.RenewID
        WHERE F.ClosedDate IS NULL
            AND MR.MemberID = @MemberID
    )
    BEGIN
        SET @HasGeneralFees = 1;
        RETURN;
    END

    SET @HasGeneralFees = 0;
END
GO


CREATE PROCEDURE [dbo].[SP_HasMembershipRenewFees]
    @RenewID INT,
    @HasFine BIT OUTPUT
AS
BEGIN
    DECLARE @PaidAmount DECIMAL(10,2) =
    ISNULL
    (
        (
            SELECT SUM(FPayment.AmountPaid)
            FROM FinePayments AS FPayment
            INNER JOIN Fines AS F
                ON FPayment.FineID = F.FineID
            WHERE F.RenewID = @RenewID
        ),
        0
    );

    DECLARE @FineAmount DECIMAL(10,2) =
    (
        SELECT FineAmount
        FROM Fines
        WHERE RenewID = @RenewID
    );

    DECLARE @Remainder DECIMAL(10,2) =
        @FineAmount - @PaidAmount;

    IF @Remainder <= 0
    BEGIN
        SET @HasFine = 0;
        RETURN;
    END

    SET @HasFine = 1;
END
GO


CREATE PROCEDURE [dbo].[SP_HasReachedBorrowLimit]
    @MemberID INT,
    @LimitReached BIT OUTPUT
AS
BEGIN
    IF
    (
        SELECT COUNT(*)
        FROM BorrowTransactions
        WHERE MemberID = @MemberID
            AND ReturnDate IS NULL
            AND LostDate IS NULL
    )
    >=
    ISNULL
    (
        (
            SELECT MembershipBorrowLimit
            FROM MembershipType
            INNER JOIN Members
                ON Members.MembershipTypeID = MembershipType.MembershipTypeID
            WHERE Members.MemberID = @MemberID
        ),
        0
    )
    BEGIN
        SET @LimitReached = 1;
        RETURN;
    END

    SET @LimitReached = 0;
END
GO


CREATE PROCEDURE [dbo].[SP_IsBookCopyBorrowed]
    @BookCopyID INT,
    @IsBorrowed BIT OUTPUT
AS
BEGIN
    IF EXISTS
    (
        SELECT 1
        FROM BorrowTransactions
        WHERE BookCopyID = @BookCopyID
            AND ReturnDate IS NULL
            AND LostDate IS NULL
    )
    BEGIN
        SET @IsBorrowed = 1;
        RETURN;
    END

    SET @IsBorrowed = 0;
END
GO


CREATE PROCEDURE [dbo].[SP_IsMembershipExpired]
    @MemberID INT,
    @Expired BIT OUTPUT
AS
BEGIN
    IF EXISTS
    (
        SELECT 1
        FROM Members
        WHERE MemberID = @MemberID
            AND Members.MembershipExpirationDate <= SYSDATETIMEOFFSET()
    )
        SET @Expired = 1;
    ELSE
        SET @Expired = 0;
END
GO


CREATE PROCEDURE [dbo].[SP_LostBook]
    @BookCopyID INT,
    @BorrowID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        DECLARE @BookPrice DECIMAL(10,2) =
        (
            SELECT BookCopyPrice
            FROM BookCopies
            WHERE BookCopyID = @BookCopyID
        );

        INSERT INTO Fines
        (
            BorrowID,
            FineStatusID,
            FineAmount,
            Reason,
            CreatedDate,
            ClosedDate,
            RenewID
        )
        VALUES
        (
            @BorrowID,
            2,
            @BookPrice,
            'Lost Book',
            GETDATE(),
            NULL,
            NULL
        );

        UPDATE BookCopies
        SET StatusID = 2
        WHERE BookCopyID = @BookCopyID;

        UPDATE BorrowTransactions
        SET
            BorrowStatusID = 4,
            LostDate = GETDATE()
        WHERE BorrowID = @BorrowID;

        COMMIT TRANSACTION
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH
END
GO


CREATE PROCEDURE [dbo].[SP_PerformReturnLostDamaged]
    @BookCopyID INT,
    @BorrowId INT,
    @NewConditionID INT,
    @BorrowStatus INT,
    @Result BIT OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        IF @BorrowStatus = 2
            EXEC SP_ReturnBook
                @BookCopyID = @BookCopyID,
                @BorrowID = @BorrowId;

        ELSE IF @BorrowStatus = 3
            EXEC SP_DamagedBook
                @BookCopyID = @BookCopyID,
                @BorrowID = @BorrowId,
                @NewConditionID = @NewConditionID;

        ELSE IF @BorrowStatus = 4
            EXEC SP_LostBook
                @BookCopyID = @BookCopyID,
                @BorrowID = @BorrowId;

        ELSE
            THROW 50006, 'invalid transaction return state', 1;

        COMMIT TRANSACTION

        SET @Result = 1;
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        SET @Result = 0;

        THROW;
    END CATCH
END
GO


CREATE PROCEDURE [dbo].[SP_RenewMembership]
    @MemberID INT,
    @MembershipTypeID INT,
    @RenewID INT OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        DECLARE @RenewFees DECIMAL =
        (
            SELECT MembershipFees
            FROM MembershipType
            WHERE MembershipTypeID = @MembershipTypeID
        );

        INSERT INTO MembershipRenews
        (
            MemberID,
            MembershipTypeID,
            RenewDate,
            RenewFees,
            IsPaid
        )
        VALUES
        (
            @MemberID,
            @MembershipTypeID,
            GETDATE(),
            @RenewFees,
            0
        );

        SET @RenewID = SCOPE_IDENTITY();

        INSERT INTO Fines
        (
            BorrowID,
            FineStatusID,
            FineAmount,
            Reason,
            CreatedDate,
            ClosedDate,
            RenewID
        )
        VALUES
        (
            NULL,
            2,
            @RenewFees,
            'Membership renewal',
            GETDATE(),
            NULL,
            @RenewID
        );

        UPDATE Members
        SET MembershipExpirationDate =
            DATEADD(MONTH, 1, MembershipExpirationDate)
        WHERE MemberID = @MemberID;

        COMMIT TRANSACTION
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH
END
GO


CREATE PROCEDURE [dbo].[SP_ReturnBook]
    @BookCopyID INT,
    @BorrowID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        DECLARE @DueDate DATETIME =
        (
            SELECT DueDate
            FROM BorrowTransactions
            WHERE BorrowID = @BorrowID
        );

        DECLARE @PolicyID INT =
        (
            SELECT PolicyID
            FROM BorrowTransactions
            WHERE BorrowID = @BorrowID
        );

        DECLARE @Fees DECIMAL(10,2);
        DECLARE @Result BIT;

        EXEC SP_IsBookCopyBorrowed
            @BookCopyID,
            @IsBorrowed = @Result OUTPUT;

        IF @Result <= 0
            THROW 50004, 'book copy is not borrowed', 1;

        EXEC SP_CalculateBorrowFines
            @BookCopyID = @BookCopyID,
            @DueDate = @DueDate,
            @PolicyID = @PolicyID,
            @TotalFees = @Fees OUTPUT;

        IF @Fees > 0
        BEGIN
            INSERT INTO Fines
            (
                BorrowID,
                FineStatusID,
                FineAmount,
                Reason,
                CreatedDate,
                ClosedDate,
                RenewID
            )
            VALUES
            (
                @BorrowID,
                2,
                @Fees,
                'Late return',
                GETDATE(),
                NULL,
                NULL
            );
        END

        UPDATE BorrowTransactions
        SET
            BorrowStatusID = 2,
            ReturnDate = GETDATE()
        WHERE BorrowID = @BorrowID;

        UPDATE BookCopies
        SET StatusID = 1
        WHERE BookCopyID = @BookCopyID;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH
END
GO


CREATE PROCEDURE [dbo].[SP_TotalUnpaidFees]
    @MemberID INT,
    @TotalUnpaidFees DECIMAL OUTPUT
AS
BEGIN
    DECLARE @TotalBorrowFees DECIMAL(10,2) =
    (
        SELECT ISNULL(SUM(FineAmount), 0)
        FROM Fines AS F
        INNER JOIN BorrowTransactions AS Borrow
            ON Borrow.BorrowID = F.BorrowID
        WHERE Borrow.MemberID = @MemberID
            AND ClosedDate IS NULL
    );

    DECLARE @TotalRenewFees DECIMAL(10,2) =
    (
        SELECT ISNULL(SUM(FineAmount), 0)
        FROM Fines AS F
        INNER JOIN MembershipRenews AS Renews
            ON Renews.RenewID = F.RenewID
        WHERE F.RenewID IS NOT NULL
            AND Renews.MemberID = @MemberID
            AND IsPaid = 0
    );

    SET @TotalUnpaidFees =
        @TotalBorrowFees + @TotalRenewFees;
END
GO


CREATE PROCEDURE [dbo].[SP_UpdateMemberMembership]
    @MemberID INT,
    @MembershipTypeID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        DECLARE @RenewFees DECIMAL(10,2) =
        (
            SELECT MembershipFees
            FROM MembershipType
            WHERE MembershipTypeID = @MembershipTypeID
        );

        DECLARE @RenewID INT;

        INSERT INTO MembershipRenews
        (
            MemberID,
            MembershipTypeID,
            RenewDate,
            RenewFees,
            IsPaid
        )
        VALUES
        (
            @MemberID,
            @MembershipTypeID,
            GETDATE(),
            @RenewFees,
            0
        );

        SET @RenewID = SCOPE_IDENTITY();

        IF @RenewFees > 0
        BEGIN
            INSERT INTO Fines
            (
                BorrowID,
                FineStatusID,
                FineAmount,
                Reason,
                CreatedDate,
                ClosedDate,
                RenewID
            )
            VALUES
            (
                NULL,
                2,
                @RenewFees,
                'Membership renewal',
                GETDATE(),
                NULL,
                @RenewID
            );
        END
        ELSE
            UPDATE MembershipRenews
            SET IsPaid = 1
            WHERE RenewID = @RenewID;

        UPDATE Members
        SET
            MembershipExpirationDate = DATEADD(MONTH, 1, GETDATE()),
            MembershipTypeID = @MembershipTypeID
        WHERE MemberID = @MemberID;

        COMMIT TRANSACTION
    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH
END
GO