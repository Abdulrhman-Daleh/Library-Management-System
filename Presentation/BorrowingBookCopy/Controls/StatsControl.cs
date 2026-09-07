using Business;
using BusinessLogic;
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

namespace WindowsFormsApp1.BorrowingBookCopy.Controls
{
    public partial class StatsControl : BaseUserControl
    {
        public StatsControl()
        {
            InitializeComponent();
        }

        private enum enFinesAmountLimit { good = 5, normal = 10, bad = 15 }
        private enum enOverdueCountLimit { good = 1, normal = 3, bad = 5 }

        public void LoadInfo(StateControlInformation stateInfo)
        {
            _setImages(stateInfo.Images);
            _setLinesLables(stateInfo.LinesLables);
            _setLinesValues(stateInfo.LinesValues);
        }

        private bool _IsValidLength(int Length) => Length >= 4;

        private void _setImages(List<Image> images)
        {
            if(_IsValidLength(images.Count))
            {
                pbImage1.Image = images[0];
                pbImage2.Image = images[1];
                pbImage3.Image = images[2];
                pbImage4.Image = images[3];
            }
        }

        private void _setLinesLables(List<string> linesLables)
        {
            if(_IsValidLength(linesLables.Count))
            {
                LblLine1.Text = linesLables[0];
                LblLine2.Text = linesLables[1];
                LblLine3.Text = linesLables[2];
                LblLine4.Text = linesLables[3];
            }
        }

        private void _setLinesValues(List<string> linesValue)
        {
            if(linesValue.Count >= 3)
            {
                LblValue1.Text = linesValue[0];
                LblValue2.Text = linesValue[1];
                LblValue3.Text = linesValue[2];
                LblValue4.Text = _CalculateStandingBadge(Convert.ToDecimal(linesValue[2]), Convert.ToInt16(linesValue[1]));
            }
        }

        private string _CalculateStandingBadge(decimal totalFines, short overdueCount)
        {
            enFinesAmountLimit fineAmountStatus = totalFines <= (int)enFinesAmountLimit.good ? enFinesAmountLimit.good :
                totalFines <= (int)enFinesAmountLimit.normal ? enFinesAmountLimit.normal : enFinesAmountLimit.bad;

            enOverdueCountLimit overdueCountLimit = overdueCount <= (int)enOverdueCountLimit.good ? enOverdueCountLimit.good
                : overdueCount <= (int)enOverdueCountLimit.normal ? enOverdueCountLimit.normal : enOverdueCountLimit.bad;

            int total = (int)fineAmountStatus + (int)overdueCountLimit;

            if (total <= 8)
                return "Good";
            else if (total <= 13)
                return "Normal";
            else
                return "bad";
        }
    }
}
