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

namespace TournamentTrackerUI.CreateForms
{
    public partial class CreateSeasonForm : Form, IDivisionRequester, IDivisionDatesRequester, ITeamRequester
    {
        // retrieve the last season created, could change this by getting
        // calling form to pass over the information instead.
        private List<SeasonModel> thisSeasonAsList = GlobalConfig.Connection.GetLastSeason();
        // variable to hold created season
        private SeasonModel thisSeason = new SeasonModel();
        //variable to hold this seasons seasonID
        private int seasonID;

        private static DivisionModel DivModel = new DivisionModel();
        private static TeamModel TeamModel = new TeamModel();

        List<DivisionModel> divs = new List<DivisionModel>();

        private static SeasonDivisionsModel sdm = new SeasonDivisionsModel();
        private List<DivisionModel> selectedDivisions = new List<DivisionModel>();
        private static DivisionTeamsModel dtm = new DivisionTeamsModel();

        private List<TeamModel> selectedTeams = new List<TeamModel>();




        public CreateSeasonForm()
        {
            InitializeComponent();
            ConvertSeasonListToSeasonModel();
            InitializeLabels();

            WireUpDivisionComboBox();
            wireUpDivisionListBox();
            wireUpTeamsDivisionComboBox();


            wireUpPlayersTeamComboBox();
            
        }

        /// <summary>
        /// Takes the list containing the last season created (The one that called this form)
        /// and creates a SeasonModel from the data.
        /// could possibly do this in previous form and pass the seasonmodel
        /// </summary>
        private void ConvertSeasonListToSeasonModel()
        {
            foreach (SeasonModel sm in thisSeasonAsList)
            {
                thisSeason.SeasonID = sm.SeasonID;
                seasonID = sm.SeasonID;
                thisSeason.SeasonName = sm.SeasonName;
                thisSeason.SeasonYear = sm.SeasonYear;
                thisSeason.SeasonDescription = sm.SeasonDescription;
            }
        }
        /// <summary>
        /// Show Details of Current Season at top of form
        /// </summary>
        private void InitializeLabels()
        {
            displayNameLabel.Text = thisSeason.SeasonName;
            displayYearLabel.Text = thisSeason.SeasonYear.ToString();
            displayDescriptionLabel.Text = thisSeason.SeasonDescription;

        }
        /// <summary>
        /// Wires up the division combo box with divisions in this season
        /// Takes a list of divisions, if division has not beeen selected in this season adds to 
        /// combobox
        /// </summary>
        private void WireUpDivisionComboBox()
        {
            divisionsComboBox.DataSource = null;
            divisionsComboBox.DataSource = GlobalConfig.Connection.GetDivsNotInThisSeason(thisSeason.SeasonID);
            divisionsComboBox.DisplayMember = "DivisionName";
        }
        /// <summary>
        /// Opens a new Create Division form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewDivisionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateDivisionForm divisionForm = new CreateDivisionForm(this, thisSeason);
            divisionForm.Show();
            this.Hide();
            divisionForm.FormClosing += closeForm;
        }

        public void closeForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        /// <summary>
        /// When New Division has been created
        /// </summary>
        /// <param name="model"></param>
        public void DivisionComplete(DivisionModel model)
        {    
            selectedDivisions.Add(model);           
            wireUpDivisionListBox();
            wireUpTeamsDivisionComboBox();
            WireUpDivisionComboBox();
        }   
        /// <summary>
        /// Display 
        /// </summary>
        private void wireUpDivisionListBox()
        {
            //divisionsListBox.Items.Clear();
            divisionsListBox.DataSource = null;
            divisionsListBox.DataSource = GlobalConfig.Connection.GetSeasonDivisions(seasonID);
            //foreach (DivisionModel dm in selectedDivisions)
            //{
            //    divisionsListBox.Items.Add(dm);
            //    divisionsListBox.DisplayMember = "DivisionName";
            //}
            divisionsListBox.DisplayMember = "DivisionName";          
        }
        /// <summary>
        /// Opens a new Division Dates form so selected division "frame" can have dates added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDivisionButton_Click(object sender, EventArgs e)
        {
            DivModel = (DivisionModel)(divisionsComboBox.SelectedItem);           
            DivisionDatesForm ddf = new DivisionDatesForm(this, seasonID, DivModel);            
            ddf.Show();
            this.Hide();
            ddf.FormClosing += closeForm;
        }

