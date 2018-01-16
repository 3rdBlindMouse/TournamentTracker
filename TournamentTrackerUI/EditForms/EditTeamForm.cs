using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI.EditForms
{
    public partial class EditTeamForm : Form, IVenueRequester, IPersonRequester
    {
        private List<PersonModel> availablePlayers = GlobalConfig.Connection.GetAllPeople();
        private List<PersonModel> selectedPlayers = new List<PersonModel>();
        private List<VenueModel> venues = GlobalConfig.Connection.GetAllVenues();
        private List<TeamModel> teams = GlobalConfig.Connection.GetAllTeams();

        private static List<string> teamNames = new List<string>();
        private static string originalTeamName;
        private CaptainModel captain;
        private static TeamModel tm;
        //private static VenueModel vm;
        private static List<CaptainModel> captains;
        // These two lists are to aid in EditRoster storedProcedure by 
        //storing the People to either Add or remove to Roster
        private static List<PersonModel> addedPeople = new List<PersonModel>();
        private static List<PersonModel> removedPeople = new List<PersonModel>();


        public EditTeamForm()
        {
            InitializeComponent();
            //createSampleData();                     
            // Wireup Team Combobox with Division Teams
            wireUpTeamComboBox();
            // Wireup Venue Combobox with Venues
            WireUpVenueDropDown();
        }
        /// <summary>
        /// Wires up Team combobox with available Teams 
        /// At the moment is all teams 
        /// Adds a " Select Team " to combobox
        /// </summary>
        private void wireUpTeamComboBox()
        {
            // Is " Select Team " already in combobox?
            int index = teams.FindIndex(item => item.TeamID == -1);

            if (index >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                TeamModel t = new TeamModel(" Select Team ", -1);
                teams.Insert(0, t);
            }
            teamDropDown.DataSource = null;
            teamDropDown.DataSource = teams.OrderBy(p => p.TeamName).ToList();
            teamDropDown.DisplayMember = "TeamName";
        }
        /// <summary>
        /// Wires up Players combobox with available Players
        /// At the moment is all Persons less those in selected team
        /// Adds a " Select Player " to combobox
        /// </summary>
        private void WireUpPlayerDropDown()
        {
            availablePlayers = GlobalConfig.Connection.GetAllPeople();
            int index = availablePlayers.FindIndex(item => item.PersonID == -1);

            if (index >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                PersonModel p = new PersonModel(" Select Player ", -1);
                availablePlayers.Insert(0, p);
            }
            // Remove players in team from list of availble players
            //https://stackoverflow.com/questions/19175257/remove-items-from-list-that-intersect-on-property-using-linq
            availablePlayers.RemoveAll(x => selectedPlayers.Any(y => y.PersonID == x.PersonID));

            addPlayerDropdown.DataSource = null;
            addPlayerDropdown.DataSource = availablePlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            addPlayerDropdown.DisplayMember = "FullName";
        }
        /// <summary>
        /// Wires up Venue combobox with available Venues
        /// At the moment is all Venues
        /// Adds a " Select Venue " to combobox
        /// </summary>
        private void WireUpVenueDropDown()
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
            venueDropDown.DataSource = null;
            venueDropDown.DataSource = venues.OrderBy(p => p.VenueName).ToList();
            venueDropDown.DisplayMember = "VenueName";


        }
        /// <summary>
        /// Wires up Team Members List Box
        /// </summary>
        private void WireUpTeamMembers()
        {
            int index = selectedPlayers.FindIndex(item => item.PersonID == -1);

            if (index >= 0)
            {
                selectedPlayers.RemoveAt(index);
            }

            teamMemberListBox.DataSource = null;
            teamMemberListBox.DataSource = selectedPlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            teamMemberListBox.DisplayMember = "FullName";
        }
        /// <summary>
        /// Wires up Team Captain dropdown with list of team members
        /// </summary>
        private void WireUpCaptainDropDown()
        {
            int indexp = selectedPlayers.FindIndex(item => item.PersonID == -1);

            if (indexp >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                PersonModel p = new PersonModel(" Select Captain ", -1);
                selectedPlayers.Insert(0, p);
            }

            teamCaptainDropdown.DataSource = null;
            teamCaptainDropdown.DataSource = selectedPlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            teamCaptainDropdown.DisplayMember = "FullName";
        }
        /// <summary>
        /// Hides Team Editor form and 
        /// Opens a new form specific to createNewPerson link from TeamForm
        /// When create Player button is pushed on new (child) form it closes and
        /// TeamForm is made visible again 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewPlayerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreatePersonForm personForm = new CreatePersonForm(this);
            personForm.Show();
            this.Hide();
            personForm.FormClosing += personForm_FormClosing;
        }
        /// <summary>
        /// when child form (createTeamPlayerForm) closes
        /// parent form (EditTeamForm) is made visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void personForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        /// <summary>
        /// Clears Form Data
        /// </summary>
        private void clearForm()
        {
            teamNameTextbox.Text = "";
            DisplayTeamName.Text = "";
            DisplayTeamVenue.Text = "";
            DisplayCaptain.Text = "";
            if (teamMemberListBox.Items.Count > 0)
            {
                teamMemberListBox.DataSource = null;
                teamMemberListBox.Items.Clear();
            }

            availablePlayers = GlobalConfig.Connection.GetAllPeople();
            selectedPlayers = new List<PersonModel>();

            wireUpTeamComboBox();
            WireUpPlayerDropDown();
            WireUpTeamMembers();
            WireUpCaptainDropDown();
            WireUpVenueDropDown();
        }
        /// <summary>
        /// Performs Edits on DB depending on changes made to team in edit form
        /// DB tables altered at team, roster, and teamcaptains
        /// </summary>
        /// <param name="model">A TeamModel</param>
        private void EditTeam(TeamModel model)
        {
            RosterModel roster = new RosterModel();
            roster.TeamID = model.TeamID;
            roster.players = selectedPlayers;
            GlobalConfig.Connection.EditTeam(model);
            GlobalConfig.Connection.EditRoster(roster, addedPeople, removedPeople);
            // If no team members remove team captain data from DB
            // count of 1 is "No Captain" string
            if (selectedPlayers.Count == 1)
            {
                GlobalConfig.Connection.EditCaptainRemove(model);
            }
            else
            {
                GlobalConfig.Connection.EditCaptain(model);
            }
        }
        /// <summary>
        /// Validates the form before allowing edit actions to be written
        /// On this form only validates wether team name is a string
        /// </summary>
        /// <returns>True is form is valid, else returns false</returns>
        //TODO add validation to see if team name already exists
        private bool validateForm()
        {
            Validator validator = new Validator();
            bool output = true;
            if (!validateTeamName(teamNameTextbox))
            {
                output = false;
            }
            else
            {
                teamNameTextbox.BackColor = Color.LightGreen;
                output = true;
            }
            //if (captain == null)
            //{
            //    MessageBox.Show("Please Select A Captain");
            //    output = false;
            //}
            //if ((vm.VenueID == -1) || (vm == null))
            //{
            //    MessageBox.Show("Please Select A Venue");
            //}


            return output;
        }
        /// <summary>
        /// Take player from available players list and place them into team member list
        /// IF player ONLY been added vs removed then added player added to new list to aid DB updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)addPlayerDropdown.SelectedItem;
            // If selection is a Person vs nothing or menu select option
            if ((p != null) && (p.PersonID != -1))
            {
                availablePlayers.Remove(p);
                selectedPlayers.Add(p);
                // adds new team members to a new list to aid DB updating
                if (p != removedPeople.Find(x => x.PersonID == p.PersonID))
                {
                    addedPeople.Add(p);
                }
                else
                // adds removed team members to a new list to aid in DB updating
                {
                    removedPeople.Remove(p);
                }
                WireUpPlayerDropDown();
                WireUpTeamMembers();
                WireUpCaptainDropDown();
            }
        }
        /// <summary>
        /// Take player from team member list and place them into available players list
        /// IF player ONLY been removed vs added then removed player added to new list to aid DB updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;
            // If a player has been selected
            if (p != null)
            {
                selectedPlayers.Remove(p);
                if (selectedPlayers.Count == 1)
                {
                    DisplayCaptain.Text = "No Captain";
                    //GlobalConfig.Connection.EditCaptainRemove(tm);
                }
                availablePlayers.Add(p);

                // If player was team member on form creation but has now been removed
                if (p != addedPeople.Find(x => x.PersonID == p.PersonID))
                {
                    removedPeople.Add(p);
                }
                else
                {
                    addedPeople.Remove(p);
                }

                WireUpPlayerDropDown();
                WireUpTeamMembers();
                WireUpCaptainDropDown();
            }
        }
        /// <summary>
        /// Check player has been selected as a captain
        /// Update Display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void captainSelectButton_Click(object sender, EventArgs e)
        {
            // If a player Has beeen selected
            if (teamCaptainDropdown.SelectedIndex != 0)
            {
                CaptainModel c = getCaptain();
                DisplayCaptain.Text = c.Name;
            }
        }
        /// <summary>
        /// Creates a new Captain model from selected team member
        /// </summary>
        /// <returns>A Captain Model</returns>
        private CaptainModel getCaptain()
        {
            PersonModel p = new PersonModel();
            // potentially redunsant check here with check in captainSelectButton_Click
            if (teamCaptainDropdown.SelectedItem != null)
            {
                captain = new CaptainModel();
                p = (PersonModel)teamCaptainDropdown.SelectedItem;
                captain.PersonID = p.PersonID;
                captain.Name = p.FullName;
                return captain;
            }
            else
            {
                return captain;
            }
        }
        /// <summary>
        /// Perform validation on Team Name
        /// Notify User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //TODO Update validation to include duplicate names etc
        private void teamNameTextbox_Leave(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            if (!validator.isValidString(teamNameTextbox.Text))
            {
                teamNameTextbox.BackColor = Color.Crimson;
                teamNameTextbox.Text = "Enter a Valid Name";
            }
            else
            {
                teamNameTextbox.BackColor = Color.LightGreen;
                DisplayTeamName.Text = teamNameTextbox.Text;
            }
        }
        /// <summary>
        /// Change backcolor of teamNameTextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // TODO modify
        private void teamNameTextbox_Enter(object sender, EventArgs e)
        {
            //teamNameTextbox.Text = "";
            teamNameTextbox.BackColor = SystemColors.Info;
        }
        /// <summary>
        /// Change backcolor of venueDropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // TODO Modify
        private void venueDropDown_Enter(object sender, EventArgs e)
        {
            venueDropDown.BackColor = SystemColors.Info;
        }
        /// <summary>
        /// Actions after a new VenueModel is created
        /// </summary>
        /// <param name="model"></param>
        public void VenueComplete(VenueModel model)
        {
            venues.Add(model);
            DisplayTeamVenue.Text = model.VenueName;
            WireUpVenueDropDown();
        }
        /// <summary>
        /// Actions after a new PersonModel is created
        /// </summary>
        /// <param name="model"></param>
        public void PersonComplete(PersonModel model)
        {
            // Add player to list of team members
            selectedPlayers.Add(model);
            // Add player to newly added player List
            addedPeople.Add(model);
            WireUpTeamMembers();
            WireUpCaptainDropDown();
            WireUpPlayerDropDown();
        }
        /// <summary>
        /// The Initiator of most actions taken on this form
        /// User selects a team from dropdown lists, dropsdowns, listboxes etc are populated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (teamDropDown.SelectedValue != null)
            {
                teamNames.Clear();
                tm = (TeamModel)teamDropDown.SelectedValue;
                if (tm.TeamID != -1)
                {

                    
                    selectedPlayers = GlobalConfig.Connection.GetTeamMembers(tm);
                    originalTeamName = tm.TeamName;
                    getTeamNames();
                    teamNameTextbox.Text = tm.TeamName;
                    DisplayTeamName.Text = tm.TeamName;
                    // Find captain and display details
                    DoCaptainStuff(tm);
                    // Display cyrrent teams Venue in Display and as VenueBox selectedItem
                    DoVenueStuff(tm);
                    // Populate Teams Members ListBox
                    DoTeamMemberStuff(tm);
                    // Do form and list stuff
                    
                    addedPeople.Clear();
                    removedPeople.Clear();
                    WireUpPlayerDropDown();
                    WireUpTeamMembers();
                    WireUpCaptainDropDown();
                   
                }
            }
        }

        private void getTeamNames()
        {
            foreach (TeamModel team in teams)
            {
                if (team.TeamID != -1)
                {
                    teamNames.Add(team.TeamName);
                }
            }
            teamNames.Remove(originalTeamName);
        }

        /// <summary>
        /// Populate teamMemberListBox
        /// </summary>
        /// <param name="tm"></param>
        private void DoTeamMemberStuff(TeamModel tm)
        {
            teamMemberListBox.DataSource = null;
            teamMemberListBox.DataSource = GlobalConfig.Connection.GetTeamMembers(tm);
            teamMemberListBox.DisplayMember = "FullName";
        }
        /// <summary>
        /// Populate VenueDropDown and Display Selected Team Venue
        /// </summary>
        /// <param name="tm"></param>
        private void DoVenueStuff(TeamModel tm)
        {
            int venueID = tm.TeamVenue;
            //TODO learn what i have done here study more linq
            DisplayTeamVenue.Text = venues.Find(v => v.VenueID == venueID).VenueName;
            venueDropDown.SelectedItem = venues.Find(v => v.VenueID == venueID);
        }
        /// <summary>
        /// Identify captain and Display 
        /// </summary>
        /// <param name="tm"></param>
        private void DoCaptainStuff(TeamModel tm)
        {
            captains = GlobalConfig.Connection.GetTeamCaptains(tm);
            captain = captains.Find(c => c.TeamID == tm.TeamID);
            if ((captain != null) && (captain.CaptianID !=0))
            {
                DisplayCaptain.Text = selectedPlayers.Find(p => p.PersonID == captain.PersonID).FullName;
            }
            else
            {
                DisplayCaptain.Text = "No Captain";
            }
        }
        /// <summary>
        /// Update Database with Edited Team Information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditTeamButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                tm.TeamName = teamNameTextbox.Text;
                PersonModel p = new PersonModel();
                if(captain != null)
                { tm.TeamCaptain = captain.PersonID;
                    }
                VenueModel venue = (VenueModel)venueDropDown.SelectedItem;
                tm.Venue = venue;
                EditTeam(tm);
                MessageBox.Show("Team Successfully Edited");
                clearForm();
            }
        }

        private void teamNameTextbox_TextChanged(object sender, EventArgs e)
        {
            validateTeamName(teamNameTextbox);
        }

        private bool validateTeamName(TextBox tb)
        {

            bool nameValid = true;
            DisplayTeamName.BackColor = Color.LightGreen;
            Validator validator = new Validator();
            if (tb.Text == "")
            {
                DisplayTeamName.Text = "Please Enter a Name";
                DisplayTeamName.BackColor = Color.Crimson;
                nameValid = false;
                return nameValid;
            }
            else
            {
                DisplayTeamName.BackColor = Color.LightGreen;
                DisplayTeamName.Text = tb.Text;

                if (!validator.noNumbers(tb.Text))
                {
                    DisplayTeamName.Text = "No Numbers Allowed";
                    DisplayTeamName.BackColor = Color.Crimson;
                    nameValid = false; ;
                }
                else if (!validator.noSpaces(tb.Text))
                {
                    DisplayTeamName.Text = "No Leading or Ending Spaces Allowed";
                    DisplayTeamName.BackColor = Color.Crimson;
                    nameValid = false;
                }
                else
                {
                    if (teamNames.Contains(tb.Text))
                    {
                        DisplayTeamName.Text = "Name Already Exists";
                        DisplayTeamName.BackColor = Color.Crimson;
                        nameValid = false;
                    }
                }

                return nameValid;
            }

        }
    }
}
