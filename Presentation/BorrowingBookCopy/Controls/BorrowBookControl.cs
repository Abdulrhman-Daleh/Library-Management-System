using BusinessLogic;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.BorrowingBookCopy.Controls
{
    public partial class BorrowBookControl : BaseUserControl
    {
        private BorrowTransaction.StatusType _currentBorrowStatus;

        public BorrowTransaction.StatusType ChangeBorrowStatus
        {
            get => _currentBorrowStatus;
            set
            {
                _currentBorrowStatus = value;
                ChangePageStatus(value);
            }
        }

        public BorrowBookControl()
        {
            InitializeComponent();
        }

        public void ChangePageStatus(BorrowTransaction.StatusType status)
        {
            LblStatusTitle.Text = status.ToString();

            switch (status)
            {
                case BorrowTransaction.StatusType.Borrow:
                    LblTitle.Text = "Borrow Book";
                    break;
                case BorrowTransaction.StatusType.Return:
                    LblTitle.Text = "Return Book";
                    break;
                case BorrowTransaction.StatusType.Damage:
                    LblTitle.Text = "Damage Book";
                    break;
                case BorrowTransaction.StatusType.Lost:
                    LblTitle.Text = "Lost Book";
                    break;

                default:
                    LblTitle.Text = "Borrow Book";
                    LblStatusTitle.Text = "[Not Set]";
                    break;
            }
        }

        public void LoadBookBorrowData(int borrowId, int bookCopyId, int memberId, int policyId)
        {
            LblBorrowId.Text =  borrowId <= 0 ? "[Not Set]" : borrowId.ToString();
            LblBookCopyId.Text = bookCopyId.ToString();
            LblMemberId.Text = memberId.ToString();
            LblPolicyId.Text = policyId.ToString();
        }

        public void Reset()
        {
            LblBorrowId.Text = "[Not Set]";
            LblBookCopyId.Text = "[Not Set]";
            LblMemberId.Text = "[Not Set]";
            LblPolicyId.Text = "[Not Set]";
            ChangePageStatus((BorrowTransaction.StatusType)5);
        }
    }
}