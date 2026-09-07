using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem.LibraryPolicies
{
    public partial class AddUpdatePolicyForm : BaseForm
    {
        private Policy _currentPolicy;

        public delegate void PolicySavedHandler(int policyId);
        public event PolicySavedHandler OnPolicySaved;

        public AddUpdatePolicyForm()
        {
            InitializeComponent();
            _currentPolicy = new Policy();
        }

        public AddUpdatePolicyForm(int policyId)
        {
            InitializeComponent();
            _currentPolicy = Policy.GetPolicyById(policyId);
        }


        private void InitializeAddMode()
        {
            LblTitle.Text = "Add New Policy";
            this.Text = "Add New Policy";
        }

        private void LoadPolicyForUpdate()
        {
            LblTitle.Text = "Update Policy";
            this.Text = "Update Policy";

            if (_currentPolicy == null)
            {
                MessageBox.Show("Policy not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            LblPolicyId.Text = _currentPolicy.PolicyId.ToString();
            NudFeesPerLateDay.Value = (decimal)_currentPolicy.FeesPerLateDay;
            NudGracePeriodDays.Value = _currentPolicy.GracePeriodDays;
            NudLostBookMultiplier.Value = _currentPolicy.LostBookFeeMultiplier;
            DtpEffectiveFrom.Value = _currentPolicy.EffectiveFrom;
            DtpEffectiveTo.Value = _currentPolicy.EffectiveTo;
        }

        private void MapPolicyDataFromUi()
        {
            _currentPolicy.FeesPerLateDay = NudFeesPerLateDay.Value;
            _currentPolicy.GracePeriodDays = (int)NudGracePeriodDays.Value;
            _currentPolicy.LostBookFeeMultiplier = NudLostBookMultiplier.Value;
            _currentPolicy.EffectiveFrom = DtpEffectiveFrom.Value;
            _currentPolicy.EffectiveTo = DtpEffectiveTo.Value;
        }

        private void ShowSaveSuccess()
        {
            MessageBox.Show("Policy saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblPolicyId.Text = _currentPolicy.PolicyId.ToString();
            LblTitle.Text = "Update Policy";
            this.Text = "Update Policy";
            OnPolicySaved?.Invoke(_currentPolicy.PolicyId);
        }

        private void AddUpdatePolicyForm_Load(object sender, EventArgs e)
        {
            InitializeAddMode();

            if (_currentPolicy.CurrentMode == Policy.ModeType.Update)
                LoadPolicyForUpdate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(this.Controls, errorProvider, this))
            {
                MessageBox.Show("Form contains invalid data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MapPolicyDataFromUi();

            if (_currentPolicy.Save())
                ShowSaveSuccess();
            else
                MessageBox.Show("Failed to save policy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void DtpEffectiveTo_Validating(object sender, CancelEventArgs e)
        {
            if (DtpEffectiveTo.Value <= DtpEffectiveFrom.Value)
                e.Cancel = true;
        }

        private void NudFeesPerLateDay_Validating(object sender, CancelEventArgs e)
        {
            if (NudFeesPerLateDay.Value < 0)
                e.Cancel = true;
        }

    }
}