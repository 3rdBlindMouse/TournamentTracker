using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.DataAccess;
using TournamentLibrary.Models;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI
{
    public partial class FirstForm : Form, ITeamRequester, IVenueRequester, IPersonRequester
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void newPersonButton_Click(object sender, EventArgs e)
        {
            CreatePersonForm personForm = new CreatePersonForm(this);
            personForm.Show();
            this.Hide();
            personForm.FormClosing += closeForm;
        }

        public void closeForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void newDivisionButton_Click(object sender, EventArgs e)
        {
            CreateDivisionForm divisionForm = new CreateDivisionForm();
            divisionForm.Show();
            this.Hide();
            divisionForm.FormClosing += closeForm;
        }
        //TODO create a new season form
        private void newSeasonButton_Click(object sender, EventArgs e)
        {
            //CreateSeasonForm seasonForm = new CreateSeasonForm();
            //seasonForm.Show();
            //this.Hide();
            //seasonForm.FormClosing += closeForm;
        }

        private void newTeamButton_Click(object sender, EventArgs e)
        {
            CreateTeamForm teamForm = new CreateTeamForm(this);
            teamForm.Show();
            this.Hide();
            teamForm.FormClosing += closeForm;
        }

        private void newVenueButton_Click(object sender, EventArgs e)
        {
            CreateVenueForm venueForm = new CreateVenueForm(this);
            venueForm.Show();
            this.Hide();
            venueForm.FormClosing += closeForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditDivisionForm editDivisionForm = new EditDivisionForm();
            editDivisionForm.Show();
            this.Hide();
            editDivisionForm.FormClosing += closeForm;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditVenueForm eVenueForm = new EditVenueForm();
            eVenueForm.Show();
            this.Hide();
            eVenueForm.FormClosing += closeForm;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditPersonForm ePersonForm = new EditPersonForm();
            ePersonForm.Show();
            this.Hide();
            ePersonForm.FormClosing += closeForm;
        }

        public void TeamComplete(TeamModel model)
        {
            // no need to do anything from this form
        }

        public void VenueComplete(VenueModel model)
        {
            // no need to do anything from this form
        }

        public void PersonComplete(PersonModel model)
        {
            // no need to do anything from this form
        }
    }
    
}
