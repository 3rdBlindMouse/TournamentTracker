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
        private SeasonModel season = GlobalConfig.Connection.GetLastSeason();
        //variable to hold this seasons seasonID

        private static DivisionModel dm = new DivisionModel();
        private static TeamModel TeamModel = new TeamModel();

        List<DivisionModel> divs = new List<DivisionModel>();

        private static SeasonDivisionsModel sdm = new SeasonDivisionsModel();
       // private List<DivisionModel> selectedDivisions = new List<DivisionModel>();
        private static DivisionTeamsModel dtm = new DivisionTeamsModel();

        //private List<TeamModel> selectedTeams = new List<TeamModel>();
        private static List<PersonModel> allPlayers = GlobalConfig.Connection.GetAllPeople();
        private static List<PersonModel> seasonPlayers = new List<PersonModel>();

        private static List<PersonModel> teamMembers = new List<PersonModel>();

        /// <summary>
        /// Season Division Team Player Model, will hold the IDs to make DB searching a bit easier.
        /// Will populate as user progesses through form.
        /// </summary>
        private static sdtpModel sdtp = new sdtpModel();
        private static int seasonID;

        public CreateSeasonForm()
        {
            InitializeComponent();            
            InitializeLabels();
            seasonID = season.SeasonID;
            sdtp.SeasonID = seasonID;

            WireUpDivisionComboBox();
            wireUpDivisionListBox();
            wireUpTeamsDivisionComboBox();


            wireUpPlayersTeamComboBox();

            wireUpPlayersComboBox();
        }
  
        /// <summary>
        /// Show Details of Current Season at top of form
        /// </summary>
        private void InitializeLabels()
        {
            displayNameLabel.Text = season.SeasonName;
            displayYearLabel.Text = season.SeasonYear.ToString();
            displayDescriptionLabel.Text = season.SeasonDescription;
        }
        /// <summary>
        /// Wires up the division combo box with divisions in this season
        /// Takes a list of divisions, if division has not beeen selected in this season adds to 
        /// combobox
        /// </summary>
        private void WireUpDivisionComboBox()
        {
            divisionsComboBox.DataSource = null;
            divisionsComboBox.DataSource = GlobalConfig.Connection.GetAllDivisions();
            // Each season can have any division from any other season
            //divisionsComboBox.DataSource = GlobalConfig.Connection.GetDivsNotInThisSeason(seasonID);
            divisionsComboBox.DisplayMember = "DivisionName";
        }
        /// <summary>
        /// Opens a new Create Division form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewDivisionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateDivisionForm divisionForm = new CreateDivisionForm(this, season);
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
            //selectedDivisions.Add(model);
            sdtp.DivisionID = model.DivisionID;
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
            dm = (DivisionModel)(divisionsComboBox.SelectedItem);
            sdtp.DivisionID = dm.DivisionID;
            DivisionDatesForm ddf = new DivisionDatesForm(this, seasonID, dm);
            ddf.Show();
            this.Hide();
            ddf.FormClosing += closeForm;
        }

        private void removeDivisionButton_Click(object sender, EventArgs e)
        {
            dm = (DivisionModel)(divisionsListBox.SelectedItem);
            sdtp.DivisionID = 0;
            //selectedDivisions.Remove(DivModel);
            GlobalConfig.Connection.DeleteSeasonDivisions(seasonID, dm.DivisionID);
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
            //selectedDivisions.Add(DivModel);
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

                sdtp.DivisionID = sdm.DivisionID;
                sdtp.SeasonDivisionsID = sdm.SeasonDivisionsID;

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
            dm = (DivisionModel)(teamsDivisionComboBox.SelectedItem);
            if (dm != null)
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
            dtm.SeasonDivisionsID = sdtp.SeasonDivisionsID;
            dtm.DivisionID = ((DivisionModel)teamsDivisionComboBox.SelectedItem).DivisionID;
            dtm.TeamID = model.TeamID;
            sdtp.TeamID = model.TeamID;
            //selectedTeams.Add(model);
            GlobalConfig.Connection.CreateDivisionTeams(dtm);
            sdtp.DivisionTeamsID = dtm.DivisionTeamsID;
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
            dm = (DivisionModel)(teamsDivisionComboBox.SelectedItem);
            if (dm != null)
            {
                TeamModel tm = (TeamModel)teamsComboBox.SelectedItem;
                if (tm != null)
                {
                    //selectedTeams.Add(tm);
                    dtm = new DivisionTeamsModel();
                    dtm.SeasonDivisionsID = sdtp.SeasonDivisionsID;
                    dtm.DivisionID = dm.DivisionID;
                    dtm.TeamID = tm.TeamID;
                    GlobalConfig.Connection.CreateDivisionTeams(dtm);
                    sdtp.DivisionTeamsID = dtm.DivisionTeamsID;
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
                sdtp.DivisionTeamsID = 0;
                sdtp.TeamID = 0;
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
            return dm.DivisionName;
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
            sdtp.PersonID = model.PersonID;
            teamMembers.Add(model);
            rm.players = teamMembers;
            GlobalConfig.Connection.CreateRoster(rm);
            sdtp.RosterID = rm.RosterID;
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
                    teamMembers.Clear();
                    teamMembers.Add(pm);
                    seasonPlayers.Add(pm);
                    RosterModel rm = new RosterModel();
                    rm.DivisionTeamsID = dtm.DivisionTeamsID;
                    rm.players = teamMembers;
                    GlobalConfig.Connection.CreateRoster(rm);
                    
                   
                    


                    sdtp.PersonID = pm.PersonID;
                    sdtp.DivisionTeamsID = dtm.DivisionTeamsID;
                    sdtp.RosterID = rm.RosterID;
                    sdtp.TeamID = dtm.TeamID;
                    sdtp.DivisionID = dtm.DivisionID;
                    
                    //dtm = (DivisionTeamsModel)playersTeamComboBox.SelectedItem;

                    teamMembers.Clear();
                    teamMembers = GlobalConfig.Connection.GetTeamMembers(dtm);
                    

                    // creat ean entry in DB with SeasonID, DivisionteamsID and PlayerID
                    GlobalConfig.Connection.CreateSDTP(sdtp);
                    
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
                // not sure this is needed see below cascade etc
                // int Sid = seasonID;
                int Pid = pm.PersonID;

                GlobalConfig.Connection.DeletePlayerFromRoster(Pid);
                // not sure this is needed with cascade on delete
                //GlobalConfig.Connection.DeleteSDTP(Sid, Pid);


                teamMembers = GlobalConfig.Connection.GetTeamMembers(dtm);
                wireUpPlayersListBox();
                wireUpPlayersComboBox();
            }
        }
    }

        }
    
