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
    public partial class ViewPaymentControl : BaseUserControl
    {
        public ViewPaymentControl()
        {
            InitializeComponent();
        }

        public void LoadPaymentInfo(int paymentId)
        {
            if (paymentId <= 0)
            {
                MessageBox.Show("Invalid payment ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FinePayment finePayment = FinePayment.FindByPaymentId(paymentId);

            if (finePayment == null)
            {
                MessageBox.Show("Payment not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

               LblPaymentId.Text = finePayment.PaymentId.ToString();
               LblAmountPaid.Text = finePayment.AmountPaid.ToString();
               LblPaymentDate.Text = finePayment.PaymentDate.ToShortDateString();
               LblPaymentMethod.Text = finePayment.PaymentMethod;
        }
    }
}
