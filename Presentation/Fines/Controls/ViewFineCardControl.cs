using BusinessLogic;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.BorrowFines.Controls
{
    public partial class ViewFineCardControl : BaseUserControl
    {
        public ViewFineCardControl()
        {
            InitializeComponent();
        }

        public void LoadFinesDetails(int fineId)
        {
            Fine fine = Fine.FindByFineId(fineId);

            if (fine == null)
            {
                MessageBox.Show("Fine not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fine.GetFineType() == Fine.ProcessMode.BorrowFine)
            {
                LblPaidAmount.Text = FinePayment.GetTotalAmountPaid(fine.FineId).ToString();
            }
            else
            {
                LblPaidAmount.Text = fine.GetRemainingFines().ToString();
            }

            LblFineId.Text = fine.FineId.ToString();
            LblFineStatus.Text = fine.GetStatusText();
            LblReason.Text = fine.GetReasonText();
            LblFineAmount.Text = fine.FineAmount.ToString();
            LblRemainingAmount.Text = (fine.FineAmount - Convert.ToDecimal(LblPaidAmount.Text)).ToString();
        }
    }
}