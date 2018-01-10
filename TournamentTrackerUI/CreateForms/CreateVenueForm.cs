using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI
{
    public partial class CreateVenueForm : Form
    {
        IVenueRequester callingForm;
        Validator validator = new Validator();
        private string method;


        public CreateVenueForm(IVenueRequester caller)
        {
            InitializeComponent();
            callingForm = caller;

            StackFrame frame = new StackFrame(1, true);
            method = (frame.GetMethod().Name);
        }

        private void createVenueButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                createModel();
                if (method == "createNewVenueLinkLabel_LinkClicked")
                {
                    this.Close();
                    //MessageBox.Show("");
                }
                else
                {
                    //MessageBox.Show("Not ");
                }

            }
            clearForm();
        }

        private void createModel()
        {
            VenueModel model = new VenueModel();

            model.VenueName = venueNameTextBox.Text;
            // TODO make address regex
            model.VenueAddress = venueAddressTextBox.Text;
            model.VenuePhone = venuePhoneTextBox.Text;
            model.ContactPerson = contactPersonTextBox.Text;
            model.PoolTables = int.Parse(numberOfPoolTablesTextBox.Text);

            GlobalConfig.Connection.CreateVenue(model);
            callingForm.VenueComplete(model);
        }

        private bool ValidateForm()
        {           
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

       




        /*
        * User notifications
        */
        private void OnEnter(TextBox tb)
        {
            tb.BackColor = SystemColors.Info;
            tb.Text = "";
        }
        private void Success(TextBox tb)
        {
            tb.BackColor = Color.LightGreen;
        }
        private void Fail(TextBox tb)
        {
            tb.BackColor = Color.Crimson;
            tb.Text = "Try Again";
        }

        
        /*
         * Enter / Leave with validation Events
         */
        private void venueNameTextBox_Enter(object sender, EventArgs e)
        {
            OnEnter(venueNameTextBox);
        }
        private void venueAddressTextBox_Enter(object sender, EventArgs e)
        {
            OnEnter(venueAddressTextBox);
        }
        private void venuePhoneTextBox_Enter(object sender, EventArgs e)
        {
            OnEnter(venuePhoneTextBox);
        }
        private void contactPersonTextBox_Enter(object sender, EventArgs e)
        {
            OnEnter(contactPersonTextBox);
        }
        private void numberOfPoolTablesTextBox_Enter(object sender, EventArgs e)
        {
            OnEnter(numberOfPoolTablesTextBox);
        }
        private void venueNameTextBox_Leave(object sender, EventArgs e)
        {
            if(validateName(venueNameTextBox.Text))
            {
                Success(venueNameTextBox);
                detailsListbox.Items.RemoveAt(0);
                detailsListbox.Items.Insert(0, venueNameTextBox.Text);
            }
            else
            {
                Fail(venueNameTextBox);
            }
        }
        private bool validateName(string name)
        {
            return validator.isValidName(name);
        }
        private void venueAddressTextBox_Leave(object sender, EventArgs e)
        {
            if(validateAddress(venueAddressTextBox.Text))
            {
                Success(venueAddressTextBox);
                detailsListbox.Items.RemoveAt(1);
                detailsListbox.Items.Insert(1, venueAddressTextBox.Text);
            }
            else
            {
                Fail(venueAddressTextBox);
            }
        }
        private bool validateAddress(string address)
        {
            return validator.isValidAddress(address);
        }
        private void venuePhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (validatePhone(venuePhoneTextBox.Text))
            {
                Success(venuePhoneTextBox);
                detailsListbox.Items.RemoveAt(2);
                detailsListbox.Items.Insert(2, venuePhoneTextBox.Text);
            }
            else
            {
                Fail(venuePhoneTextBox);
            }
        }
        private bool validatePhone(string phone)
        {
            return validator.isValidPhoneNumber(phone);
        }
        private void contactPersonTextBox_Leave(object sender, EventArgs e)
        {
            if (validateName(contactPersonTextBox.Text))
            {
                Success(contactPersonTextBox);
                detailsListbox.Items.RemoveAt(3);
                detailsListbox.Items.Insert(3, contactPersonTextBox.Text);
            }
            else
            {
                Fail(contactPersonTextBox);
            }
        }
        private void numberOfPoolTablesTextBox_Leave(object sender, EventArgs e)
        {
            if (numberOfPoolTablesTextBox.Text != "")
            {
                if (validateNumber(numberOfPoolTablesTextBox.Text))
                {
                    Success(numberOfPoolTablesTextBox);
                    detailsListbox.Items.RemoveAt(4);
                    detailsListbox.Items.Insert(4, numberOfPoolTablesTextBox.Text);
                }
                else
                {
                    Fail(numberOfPoolTablesTextBox);
                }
            }
            else
            {
                Fail(numberOfPoolTablesTextBox);
            }
        }
        private bool validateNumber(string number)
        {
            return validator.isValidNumber(number);
        }
        /// <summary>
        /// Clears the textboxes and resets color (uses OnEnter method)
        /// </summary>
        private void clearForm()
        {
            OnEnter(venueNameTextBox);
            OnEnter(venueAddressTextBox);
            OnEnter(venuePhoneTextBox);
            OnEnter(contactPersonTextBox);
            OnEnter(numberOfPoolTablesTextBox);
            detailsListbox.Items.RemoveAt(0);
            detailsListbox.Items.Insert(0, "");
            detailsListbox.Items.RemoveAt(1);
            detailsListbox.Items.Insert(1, "");
            detailsListbox.Items.RemoveAt(2);
            detailsListbox.Items.Insert(2, "");
            detailsListbox.Items.RemoveAt(3);
            detailsListbox.Items.Insert(3, "");
            detailsListbox.Items.RemoveAt(4);    
            detailsListbox.Items.Insert(4, "");
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
