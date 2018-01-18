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
using TournamentTrackerUI.CreateForms;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI
{
    public partial class TournamentCreatorForm : Form
    {
        Validator validator = new Validator();
        private bool validateForm = false;

        public TournamentCreatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewTournamentButton_Click(object sender, EventArgs e)
        {
            ValidateForm();
            if (validateForm)
            {
                SeasonModel sm = new SeasonModel();
                sm.SeasonName = nameTextBox.Text;
                sm.SeasonYear = int.Parse(yearTextBox.Text);
                sm.SeasonDescription = descriptionTextBox.Text;
                GlobalConfig.Connection.CreateSeason(sm);               
                CreateSeasonForm seasonForm = new CreateSeasonForm();
                seasonForm.Show();
                this.Hide();
                seasonForm.FormClosing += closeForm;
            }
        }

            public void closeForm(object sender, FormClosingEventArgs e)
            {
                this.Show();
            }

        

        private bool ValidateForm()
        {
            bool valid = false;
            valid = ValidateSeasonName(nameTextBox);
            valid = ValidateSeasonYear(yearTextBox);
            validateForm = valid;
            return valid;
        }

        private bool ValidateSeasonName(TextBox tb)
        {
            bool valid = false;
            if (tb.Text == "")
            {
                nameErrorLabel.BackColor = Color.Crimson;
                nameErrorLabel.Text = "Please Enter a Name";
            }
            // If spaces at start/end of name of multiple consecutive spaces exist in name
            else if (!validator.noSpaces(tb.Text))
            {
                nameErrorLabel.BackColor = Color.Crimson;
                nameErrorLabel.Text = "No Leading, Ending, or Multiple Spaces Allowed";
                valid = false;
            }
            else
            {
                nameErrorLabel.BackColor = Color.White;
                nameErrorLabel.Text = "";
                valid = true;
            }
            return valid;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateSeasonName(nameTextBox);
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateSeasonYear(yearTextBox);
        }

        private bool ValidateSeasonYear(TextBox tb)
        {
            bool valid = false; ;

            if (tb.Text == "")
            {
                yearErrorLabel.BackColor = Color.Crimson;
                yearErrorLabel.Text = "Please Enter a Year";
            }
            else
            {
                if (tb.Text.Length > 6)
                {
                    MessageBox.Show("Please enter a smaller number");
                    yearTextBox.Text = "";
                }
                // If number is not a valid number
                if (!validator.isValidNumber(tb.Text))
                {
                    yearErrorLabel.BackColor = Color.Crimson;
                    yearErrorLabel.Text = "Please Enter a Valid Year";
                }
                else if((int.Parse(tb.Text) <= 2017) || (int.Parse(tb.Text) >= 2100))
                {
                    yearErrorLabel.BackColor = Color.Crimson;
                    yearErrorLabel.Text = "Please Enter a Valid Year";
                }
                else
                {
                    tb.BackColor = Color.LightGreen;
                    yearErrorLabel.Text = "";
                    yearErrorLabel.BackColor = Color.White;
                    valid = true;
                }               
            }
            return valid;
        }       
    }
}
