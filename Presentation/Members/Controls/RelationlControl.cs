using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Members.Controls
{
    public partial class RelationlControl : BaseUserControl
    {
        public RelationlControl()
        {
            InitializeComponent();
        }

        public Action RightLinkSave;
        private Action _RightPageAction { get; set; }
        private Action _LeftPageAction { get; set; }

        public void SetLeftPage(RelationalControlInformation leftSideInformation)
        {
            LblLeftPTitle.Text = leftSideInformation.Title;
            gpLeft.Text = leftSideInformation.PageTitle;
            _SetLeftPageLines(leftSideInformation.Lines, leftSideInformation.LinesLabels);
            _SetLeftPageImages(leftSideInformation.LinesImages);
            _LeftPageAction = leftSideInformation.OnClick;
        }


        public void SetRightPage(RelationalControlInformation rightSideInformation)
        {
            LblRightTitle.Text = rightSideInformation.Title;
            gpRight.Text = rightSideInformation.PageTitle;
            _SetRightPageLines(rightSideInformation.Lines, rightSideInformation.LinesLabels);
            _SetRightPageImages(rightSideInformation.LinesImages);
            _RightPageAction = rightSideInformation.OnClick;
        }


        public LinkLabel LeftPageLink => LnkLeft;

        public LinkLabel RightPageLink => LnkRight;

        private bool _IsValidList<T>(List<T> list) => (list != null && list.Count >= 3);

        private void _SetLeftPageLines(List<string> lines, List<string> linesLabels)
        {
            if (_IsValidList(linesLabels))
            {
                LblLeft1.Text = linesLabels[0];
                LblLeft2.Text = linesLabels[1];
                LblLeft.Text = linesLabels[2];
            }

            if (_IsValidList(lines))
            {
                LblLeftLine1.Text = lines[0];
                LblLeftLine23.Text = lines[1];
                LblLeftLine3.Text = lines[2];
            }
        }

        private void _SetLeftPageImages(List<Image> images)
        {
            if (_IsValidList(images))
            {
                pbLine1ImageLeft.Image = images[0];
                pbLine2ImageLeft.Image = images[1];
                pbLine3ImageLeft.Image = images[2];
            }
        }

        private void LnkRight_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RightPageAction?.Invoke();
        }

        private void _SetRightPageLines(List<string> lines, List<string> linesLabels)
        {
            if (_IsValidList(linesLabels))
            {
                LblRight1.Text = linesLabels[0];
                LblRight2.Text = linesLabels[1];
                LblRight3.Text = linesLabels[2];
                LblRight4.Text = linesLabels[3];
            }

            if (_IsValidList(lines))
            {
                LblLine1Right.Text = lines[0];
                LblLine2Right.Text = lines[1];
                LblLine3Right.Text = lines[2];
                LblLine4Right.Text = lines[3];
            }
        }

        private void _SetRightPageImages(List<Image> images)
        {
            if (_IsValidList(images))
            {
                pbLine1ImageRight.Image = images[0];
                pbLine2ImageRight.Image = images[1];
                pbLine3ImageRight.Image = images[2];
                pbLine4ImageRight.Image = images[3];
            }
        }

        private void LnkLeft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _LeftPageAction?.Invoke();
        }
    }
}
