using Business;
using BusinessLogic;
using LibrarySystem.BorrowingBookCopy;
using LibrarySystem.BorrowingBookCopy.Controls;
using LibrarySystem.Common;
using LibrarySystem.FinePayments;
using LibrarySystem.Members;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.MembershipRenewals;
using WindowsFormsApp1.Properties;

namespace LibrarySystem.BorrowFines
{
    public partial class ViewFineDetailsForm : BaseForm
    {
        private int _FineId { get; set; }
        public ViewFineDetailsForm(int fineId)
        {
            InitializeComponent();
            _FineId = fineId;
            ViewFineCardControl.LoadFinesDetails(fineId);
            relationlControl1.SetLeftPage(_GetLeftPageInformation());
            relationlControl1.SetRightPage(_GetRightPageInformation());
        }

        private RelationalControlInformation _GetLeftPageInformation()
        {
            var fine = Fine.FindByFineId(_FineId);
            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (!GenericOperations.IsEmptyObject(fine.BorrowTransaction))
            {
                relationlControl1.LeftPageLink.Text = "View Borrow";

                rightPageInformation = new RelationalControlInformation
                    ("view book copy",
                    "book copy",
                    new List<string>() { fine.BorrowId.ToString(), fine.BorrowTransaction.DueDate.ToShortDateString(), fine.BorrowTransaction.BorrowStatus.ToString() },
                    new List<string>() { "Borrow", "Due", "Status" },
                    new List<Image>() { Resources.Fine_ID_32, Resources.Calendar_32, Resources.Status_32 },
                    () => new ViewBookBorrowDetailsForm(fine.BorrowId ?? -1).ShowDialog());
                return rightPageInformation;
            }
            else if(!GenericOperations.IsEmptyObject(fine.MembershipRenewDetails))
            {
                relationlControl1.LeftPageLink.Text = "View Renewal";

                rightPageInformation = new RelationalControlInformation
                    ("view renewal",
                    "renewal info",
                    new List<string>() { fine.RenewId.ToString(), fine.MembershipRenewDetails.RenewFees.ToString(),
                        fine.MembershipRenewDetails.RenewDate.ToShortDateString() },
                    new List<string>() { "Renewal Id", "Fees", "Renew Date" },
                    new List<Image>() { Resources.RenewId_32, Resources.Money_Bag_32, Resources.Calendar_32 },
                    () => new ViewMembershipRenewalInfo(fine.RenewId ?? -1).ShowDialog());
                return rightPageInformation;
            }

                return rightPageInformation;
        }

        private RelationalControlInformation _GetRightPageInformation()
        {
            var fine = Fine.FindByFineId(_FineId);

            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (!GenericOperations.IsEmptyObject(fine.BorrowTransaction))
            {
                relationlControl1.RightPageLink.Text = "View Member";

                rightPageInformation = new RelationalControlInformation
                    ("Member Info",
                    fine.BorrowTransaction.MemberInfo.UserInfo.PersonInfo.FullName,
                    new List<string>() {"MEM-" + fine.BorrowTransaction.MemberId, fine.BorrowTransaction.MemberInfo.MembershipTypeInfo.MembershipTypeName, fine.BorrowTransaction.MemberInfo.MembershipTypeInfo.GetFinesAmountInType().ToString(), fine.BorrowTransaction.MemberInfo.IsMembershipExpired() ? "Expired" : "Active" },

                    new List<string>() { "Member", "Type", "Total Fees", "Expires" },
                    new List<Image>() { Resources.Membership_32, Resources.ID_32, Resources.Status_32, Resources.Membership_32 },
                    () => new ViewMemberCardForm(fine.BorrowTransaction.MemberId).ShowDialog());
                return rightPageInformation;
            }
            else if(!GenericOperations.IsEmptyObject(fine.MembershipRenewDetails))
            {
                relationlControl1.RightPageLink.Text = "View Member";

                rightPageInformation = new RelationalControlInformation
                    ("Member Info",
                    fine.MembershipRenewDetails.MemberInfo.UserInfo.PersonInfo.FullName,
                    new List<string>() { "MEM-" + fine.MembershipRenewDetails.MemberId, fine.MembershipRenewDetails.MemberInfo.MembershipTypeInfo.MembershipTypeName, fine.MembershipRenewDetails.MemberInfo.MembershipTypeInfo.GetFinesAmountInType().ToString(), fine.MembershipRenewDetails.MemberInfo.IsMembershipExpired() ? "Expired" : "Active" },

                    new List<string>() { "Member", "Type", "Total Fees", "Expires" },
                    new List<Image>() { Resources.Membership_32, Resources.ID_32, Resources.Status_32, Resources.Membership_32 },
                    () => new ViewMemberCardForm(fine.MembershipRenewDetails.MemberId).ShowDialog());
                return rightPageInformation;
            }

                return rightPageInformation;
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LnkPayments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageFinePaymentsForm finePaymentsForm = new ManageFinePaymentsForm();
            finePaymentsForm.ShowDialog();
        }
    }
}