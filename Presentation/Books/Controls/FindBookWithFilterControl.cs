using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.Books.Controls
{
    public partial class FindBookWithFilterControl : BaseUserControl
    {
        public event Action<int> SendBookIdEvent;

        public bool AllowSearchSection
        {
            set
            {
                GbFilter.Enabled = value;
            }
            get { return GbFilter.Enabled; }
        }

        public FindBookWithFilterControl()
        {
            InitializeComponent();
            CbFilterBy.SelectedIndex = 0;
        }

        private void RaiseSendBookIdEvent(int bookId) => SendBookIdEvent?.Invoke(bookId);

        public void LoadOriginalBookInfo(int bookId)
        {
            TxtFilter.Text = bookId.ToString();
            ExecuteBookSearch();
        }

        private void InitializeFilterFocus()
        {
            TxtFilter.Text = "";
            TxtFilter.Select();
        }

        private void ResetSearchControls()
        {
            InitializeFilterFocus();
            ViewBookCardControl.LoadBookInfo(-1);
        }

        private void ExecuteBookSearch()
        {
            if (string.IsNullOrEmpty(TxtFilter.Text.Trim()))
            {
                MessageBox.Show("Cannot search with empty filter", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetSearchControls();
                return;
            }

            switch (CbFilterBy.Text)
            {
                case "Book ID":
                    ViewBookCardControl.LoadBookInfo(int.Parse(TxtFilter.Text.Trim()));
                    break;
                case "Category ID":
                    ViewBookCardControl.LoadBookInfoByCategoryId(int.Parse(TxtFilter.Text.Trim()));
                    break;
            }

            if (ViewBookCardControl.SelectedBook == null)
            {
                InitializeFilterFocus();
                return;
            }

            if (AllowSearchSection)
                RaiseSendBookIdEvent(ViewBookCardControl.SelectedBook.BookId);
        }

        private void BtnFindBook_Click(object sender, EventArgs e) => ExecuteBookSearch();

        private void HandleBookInfoAfterSave(object sender, AddUpdateBookForm.BookInfoEventArgs e)
        {
            TxtFilter.Text = CbFilterBy.Text.Trim() == "Book ID"
                ? e.AddedBook.BookId.ToString()
                : e.AddedBook.CategoryId.ToString();

            ExecuteBookSearch();
        }

        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            AddUpdateBookForm addUpdateBookForm = new AddUpdateBookForm();
            addUpdateBookForm.SendBookInfoOnSaveEvent += HandleBookInfoAfterSave;
            addUpdateBookForm.ShowDialog();
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e) => InitializeFilterFocus();

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.EnableOnlyDigits(e);
    }
}