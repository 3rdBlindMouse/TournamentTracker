using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TournamentTrackerUI
{
    public partial class VenueCreatorForm : Form
    {
        public VenueCreatorForm()
        {
            InitializeComponent();
        }

        private void createVenueButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                createModel();
            }
        }

        private void createModel()
        {
            VenueModel model = new VenueModel();

            model.VenueName = venueNameTextBox.Text;
            // TODO make address regex
            model.VenueAddress = venueAddressTextBox.Text;
            model.VenuePhone = venuePhoneTextBox.Text;
            model.ContactPerson = contactPersonTextBox.Text;
            model.NumberOfPoolTables = int.Parse(numberOfPoolTablesTextBox.Text);

            GlobalConfig.Connection.CreateVenue(model);
        }

        private bool ValidateForm()
        {
            Validator validator = new Validator();
            if ((validator.isValidName(venueNameTextBox.Text))
                && (validator.isValidAddress(venueAddressTextBox.Text))
                && (validator.isValidPhoneNumber(venuePhoneTextBox.Text))
                && (validator.isValidName(contactPersonTextBox.Text))
                && (validator.isValidNumber(numberOfPoolTablesTextBox.Text))
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
