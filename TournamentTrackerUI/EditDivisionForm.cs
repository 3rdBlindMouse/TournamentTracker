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
    public partial class EditDivisionForm : Form
    {
        // A list to hold dates to be skipped
        private static List<DateTime> skippedDates = new List<DateTime>();
        private static List<DivisionModel> divs = GlobalConfig.Connection.GetAllDivisions();
        private static List<TeamModel> selectedTeams = new List<TeamModel>();
        private static List<TeamModel> teamsAvailable = GlobalConfig.Connection.GetAllTeams();
        private static List<TeamModel> availableTeams = new List<TeamModel>(teamsAvailable);
        private static List<SkippedDatesModel> sd = new List<SkippedDatesModel>();

        private static DivisionModel dm ;

        public EditDivisionForm()
        {
            InitializeComponent();
            //SetupAvailableTeams();
            WireupLists();
            DivisionNameComboBox.SelectedIndex = -1;
            //WireupLists();
            
            
        }

        private void SetupAvailableTeams()
        {
            
            foreach (TeamModel team in selectedTeams)
            {
                int id = team.TeamID;
                foreach (TeamModel aTeam in teamsAvailable)
                {
                    if (id.Equals(aTeam.TeamID))
                    {
                        availableTeams.Remove(aTeam);
                    }
                }
            }
            
        }

        private void WireupLists()
        {
            DivisionNameComboBox.DataSource = null;
            DivisionNameComboBox.DataSource = divs;
            DivisionNameComboBox.DisplayMember = "DivisionName";

            

            addTeamsDropdown.DataSource = null;
            addTeamsDropdown.DataSource = availableTeams;
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
        private void UpdateDivName(ComboBox cb)
        {
            DivisionModel d = new DivisionModel();
            d = (DivisionModel)cb.SelectedItem;
            nameTextBox.Text = d.DivisionName;
        }
        private void UpdateDivNumber(TextBox tb)
        {
            numberTextBox.Text = tb.Text;
        }
        private void UpdateDivTeams(TextBox tb)
        {

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
       
        private void DivisionNumberTextbox_Enter(object sender, EventArgs e)
        {
            OnEnter(DivisionNumberTextbox);
        }

        /*
         * Leave Events
         */
       
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
            // create a division model
            DivisionModel model = new DivisionModel();
            model.DivisionName = DivisionNameComboBox.SelectedItem.ToString();
            model.DivisionNumber = int.Parse(DivisionNumberTextbox.Text);
            //model.DivisionTeams = selectedTeams;
            model.StartDate = StartDate.Value;
            // store division in Db and return ID
            GlobalConfig.Connection.EditDivision(model);


            foreach (DateTime date in skippedDates)
            {
                SkippedDatesModel skDates = new SkippedDatesModel();
                skDates.DivisionID = model.DivisionID;
                skDates.DateToSkip = date;
                //GlobalConfig.Connection.CreateSkippedDates(skDates);
            }

            model.DivisionSkippedDates = GlobalConfig.Connection.GetSkippedDates(model);

            foreach (TeamModel team in selectedTeams)
            {
                TeamModel teammodel = new TeamModel();
                teammodel.DivisionID = model.DivisionID;
                teammodel.TeamID = team.TeamID;
              //  GlobalConfig.Connection.CreateDivisionTeams(teammodel);
            }


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

        private void DivisionNameComboBox_Leave(object sender, EventArgs e)
        {
            UpdateDivName(DivisionNameComboBox);
        }

        private void DivisionNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            teamsListBox.DataSource = null;
            

            if (DivisionNameComboBox.SelectedIndex != -1)
            {
                dm = (DivisionModel)DivisionNameComboBox.SelectedItem;
                DivisionNumberTextbox.Text = dm.DivisionNumber.ToString();
                StartDate.Value = dm.StartDate;
                
                

                teamsListBox.DataSource = null;
                selectedTeams = GlobalConfig.Connection.GetDivisionTeams(dm);
                teamsListBox.DataSource = selectedTeams.OrderBy(p => p.TeamName).ToList();
                teamsListBox.DisplayMember = "TeamName";
                //WireupLists();
            }
        }
    }
}

