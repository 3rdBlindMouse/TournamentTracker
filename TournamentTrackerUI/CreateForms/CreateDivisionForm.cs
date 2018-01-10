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
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI
{
    public partial class CreateDivisionForm : Form, ITeamRequester
    {

        // A list to hold dates to be skipped
        private static List<DateTime> skippedDates = new List<DateTime>();
        //TODO
        private static List<TeamModel> availableTeams = GlobalConfig.Connection.GetAllTeams();
        private List<TeamModel> selectedTeams = new List<TeamModel>();

        public CreateDivisionForm()
        {
            InitializeComponent();
            WireupLists();
        }

        private void WireupLists()
        {
            addTeamsDropdown.DataSource = null;
            addTeamsDropdown.DataSource = availableTeams;
            addTeamsDropdown.DisplayMember = "TeamName";

            teamsListBox.DataSource = null;
            teamsListBox.DataSource = selectedTeams.OrderBy(t => t.TeamName).ToList(); ;
            teamsListBox.DisplayMember = "TeamName";

            DisplayNumTeams.Text = selectedTeams.Count.ToString();
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
            DisplayName.Text = tb.Text;
        }
        private void UpdateDivNumber(TextBox tb)
        {
            DisplayNumber.Text = tb.Text;
        }
        
        private void UpdateStartDate()
        {
            selectedStartDate.Text = StartDate.Value.ToString("D");
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
            if ((validator.isValidString(tb.Text) && (tb.Text != "Try Again")))
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
            if ((check.isValidNumber(tb.Text) && (tb.Text != "")))
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
            
                //Create updated Model(s)
                if ((ValidateDivisionName(DivisionNameTextbox)) && (ValidateDivisionNumber(DivisionNumberTextbox)))
                {
                    // create a division model
                    DivisionModel model = new DivisionModel();
                    model.DivisionName = DivisionNameTextbox.Text;
                    model.DivisionNumber = int.Parse(DivisionNumberTextbox.Text);
                    //model.DivisionTeams = selectedTeams;
                    model.StartDate = StartDate.Value;
                    // store division in Db and return ID
                    GlobalConfig.Connection.CreateDivision(model);
                    MessageBox.Show("Division Successfully Created");
                    clearForm();


                    foreach (DateTime date in skippedDates)
                    {
                        SkippedDatesModel skDates = new SkippedDatesModel();
                        skDates.DivisionID = model.DivisionID;
                        skDates.DateToSkip = date;
                        GlobalConfig.Connection.CreateSkippedDates(skDates);
                    }

                    model.DivisionSkippedDates = GlobalConfig.Connection.GetSkippedDates(model);

                    foreach (TeamModel team in selectedTeams)
                    {
                        TeamModel teammodel = new TeamModel();
                        teammodel.DivisionID = model.DivisionID;
                        teammodel.TeamID = team.TeamID;
                        GlobalConfig.Connection.CreateDivisionTeams(teammodel);
                    }
                }
            else
            {
                MessageBox.Show("Form Has Invalid Information");
            }
            
           
        }

        private void clearForm()
        {
            DivisionNameTextbox.Text = "";
            DivisionNumberTextbox.Text = "";
            StartDate.ResetText();
            selectedStartDate.Text = "";
            SkipDatesdateTimePicker.ResetText();
            skippedDatesListbox.Items.Clear();
            DisplayName.Text = "";
            DisplayNumber.Text = "";
            DisplayNumTeams.Text = "";
            if (teamsListBox.Items.Count > 0)
            {
                teamsListBox.Items.Clear();
            }
            addTeamsDropdown.DataSource = GlobalConfig.Connection.GetAllTeams();
        }

        private void ExitToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)addTeamsDropdown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireupLists();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)teamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                

                WireupLists();
            }
        }

       

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireupLists();
        }

        private void createNewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm teamForm = new CreateTeamForm(this);
            teamForm.Show();
            this.Hide();
            teamForm.FormClosing += closeForm;
        }

        public void closeForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
    }

