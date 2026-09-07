using BusinessLogic;
using LibrarySystem.BorrowingBookCopy.Controls;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem.BorrowingBookCopy
{
    public partial class BorrowBookCopyForm : BaseForm
    {

        public Action<int> OnBorrowAdded;
        private BorrowTransaction _currentTransaction
        {
            get => bookTransactionsControl.Borrow;
            set => bookTransactionsControl.Borrow = value;
        }
        private BorrowTransaction.StatusType _borrowStatus { get; set;}
        private int BookCopyId { get; set; }
        private BookConditions.ConditionType _NewCopyCondition { get; set; }
        public BorrowBookCopyForm(BorrowTransaction.StatusType borrowStatus)
        {
            InitializeComponent();
            _borrowStatus = borrowStatus;
            bookTransactionsControl.SendSelectedBookCopyID += _ReciveBookCopyID;
            bookTransactionsControl.AllowBookCopySearch = true;
        }

        public BorrowBookCopyForm(int bookCopyId, BorrowTransaction.StatusType borrowStatus)
        {
            InitializeComponent();
            _borrowStatus = borrowStatus;
            _currentTransaction = BorrowTransaction.FindByBookCopyId(bookCopyId);
            bookTransactionsControl.SendNewCopyCondition += _ReciveNewCopyCondition;
            bookTransactionsControl.AllowBookCopySearch = false;

            if (borrowStatus != BorrowTransaction.StatusType.Borrow)
            bookTransactionsControl.LoadTransactionInfoToView(_currentTransaction, _borrowStatus);
            else
            bookTransactionsControl.LoadTransactionInfoToView(_currentTransaction, _borrowStatus, bookCopyId);

        }

        private void _ReciveNewCopyCondition(BookConditions.ConditionType newCopyCondition)
        {
            _NewCopyCondition = newCopyCondition;
        }

        private void _ReciveBookCopyID(int bookCopyId)
        {
            BookCopyId = bookCopyId;
            _FillInStatusOnlyTransaction();
        }

        private void SetPage(BorrowTransaction.StatusType status)
        {
            switch (status)
            {
                case BorrowTransaction.StatusType.Borrow:
                    LblTitle.Text = "Borrow Book";
                    break;
                case BorrowTransaction.StatusType.Return:
                    LblTitle.Text = "Return Book";
                    break;
                case BorrowTransaction.StatusType.Damage:
                    LblTitle.Text = "Damaged Book";
                    break;
                case BorrowTransaction.StatusType.Lost:
                    LblTitle.Text = "Lost Book";
                    break;
            }
        }

        private void _FillInStatusOnlyTransaction()
        {
            if(_borrowStatus != BorrowTransaction.StatusType.Borrow)
            {
                _currentTransaction = BorrowTransaction.FindByBookCopyId(BookCopyId);
            }
            else
            {
                _currentTransaction = new BorrowTransaction();
                _currentTransaction.PolicyInfo = Policy.GetCurrentActivePolicy();
                _currentTransaction.MemberInfo = GlobalContext.CurrentMember;
            }

            bookTransactionsControl.LoadTransactionInfoToView(_currentTransaction, _borrowStatus);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void BorrowBookCopyForm_Load(object sender, EventArgs e)
        {
            bookTransactionsControl.OnPressNextSuccess += _OnNextPressSuccess;
            bookTransactionsControl.OnPreviousPress += _OnPreviousPress;
            SetPage(_borrowStatus);

        }

        private void _OnNextPressSuccess()
        {
            BtnSave.Enabled = true;
        }

        private void _OnPreviousPress()
        {
            BtnSave.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _currentTransaction.BorrowStatus = _borrowStatus;
            _currentTransaction.ApplyDate();
            _currentTransaction.BookCopyInfo.ConditionId = (byte)_NewCopyCondition;
            if (_currentTransaction.Save())
            {
                MessageBox.Show("transaction done successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Failed to save transaction", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}