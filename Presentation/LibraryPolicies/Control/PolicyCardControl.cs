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

namespace WindowsFormsApp1.LibraryPolicies.Controls
{
    public partial class PolicyCardControl : BaseUserControl
    {
        public PolicyCardControl()
        {
            InitializeComponent();
        }

        public void LoadPolicyDetails(int policyId)
        {
            if(policyId <= 0)
            {
                MessageBox.Show("Policy is invalid", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Policy policyDetails = Policy.GetPolicyById(policyId);

            if(policyDetails == null)
            {
                MessageBox.Show("Policy is not found", "not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LblPolicyId.Text = policyDetails.PolicyId.ToString();
            LblGracePeriodDays.Text = policyDetails.GracePeriodDays.ToString();
            LblLostBookMultiplier.Text = policyDetails.LostBookFeeMultiplier.ToString();
            LblEffectiveTo.Text = policyDetails.EffectiveTo.ToString();
            LblEffectiveFrom.Text = policyDetails.EffectiveFrom.ToString();
            LblFeesPerLateDay.Text = policyDetails?.FeesPerLateDay.ToString();
        }
    }
}
