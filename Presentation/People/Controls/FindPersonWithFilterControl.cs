using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.People.Controls
{
    public partial class FindPersonWithFilterControl : BaseUserControl
    {
         public Person SelectedPerson => personCardControl.SelectedPerson;

        public class PersonFoundPublisher
        {
            public event EventHandler<int> PersonFoundPublisherEvent;
            public void PublishPersonFound(int personId) => PersonFoundPublisherEvent?.Invoke(this, personId);
        }

        public PersonFoundPublisher Publisher = new PersonFoundPublisher();
        public bool AllowSearchSection
        {
            set
            {
                GbFilter.Enabled = value;
            }
            get
            {
                return GbFilter.Enabled;
            }
        }

        public FindPersonWithFilterControl()
        {
            InitializeComponent();
            CbFilters.SelectedIndex = 0;
        }

        private void FindPersonWithFilterControl_Load(object sender, EventArgs e) => CbFilters.SelectedIndex = 0;

        public void ResetFilterInputFocus()
        {
            TxtFilterBy.Text = "";
            TxtFilterBy.Select();
        }

        public void LoadPerson(int personId)
        {
            CbFilters.SelectedIndex = 0;
            TxtFilterBy.Text = personId.ToString();
            personCardControl.LoadPersonById(personId);
        }

        private void ReceiveAddedPersonId(object sender, int personId)
        {
            TxtFilterBy.Text = personId.ToString();
            ExecuteSearch();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddUpdatePersonForm addUpdatePersonForm = new AddUpdatePersonForm();
            addUpdatePersonForm.NotifyOnSaveSuccess += ReceiveAddedPersonId;
            addUpdatePersonForm.Show();
        }

        private void TxtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilters.Text.ToLower() == "person id")
                CommonValidation.EnableOnlyDigits(e);
        }

        private void BindSelectedPersonToCard()
        {
             if (CbFilters.Text.ToLower() == "person id")
               personCardControl.LoadPersonById(int.Parse(TxtFilterBy.Text.Trim()));
             else
               personCardControl.LoadPersonByNationalNo(TxtFilterBy.Text.Trim());
        }

        private void ExecuteSearch()
        {
            if (string.IsNullOrWhiteSpace(TxtFilterBy.Text))
            {
                MessageBox.Show($"Cannot search with empty {CbFilters.Text}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BindSelectedPersonToCard();

             if (AllowSearchSection && personCardControl.SelectedPerson != null)
                 Publisher.PublishPersonFound(personCardControl.SelectedPerson.PersonId);
        }

        private void BtnFind_Click(object sender, EventArgs e) => ExecuteSearch();

        private void CbFilters_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void CbFilters_SelectedIndexChanged(object sender, EventArgs e) => ResetFilterInputFocus();
    }
}