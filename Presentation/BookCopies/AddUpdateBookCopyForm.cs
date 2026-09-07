using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.BookCopies
{
    public partial class AddUpdateBookCopyForm : BaseForm
    {
        private BookCopy _bookCopy;

        public event EventHandler<int> SendBookCopyId;

        public AddUpdateBookCopyForm()
        {
            InitializeComponent();
            _bookCopy = new BookCopy();
            FindBookWithFilterControl.AllowSearchSection = true;
            FindBookWithFilterControl.SendBookIdEvent += OnBookIdReceived;
        }

        public AddUpdateBookCopyForm(int bookCopyId)
        {
            InitializeComponent();
            _bookCopy = BookCopy.FindBookCopyById(bookCopyId);
            FindBookWithFilterControl.AllowSearchSection = false;
            FindBookWithFilterControl.SendBookIdEvent += OnBookIdReceived;
        }

        private void OnBookIdReceived(int bookId)
        {
            LblBookId.Text = bookId.ToString();
           _bookCopy.OriginalBook = Book.FindBookById(bookId);
            _bookCopy.BookId = bookId; 
        }

        private bool IsBookSelected() => !GenericOperations.IsEmptyObject(_bookCopy.OriginalBook);

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!IsBookSelected())
            {
                MessageBox.Show("Select a book first", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TbPages.TabPages["tpAddACopy"].Enabled = true;
            TbPages.SelectedTab = TbPages.TabPages["tpAddACopy"];
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            TbPages.SelectedTab = TbPages.TabPages["tpSelectBook"];
        }

        private void ConfigureUpdateMode()
        {
            LblTitle.Text = "Update Book Copy";
            this.Text = "Update Book Copy";
            FindBookWithFilterControl.LoadOriginalBookInfo(_bookCopy.BookId);

            LblBookCopyId.Text = _bookCopy.BookCopyId.ToString();
            LblBookId.Text = _bookCopy.BookId.ToString();
            TxtPrice.Text = _bookCopy.BookCopyPrice.ToString();
            CbStatus.SelectedIndex = CbStatus.FindString(_bookCopy.GetStatusText());
            CbCondition.SelectedIndex = CbCondition.FindString(_bookCopy.GetConditionText());
        }

        private void InitializeFormState()
        {
            TbPages.TabPages["tpAddACopy"].Enabled = false;
            CbStatus.SelectedIndex = 0;
            CbCondition.SelectedIndex = 0;
        }

        private void AddUpdateBookCopyForm_Load(object sender, EventArgs e)
        {
            InitializeFormState();

            if (_bookCopy.CurrentMode == BookCopy.Mode.Update)
                ConfigureUpdateMode();
        }

        private void BindFormToBookCopy()
        {
            _bookCopy.StatusId = Convert.ToByte(CbStatus.SelectedIndex + 1);
            _bookCopy.ConditionId = Convert.ToByte(CbCondition.SelectedIndex + 1);
            _bookCopy.BookCopyPrice = decimal.Parse(TxtPrice.Text.Trim());
            _bookCopy.ConditionInfo = BookConditions.FindBookCondition(_bookCopy.ConditionId);
            _bookCopy.OriginalBook = Book.FindBookById(_bookCopy.BookId);
            _bookCopy.AddedDate = DateTime.Now;
        }

        private void ShowSaveSuccess()
        {
            FindBookWithFilterControl.AllowSearchSection = false;
            MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LblBookCopyId.Text = _bookCopy.BookCopyId.ToString();
            LblTitle.Text = "Update Book Copy";
            this.Text = "Update Book Copy";

            SendBookCopyId?.Invoke(this, _bookCopy.BookCopyId);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(TpAddACopy.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BindFormToBookCopy();

            if (_bookCopy.Save())
                ShowSaveSuccess();
            else
                MessageBox.Show("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CbCondition_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (string.IsNullOrEmpty(comboBox.Text))
                errorProvider.SetError(comboBox, "This field is required");
            else
                errorProvider.SetError(comboBox, null);
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && !TxtPrice.Text.Contains("."))
                e.Handled = false;
            else
                CommonValidation.EnableOnlyDigits(e);
        }

        private void TxtPrice_Validating(object sender, CancelEventArgs e)
        {
            TextBox TxtBox = (TextBox)sender;

            if (string.IsNullOrEmpty(TxtBox.Text.Trim()))
                errorProvider.SetError(TxtBox, "Enter a price");
            else
                errorProvider.SetError(TxtBox, null);


        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        }
    }