using Business;
using BusinessLogic;
using LibrarySystem.BorrowFines;
using LibrarySystem.BorrowFines.Controls;
using LibrarySystem.Members;
using LibrarySystem.People;
using LibrarySystem.People.Controls;
using LibrarySystem.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace LibrarySystem.FinePayments
{
    public partial class ViewFinePaymentInfoForm : BaseForm
    {
        private FinePayment _payment;
        public ViewFinePaymentInfoForm(int paymentId)
        {
            InitializeComponent();
            _payment = FinePayment.FindByPaymentId(paymentId);  
            viewPaymentControl1.LoadPaymentInfo(paymentId);
            relationlControl1.SetLeftPage(_GetLeftPageInformation());
            relationlControl1.SetRightPage(_GetRightPageInformation());
        }

        private RelationalControlInformation _GetLeftPageInformation()
        {
            RelationalControlInformation leftPageInformation = new RelationalControlInformation();

            if (_payment != null)
            {
                relationlControl1.LeftPageLink.Text = "View Fine";


                leftPageInformation = new RelationalControlInformation
                    ("fine payment details",
                    ($"Fine : #F-" + _payment.FineId),
                    new List<string>() { "Total", "Remaining", "Pay Method" },
                    new List<string>() { _payment.FineInfo.FineAmount.ToString(), _payment.FineInfo.GetRemainingFines().ToString(), _payment.PaymentMethod },
                    new List<Image>() { Resources.Money_Bag_32, Resources.Fine_32, Resources.Payment_Method_32 },
                    () => new ViewFineDetailsForm(_payment.FineId).ShowDialog());
                return leftPageInformation;
            }
            else
            {
                relationlControl1.LeftPageLink.Text = "Make fine payment";
                leftPageInformation.PageTitle = "fine payment fine";
                leftPageInformation.Title = "Fine";
                leftPageInformation.OnClick = () => new ProcessFinePaymentForm(_payment.FineId).ShowDialog();
            }


            return leftPageInformation;
        }

        private RelationalControlInformation _GetRightPageInformation()
        {
            var memberRecord = Member.FindMemberByPaymentID(_payment.PaymentId);

            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (memberRecord != null)
            {
                relationlControl1.RightPageLink.Text = "View Member";


                rightPageInformation = new RelationalControlInformation
                    ("Member Info",
                    "Member",
                    new List<string>() { memberRecord.MembershipTypeInfo.MembershipTypeName, memberRecord.MemberId.ToString(), memberRecord.IsMembershipExpired() ? "Expired" : "Active", memberRecord.MembershipExpirationDate.ToShortDateString() },
                    new List<string>() { "Type", "ID", "Status", "Expires" },
                    new List<Image>() { Resources.Membership_32, Resources.ID_32, Resources.Status_32, Resources.Membership_32 },
                    () => new ViewMemberCardForm(memberRecord.MemberId).ShowDialog());
                return rightPageInformation;
            }
            else
            {
                relationlControl1.RightPageLink.Text = "Create Member";
                rightPageInformation.PageTitle = "Membership";
                rightPageInformation.Title = "Member Info";
                rightPageInformation.OnClick = () => new AddUpdateMemberForm().ShowDialog();
            }

            return rightPageInformation;
        }


        private void BtnClose_Click(object sender, EventArgs e) => this.Close();

    }
}