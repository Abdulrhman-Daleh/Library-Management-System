using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DatabaseRegistry
    {
        public static async Task FillDefaultDataAsync()
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM BookCopyStatus)
                BEGIN
                    SET IDENTITY_INSERT BookCopyStatus ON;
                    INSERT INTO BookCopyStatus (BookStatusID, StatusTitle) VALUES 
                    (1, N'Available'), (2, N'NotAvailable'), (3, N'CheckedOut'), (4, N'OnHold'), (5, N'InLibraryUseOnly');
                    SET IDENTITY_INSERT BookCopyStatus OFF;
                END
                
                IF NOT EXISTS (SELECT 1 FROM BookConditions)
                BEGIN
                    SET IDENTITY_INSERT BookConditions ON;
                    INSERT INTO BookConditions (ConditionID, ConditionTitle, ConditionFees) VALUES 
                    (1, N'AsNew', 0.00), (2, N'Fine', 0.00), (3, N'NearFine', 2.50), (4, N'VeryGood', 5.00),
                    (5, N'Good', 7.50), (6, N'Fair', 10.00), (7, N'Poor', 20.00);
                    SET IDENTITY_INSERT BookConditions OFF;
                END
                
                IF NOT EXISTS (SELECT 1 FROM FineStatus)
                BEGIN
                    SET IDENTITY_INSERT FineStatus ON;
                    INSERT INTO FineStatus (FineStatusID, FineStatusName) VALUES (1, N'Completed'), (2, N'Pending');
                    SET IDENTITY_INSERT FineStatus OFF;
                END
                
                IF NOT EXISTS (SELECT 1 FROM BorrowStatus)
                BEGIN
                    SET IDENTITY_INSERT BorrowStatus ON;
                    INSERT INTO BorrowStatus (BorrowStatusID, BorrowStatusTitle) VALUES 
                    (1, N'Borrow'), (2, N'Return'), (3, N'Damage'), (4, N'Lost');
                    SET IDENTITY_INSERT BorrowStatus OFF;
                END
                
                IF NOT EXISTS (SELECT 1 FROM MembershipType)
                BEGIN
                    SET IDENTITY_INSERT MembershipType ON;
                    INSERT INTO MembershipType (MembershipTypeID, MembershipTypeName, MembershipFees, MembershipBorrowLimit) VALUES 
                    (1, N'Basic', 0.00, 2), (2, N'Standard', 50.00, 5), (3, N'Premium', 100.00, 10);
                    SET IDENTITY_INSERT MembershipType OFF;
                END
                
                IF NOT EXISTS (SELECT 1 FROM BookCategories)
                BEGIN
                    INSERT INTO BookCategories (CategoryName, CategoryDescription) VALUES 
                    (N'Science', N'Scientific research'), (N'History', N'Historical events'),
                    (N'Technology', N'Computer science'), (N'Fiction', N'Novels');
                END
                
                IF NOT EXISTS (SELECT 1 FROM LibraryPolicy)
                BEGIN
                    INSERT INTO LibraryPolicy (FeesPerLateDay, GracePeriodDays, LostBookFeeMultiplier, EffectiveFrom, EffectiveTo) VALUES 
                    (5.00, 2, 1.5, GETDATE(), '2030-12-31');
                END
            ";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        await connection.OpenAsync();
                        await command.ExecuteScalarAsync();
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError("DatabaseRegistry", ex.Message);
                }
            }
        }
    }
}