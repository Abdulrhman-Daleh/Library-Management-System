using DataAccess;
using DataAccess.DTOs;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BorrowTransaction
    {
        public enum ModeType
        {
            Add = 1,
            Update = 2
        }

        public enum StatusType
        {
            Borrow = 1,
            Return = 2,
            Damage = 3,
            Lost = 4
        }

        private BorrowTransactionDTO _transactionDto;
        public ModeType CurrentMode { get; set; }

        public int BorrowId
        {
            get => _transactionDto.BorrowId;
            set => _transactionDto.BorrowId = value;
        }

        public int MemberId
        {
            get => _transactionDto.MemberId;
            set => _transactionDto.MemberId = value;
        }

        public int BookCopyId
        {
            get => _transactionDto.BookCopyId;
            set => _transactionDto.BookCopyId = value;
        }

        public int PolicyId
        {
            get => _transactionDto.PolicyId;
            set => _transactionDto.PolicyId = value;
        }

        public StatusType BorrowStatus
        {
            get => (StatusType)_transactionDto.BorrowStatusId;
            set => _transactionDto.BorrowStatusId = (int)value;
        }

        public DateTime BorrowDate
        {
            get => _transactionDto.BorrowDate;
            set => _transactionDto.BorrowDate = value;
        }

        public DateTime DueDate
        {
            get => _transactionDto.DueDate;
            set => _transactionDto.DueDate = value;
        }

        public DateTime? ReturnDate
        {
            get => _transactionDto.ReturnDate;
            set => _transactionDto.ReturnDate = value;
        }

        public DateTime? LostDate
        {
            get => _transactionDto.LostDate;
            set => _transactionDto.LostDate = value;
        }

        public Member MemberInfo { get; set; }
        public BookCopy BookCopyInfo { get; set; }
        public Policy PolicyInfo { get; set; }

        public BorrowTransaction(BorrowTransactionDTO transactionDto)
        {
            _transactionDto = transactionDto;
            MemberInfo = Member.FindByMemberId(transactionDto.MemberId);
            BookCopyInfo = BookCopy.FindBookCopyById(transactionDto.BookCopyId);
            PolicyInfo = Policy.GetCurrentActivePolicy();
            CurrentMode = ModeType.Update;
        }

        public BorrowTransaction()
        {
            _transactionDto = new BorrowTransactionDTO();
            CurrentMode = ModeType.Add;
            PolicyInfo = Policy.GetCurrentActivePolicy();
        }

        public static async Task<DataTable> GetAllAsync(User currentUser, int memberId)
        {
            if (currentUser.HasPermission(User.Permissions.All))
                return await BorrowBookData.GetBorrowTransactionsAsync();

            if (currentUser.HasPermission(User.Permissions.ManageBorrowTransactions))
                return await BorrowBookData.GetBorrowTransactionsByMemberIdAsync(memberId);

            return null;
        }

        public static BorrowTransaction FindByBookCopyId(int bookCopyId)
        {
            BorrowTransactionDTO transactionDto = BorrowBookData.GetBorrowTransactionByCopyId(bookCopyId);
            return transactionDto == null ? null : new BorrowTransaction(transactionDto);
        }

        public static BorrowTransaction FindByBorrowId(int? borrowId)
        {
            BorrowTransactionDTO transactionDto = BorrowBookData.GetBorrowTransactionById(borrowId);
            return transactionDto == null ? null : new BorrowTransaction(transactionDto);
        }

        public string GetReturnDateText()
        {
            return ReturnDate.HasValue ? ReturnDate.Value.ToShortDateString() : "[Not Returned]";
        }

        public string GetLostDateText()
        {
            return LostDate.HasValue ? LostDate.Value.ToShortDateString() : "[Not Lost]";
        }

        private bool Add()
        {
            BorrowId = BorrowBookData.CreateBorrowTransaction(_transactionDto);
            return BorrowId > 0;
        }

        private bool Update()
        {
            return BorrowBookData.UpdateBorrowTransaction(
                _transactionDto.BorrowId,
                _transactionDto.BookCopyId,
                BookCopyInfo.ConditionId,
                _transactionDto.BorrowStatusId);
        }

        public OperationResult ValidateNewCondition(BookConditions.ConditionType newCondition)
        {
            if (BookCopyInfo.ConditionId >= (int)newCondition)
                return new OperationResult("new condition must be worse than current or equal", false);

            return new OperationResult(null, true);
        }

        public bool Save()
        {
            if (CurrentMode == ModeType.Add)
            {
                CurrentMode = ModeType.Update;
                return Add();
            }

            return Update();
        }

        public void ApplyDate()
        {
            switch (BorrowStatus)
            {
                case StatusType.Borrow:
                    ReturnDate = null;
                    LostDate = null;
                    DueDate = DateTime.Now.AddDays(21);
                    BorrowDate = DateTime.Now;
                    break;

                case StatusType.Return:
                    ReturnDate = DateTime.Now;
                    LostDate = null;
                    break;

                case StatusType.Lost:
                    LostDate = DateTime.Now;
                    ReturnDate = null;
                    break;

                case StatusType.Damage:
                    ReturnDate = DateTime.Now;
                    LostDate = null;
                    break;
            }
        }

        public OperationResult ValidateNext(StatusType status)
        {
            OperationResult result = ValidateRequiredEntities();
            if (!result.Success)
                return result;


            if (MemberInfo.IsMembershipExpired())
                return new OperationResult("Membership expired. Please renew.", false);

            if (status == StatusType.Borrow)
            {

                result = BookCopyInfo.IsBookCopyAvailable();
                if (result.Success)
                {
                    if (MemberInfo.IsAtBorrowLimit())
                        return new OperationResult("Borrow limit reached.", false);

                    if (MemberInfo.HasGeneralFees())
                        return new OperationResult("Outstanding fines.", false);
                }
                else
                    return result;
            }

            if (IsSameTransaction(status))
                return new OperationResult($"Book copy can't perform this operation", false);


            return OperationResult.Create(null, true);
        }

        public OperationResult ValidateRequiredEntities()
        {
            if (Util.IsEmptyObject(MemberInfo))
                return new OperationResult("membership is required", false);

            if (Util.IsEmptyObject(BookCopyInfo))
                return new OperationResult("Book copy not loaded.", false);

            if (Util.IsEmptyObject(PolicyInfo))
                return new OperationResult("No policy.", false);


            return OperationResult.Create(null, true);
        }

        public bool IsSameTransaction(StatusType status)
        {
            if (status == StatusType.Borrow)
                return BorrowBookData.IsBookCopyBorrowed(BookCopyId);

            return !BorrowBookData.IsBookCopyBorrowed(BookCopyId);
        }

        public static int GetTotalBorrowedTransactionForMember(int memberId)
        {
            return BorrowBookData.GetTotalBorrowedTransactionForMember(memberId);
        }

        public static short GetTotalOverdueTransactionForMember(int memberId)
        {
            return BorrowBookData.GetTotalOverdueTransactionForMember(memberId);
        }
    }
}