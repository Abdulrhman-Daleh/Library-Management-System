using BusinessLogic;
using LibrarySystem.Books;
using LibrarySystem.Common;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.BookCopies.Controls
{
    public partial class ViewBookCopyCardControl : BaseUserControl
    {
        private BookCopy _bookCopy;
        public BookCopy BookCopy => _bookCopy;

        private int _bookCopyId;
        public int copyId => _bookCopyId;

        public ViewBookCopyCardControl()
        {
            InitializeComponent();
        }

        private void ResetDefaults()
        {
            LblBookCopyId.Text = "[Not Set]";
            LblStatus.Text = "[Not Set]";
            LblCondition.Text = "[Not Set]";
            LblAddedDate.Text = "[??/??/????]";
            LblPrice.Text = "[$$$]";
        }

        private void BindData()
        {
            if (GenericOperations.IsEmptyObject(_bookCopy))
                return;

            LblBookCopyId.Text = _bookCopy.BookCopyId.ToString();
            LblAddedDate.Text = _bookCopy.AddedDate.ToShortDateString();
            LblStatus.Text = _bookCopy.GetStatusText();
            LblCondition.Text = _bookCopy.GetConditionText();
            LblPrice.Text = _bookCopy.BookCopyPrice.ToString();
        }

        public void LoadByBookCopyId(int bookCopyId)
        {
            _bookCopy = BookCopy.FindBookCopyById(bookCopyId);

            if (_bookCopy == null)
            {
                MessageBox.Show("Book copy not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaults();
                return;
            }

            _bookCopyId = _bookCopy.BookCopyId;
            BindData();
        }

        public void LoadByBookId(int bookId)
        {
            _bookCopy = BookCopy.FindBookCopyById(bookId);

            if (_bookCopy == null)
            {
                MessageBox.Show("Book copy not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaults();
                return;
            }
            _bookCopyId = _bookCopy.BookCopyId;
            BindData();
        }

       
    }
}