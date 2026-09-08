using BusinessLogic;
using LibrarySystem.BookCopies;
using LibrarySystem.Common;
using LibrarySystem.Members;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.BorrowingBookCopy.Controls
{
    public partial class ViewBorrowDetailsControl : BaseUserControl
    {
        private BorrowTransaction _borrowRecord;

        public ViewBorrowDetailsControl()
        {
            InitializeComponent();
        }

        private void ResetDefaultControls()
        {
            LblBorrowId.Text = "[Not Set]";
            LblBorrowStatusId.Text = "[Not Set]";
            LblBorrowDate.Text = "[Not Set]";
            LblBorrowDueDate.Text = "[Not Set]";
            LblReturnDate.Text = "[Not Set]";
            LblLostDate.Text = "[Not Set]";
        }

        private void ConfigureBorrowDataToUi()
        {
            if (GenericOperations.IsEmptyObject(_borrowRecord))
            {
                ResetDefaultControls();
                return;
            }


            LblBorrowId.Text = _borrowRecord.BorrowId.ToString();
            LblBorrowStatusId.Text = _borrowRecord.BorrowStatus.ToString();
            LblBorrowDate.Text = _borrowRecord.BorrowDate.ToShortDateString();
            LblBorrowDueDate.Text = _borrowRecord.DueDate.ToShortDateString();
            LblReturnDate.Text = _borrowRecord.GetReturnDateText();
            LblLostDate.Text = _borrowRecord.GetLostDateText();
        }

        public void LoadBorrowedBookDetails(int borrowId)
        {
            _borrowRecord = BorrowTransaction.FindByBorrowId(borrowId);

            if (GenericOperations.IsEmptyObject(_borrowRecord))
            {
                MessageBox.Show($"Borrow record {borrowId} not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaultControls();
                return;
            }

            ConfigureBorrowDataToUi();
        }

    }
}