        private void removeDivisionButton_Click(object sender, EventArgs e)
        {
            DivModel = (DivisionModel)(divisionsListBox.SelectedItem);
            selectedDivisions.Remove(DivModel);
            GlobalConfig.Connection.DeleteSeasonDivisions(seasonID, DivModel.DivisionID);
            wireUpDivisionListBox();
            wireUpTeamsDivisionComboBox();
            WireUpDivisionComboBox();
        }
        /// <summary>
        /// When dates have been successfully added to Division "frame"
        /// </summary>
        /// <param name="model"></param>
        public void DatesComplete(SeasonDivisionsModel model)
        {
            selectedDivisions.Add(DivModel);
            wireUpDivisionListBox();
            wireUpTeamsDivisionComboBox();
            WireUpDivisionComboBox();
        }
        /// <summary>
        /// WiresUp Division Combo Box associated with the Team section of the form
        /// </summary>
        private void wireUpTeamsDivisionComboBox()
        {
            teamsDivisionComboBox.DataSource = null;
            teamsDivisionComboBox.DataSource = GlobalConfig.Connection.GetSeasonDivisions(seasonID);
            teamsDivisionComboBox.DisplayMember = "DivisionName";
        }
       
        /// <summary>
        /// When a Division is selected from the division Combo box in the team section
        /// Get the Season/Division Teams and wire up Team boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamsDivisionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DivisionModel dm = (DivisionModel)teamsDivisionComboBox.SelectedItem;
            if (dm != null)
            {
                divisionLabel.Text = dm.DivisionName;
                sdm = GlobalConfig.Connection.GetSeasonDivisionModel(dm);
                wireUpTeamsComboBox(sdm);
                wireupTeamsListBox();
            }
        }
        /// <summary>
        /// Wire Up Team Combo box with teams that are NOT
        /// already selected in the current season
        /// </summary>
        /// <param name="model"></param>
        private void wireUpTeamsComboBox(SeasonDivisionsModel model)
        {
            teamsComboBox.DataSource = null;
            teamsComboBox.DataSource = GlobalConfig.Connection.GetTeamsNotInSeason(model);
            teamsComboBox.DisplayMember = "TeamName";
        }
        /// <summary>
        /// Opens and new Create Team form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DivModel = (DivisionModel)(teamsDivisionComboBox.SelectedItem);
            if (DivModel != null)
            {
                CreateTeamForm tf = new CreateTeamForm(this);
                tf.Show();
                this.Hide();
                tf.FormClosing += closeForm;
            }
            else
            {
                MessageBox.Show("Please Select a Division");
            }
        }
        /// <summary>
        /// When team is complete update display and DB
        /// </summary>
        /// <param name="model"></param>
        public void TeamComplete(TeamModel model)
        {
            dtm.SeasonDivisionsID = seasonID;
            dtm.TeamID = model.TeamID;
            selectedTeams.Add(model);
            GlobalConfig.Connection.CreateDivisionTeams(dtm);
            wireupTeamsListBox();
            teamsListBox.Items.Add(model.TeamName);            
        }
        /// <summary>
        /// Wires up Teams List Box to display selected teams names
        /// </summary>
        private void wireupTeamsListBox()
        {
            selectedTeams = GlobalConfig.Connection.GetDivisionTeams(sdm);
            teamsListBox.Items.Clear();
            foreach (TeamModel tm in selectedTeams)
            {
                teamsListBox.Items.Add(tm);
                teamsListBox.DisplayMember = "TeamName";
            }         
        }
        /// <summary>
        /// Adds selected team to selected Division in current season
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            DivModel = (DivisionModel)(teamsDivisionComboBox.SelectedItem);
            if (DivModel != null)
            {
                TeamModel tm = (TeamModel)teamsComboBox.SelectedItem;
                if (tm != null)
                {
                    selectedTeams.Add(tm);
                    DivisionTeamsModel dtm = new DivisionTeamsModel();
                    dtm.SeasonDivisionsID = sdm.SeasonDivisionsID;
                    dtm.TeamID = tm.TeamID;
                    GlobalConfig.Connection.CreateDivisionTeams(dtm);
                    wireupTeamsListBox();
                    wireUpTeamsComboBox(sdm);
                    wireUpPlayersTeamComboBox();
                }
            }
        }

        private void wireUpPlayersTeamComboBox()
        {
            playersTeamComboBox.DataSource = null;
            playersTeamComboBox.DataSource = GlobalConfig.Connection.GetSeasonTeams(sdm);
            playersTeamComboBox.DisplayMember = "TeamName";
        }

        private void removeTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel tm = (TeamModel)(teamsListBox.SelectedItem);
            if (tm != null)
            {
                selectedTeams.Remove(tm);
                GlobalConfig.Connection.DeleteDivisionTeams(sdm.SeasonDivisionsID, tm.TeamID);
                wireupTeamsListBox();
                wireUpTeamsComboBox(sdm);
                wireUpPlayersTeamComboBox();
            }
        }



        /// <summary>
        /// method called form can call to get currently selected divisions name
        /// </summary>
        /// <returns></returns>
        public string DivisionName()
        {
            return DivModel.DivisionName;
        }
        /// <summary>
        /// method called form can call to get currently selected SeasonDivisionsModel
        /// </summary>
        /// <returns></returns>
        public SeasonDivisionsModel SeasonDivision()
        {
            return sdm;
        }

        
    }
}
