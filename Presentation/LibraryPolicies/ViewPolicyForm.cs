using BusinessLogic;
using LibrarySystem;
using LibrarySystem.Common;
using LibrarySystem.LibraryPolicies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.LibraryPolicies
{
    public partial class ViewPolicyForm : BaseForm
    {
        private int _policyId { get; set; }
        public ViewPolicyForm(int policyId)
        {
            InitializeComponent();
            _policyId = policyId;   
            policyCardControl1.LoadPolicyDetails(policyId);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LinkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            AddUpdatePolicyForm updatePolicy = new AddUpdatePolicyForm(_policyId);
            updatePolicy.ShowDialog();
        }

    }
}
