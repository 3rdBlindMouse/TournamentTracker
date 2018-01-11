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
        private List<PersonModel> lastPerson;
        private PersonModel captain = new PersonModel();

        private TeamModel tm;
        private static VenueModel vm = new VenueModel();


        public EditTeamForm()
        {
            InitializeComponent();
            //createSampleData();           
           WireupLists();
            // teamComboxBox wires up seperately to avoid clearing data from memory
            wireUpTeamComboBox();
        }

        private void AddSelectTitle()
        {
            int indexV = venues.FindIndex(item => item.VenueID == -1);
            int indexP = availablePlayers.FindIndex(item => item.PersonID == -1);
            int indexT = teams.FindIndex(item => item.TeamID == -1);
            if (indexV >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                VenueModel v = new VenueModel(" Select Venue ", -1);
                venues.Insert(0, v);
            }

            if (indexP >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                PersonModel p = new PersonModel(" Select Player ", -1);
                availablePlayers.Insert(0, p);
            }
            if (indexT >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                TeamModel t = new TeamModel(" Select Team ", -1);
                teams.Insert(0, t);
            }
        }

            private void createSampleData()
        {
            availablePlayers.Add(new PersonModel { FirstName = "Phill", LastName = "Sutherland" });
            availablePlayers.Add(new PersonModel { FirstName = "Bill", LastName = "Bird" });
            selectedPlayers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

        }

        private void WireupLists()
        {
            AddSelectTitle();

            addPlayerDropdown.DataSource = null;
            addPlayerDropdown.DataSource = availablePlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            addPlayerDropdown.DisplayMember = "FullName";

            teamMemberListBox.DataSource = null;

            teamMemberListBox.DataSource = selectedPlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            teamMemberListBox.DisplayMember = "FullName";

            teamCaptainDropdown.DataSource = null;
            teamCaptainDropdown.DataSource = selectedPlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            teamCaptainDropdown.DisplayMember = "FullName";

            venueDropDown.DataSource = null;
            venueDropDown.DataSource = venues.OrderBy(p => p.VenueName).ToList();
            venueDropDown.DisplayMember = "VenueName";          
        }


        private void wireUpTeamComboBox()
        {
            teamDropDown.DataSource = null;
            teamDropDown.DataSource = teams.OrderBy(p => p.TeamName).ToList();
            teamDropDown.DisplayMember = "TeamName";
        }

        /// <summary>
        /// Hies Team Creator form and 
        /// Opens a new form sepcific to createNewPerson link from TeamForm
        /// When create Player button is pushed on new (child) form it closes and
        /// TeamForm is made visible again 
        /// 
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
            addLastPerson();
            this.Show();
        }

        private void addLastPerson()
        {
            lastPerson = GlobalConfig.Connection.GetLastPerson();
            foreach (PersonModel p in lastPerson)
            {
                selectedPlayers.Add(p);
                WireupLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                TeamModel model = new TeamModel();
                model.TeamName = teamNameTextbox.Text;
                PersonModel p = new PersonModel();
                model.Captain = getCaptain();
                // TODO - sort or remove

                VenueModel venue = (VenueModel)venueDropDown.SelectedItem;
                model.Venue = venue;
                createTeamAndRoster(model);

                // this.Close();
                MessageBox.Show("Team Successfully Edited");
                    clearForm();
                
            }
        }


        private void clearForm()
        {

            teamNameTextbox.Text = "";
            DisplayTeamName.Text = "";
            DisplayTeamVenue.Text = "";
            if (teamMemberListBox.Items.Count > 0)
            {
                teamMemberListBox.DataSource = null;
                teamMemberListBox.Items.Clear();
            }

            availablePlayers = GlobalConfig.Connection.GetAllPeople();
            selectedPlayers = new List<PersonModel>();
            WireupLists();
        }

        /// <summary>
        /// Enters data into Roster table and creates Roster Model(s).
        /// Roster shows which players play for which teams
        /// </summary>
        /// <param name="model">A TeamModel</param>
        private void createTeamAndRoster(TeamModel model)
        {
            RosterModel roster = new RosterModel();
            roster.TeamID = model.TeamID;
            roster.players = selectedPlayers;
            GlobalConfig.Connection.CreateTeam(model);

           

            roster.TeamID = model.TeamID;
            roster.players = selectedPlayers;
            GlobalConfig.Connection.CreateRoster(roster);
        }

        private bool validateForm()
        {
            Validator validator = new Validator();
            bool output = true;
            if (!validator.isValidName(teamNameTextbox.Text))
            {
                output = false;
            }
            else
            {
                teamNameTextbox.BackColor = Color.LightGreen;
                output = true;
            }
            return output;

        }

        /// <summary>
        /// Take player from available players list and place them into team member list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)addPlayerDropdown.SelectedItem;
            if (p != null)
            {
                availablePlayers.Remove(p);
                selectedPlayers.Add(p);

                WireupLists();
            }


        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;

            if (p != null)
            {
                selectedPlayers.Remove(p);
                availablePlayers.Add(p);

                WireupLists();
            }
        }

        private void captainSelectButton_Click(object sender, EventArgs e)
        {
            PersonModel p = getCaptain();
            DisplayCaptain.Text = p.FullName;
        }

        private PersonModel getCaptain()
        {
            PersonModel p = new PersonModel();
            if (teamCaptainDropdown.SelectedItem != null)
            {
                p = (PersonModel)teamCaptainDropdown.SelectedItem;
                return p;
            }
            else
            {
                return p;
            }
        }

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

        private void teamNameTextbox_Enter(object sender, EventArgs e)
        {
            teamNameTextbox.Text = "";
            teamNameTextbox.BackColor = SystemColors.Info;
        }

        private void venueDropDown_Enter(object sender, EventArgs e)
        {
            venueDropDown.BackColor = SystemColors.Info;
        }

        public void VenueComplete(VenueModel model)
        {
            venues.Add(model);
            DisplayTeamVenue.Text = model.VenueName;
            WireupLists();
        }

        public void PersonComplete(PersonModel model)
        {
            selectedPlayers.Add(model);
            WireupLists();
        }

        private void venueDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (venueDropDown.SelectedItem != null)
            {
                // Get/Create Division Model that has been selected
                vm = (VenueModel)venueDropDown.SelectedItem;
                if (vm.VenueName != " Select Venue ")
                {
                    DisplayTeamVenue.Text = vm.VenueName;
                }
                else
                {
                    DisplayTeamVenue.Text = "";
                }
            }
        }

        private void teamDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            tm = new TeamModel();
            tm = (TeamModel)teamDropDown.SelectedValue;
            
            DisplayTeamName.Text = tm.TeamName;

            teamMemberListBox.DataSource = null;
            teamMemberListBox.DataSource = GlobalConfig.Connection.GetTeamMembers(tm);
            teamMemberListBox.DisplayMember = "FullName";



            if (tm.TeamID != -1)
            {
                int venueID = tm.TeamVenue;

                //TODO learn what i have done here study more linq
                DisplayTeamVenue.Text = venues.Find(v => v.VenueID == venueID).VenueName;

                venueDropDown.SelectedItem = venues.Find(v => v.VenueID == venueID);


                selectedPlayers = GlobalConfig.Connection.GetTeamMembers(tm);
                //WireupLists();
            }


            
        }
    }
}
