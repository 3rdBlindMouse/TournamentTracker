using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI
{
    public partial class EditDivisionForm : Form, ITeamRequester
    {
        // List of All Divisions
        //TODO sort Season out so list of divisions in selcted season.
        private static List<DivisionModel> divs = GlobalConfig.Connection.GetAllDivisions();
        // A list to hold dates to be skipped
        private static List<DateTime> skippedDates = new List<DateTime>();
        // used to store Division skipped dates before any edits to allow for comparisons.
        private static List<DateTime> OriginalskippedDates = new List<DateTime>();
        // List if Teams already in selected Division
        private static List<TeamModel> selectedTeams = new List<TeamModel>();
        // List of all teams not currently in selected division
        //TODO make it so only teams not in any division are included
        private static List<TeamModel> teamsAvailable = new List<TeamModel>(); 
        //temporary List to hold TeamModels for list comparisons
        private static List<TeamModel> tempTeamsList = new List<TeamModel>();
        // unneccesssary list was used in createDivisonsForm perhaps
        //TODO verify this is redundant and can be removed
        // private static List<SkippedDatesModel> sd = new List<SkippedDatesModel>();
        // List to hold teams to add to db et.al
        private static List<TeamModel> teamsToAdd = new List<TeamModel>();
        // List to hold teams to remove from db et.al
        private static List<TeamModel> teamsToRemove = new List<TeamModel>();
        // Variable to allow creation of DivisionModels
        private static DivisionModel dm ;
        // Variable to allow count of teams selected in Division
        private static int numberOfTeams;

        public EditDivisionForm()
        {
            InitializeComponent();           
            WireupDivisionSelector();
        }
        /// <summary>
        /// creates a new Division Model to use as a combobox Title
        /// Wires up Division List as datasource for DivisionNameComboBox
        /// </summary>
        private void WireupDivisionSelector()
        {
            AddSelectTitle();
           
            DivisionNameComboBox.DataSource = null;
            DivisionNameComboBox.DataSource = divs.OrderBy(p => p.DivisionNumber).ToList(); ;
            DivisionNameComboBox.DisplayMember = "DivisionName";
        }

        private void AddSelectTitle()
        {
            int index = divs.FindIndex(item => item.DivisionID == -1);
            if (index >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                DivisionModel d = new DivisionModel("Select Division", -1);
                divs.Insert(0, d);
            }
        }

        /// <summary>
        /// Wires up addTeamsDropdown and teamsListBox to datasources
        /// Updates displays addTeamsDropDown, teamsListBox, and numberOfTeamsLabel;
        /// </summary>
        /// <param name="available">List of Teams Available to be added to Division</param>
        /// <param name="selected">List of Teams already included in Division</param>
        private void WireupTeamLists(List<TeamModel> available, List<TeamModel> selected)
        {
            addTeamsDropdown.DataSource = null;
            addTeamsDropdown.DataSource = available.OrderBy(p => p.TeamName).ToList();
            addTeamsDropdown.DisplayMember = "TeamName";

            teamsListBox.DataSource = null;
            teamsListBox.DataSource = selected.OrderBy(p => p.TeamName).ToList();
            teamsListBox.DisplayMember = "TeamName";
            numberOfTeams = selected.Count();
            numberOfTeamsLabel.Text = numberOfTeams.ToString();
        }

        /*
        * User notifications
        */
        /// <summary>
        /// Displays in textbox current Name of Division
        /// Editable by user
        /// </summary>
        /// <param name="cb">A Combobox</param>
        private void UpdateDivName(ComboBox cb)
        {
            DivisionModel d = new DivisionModel();
            d = (DivisionModel)cb.SelectedItem;
            nameTextBox.Text = d.DivisionName;
        }

        /// <summary>
        /// Displays in textbox current number of Division
        /// Editable by user
        /// </summary>
        /// <param name="tb">A Label</param>
        private void UpdateDivNumber(Label tb)
        {
            numberTextBox.Text = tb.Text;
        }

        /// <summary>
        /// Updates display based on current division startdate or that selected by user
        /// </summary>
        private void UpdateStartDate()
        {
            selectedStartDate.Text = StartDate.Value.ToString("D");
        }

        /// <summary>
        /// Checks if selected date already in selected, if not adds
        ///date to List and calls updateSkippedDatesBox to update display
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

        /// <summary>
        /// Updates display to show selected date(s) to skip
        /// </summary>
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
        /// Removes selected date from skippedDates list and calls
        /// updteSkippedDatesBox to update display
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
        /// //TODO stop spaces at end being allowed
        private bool ValidateDivisionName(TextBox tb)
        {
            Validator validator = new Validator();
            if (validator.isValidString(tb.Text))
            {                
                return true;
            }
            else
            {               
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
                return true;
            }
            else
            {               
                return false;
            }
        }

        /*
         * Select / Change Events
         */
         /// <summary>
         /// If form is ready update startdate
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            if (formReady() == true)
            UpdateStartDate();
        }
        /// <summary>
        /// If form is ready add skipped dates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skipDatesAddButton_Click(object sender, EventArgs e)
        {
            if(formReady() == true)
            addSkipdates();
        }

        /// <summary>
        /// remove skipped dates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skipDatesRemoveButton_Click(object sender, EventArgs e)
        {
            removeSkippedDates();
        }

        private void ExitToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayDivisionNumber(DivisionModel dm)
        {
            DivNumberLabel.Text = dm.DivisionNumber.ToString();
        }

        private void DisplayDivisionStartDate(DivisionModel dm)
        {
            StartDate.Value = dm.StartDate;
        }

        /// <summary>
        /// Gets Division Teams from datasource
        /// </summary>
        /// <param name="dm"></param>
        private List<TeamModel> getDivisionTeams(DivisionModel dm)
        {
            selectedTeams = GlobalConfig.Connection.GetDivisionTeams(dm);            
            return selectedTeams;
        }

        /// <summary>
        /// Gets skipped date for division from the DB
        /// Converts skipped date field into List of DateTime
        /// populates the skipped dates list box
        /// which can be manipulated
        /// </summary>
        private void getSkippedDates(DivisionModel dm)
        {
            List<SkippedDatesModel> sd = GlobalConfig.Connection.GetSkippedDates(dm);
            skippedDates = new List<DateTime>();
            foreach (SkippedDatesModel sdm in sd)
            {
                skippedDates.Add(sdm.DateToSkip);
                OriginalskippedDates.Add(sdm.DateToSkip);
            }
            updateSkippedDatesBox();
        }

        /// <summary>
        /// Removes Team from teamsListBox and adds it to addTeamsDropdown
        /// calls WireupTeamLists 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)teamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                teamsAvailable.Add(t);
                teamsToRemove.Add(t);
                WireupTeamLists(teamsAvailable, selectedTeams);
                numberOfTeams = selectedTeams.Count;
            }
        }

        /// <summary>
        /// Removes Team from addTeamsDropdown and adds it to teamsListBox
        /// calls WireupTeamLists 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)addTeamsDropdown.SelectedItem;
            if (t != null)
            {
               selectedTeams.Add(t);
               teamsAvailable.Remove(t);
                teamsToAdd.Add(t);
               WireupTeamLists(teamsAvailable, selectedTeams);
                numberOfTeams = selectedTeams.Count;
            }
        }

        // TODO : make it so available teams only includes those not assigned to a division
        /// <summary>
        /// removes teams already assigned to divison from
        /// list of all teams
        /// </summary>
        /// <param name="dm"></param>
        private List<TeamModel> getAvailableTeams(DivisionModel dm)
        {
            // Get ALL teams
            teamsAvailable = GlobalConfig.Connection.GetAllTeams();
            // Add Selected Teams to a temp list.
            // WHY???? no idea but cant make it work without doing this.
            // I thought foreach in selected remove from available would work but nope
            foreach (TeamModel team in selectedTeams)
            {
                int id = team.TeamID;
                foreach(TeamModel aTeam in teamsAvailable)
                {
                    if(id == aTeam.TeamID)
                    {
                        tempTeamsList.Add(aTeam);
                    }
                }    
            }
            // if teamsAvailable list has any of the teams in the temp list remove them from
            // teamsAvailable list
            foreach (TeamModel temp in tempTeamsList)
            {
                teamsAvailable.Remove(temp);
            }
            return teamsAvailable;
        }

        /// <summary>
        /// What happens when user makes a Division selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivisionNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //clears team listbox
            teamsListBox.DataSource = null;         
            // i.e. if a Division has been selected
            if(formReady() == true)         
            {
                // Get/Create Division Model that has been selected
                dm = (DivisionModel)DivisionNameComboBox.SelectedItem;
                //Display Division details
                DisplayDivisionNumber(dm);
                DisplayDivisionStartDate(dm);
                getSkippedDates(dm);
                selectedTeams = getDivisionTeams(dm);              
                teamsAvailable = getAvailableTeams(dm);
                WireupTeamLists(teamsAvailable, selectedTeams);
                UpdateDivName(DivisionNameComboBox);
                UpdateDivNumber(DivNumberLabel);
            }
            else
            {
                resetForm();
            }
        }

        /// <summary>
        /// Make sure form is in ready state before user can edit anything
        /// </summary>
        /// <returns></returns>
        private bool formReady()
        {
            // If a Division has been selected from DivisionNameComboBox
            if ((DivisionNameComboBox.SelectedIndex != 0)
                && (DivisionNameComboBox.SelectedItem != null)
                && (DivisionNameComboBox.SelectedText != "Select Division"))
                return true;
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Creates basic framework of Division Model
        /// </summary>
        /// <returns></returns>
        private DivisionModel getDivisionModel()
        {
            // create a division model
            DivisionModel model = (DivisionModel)DivisionNameComboBox.SelectedItem;
            model.DivisionName = nameTextBox.Text;
            model.DivisionNumber = int.Parse(numberTextBox.Text);
            //model.DivisionTeams = selectedTeams;
            model.StartDate = StartDate.Value;
            // store division in Db and return ID    
            return model;
        }
        /// <summary>
        /// Where the heavy lifting happens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditDivisionButton_Click(object sender, EventArgs e)
        {
            if (formReady() == true)
            {
                //Create updated Model(s)
                if ((ValidateDivisionName(nameTextBox)) && (ValidateDivisionNumber(numberTextBox)))
                {
                    // Create a simple Division Model using selected Division ID and any changes on form that may or may not have been made
                    DivisionModel model = getDivisionModel();
                    // Commit simple Divison Model to db et.al
                    GlobalConfig.Connection.EditDivision(model);
                    // Commit Division Skipped Dates to db et.al
                    EditSkippedDates(model);
                    // Commit Division Teams to db et.al
                    EditTeamsModels(model);
                    // Clear Form
                    resetForm();
                    MessageBox.Show("Division Sucessfully Edited");
                }
                else
                {
                    MessageBox.Show("Division Name or Number Invalid");
                }    
            }
        }

        /// <summary>
        /// Calls methods to add and/or remove teams
        /// </summary>
        /// <param name="model"></param>
        private void EditTeamsModels(DivisionModel model)
        {
            if(teamsToAdd.Count > 0)
            {
                addTeams(model);
            }
            if (teamsToRemove.Count > 0)
            {
                removeTeams(model);
            }
            
        }

        /// <summary>
        /// add selected teams to db et.al
        /// </summary>
        /// <param name="model"></param>
        private void addTeams(DivisionModel model)
        {
            foreach (TeamModel team in teamsToAdd)
            {
                TeamModel teammodel = new TeamModel();
                teammodel.DivisionID = model.DivisionID;
                teammodel.TeamID = team.TeamID;
                GlobalConfig.Connection.CreateDivisionTeams(teammodel);
            }
            teamsToAdd = new List<TeamModel>();
        }

        /// <summary>
        /// remove teams from db et.al
        /// </summary>
        /// <param name="model"></param>
        private void removeTeams(DivisionModel model)
        {
            foreach (TeamModel team in teamsToRemove)
            {
                TeamModel teammodel = new TeamModel();
                teammodel.DivisionID = model.DivisionID;
                teammodel.TeamID = team.TeamID;
                GlobalConfig.Connection.DeleteDivisionTeams(teammodel);
            }
            teamsToRemove = new List<TeamModel>();
        }

        /// <summary>
        /// Compare Divsion Skipped Dates list to any changes that user may have made to this list
        /// update db et.al accordingly
        /// </summary>
        /// <param name="model"></param>
        // TODO likely change to match with what have done with teams but having the two different variations is ok for now
        private void EditSkippedDates(DivisionModel model)
        {
            // Are the two lists the same size? does one of the lists contain everything in the other list?
            var skippedDatesSame = ((OriginalskippedDates.Count == skippedDates.Count) && OriginalskippedDates.All(skippedDates.Contains));
            if (skippedDatesSame != true)
            {
                // if not remove all dates from db 
                GlobalConfig.Connection.DeleteSkippedDates(model);
                // and repopulate with new data
                foreach (DateTime date in skippedDates)
                {
                    SkippedDatesModel skDates = new SkippedDatesModel();
                    skDates.DivisionID = model.DivisionID;
                    skDates.DateToSkip = date;
                    GlobalConfig.Connection.CreateSkippedDates(skDates);
                }

            }


            model.DivisionSkippedDates = GlobalConfig.Connection.GetSkippedDates(model);
        }

        

        /// <summary>
        /// Resets form labels, comboxboxes, colors etc
        /// </summary>
        private void resetForm()
        {
            DivisionNameComboBox.SelectedIndex = 0;
            DivNumberLabel.Text = "";
            skippedDatesListbox.Items.Clear();
            StartDate.ResetText();
            selectedStartDate.Text = "";
            nameTextBox.Text = "";
            numberTextBox.Text = "";
            DivisionNameComboBox.BackColor = SystemColors.Info;
            DivNumberLabel.BackColor = SystemColors.Info;
            nameErrorLabel.Text = "";
            numberErrorLabel.Text = "";
            nameErrorLabel.BackColor = SystemColors.Info;
            numberErrorLabel.BackColor = SystemColors.Info;
            addTeamsDropdown.DataSource = null;
        }

        /// <summary>
        /// Validate users changes to Division Name
        /// Will not allow names of existing divisions to be used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get DivisionModel user has selected
            dm = (DivisionModel)DivisionNameComboBox.SelectedItem;
            // Get Divison Name from selected Division
            string initialName = dm.DivisionName.ToString();
            // Create List of Division Names
            List<string> teamNames = new List<string>();
            foreach (DivisionModel d in divs)
            {
                teamNames.Add(d.DivisionName.ToString());
            }
            // Create Temp list Iterate through it and remove initial name from list
            List<string> tempNames = new List<string>();
            foreach (string name in teamNames)
            {
                if(name != initialName)
                {
                    tempNames.Add(name);
                }
            }
            teamNames = tempNames;
            // Gives users some visual clues
            if ((teamNames.Contains(nameTextBox.Text) || (!ValidateDivisionName(nameTextBox))))
            {
            nameErrorLabel.BackColor = Color.Crimson;
            nameErrorLabel.Text = "Name Already Exists or is Invalid";
            }
            else
            {
            nameErrorLabel.BackColor = Color.LightGreen;
            nameErrorLabel.Text = "Valid Name";
            }           
        }

       
        /// <summary>
        /// Validate users changes to Divison Number
        /// Will not allow numbers of existing divisons to be used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // TODO disallow huge numbers
        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get DivisionModel user has selected
            dm = (DivisionModel)DivisionNameComboBox.SelectedItem;
            // Get Divison Name from selected Division
            int initialNum = dm.DivisionNumber;
            // Create List of Division Names
            List<int> teamNums = new List<int>();
            foreach (DivisionModel d in divs)
            {
                teamNums.Add(d.DivisionNumber);
            // Create Temp list Iterate through it and remove initial name from list
            List<int> tempNums = new List<int>();
            foreach (int n in teamNums)
            {
                if (n != initialNum)
                {
                    tempNums.Add(n);
                }
            }
            teamNums = tempNums;
            // show user some visual clues
            if  ((!ValidateDivisionNumber(numberTextBox)) ||  (numberTextBox.Text == ""))
            {
                    numberErrorLabel.BackColor = Color.Crimson;
            }
                else if(teamNums.Contains(int.Parse(numberTextBox.Text)))
                {
                    numberErrorLabel.BackColor = Color.Crimson;
                    numberErrorLabel.Text = "Number Already Exists or is Invalid";
                }
                    else
                    {
                    numberErrorLabel.BackColor = Color.LightGreen;
                    numberErrorLabel.Text = "Valid Number";
                }
        }
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

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireupTeamLists(teamsAvailable, selectedTeams);
        }
    }
}

