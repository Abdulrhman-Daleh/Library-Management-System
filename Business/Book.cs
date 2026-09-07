using DataAccess;
using DataAccess.DTOs;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Book
    {
        public enum Mode
        {
            Add,
            Update
        }

        private BookDTO _bookDto;
        private Mode _currentMode;

        public Mode CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }
        public int BookId
        {
            get => _bookDto.BookId;
            set => _bookDto.BookId = value;
        }

        public string Isbn
        {
            get => _bookDto.Isbn;
            set => _bookDto.Isbn = value;
        }

        public DateTime PublicationDate
        {
            get => _bookDto.PublicationDate;
            set => _bookDto.PublicationDate = value;
        }

        public int CategoryId
        {
            get => _bookDto.CategoryId;
            set => _bookDto.CategoryId = value;
        }

        public string AuthorName
        {
            get => _bookDto.AuthorName;
            set => _bookDto.AuthorName = value;
        }

        public BookCategory Category { get; set; }

        public Book()
        {
            _bookDto = new BookDTO();
            _currentMode = Mode.Add;
        }

        private Book(BookDTO bookDto)
        {
            _bookDto = bookDto;
            Category = BookCategory.FindCategory(bookDto.CategoryId);
            _currentMode = Mode.Update;
        }

        public static async Task<DataTable> GetAllBooksAsync()
        {
            return await BookData.GetAllBooksAsync();
        }

        public static Book FindBookById(int bookId)
        {
            if (BookData.FindBookById(bookId, out BookDTO bookDto))
                return new Book(bookDto);

            return null;
        }

        public static Book FindBookByCategoryId(int categoryId)
        {
            if (BookData.FindBookByCategoryId(categoryId, out BookDTO bookDto))
                return new Book(bookDto);

            return null;
        }

        private bool AddNew()
        {
            BookId = BookData.AddBook(_bookDto);
            return BookId > 0;
        }

        private bool Update()
        {
            return BookData.UpdateBook(_bookDto);
        }

        public bool Save()
        {
            if (_currentMode == Mode.Add)
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

        public static bool DeleteBook(int bookId)
        {
            return BookData.DeleteBook(bookId);
        }

        public static bool IsIsbnAlreadyUsed(string isbn)
        {
            return BookData.IsIsbnAlreadyUsed(isbn);
        }

        public int TotalCopies()
        {
            return BookData.TotalCopies(BookId);
        }

        public static async Task<DataTable> GetAllBooksByCategoryAsync(int categoryId)
        {
            return await BookData.GetAllBooksByCategoryAsync(categoryId);
        }
    }
}