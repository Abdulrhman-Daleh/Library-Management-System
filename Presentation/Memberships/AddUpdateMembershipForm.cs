using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem.Memberships
{
    public partial class AddUpdateMembershipForm : BaseForm
    {
        private MembershipType _currentMembershipType;

        public delegate void OnNewMembershipAddedHandler(int membershipId);
        public event OnNewMembershipAddedHandler OnNewMembershipAdded;

        public AddUpdateMembershipForm()
        {
            InitializeComponent();
            _currentMembershipType = new MembershipType();
        }

        public AddUpdateMembershipForm(int membershipTypeId)
        {
            InitializeComponent();
            _currentMembershipType = MembershipType.FindById(membershipTypeId);
        }

        private void InitializeAddMode()
        {
            LblTitle.Text = "Add New Membership Type";
            this.Text = "Add New Membership Type";
        }

        private void LoadMembershipTypeForUpdate()
        {
            LblTitle.Text = "Update Membership Type";
            this.Text = "Update Membership Type";

            if (_currentMembershipType == null)
            {
                MessageBox.Show("Membership type not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LblMembershipTypeId.Text = _currentMembershipType.MembershipTypeId.ToString();
            TxtMembershipTypeName.Text = _currentMembershipType.MembershipTypeName;
            NudMembershipFees.Value = (decimal)_currentMembershipType.MembershipFees;
            NudBorrowLimit.Value = _currentMembershipType.MembershipBorrowLimit;
        }

        private void MapMembershipTypeDataFromUi()
        {
            _currentMembershipType.MembershipTypeName = TxtMembershipTypeName.Text.Trim();
            _currentMembershipType.MembershipFees = Convert.ToSingle(NudMembershipFees.Value);
            _currentMembershipType.MembershipBorrowLimit = Convert.ToInt32(NudBorrowLimit.Value);
        }

        private void ShowSaveSuccess()
        {
            MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblMembershipTypeId.Text = _currentMembershipType.MembershipTypeId.ToString();
            LblTitle.Text = "Update Membership Type";
            this.Text = "Update Membership Type";
            OnNewMembershipAdded?.Invoke(_currentMembershipType.MembershipTypeId);
        }

        private void AddUpdateMembershipForm_Load(object sender, EventArgs e)
        {
            InitializeAddMode();

            if (_currentMembershipType.CurrentMode == MembershipType.ModeType.Update)
                LoadMembershipTypeForUpdate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(this.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MapMembershipTypeDataFromUi();

            if (_currentMembershipType.Save())
                ShowSaveSuccess();
            else
                MessageBox.Show("Failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void TxtMembershipTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMembershipTypeName.Text.Trim()))
                errorProvider.SetError(TxtMembershipTypeName, "This field is required");
            else
                errorProvider.SetError(TxtMembershipTypeName, null);
        }

    }
}