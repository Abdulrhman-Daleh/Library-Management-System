using BusinessLogic;
using LibrarySystem;
using LibrarySystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.MembershipRenewals
{
    public partial class ViewMembershipRenewalInfo : BaseForm
    {
        public ViewMembershipRenewalInfo(int renewId)
        {
            InitializeComponent();
            _LoadRenewalInfo(renewId);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void _LoadRenewalInfo(int renewId)
        {
            MembershipRenew renewInfo = MembershipRenew.FindByRenewId(renewId);

            if (GenericOperations.IsEmptyObject(renewInfo))
            {
                LblMembershipType.Text = "[????]";
                LblRenewDate.Text = "[????]";
                LblRenewFees.Text = "[$$$]";
                LblRenewDate.Text = "[????/??/??]";
                return;
            }

            LblMembershipType.Text = renewInfo.MemberInfo.MembershipTypeInfo.MembershipTypeName;
            LblRenewDate.Text = renewInfo.RenewDate.ToShortDateString();
            LblRenewFees.Text = renewInfo.RenewFees.ToString();
            LblRenewId.Text = renewInfo.RenewId.ToString();
        }
    }
}
