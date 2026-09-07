using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Memberships.Controls
{
    public partial class ViewMembershipCardControl : BaseUserControl
    {
        public ViewMembershipCardControl()
        {
            InitializeComponent();
        }

        public void LoadMembershipInformation(MembershipType membershipType)
        {
            if (membershipType == null)
            {
                MessageBox.Show($"membership is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            LblTypeID.Text = membershipType.MembershipTypeId.ToString();
            LblMembershipName.Text = membershipType.MembershipTypeName;
            LblMaxBooks.Text = membershipType.MembershipBorrowLimit.ToString();
        }
    }
}
