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
        private CaptainModel captain = new CaptainModel();

        private TeamModel tm;
        private static VenueModel vm = new VenueModel();

        private static List<CaptainModel> captains = new List<CaptainModel>();
        

        // These two lists are to aid in EditRoster storedProcedure by 
        //storing the People to either Add or remove to Roster
        private static List<PersonModel> addedPeople = new List<PersonModel>();
        private static List<PersonModel> removedPeople = new List<PersonModel>();


        public EditTeamForm()
        {
            InitializeComponent();
            //createSampleData();           
           
            // teamComboxBox wires up seperately to avoid clearing data from memory
            wireUpTeamComboBox();

            WireupVenueDropDown();
        }

        

            private void createSampleData()
        {
            availablePlayers.Add(new PersonModel { FirstName = "Phill", LastName = "Sutherland" });
            availablePlayers.Add(new PersonModel { FirstName = "Bill", LastName = "Bird" });
            selectedPlayers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

        }

        


        private void wireUpTeamComboBox()
        {
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

        private void WireUpPlayerDropDown()
        {
            availablePlayers = GlobalConfig.Connection.GetAllPeople();
            int indexp = availablePlayers.FindIndex(item => item.PersonID == -1);

            if (indexp >= 0)
            {
                // element exists, do what you need
            }
            else
            {
                PersonModel p = new PersonModel(" Select Player ", -1);
                availablePlayers.Insert(0, p);
            }
            
            //https://stackoverflow.com/questions/19175257/remove-items-from-list-that-intersect-on-property-using-linq
            availablePlayers.RemoveAll(x => selectedPlayers.Any(y => y.PersonID == x.PersonID));

            addPlayerDropdown.DataSource = null;
            addPlayerDropdown.DataSource = availablePlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            addPlayerDropdown.DisplayMember = "FullName";
        }


        private void WireupVenueDropDown()
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
        private void WireupMembersAndCaptain()
        {
            teamMemberListBox.DataSource = null;

            teamMemberListBox.DataSource = selectedPlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            teamMemberListBox.DisplayMember = "FullName";

            teamCaptainDropdown.DataSource = null;
            teamCaptainDropdown.DataSource = selectedPlayers.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList(); ;
            teamCaptainDropdown.DisplayMember = "FullName";
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
                WireUpPlayerDropDown();
                WireupMembersAndCaptain();
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
            WireUpPlayerDropDown();
            WireupMembersAndCaptain();
        }

        /// <summary>
        /// Enters data into Roster table and creates Roster Model(s).
        /// Roster shows which players play for which teams
        /// </summary>
        /// <param name="model">A TeamModel</param>
        private void EditTeam(TeamModel model)
        {
            RosterModel roster = new RosterModel();
            roster.TeamID = model.TeamID;
            roster.players = selectedPlayers;
            GlobalConfig.Connection.EditTeam(model);

           

            roster.TeamID = model.TeamID;
            roster.players = selectedPlayers;
            GlobalConfig.Connection.EditRoster(roster, addedPeople, removedPeople);

            if(selectedPlayers.Count == 0)
            {
                GlobalConfig.Connection.EditCaptainRemove(model);
            }
            else
            {
                GlobalConfig.Connection.EditCaptain(model);
            }
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
                if(p != removedPeople.Find(x => x.PersonID == p.PersonID))
                    {
                    addedPeople.Add(p);
                }
                else
                {
                    removedPeople.Remove(p);
                }

                WireUpPlayerDropDown();
                WireupMembersAndCaptain();
            }


        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;

            if (p != null)
            {
                selectedPlayers.Remove(p);
                availablePlayers.Add(p);


                if (p != addedPeople.Find(x => x.PersonID == p.PersonID))
                {
                    removedPeople.Add(p);
                }
                else
                {
                    addedPeople.Remove(p);
                }

                WireUpPlayerDropDown();
                WireupMembersAndCaptain();
            }
        }

        private void captainSelectButton_Click(object sender, EventArgs e)
        {
            CaptainModel c = getCaptain();
            DisplayCaptain.Text = c.Name;
        }

        private CaptainModel getCaptain()
        {
            
            PersonModel p = new PersonModel();
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
            WireupVenueDropDown();
        }

        public void PersonComplete(PersonModel model)
        {
            selectedPlayers.Add(model);
            WireupMembersAndCaptain();
            WireUpPlayerDropDown();
        }

        private void venueDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (venueDropDown.SelectedItem != null)
            //{
            //    // Get/Create Division Model that has been selected
            //    vm = (VenueModel)venueDropDown.SelectedItem;
            //    if (vm.VenueName != " Select Venue ")
            //    {
            //        DisplayTeamVenue.Text = vm.VenueName;
            //    }
            //    else
            //    {
            //        DisplayTeamVenue.Text = "";
            //    }
            //}
        }

        private void teamDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
   
            tm = (TeamModel)teamDropDown.SelectedValue;
            

            

            



            if (tm.TeamID != -1)
            {
                teamNameTextbox.Text = tm.TeamName;
                DisplayTeamName.Text = tm.TeamName;
                selectedPlayers = GlobalConfig.Connection.GetTeamMembers(tm);
                // Find captain and display details
                DoCaptainStuff(tm);
                // Display cyrrent teams Venue in Display and as VenueBox selectedItem
                DoVenueStuff(tm);

                // Populate Teams Members ListBox
                DoTeamMemberStuff(tm);

                

                addedPeople.Clear();
                removedPeople.Clear();

                WireupMembersAndCaptain();
                WireUpPlayerDropDown();
            }


            
        }

        private void DoTeamMemberStuff(TeamModel tm)
        {
            teamMemberListBox.DataSource = null;
            teamMemberListBox.DataSource = GlobalConfig.Connection.GetTeamMembers(tm);
            teamMemberListBox.DisplayMember = "FullName";
        }

        private void DoVenueStuff(TeamModel tm)
        {
            int venueID = tm.TeamVenue;
            //TODO learn what i have done here study more linq
            DisplayTeamVenue.Text = venues.Find(v => v.VenueID == venueID).VenueName;            
            venueDropDown.SelectedItem = venues.Find(v => v.VenueID == venueID);
        }

        private void DoCaptainStuff(TeamModel tm)
        {
            captains = GlobalConfig.Connection.GetTeamCaptains(tm);
            captain = captains.Find(c => c.TeamID == tm.TeamID);

            if ((captain != null))
            {
                DisplayCaptain.Text = selectedPlayers.Find(p => p.PersonID == captain.PersonID).FullName;
            }
            else
            {
                DisplayCaptain.Text = "No Captain";
            }
        }

        private void EditTeamButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                
                tm.TeamName = teamNameTextbox.Text;
                PersonModel p = new PersonModel();
                
                tm.TeamCaptain = captain.PersonID;
                

                VenueModel venue = (VenueModel)venueDropDown.SelectedItem;
                tm.Venue = venue;
                EditTeam(tm);

                // this.Close();
                MessageBox.Show("Team Successfully Edited");
                clearForm();

            }
        }
    }
}
