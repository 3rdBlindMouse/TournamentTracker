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
    public partial class CreateDivisionForm : Form
    {
        // A list to hold dates to be skipped
        private static List<DateTime> skippedDates = new List<DateTime>();
        private static List<TeamModel> teams = GlobalConfig.Connection.GetAllTeams();

        public CreateDivisionForm()
        {
            InitializeComponent();
            WireupLists();
        }

        private void WireupLists()
        {
            addTeamsDropdown.DataSource = null;
            addTeamsDropdown.DataSource = teams;
            addTeamsDropdown.DisplayMember = "TeamName";
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
        private void UpdateDivName(TextBox tb)
        {
            detailsListbox.Items.RemoveAt(0);
            detailsListbox.Items.Insert(0, tb.Text);
        }
        private void UpdateDivNumber(TextBox tb)
        {
            detailsListbox.Items.RemoveAt(2);
            detailsListbox.Items.Insert(2, tb.Text);
        }
        private void UpdateDivTeams(TextBox tb)
        {
            detailsListbox.Items.RemoveAt(4);
            detailsListbox.Items.Insert(4, tb.Text);
        }
        private void UpdateStartDate()
        {
            detailsListbox.Items.RemoveAt(6);
            detailsListbox.Items.Insert(6, StartDate.Value.ToString("D"));
        }
        /// <summary>
        /// Updates display to show selected date(s) to skip
        /// </summary>
        private void addSkipdates()
        {
            var date = SkipDatesdateTimePicker.Value.ToString("D");
            // check to see if date is already selected as a skipped date
            if (!skippedDates.Contains(DateTime.Parse(date)))
            {
                skippedDates.Add(DateTime.Parse(date));
                updateSkippedDatesBox();
                
               
            }
        }

        private void updateSkippedDatesBox()
        {
            skippedDatesListbox.Items.Clear();
            var sortedDates = skippedDates.OrderBy(x => x).ToList();
            foreach (DateTime dates in sortedDates)
            {
                skippedDatesListbox.Items.Add(dates.ToString("D"));
            }
        }

        /// <summary>
        /// Updates display to remove selected date(s)
        /// </summary>
        private void removeSkippedDates()
        {
            if (skippedDatesListbox.SelectedItem != null)
            {
                var sortedDates = skippedDates.OrderBy(x => x).ToList();
                var date = DateTime.Parse(skippedDatesListbox.SelectedItem.ToString());
                skippedDates.Remove(date);

                updateSkippedDatesBox();
            }
        }
        /*
         * Validations
         */
        /// <summary>
        /// validates user input division name as a valid alphabetical string
        /// </summary>
        /// <param name="tb"></param>
        private bool ValidateDivisionName(TextBox tb)
        {
            Validator validator = new Validator();           
            if (validator.isValidString(tb.Text))
            {
                Success(tb);
                return true;
            }
            else
            {
                Fail(tb);
                return false;
            };
        }
        /// <summary>
        /// validates user input division number as a valid number
        /// </summary>
        /// <param name="tb"></param>
        private bool ValidateDivisionNumber(TextBox tb)
        {
            Validator check = new Validator();
            if (check.isValidNumber(tb.Text))
            {
                Success(tb);
                return true;
            }
            else
            {
                Fail(tb);
                return false;
            }
        }
        /// <summary>
        /// validates user input number of teams as a valid number
        /// </summary>
        /// <param name="tb"></param>
        private bool ValidateNumberOfTeams(TextBox tb)
        {
            Validator check = new Validator();
            if (check.isValidNumber(tb.Text))
            {
                Success(tb);
                return true;
            }
            else
            {
                Fail(tb);
                return false;
            }
        }

        /*
        * Enter Events
        */
        private void DivisionNameTextbox_Enter(object sender, EventArgs e)
        {
            OnEnter(DivisionNameTextbox);
        }
        private void DivisionNumberTextbox_Enter(object sender, EventArgs e)
        {
            OnEnter(DivisionNumberTextbox);
        }
       
        /*
         * Leave Events
         */
        private void DivisionNameTextbox_Leave(object sender, EventArgs e)
        {
            if (ValidateDivisionName(DivisionNameTextbox))
            {
                UpdateDivName(DivisionNameTextbox);
            }
        }
        private void DivisionNumberTextbox_Leave(object sender, EventArgs e)
        {
            if (ValidateDivisionNumber(DivisionNumberTextbox))
            {
                UpdateDivNumber(DivisionNumberTextbox);
            }
        }
        
        /*
         * Select Events
         */
        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateStartDate();
        }
        private void skipDatesAddButton_Click(object sender, EventArgs e)
        {
            addSkipdates();
        }
        private void skipDatesRemoveButton_Click(object sender, EventArgs e)
        {
            removeSkippedDates();
        }

        private void createDivisionButton_Click(object sender, EventArgs e)
        {
        }

        private void ExitToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

