using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.BookCopies.Controls
{
    public partial class FindBookCopyWithFilterControl : BaseUserControl
    {
        public Action<int> SendBookCopyId;
        public bool EnableSearchSection
        {
            get
            {
                return GbFilter.Enabled;
            }
            set
            {
                GbFilter.Enabled = value;
            }
        }

        public BookCopy SelectedBookCopy => ViewBookCopyCardControl.BookCopy;

        public FindBookCopyWithFilterControl()
        {
            InitializeComponent();
            CbFilterBy.SelectedIndex = 0;
        }

        public void LoadBookCopyById(int bookCopyId)
        {
            CbFilterBy.SelectedIndex = 0;
            TxtFilter.Text = bookCopyId.ToString();
            LoadBookCopy();
        }

        private void LoadBookCopy()
        {
            switch (CbFilterBy.Text)
            {
                case "Book Copy ID":
                    ViewBookCopyCardControl.LoadByBookCopyId(int.Parse(TxtFilter.Text.Trim()));
                    break;
                case "Original Book ID":
                    ViewBookCopyCardControl.LoadByBookId(int.Parse(TxtFilter.Text.Trim()));
                    break;
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(TxtFilter.Text.Trim()))
            {
                MessageBox.Show($"Cannot search with empty {CbFilterBy.Text}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadBookCopy();
            SendBookCopyId?.Invoke(ViewBookCopyCardControl.copyId);
        }

        private void BtnFindBookCopy_Click(object sender, EventArgs e) => Search();

        public void ResetFocus()
        {
            TxtFilter.Clear();
            TxtFilter.Select();
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e) => ResetFocus();

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.EnableOnlyDigits(e);

        private void OnBookCopyAdded(object sender, int bookCopyId)
        {
            CbFilterBy.SelectedIndex = 0;
            TxtFilter.Text = bookCopyId.ToString();
            Search();
        }

        private void BtnAddNewBookCopy_Click(object sender, EventArgs e)
        {
            AddUpdateBookCopyForm addUpdateBookCopyForm = new AddUpdateBookCopyForm();
            addUpdateBookCopyForm.SendBookCopyId += OnBookCopyAdded;
            addUpdateBookCopyForm.ShowDialog();
        }
    }
}