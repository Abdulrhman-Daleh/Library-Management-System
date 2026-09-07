using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.BorrowingBookCopy.Controls
{
    public partial class BookTransactionsControl : BaseUserControl
    {
        public Action OnPressNextSuccess;
        public Action OnPreviousPress;
        public Action<int> SendSelectedBookCopyID;
        private BorrowTransaction.StatusType _OuterStatus { get; set; }
        public BorrowTransaction Borrow { get; set; }
        public Action<BookConditions.ConditionType> SendNewCopyCondition;
        public BookTransactionsControl()
        {
            InitializeComponent();
            findBookCopyWithFilterControl.SendBookCopyId += _GetBookCopyId_OnSelect;
            TcPages.TabPages["tpBorrowBookCopy"].Enabled = false;
            findBookCopyWithFilterControl.EnableSearchSection = true;
        }

        public bool AllowBookCopySearch
        {
            get { return findBookCopyWithFilterControl.EnableSearchSection; }
            set
            {
                findBookCopyWithFilterControl.EnableSearchSection = value;
            }
        }

        private void _GetBookCopyId_OnSelect(int bookCopyId)
        {
            SendSelectedBookCopyID?.Invoke(bookCopyId);
        }

        public void LoadTransactionInfoToView(BorrowTransaction borrowDetails, BorrowTransaction.StatusType outerOperationStatus, int bookCopyHolderID = -1)
        {
            Borrow = borrowDetails;
            _OuterStatus = outerOperationStatus;

            if(!GenericOperations.IsEmptyObject(Borrow))
            {
                if(Borrow.BookCopyId >= 1)
                findBookCopyWithFilterControl.LoadBookCopyById(Borrow.BookCopyId);

                if (outerOperationStatus == BorrowTransaction.StatusType.Borrow)
                    borrowDetails.CurrentMode = BorrowTransaction.ModeType.Add;

                if (!GenericOperations.IsEmptyObject(findBookCopyWithFilterControl.SelectedBookCopy))
                {
                    Borrow.BookCopyInfo = findBookCopyWithFilterControl.SelectedBookCopy;
                    Borrow.BookCopyId = Borrow.BookCopyInfo.BookCopyId;
                    LblBorrowID.Text = Borrow.BorrowId <= 0 ? "[????]" : Borrow.BorrowId.ToString();
                }
            }
            else 
            {
                if (_OuterStatus == BorrowTransaction.StatusType.Borrow)
                {
                    AllowBookCopySearch = true;
                    findBookCopyWithFilterControl.LoadBookCopyById(bookCopyHolderID);
                    Borrow = new BorrowTransaction();
                    Borrow.BookCopyId = bookCopyHolderID;
                    Borrow.BookCopyInfo = BookCopy.FindBookCopyById(bookCopyHolderID);
                    Borrow.PolicyInfo = Policy.GetCurrentActivePolicy();
                    Borrow.MemberInfo = GlobalContext.CurrentMember;
                }

            }

        }
        public void NextPage()
        {
            TcPages.SelectedTab = TcPages.TabPages["tpBorrowBookCopy"];
            TcPages.TabPages["tpBorrowBookCopy"].Enabled = true;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            TcPages.SelectedTab = TcPages.TabPages["tpSelectBookCopy"];
            TcPages.TabPages["tpBorrowBookCopy"].Enabled = false;
            OnPreviousPress?.Invoke();
        }

        private void CbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int conditionId = BookConditions.GetConditionIdByName(CbCondition.Text);
            OperationResult conditionResult = Borrow.ValidateNewCondition((BookConditions.ConditionType)conditionId);

            if (conditionResult.Success)
                SendNewCopyCondition?.Invoke((BookConditions.ConditionType)conditionId);
            else
            {
                MessageBox.Show(conditionResult.Message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbCondition.SelectedIndex = Borrow.BookCopyInfo.ConditionId;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            if (_OuterStatus == BorrowTransaction.StatusType.Damage)
                GpDamaged.Visible = true;

            if (GenericOperations.IsEmptyObject(Borrow) && _OuterStatus != BorrowTransaction.StatusType.Borrow)
            {
                MessageBox.Show("Book copy is not borrowed", "Invalid copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationResult result = Borrow.ValidateNext(_OuterStatus);

            if (result.Success)
            {
                Borrow.PolicyId = Borrow.PolicyInfo.PolicyId;
                Borrow.MemberId = Borrow.MemberInfo.MemberId;

                borrowBookControl.ChangePageStatus(_OuterStatus);
                borrowBookControl.LoadBookBorrowData(Borrow.BorrowId, Borrow.BookCopyId, Borrow.MemberId, Borrow.PolicyId);
                NextPage();
                OnPressNextSuccess?.Invoke();
            }
            else
            {
                MessageBox.Show(result.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                borrowBookControl.Reset();
            }
        }
    }
}