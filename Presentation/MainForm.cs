using BusinessLogic;
using LibrarySystem.BookCategories;
using LibrarySystem.BookCopies;
using LibrarySystem.Books;
using LibrarySystem.BorrowFinePayments;
using LibrarySystem.BorrowFines;
using LibrarySystem.BorrowingBookCopy;
using LibrarySystem.Common;
using LibrarySystem.FinePayments;
using LibrarySystem.LibraryPolicies;
using LibrarySystem.Login;
using LibrarySystem.Members;
using LibrarySystem.Memberships;
using LibrarySystem.People;
using LibrarySystem.Users;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.MembershipRenewals;
using WindowsFormsApp1.Memberships.Controls;

namespace LibrarySystem
{
    public partial class MainForm : BaseForm
    {
        private LoginForm _loginForm;

        private async void DefaultData() => await Registry.FillDefaultDataAsync();

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            DefaultData();
            _loginForm = loginForm;
            this.FormClosing += MainForm_FormClosing;
        }

        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;


            ManagePeopleForm managePeopleForm = new ManagePeopleForm();
            managePeopleForm.ShowDialog();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.ShowDialog();
        }

        private void MembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            ManageMembersForm manageMembersForm = new ManageMembersForm();
            manageMembersForm.ShowDialog();
        }

        private void BookCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            ManageBookCategoriesForm manageBookCategoriesForm = new ManageBookCategoriesForm();
            manageBookCategoriesForm.ShowDialog();
        }

        private void ManageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
            {
                MessageBox.Show("User does not have permission", "No permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ManageBooksForm manageBooksForm = new ManageBooksForm();
            manageBooksForm.ShowDialog();
        }

        private void BookCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
            {
                MessageBox.Show("User does not have permission", "No permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ManageBookCopiesForm manageBookCopiesForm = new ManageBookCopiesForm();
            manageBookCopiesForm.ShowDialog();
        }

        private void BorrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(BorrowTransaction.StatusType.Borrow);
            borrowBookCopyForm.ShowDialog();
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            BorrowBookCopyForm returnBookForm = new BorrowBookCopyForm(BorrowTransaction.StatusType.Return);
            returnBookForm.ShowDialog();
        }

        private void LostBookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            BorrowBookCopyForm lostBookForm = new BorrowBookCopyForm(BorrowTransaction.StatusType.Lost);
            lostBookForm.ShowDialog();
        }

        private void DamagedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            BorrowBookCopyForm damagedBookForm = new BorrowBookCopyForm(BorrowTransaction.StatusType.Damage);
            damagedBookForm.ShowDialog();
        }

        private void FinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            ManageFinesForm manageFinesForm = new ManageFinesForm();
            manageFinesForm.ShowDialog();
        }

        private void MembershipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            ManageMembershipsForm manageMembershipsForm = new ManageMembershipsForm();
            manageMembershipsForm.ShowDialog();
        }

        private void MembershipRenewalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMembershipRenews))
                return;

            if (!GlobalContext.IsMemberValid())
                return;

            ManageMembershipRenewals renewMembership = new ManageMembershipRenewals();
            renewMembership.ShowDialog();
        }

        private void PoliciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            ManagePoliciesForm managePoliciesForm = new ManagePoliciesForm();
            managePoliciesForm.ShowDialog();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            ChangePasswordForm changePasswordForm = new ChangePasswordForm(GlobalContext.CurrentUser.UserId);
            changePasswordForm.ShowDialog();
        }

        private void ViewUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            ViewUserCardForm viewUserCardForm = new ViewUserCardForm(GlobalContext.CurrentUser.UserId);
            viewUserCardForm.ShowDialog();
        }

        private void UpdatePermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            AddUpdateUserForm addUpdateUserForm = new AddUpdateUserForm(GlobalContext.CurrentUser.UserId);
            addUpdateUserForm.ShowDialog();
        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!GenericOperations.IsEmptyObject(_loginForm))
                _loginForm.ShowDialog();
            else
            {
                MessageBox.Show("You are in test so there is no log out application will be ended", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GenericOperations.IsEmptyObject(_loginForm))
                _loginForm.Show();
            else
                Application.Exit();
        }

        private void manageFinePaymentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            ManageFinePaymentsForm manageFinePayments = new ManageFinePaymentsForm();
            manageFinePayments.ShowDialog();
        }

        private void manageBookCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            ManageBookCopiesForm manageBookCopies = new ManageBookCopiesForm();
            manageBookCopies.ShowDialog();
        }

        private void manageBorrowingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            ManageBorrowedBookCopiesForm manageBorrowed = new ManageBorrowedBookCopiesForm();
            manageBorrowed.ShowDialog();
        }

        private void viewPersonCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            ViewPersonCardInfoForm viewPersonCardInfoForm = new ViewPersonCardInfoForm(GlobalContext.CurrentUser.PersonId);
            viewPersonCardInfoForm.Show();
        }

        private void viewCurrentMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            if (GenericOperations.IsEmptyObject(GlobalContext.CurrentMember))
            {
                MessageBox.Show("user doese't have a member account", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ViewMembershipDetailsForm manageRenewMembershipsForm = new ViewMembershipDetailsForm(GlobalContext.CurrentMember.MembershipTypeId);
            manageRenewMembershipsForm.ShowDialog();
        }

    }
}