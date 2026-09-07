using DataAccess.DTOs;
using DataAccess;
using System;
using System.Data;
using System.Threading.Tasks;
using static BusinessLogic.BookConditions;

namespace BusinessLogic
{
    public class BookCopy
    {
        public enum Mode
        {
            AddNew,
            Update
        }

        public enum CopyStatus
        {
            Available = 1,
            NotAvailable = 2,
            CheckedOut = 3,
            OnHold = 4,
            InLibraryUseOnly = 5
        }

        private BookCopyDTO _bookCopyDto;
        private Mode _currentMode;

        public Mode CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }
        public int BookCopyId
        {
            get => _bookCopyDto.BookCopyId;
            set => _bookCopyDto.BookCopyId = value;
        }

        public int BookId
        {
            get => _bookCopyDto.BookId;
            set => _bookCopyDto.BookId = value;
        }

        public byte StatusId
        {
            get => _bookCopyDto.StatusId;
            set => _bookCopyDto.StatusId = value;
        }

        public byte ConditionId
        {
            get => _bookCopyDto.ConditionId;
            set => _bookCopyDto.ConditionId = value;
        }

        public DateTime AddedDate
        {
            get => _bookCopyDto.AddedDate;
            set => _bookCopyDto.AddedDate = value;
        }

        public decimal BookCopyPrice
        {
            get => _bookCopyDto.BookCopyPrice;
            set => _bookCopyDto.BookCopyPrice = value;
        }

        public Book OriginalBook { get; set; }
        public BookConditions ConditionInfo { get; set; }

        public BookCopy()
        {
            _bookCopyDto = new BookCopyDTO();
            _currentMode = Mode.AddNew;
        }

        private BookCopy(BookCopyDTO bookCopyDto)
        {
            _bookCopyDto = bookCopyDto;
            OriginalBook = Book.FindBookById(bookCopyDto.BookId);
            ConditionInfo = BookConditions.FindBookCondition(bookCopyDto.ConditionId);
            _currentMode = Mode.Update;
        }

        public static BookCopy FindBookCopyById(int bookCopyId)
        {
            if (BookCopyData.FindBookCopyById(bookCopyId, out BookCopyDTO bookCopyDto))
                return new BookCopy(bookCopyDto);

            return null;
        }

        public string GetStatusText()
        {
            switch ((CopyStatus)StatusId)
            {
                case CopyStatus.Available:
                    return "Available";
                case CopyStatus.NotAvailable:
                    return "Not Available";
                case CopyStatus.CheckedOut:
                    return "Checked Out";
                case CopyStatus.OnHold:
                    return "On Hold";
                case CopyStatus.InLibraryUseOnly:
                    return "In Library Use Only";
                default:
                    return "None";
            }
        }

        public string GetConditionText()
        {
            switch ((ConditionType)ConditionId)
            {
                case ConditionType.AsNew:
                    return "As New";
                case ConditionType.Fine:
                    return "Fine";
                case ConditionType.NearFine:
                    return "Near Fine";
                case ConditionType.VeryGood:
                    return "Very Good";
                case ConditionType.Good:
                    return "Good";
                case ConditionType.Fair:
                    return "Fair";
                case ConditionType.Poor:
                    return "Poor";
                default:
                    return "None";
            }
        }

        private bool AddNew()
        {
            BookCopyId = BookCopyData.AddBookCopy(_bookCopyDto);
            return BookCopyId > 0;
        }

        private bool Update()
        {
            return BookCopyData.UpdateBookCopy(_bookCopyDto);
        }

        public bool Save()
        {
            if (_currentMode == Mode.AddNew)
            {
                if (AddNew())
                {
                    _currentMode = Mode.Update;
                    return true;
                }

                return false;
            }

            return Update();
        }

        public static async Task<DataTable> GetAllBookCopiesAsync()
        {
            return await BookCopyData.GetAllBookCopiesAsync();
        }

        public static async Task<DataTable> GetAllBookCopiesByBookIdAsync(int bookId)
        {
            return await BookCopyData.GetAllBookCopiesByBookIdAsync(bookId);
        }

        public bool ChangeStatus(int newStatusId)
        {
            return BookCopyData.ChangeBookCopyStatus(BookCopyId, newStatusId);
        }

        public static bool ChangeStatus(int bookCopyId, int newStatusId)
        {
            return BookCopyData.ChangeBookCopyStatus(bookCopyId, newStatusId);
        }

        public static bool DeleteBookCopy(int bookCopyId)
        {
            return BookCopyData.DeleteBookCopy(bookCopyId);
        }

        private static bool IsAvailable(int bookCopyId)
        {
            return BookCopyData.IsBookCopyAvailable(bookCopyId);
        }

        public OperationResult IsBookCopyAvailable()
        {
            if (!IsAvailable(BookCopyId))
                return OperationResult.Create("selected book copy is not available", false);

            return OperationResult.Create(null, true);
        }

        public static decimal GetConditionFees(int bookCopyId)
        {
            return BookCopyData.GetBookConditionFees(bookCopyId);
        }

        public static bool UpdateCondition(int bookCopyId, int newConditionId)
        {
            return BookCopyData.UpdateBookCopyCondition(bookCopyId, newConditionId);
        }
    }
}