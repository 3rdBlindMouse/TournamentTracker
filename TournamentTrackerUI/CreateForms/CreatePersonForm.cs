using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class CreatePersonForm : Form
    {
        IPersonRequester callingForm;

        private List<PersonModel> people = GlobalConfig.Connection.GetAllPeople();
        private List<string> comparePeople = new List<string>();
        private string currentPerson;
        

        private string method;

        public CreatePersonForm(IPersonRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            

            wireUpComparePeopleList();
            
            StackFrame frame = new StackFrame(1, true);
            method = (frame.GetMethod().Name);

        }

        private void wireUpComparePeopleList()
        {
           
            foreach (PersonModel p in people)
            {
                string simplePersonModel = "";
                simplePersonModel += p.FullName;
                simplePersonModel += p.Sex;
                simplePersonModel += p.DateOfBirth.ToShortDateString();
                comparePeople.Add(simplePersonModel);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                // need to add something or else saving to text file blows up
                //if (EmailTextbox.Text == "")
                //{
                //    EmailTextbox.Text = "No Email";
                //}
                //if (ContactNumberTextbox.Text == "")
                //{
                //    ContactNumberTextbox.Text = "No Contact Number";
                //}

                PersonModel model = new PersonModel(
                    FirstNameTextbox.Text,
                    LastNameTextbox.Text,
                    EmailTextbox.Text,
                    ContactNumberTextbox.Text,
                    SexComboBox.SelectedItem.ToString(),
                    // TODO fix dob method
                    dob());

                currentPerson = "";
                currentPerson += model.FullName;
                currentPerson += model.Sex;
                currentPerson += model.DateOfBirth.ToShortDateString();

                if (comparePeople.Contains(currentPerson))
                {
                    MessageBox.Show("A Person with these details already Exists");
                }

                else
                {
                    GlobalConfig.Connection.CreatePerson(model);
                    callingForm.PersonComplete(model);

                    people = GlobalConfig.Connection.GetAllPeople();
                    wireUpComparePeopleList();
                    if (method == "CreateNewPlayerLinkLabel_LinkClicked")
                    {
                        this.Close();
                    }


                    MessageBox.Show("Player Successfully Created");
                    clearForm();

                }
                

            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }

        private void clearForm()
        {
            FirstNameTextbox.Text = "";
            FirstNameTextbox.BackColor = SystemColors.Info;
            LastNameTextbox.Text = "";
            LastNameTextbox.BackColor = SystemColors.Info;
            EmailTextbox.Text = "";
            EmailTextbox.BackColor = SystemColors.Info;
            ContactNumberTextbox.Text = "";
            ContactNumberTextbox.BackColor = SystemColors.Info;
            SexComboBox.Text = "";
            SexComboBox.BackColor = SystemColors.Info;
            dayComboBox.Text = "DAY";
            dayComboBox.BackColor = SystemColors.Info;
            monthComboBox.Text = "MONTH";
            monthComboBox.BackColor = SystemColors.Info;
            yearComboBox.Text = "YEAR";
            yearComboBox.BackColor = SystemColors.Info;
        }

        private bool validateForm()
        {
            Validator validator = new Validator();
            bool output = false;
            if (
                   (validator.isValidString(FirstNameTextbox.Text))
                && (validator.isValidString(LastNameTextbox.Text))
                && ((validator.isValidEmail(EmailTextbox.Text)) || (EmailTextbox.Text == ""))
                && ((validator.isValidNumber(ContactNumberTextbox.Text)) || (ContactNumberTextbox.Text == ""))
                && (validator.isValidSex(SexComboBox.Text) && (validateDateOfBirth() == true))
                )
            {
                output = true;
            }
            return output;

        }




        /*
         * Validating for each of the form fields
         */

        /// <summary>
        /// Compares user input FirstName to a string regex
        /// </summary>
        /// <returns>True if input is a string</returns>
        private void validateFirstName()
        {
            Validator validator = new Validator();
            bool output = validator.isValidString(FirstNameTextbox.Text);

            if (output == true)
            {
                FirstNameTextbox.BackColor = Color.LightGreen;
                FirstNameTextbox.Text = FirstNameTextbox.Text;
                DisplayFirstName.Text = FirstNameTextbox.Text;
            }
            else
            {
                FirstNameTextbox.BackColor = Color.Crimson;
                FirstNameTextbox.Text = "Enter a proper name";
            }
        }
        /// <summary>
        /// Compares user input LastName to a string
        /// </summary>
        /// <returns>True if input is a string</returns>
        private void validateLastName()
        {
            Validator validator = new Validator();
            bool output = validator.isValidString(LastNameTextbox.Text);
            if (output == true)
            {
                LastNameTextbox.BackColor = Color.LightGreen;
                LastNameTextbox.Text = LastNameTextbox.Text;
                DisplayLastName.Text = LastNameTextbox.Text;
            }
            else
            {
                LastNameTextbox.BackColor = Color.Crimson;
                LastNameTextbox.Text = "Enter a proper name";
            }
        }
        /// <summary>
        /// Compares user input Email to email regex
        /// </summary>
        /// <returns></returns>
        private void validateEmail()
        {
            Validator validator = new Validator();
            bool output = validator.isValidEmail(EmailTextbox.Text);
            if ((output == true) || (EmailTextbox.Text == ""))
            {

                EmailTextbox.BackColor = Color.LightGreen;
                EmailTextbox.Text = EmailTextbox.Text;
                DisplayEmail.Text = EmailTextbox.Text;
            }
            else
            {
                EmailTextbox.BackColor = Color.Crimson;
                EmailTextbox.Text = "Enter a valid Email address";
            }
        }
        /// <summary>
        /// Compares user input contact number to a number regex
        /// </summary>
        /// <returns></returns>
        private void validateContactNumber()
        {
            Validator validator = new Validator();
            bool output = validator.isValidNumber(ContactNumberTextbox.Text);
            if (output == true)
            {

                ContactNumberTextbox.BackColor = Color.LightGreen;
                ContactNumberTextbox.Text = ContactNumberTextbox.Text;
                DisplayPhone.Text = ContactNumberTextbox.Text;
            }
            else
            {
                ContactNumberTextbox.BackColor = Color.Crimson;
                ContactNumberTextbox.Text = "Enter a proper number";
            }
        }
        /// <summary>
        /// Checks values are entered for all of the combo boxes
        /// </summary>
        /// <returns>date of birth as a date</returns>
        private bool validateDateOfBirth()
        {
            bool dobValid = true;
            if (dayComboBox.Text == "DAY" && monthComboBox.Text == "MONTH" && yearComboBox.Text == "YEAR")
            {
                dayComboBox.BackColor = Color.LightGreen;
                monthComboBox.BackColor = Color.LightGreen;
                yearComboBox.BackColor = Color.LightGreen;
                dobValid = true;
            }
            else
            {
                if (dayComboBox.Text != "DAY" && monthComboBox.Text != "MONTH" && yearComboBox.Text != "YEAR")
                {
                    DateTime datetime = dob();
                    DisplayDOB.Text = datetime.ToString("dd/MM/yyyy");
                    dayComboBox.BackColor = Color.LightGreen;
                    monthComboBox.BackColor = Color.LightGreen;
                    yearComboBox.BackColor = Color.LightGreen;
                    dobValid = true;
                }

                else
                {
                    MessageBox.Show("Invalid date of birth");
                    dobValid = false;
                    if (dayComboBox.Text == "DAY")
                    {
                        dayComboBox.BackColor = Color.Crimson;
                    }
                    if (monthComboBox.Text == "MONTH")
                    {
                        monthComboBox.BackColor = Color.Crimson;
                    }
                    if (yearComboBox.Text == "YEAR")
                    {
                        yearComboBox.BackColor = Color.Crimson;
                    }
                }
            }
            return dobValid;
        }
        /// <summary>
        /// Method that takes input from the 3 Date Of Birth combox boxes and converts them to datetime
        /// </summary>
        /// <returns>Date Time</returns>
        private DateTime dob()
        {
            DateTime datetime = new DateTime();

            int i = 0;

            if (dayComboBox.Text == "DAY") i++;
            if (monthComboBox.Text == "MONTH") i++;
            if (yearComboBox.Text == "YEAR") i++;

            switch (i)
            {
                case 0:
                    string dob = $"{dayComboBox.Text}{monthComboBox.Text}{yearComboBox.Text}";
                    datetime = Convert.ToDateTime(dob);
                    return datetime;
                case 1:
                    MessageBox.Show("Invalid date of birth");
                    return datetime;
                case 2:
                    MessageBox.Show("Invalid date of birth");
                    return datetime;
                case 3:
                    return datetime;
            }
            return datetime;
        }

        /*
         * Events
         */
        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            EmailTextbox.BackColor = SystemColors.Info;
            EmailTextbox.Text = "";
        }
        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            validateEmail();
        }

        private void FirstNameTextbox_Enter(object sender, EventArgs e)
        {
            FirstNameTextbox.BackColor = SystemColors.Info;
            FirstNameTextbox.Text = "";
        }
        private void FirstNameTextbox_Leave(object sender, EventArgs e)
        {
            validateFirstName();
        }




        private void LastNameTextbox_Leave(object sender, EventArgs e)
        {
            validateLastName();
        }

        private void LastNameTextbox_Enter(object sender, EventArgs e)
        {
            LastNameTextbox.BackColor = SystemColors.Info;
            LastNameTextbox.Text = "";
        }

        private void contactNumberTextbox_Enter(object sender, EventArgs e)
        {
            ContactNumberTextbox.BackColor = SystemColors.Info;
            ContactNumberTextbox.Text = "";
        }

        private void PersonCreatorForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Reset date of birth combo boxes (colours and text), remove date from display if there.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetDOB_Click(object sender, EventArgs e)
        {
            dayComboBox.Text = "DAY";
            monthComboBox.Text = "MONTH";
            yearComboBox.Text = "YEAR";
            dayComboBox.BackColor = SystemColors.Window;
            monthComboBox.BackColor = SystemColors.Window;
            yearComboBox.BackColor = SystemColors.Window;
            DisplayDOB.Text = "";
        }

        private void contactNumberTextbox_Leave(object sender, EventArgs e)
        {
            validateContactNumber();
        }

        private void SexComboBox_Leave(object sender, EventArgs e)
        {
            if (SexComboBox.Text == Sex.Male.ToString())
            {
                SexComboBox.BackColor = Color.LightGreen;
                DisplaySex.Text = "Male";
            }
            else if (SexComboBox.Text == Sex.Female.ToString())
            {
                SexComboBox.BackColor = Color.LightGreen;
                DisplaySex.Text = "Female";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            validateDateOfBirth();
        }

        private void dayComboBox_Enter(object sender, EventArgs e)
        {
            dayComboBox.BackColor = SystemColors.Window;
        }

        private void dayComboBox_Leave(object sender, EventArgs e)
        {
            if (dayComboBox.Text != "DAY")
            {
                dayComboBox.BackColor = Color.LightGreen;
            }
        }
        private void monthComboBox_Enter(object sender, EventArgs e)
        {
            monthComboBox.BackColor = SystemColors.Window;
        }

        private void monthComboBox_Leave(object sender, EventArgs e)
        {
            if (monthComboBox.Text != "MONTH")
            {
                monthComboBox.BackColor = Color.LightGreen;
            }
        }

        private void yearComboBox_Enter(object sender, EventArgs e)
        {
            yearComboBox.BackColor = SystemColors.Window;
        }

        private void yearComboBox_Leave(object sender, EventArgs e)
        {
            if (yearComboBox.Text != "YEAR")
            {
                yearComboBox.BackColor = Color.LightGreen;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
