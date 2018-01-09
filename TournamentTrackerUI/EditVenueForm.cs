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
    public partial class EditVenueForm : Form
    {
        private static List<VenueModel> venues = GlobalConfig.Connection.GetAllVenues();
        private static VenueModel vm = new VenueModel();
        private static List<string> venueNames = new List<string>();
        private static List<string> addresses = new List<string>();
        private static List<string> venuePhones = new List<string>();

        string selectedVenueName;
        string selectedVenueAddress;
        string selectedVenuePhone; 

        Validator validator = new Validator();
        public EditVenueForm()
        {
            InitializeComponent();

            


            WireupVenueSelector();
        }

        private void WireupVenueSelector()
        {
            AddSelectTitle();

            VenueNameComboBox.DataSource = null;                                         
            VenueNameComboBox.DataSource = venues.OrderBy(p => p.VenueName).ToList(); ;
            VenueNameComboBox.DisplayMember = "VenueName";
        }

        private void AddSelectTitle()
        {
            int index = venues.FindIndex(item => item.VenueID == -1);
            if (index >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                VenueModel v = new VenueModel(" Select Venue ", -1);
                venues.Insert(0, v);
            }
        }

        private void createModel(int id)
        {
            VenueModel model = new VenueModel();
            model.VenueID = id;
            model.VenueName = venueNameTextBox.Text;
            // TODO make address regex
            model.VenueAddress = venueAddressTextBox.Text;
            model.VenuePhone = venuePhoneTextBox.Text;
            model.ContactPerson = contactPersonTextBox.Text;
            model.PoolTables = int.Parse(numberOfPoolTablesTextBox.Text);

            GlobalConfig.Connection.EditVenue(model);
            MessageBox.Show("Venue Successfully Edited");
            this.Close();
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
            // stop on leave event triggering and coloring box red
            if (VenueNameComboBox.Text != "Select Venue")
                { 
                if (validateName(venueNameTextBox.Text))
                    {
                        if(venueNames.Contains(venueNameTextBox.Text))
                    {
                        FailDuplicate("Name", venueNameTextBox);
                    }
                    else
                    {
                        Success(venueNameTextBox);
                    }
                        

                    }
                    else
                    {
                        Fail(venueNameTextBox);
                    }
                }
        }

        private void FailDuplicate(string s, TextBox tb)
        {
            tb.BackColor = Color.Crimson;
            tb.Text = $"{s} Already Exists";
        }

        private bool validateName(string name)
        {
            return validator.isValidName(name);
        }
        private void venueAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (VenueNameComboBox.Text != " Select Venue ")
            {
                if (validateAddress(venueAddressTextBox.Text))
                {
                    if (addresses.Contains(venueAddressTextBox.Text))
                    {
                        FailDuplicate("Address", venueAddressTextBox);
                    }
                    else
                    {
                        Success(venueAddressTextBox);
                    }


                }
                else
                {
                    Fail(venueAddressTextBox);
                }
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
          
            
        }

        private void numberOfPoolTablesTextBox_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Out");
        }

        private void VenueNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            vm = (VenueModel)VenueNameComboBox.SelectedItem;
            if(formReady() == true)
            {
                wireupLabels();
                wireupLists(vm);
            }
            
        }

        private void wireupLists(VenueModel vm)
        {

            selectedVenueName = vm.VenueName;
            venueNames = new List<string>();
            selectedVenueAddress = vm.VenueAddress;
            addresses = new List<string>();
            selectedVenuePhone = vm.VenuePhone;
            venuePhones = new List<string>();
            foreach (VenueModel model in venues)
            {
                if (model.VenueName != " Select Venue ")
                {
                    if (model.VenueName != selectedVenueName)
                    {
                        venueNames.Add(model.VenueName);
                    }
                    if (model.VenueAddress != selectedVenueAddress)
                    {
                        addresses.Add(model.VenueAddress);
                    }
                    if (model.VenuePhone != selectedVenuePhone)
                    {
                        venuePhones.Add(model.VenuePhone);
                    }
                }
            }
        }

        private void wireupLabels()
        {
            NameLabel2.Text = vm.VenueName;
            AddressLabel2.Text = vm.VenueAddress;
            PhoneLabel2.Text = vm.VenuePhone;
            ContactLabel2.Text = vm.ContactPerson;
            PoolTablesLabel2.Text = vm.PoolTables.ToString();

            venueNameTextBox.Text = vm.VenueName;
            venueAddressTextBox.Text = vm.VenueAddress;
            venuePhoneTextBox.Text = vm.VenuePhone;
            contactPersonTextBox.Text = vm.ContactPerson;
            numberOfPoolTablesTextBox.Text = vm.PoolTables.ToString();
        }

        private bool formReady()
        {
            // If a Division has been selected from DivisionNameComboBox
            if ((VenueNameComboBox.SelectedIndex != 0)
                && (VenueNameComboBox.SelectedItem != null)
                && (VenueNameComboBox.SelectedText != " Select Venue "))
                return true;
            else
            {
                return false;
            }
        }

        private void EditVenueButton_Click(object sender, EventArgs e)
        {
            if (formReady() == true)
            {
                if (ValidateForm())
                {
                    vm = (VenueModel)VenueNameComboBox.SelectedItem;
                    int id = vm.VenueID;
                    createModel(id);

                }
            }


            venues = GlobalConfig.Connection.GetAllVenues();
            WireupVenueSelector();
            //this.Close();
        }

      
    }
}
