using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibrarySystem.FinePayments
{
    public partial class ProcessFinePaymentForm : BaseForm
    {
        private Fine _fine;

        public ProcessFinePaymentForm(int fineId)
        {
            InitializeComponent();
            _fine = Fine.FindByFineId(fineId);
        }

        private void ProcessFinePaymentForm_Load(object sender, EventArgs e)
        {
            CbPaymentMethod.SelectedIndex = 0;
            viewFineCardControl.LoadFinesDetails(_fine.FineId);

            if (_fine == null)
            {
                BtnPay.Enabled = false;
                TxtPayAmount.Enabled = false;
            }
        }

        private void FilterFocus()
        {
            TxtPayAmount.Text = "";
            TxtPayAmount.Select();
        }

        private void FixAmount()
        {
            if (TxtPayAmount.Text == ".")
                FilterFocus();
        }

        private void TxtPayAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FixAmount();

            if (string.IsNullOrEmpty(TxtPayAmount.Text.Trim()) || Convert.ToDecimal(TxtPayAmount.Text.Trim()) == 0)
            {
                errorProvider.SetError(TxtPayAmount, "Amount cannot be zero");
                FilterFocus();
                return;
            }

            decimal amount = Convert.ToDecimal(TxtPayAmount.Text.Trim());

            if (amount > _fine.GetRemainingFines())
            {
                MessageBox.Show($"Amount exceeds remaining fine ({_fine.GetRemainingFines()})", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(TxtPayAmount, $"Max: {_fine.GetRemainingFines()}");
                FilterFocus();
            }
            else
            {
                errorProvider.SetError(TxtPayAmount, null);
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(GroupBox1.Controls, errorProvider, this))
                return;

            FinePayment finePayment = new FinePayment
            {
                FineId = _fine.FineId,
                PaymentMethod = CbPaymentMethod.Text,
                PaymentDate = DateTime.Now,
                AmountPaid = Convert.ToDecimal(TxtPayAmount.Text.Trim()),
                FineInfo = _fine
            };

            if (finePayment.Save())
            {
                MessageBox.Show($"Payment of {finePayment.AmountPaid} processed for Fine #{_fine.FineId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Payment failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && !TxtPayAmount.Text.Contains("."))
                e.Handled = false;
            else
              CommonValidation.EnableOnlyDigits(e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}