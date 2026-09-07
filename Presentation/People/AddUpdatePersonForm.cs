using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace LibrarySystem.People
{
    public partial class AddUpdatePersonForm : BaseForm
    {
        private Person _person;
        private int _personId;

        public event EventHandler<int> NotifyOnSaveSuccess;

        public AddUpdatePersonForm()
        {
            InitializeComponent();
            _person = new Person();
        }

        public AddUpdatePersonForm(int personId)
        {
            InitializeComponent();
            _personId = personId;
        }


        private void FillPerson(int personId)
        {
            _person = Person.FindById(personId) ?? new Person();

            if (_person != null && _person.CurrentMode == Person.ModeType.Update)
                LoadPersonDataForEdit();
        }

        private void InitializeAddModeLayout()
        {
            LblTitle.Text = "Add New Person";
            RbMale.Checked = true;
            LnkRemove.Visible = false;
            DtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            DtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            DtpDateOfBirth.Value = DtpDateOfBirth.MaxDate;
        }

        private void LoadPersonImage()
        {
            if (!string.IsNullOrWhiteSpace(_person.ImagePath))
            {
                PbPersonImage.ImageLocation = _person.ImagePath;
                LnkRemove.Visible = true;
            }

            PbPersonImage.Image = _person.IsMale() ? Resources.Male_512 : Resources.Female_512;
        }

        private void LoadPersonDataForEdit()
        {
            LblTitle.Text = "Update Person Info";
            LblPersonId.Text = _person.PersonId.ToString();
            TxtFirstname.Text = _person.FirstName;
            TxtSecond.Text = _person.SecondName;
            TxtThird.Text = _person.ThirdName;
            TxtLastName.Text = _person.LastName;
            TxtNationalNo.Text = _person.NationalNo;
            TxtEmail.Text = _person.Email;
            TxtAddress.Text = _person.Address;
            DtpDateOfBirth.Value = _person.DateOfBirth;
            MsbPhone.Text = _person.Phone;
            RbMale.Checked = _person.IsMale();
            RbFemale.Checked = !_person.IsMale();
            LoadPersonImage();
        }

        private void AddUpdatePersonForm_Load(object sender, EventArgs e)
        {
            InitializeAddModeLayout();
            FillPerson(_personId);
        }

        private void SetDefaultPersonImage()
        {
              if (PbPersonImage.ImageLocation == null)
                   PbPersonImage.Image = RbMale.Checked ? Resources.Male_512 : Resources.Female_512;
        }

        private void RbMale_CheckedChanged(object sender, EventArgs e) => SetDefaultPersonImage();

        private void RbFemale_CheckedChanged(object sender, EventArgs e) => SetDefaultPersonImage();

        private void LnkSelectImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                PbPersonImage.ImageLocation = openFileDialog1.FileName;
                LnkRemove.Visible = true;
            }
        }

        private void ValidateRequiredField(object sender, CancelEventArgs e)
        {
            CommonValidation.IsRequired((Control)sender, errorProvider);
        }

        private void MsbPhone_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            if (!Person.IsPhoneValid(maskedTextBox.Text.Trim()))
                errorProvider.SetError(maskedTextBox, "Enter a 10-digit number");
            else
                errorProvider.SetError(maskedTextBox, null);
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                errorProvider.SetError(textBox, null);
                return;
            }

            if (!CommonValidation.IsValidEmail(textBox.Text.Trim()))
                errorProvider.SetError(textBox, "Invalid email format");
            else
                errorProvider.SetError(textBox, null);
        }

        private void TxtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (CommonValidation.IsRequired(textBox, errorProvider))
                return;

            if (Person.Exists(textBox.Text.Trim()) && _person.CurrentMode == Person.ModeType.Add)
                errorProvider.SetError(textBox, "National No already in use");
            else
                errorProvider.SetError(textBox, null);
        }

        private void MapFormToPerson()
        {
            _person.FirstName = TxtFirstname.Text.Trim();
            _person.SecondName = TxtSecond.Text.Trim();
            _person.ThirdName = TxtThird.Text.Trim();
            _person.LastName = TxtLastName.Text.Trim();
            _person.Address = TxtAddress.Text.Trim();
            _person.Phone = MsbPhone.Text.Trim();
            _person.Email = TxtEmail.Text.Trim();
            _person.Gender = RbMale.Checked ? (byte)0 : (byte)1;
            _person.DateOfBirth = DtpDateOfBirth.Value;
            _person.NationalNo = TxtNationalNo.Text.Trim();
            _person.ImagePath = PbPersonImage.ImageLocation ?? "";
        }

        private void RaiseAddedPersonEvent() => NotifyOnSaveSuccess?.Invoke(this, _person.PersonId);

        private void SaveSuccess()
        {
            LblPersonId.Text = _person.PersonId.ToString();
            MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblTitle.Text = "Update Person Info";
            RaiseAddedPersonEvent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(GbPersonInfo.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MapFormToPerson();

            if (_person.Save())
                SaveSuccess();
            else
                MessageBox.Show("Failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PbPersonImage.ImageLocation = null;
            SetDefaultPersonImage();
            LnkRemove.Visible = false;
        }
    }
}