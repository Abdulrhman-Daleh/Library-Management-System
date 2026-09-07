using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Properties;

namespace LibrarySystem.People
{
    public partial class PersonCardControl : BaseUserControl
    {
        private Person _selectedPerson;

        public Person SelectedPerson => _selectedPerson;

        public PersonCardControl()
        {
            InitializeComponent();
        }

        private void SetPersonDefaultImage()
        {
            PbPersonImage.Image = _selectedPerson.IsMale() ? Resources.Male_512 : Resources.Female_512;
        }

        private void SetPersonImage()
        {
            if (!string.IsNullOrWhiteSpace(_selectedPerson.ImagePath))
                PbPersonImage.ImageLocation = _selectedPerson.ImagePath;
            else
                SetPersonDefaultImage();
        }

        private void ResetDefaultViews()
        {
            LblFullName.Text = "[????]";
            LblDateOfBirth.Text = "[????]";
            LblAddress.Text = "[????]";
            LblGender.Text = "[????]";
            LblPhone.Text = "[????]";
            LblEmail.Text = "[????]";
            PbPersonImage.ImageLocation = null;
        }

        private void MapPersonToPage()
        {
            LblFullName.Text = $"({_selectedPerson.PersonId}) {_selectedPerson.FullName}";
            LblEmail.Text = _selectedPerson.Email;
            LblGender.Text = _selectedPerson.IsMale() ? "Male" : "Female";
            LblAddress.Text = _selectedPerson.Address;
            LblPhone.Text = _selectedPerson.Phone;
            LblDateOfBirth.Text = _selectedPerson.DateOfBirth.ToShortDateString();
            SetPersonImage();
        }

        public void LoadPersonById(int personId)
        {
            _selectedPerson = Person.FindById(personId);
            if (_selectedPerson == null)
            {
                MessageBox.Show($"Person not found (ID: {personId})", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaultViews();
                return;
            }

            MapPersonToPage();
        }

        public void LoadPersonByNationalNo(string nationalNo)
        {
            _selectedPerson = Person.FindByNationalNo(nationalNo);
            if (_selectedPerson == null)
            {
                MessageBox.Show($"Person not found (National No: {nationalNo})", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaultViews();
                return;
            }

            MapPersonToPage();
        }

        private void LnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GlobalContext.CurrentUser.PersonId != _selectedPerson.PersonId && !CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            AddUpdatePersonForm addUpdatePersonForm = new AddUpdatePersonForm(_selectedPerson.PersonId);
            addUpdatePersonForm.ShowDialog();
            LoadPersonById(_selectedPerson.PersonId);
        }

     
    }
}