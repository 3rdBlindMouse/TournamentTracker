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
    public partial class CreateSeasonForm : Form, IDivisionRequester, IDivisionDatesRequester, ITeamRequester, IPersonRequester
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

        //private List<TeamModel> selectedTeams = new List<TeamModel>();
        private static List<PersonModel> allPlayers = GlobalConfig.Connection.GetAllPeople();
        private static List<PersonModel> seasonPlayers = new List<PersonModel>();

        private static List<PersonModel> teamMembers = new List<PersonModel>();


        public CreateSeasonForm()
        {
            InitializeComponent();
            ConvertSeasonListToSeasonModel();
            InitializeLabels();

            WireUpDivisionComboBox();
            wireUpDivisionListBox();
            wireUpTeamsDivisionComboBox();


            wireUpPlayersTeamComboBox();

            wireUpPlayersComboBox();
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
            divisionsListBox.DataSource = null;
            divisionsListBox.DataSource = GlobalConfig.Connection.GetSeasonDivisions(seasonID);
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
            wireUpTeamsComboBox(sdm);
            wireUpPlayersTeamComboBox();
            wireUpPlayersListBox();
            if (teamsDivisionComboBox.Items.Count == 0)
            {
                teamsComboBox.DataSource = null;

                teamsListBox.DataSource = null;

                playersTeamComboBox.DataSource = null;
                playersComboBox.DataSource = null;
                if (playersListBox.Items.Count > 0)
                {
                    playersListBox.DataSource = null;
                }
            }
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
            List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeamsNotInSeason(model);
            List<TeamModel> selectedTeams = GlobalConfig.Connection.GetDivisionTeams(sdm);
            // take the list of Available teams and removes those selected in a division
            // return that list and populate the divisionComboBox
            var result = availableTeams.Where(p => selectedTeams.All(p2 => p2.TeamID != p.TeamID));

            teamsComboBox.DataSource = null;
            teamsComboBox.DataSource = result.ToList();
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
            dtm = new DivisionTeamsModel();
            dtm.SeasonDivisionsID = seasonID;
            dtm.TeamID = model.TeamID;
            //selectedTeams.Add(model);
            GlobalConfig.Connection.CreateDivisionTeams(dtm);
            wireupTeamsListBox();
            wireUpPlayersTeamComboBox();
            //teamsListBox.Items.Add(model.TeamName);
        }
        /// <summary>
        /// Wires up Teams List Box to display selected teams names
        /// </summary>
        private void wireupTeamsListBox()
        {

            teamsListBox.DataSource = null;
            teamsListBox.DataSource = GlobalConfig.Connection.GetDivisionTeams(sdm);
            teamsListBox.DisplayMember = "TeamName";
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
                    //selectedTeams.Add(tm);
                    dtm = new DivisionTeamsModel();
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
                //selectedTeams.Remove(tm);
                GlobalConfig.Connection.DeleteDivisionTeams(sdm.SeasonDivisionsID, tm.TeamID);
                wireupTeamsListBox();
                wireUpTeamsComboBox(sdm);
                wireUpPlayersTeamComboBox();


                if (teamsListBox.Items.Count == 0)
                {

                    playersTeamComboBox.DataSource = null;
                    playersComboBox.DataSource = null;
                    if (playersListBox.Items.Count > 0)
                    {
                        playersListBox.DataSource = null;
                    }
                }

            }
        }

        private void wireUpPlayersComboBox()
        {
            //var result = allPlayers.Where(p => teamMembers.All(p2 => p2.PersonID != p.PersonID));
            playersComboBox.DataSource = null;
            playersComboBox.DataSource = GlobalConfig.Connection.GetPlayersNotInThisSeason(sdm);
            playersComboBox.DisplayMember = "FullName";
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

        private void createNewPlayerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreatePersonForm pf = new CreatePersonForm(this);
            pf.Show();
            this.Hide();
            pf.FormClosing += closeForm;
        }

        public void PersonComplete(PersonModel model)
        {
            DivisionTeamsModel dtm = (DivisionTeamsModel)playersTeamComboBox.SelectedItem;
            RosterModel rm = new RosterModel();
            rm.DivisionTeamsID = dtm.DivisionTeamsID;
            teamMembers.Add(model);
            rm.players = teamMembers;
            GlobalConfig.Connection.CreateRoster(rm);
            wireUpPlayersListBox();
        }

        private void wireUpPlayersListBox()
        {

            playersListBox.DataSource = null;
            playersListBox.DataSource = teamMembers;
            playersListBox.DisplayMember = "FullName";
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            dtm = (DivisionTeamsModel)(playersTeamComboBox.SelectedItem);
            if (dtm != null)
            {
                PersonModel pm = (PersonModel)playersComboBox.SelectedItem;
                if (pm != null)
                {
                    int Sid = seasonID;
                    int Did = sdm.DivisionID;
                    int SDid = sdm.SeasonDivisionsID;
                    int DTid = dtm.DivisionTeamsID;
                    int Tid = dtm.TeamID;                  
                    int Pid = pm.PersonID;
                    teamMembers.Clear();
                    teamMembers.Add(pm);
                    seasonPlayers.Add(pm);
                    RosterModel rm = new RosterModel();
                    rm.DivisionTeamsID = dtm.DivisionTeamsID;
                    rm.players = teamMembers;
                    GlobalConfig.Connection.CreateRoster(rm);
                    int Rid = rm.RosterID;
                    // creat ean entry in DB with SeasonID, DivisionteamsID and PlayerID
                    GlobalConfig.Connection.CreateSDTP(Sid, Did, SDid, DTid, Tid ,Rid, Pid);
                    dtm = (DivisionTeamsModel)playersTeamComboBox.SelectedItem;

                    teamMembers.Clear();
                    teamMembers = GlobalConfig.Connection.GetTeamMembers(dtm);
                    wireUpPlayersListBox();
                    wireUpPlayersComboBox();
                }
            }
        }

        private void playersTeamComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            dtm = (DivisionTeamsModel)playersTeamComboBox.SelectedItem;
            if (dtm != null)
            {
                teamMembers.Clear();
                teamMembers = GlobalConfig.Connection.GetTeamMembers(dtm);
                wireUpPlayersListBox();
                wireUpPlayersComboBox();
            }
        }

        private void removePlayerButtton_Click(object sender, EventArgs e)
        {

            PersonModel pm = (PersonModel)playersListBox.SelectedItem;
            if (pm != null)
            {
                int Sid = seasonID;
                int Pid = pm.PersonID;

                GlobalConfig.Connection.DeletePlayerFromRoster(Pid);
                GlobalConfig.Connection.DeleteSDTP(Sid, Pid);

                teamMembers = GlobalConfig.Connection.GetTeamMembers(dtm);
                wireUpPlayersListBox();
                wireUpPlayersComboBox();
            }
        }
    }

        }
    
