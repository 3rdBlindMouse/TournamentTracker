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
    public partial class TeamCreatorForm : Form
    {
        private List<PersonModel> availablePlayers = GlobalConfig.Connection.GetAllPeople();
        private List<PersonModel> selectedPlayers = new List<PersonModel>();
        private PersonModel captain = new PersonModel();

        public TeamCreatorForm()
        {
            InitializeComponent();
            //createSampleData();
            WireupLists();
        }

        private void createSampleData()
        {
            availablePlayers.Add(new PersonModel { FirstName = "Phill", LastName = "Sutherland" });
            availablePlayers.Add(new PersonModel { FirstName = "Bill", LastName = "Bird" });
            selectedPlayers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

        }

      private void WireupLists()
        {
            
            addPlayerDropdown.DataSource = null;
            addPlayerDropdown.DataSource = availablePlayers;
            addPlayerDropdown.DisplayMember = "FullName";

            teamMemberListBox.DataSource = null;
            
            teamMemberListBox.DataSource = selectedPlayers;
            teamMemberListBox.DisplayMember = "FullName";

            teamCaptainDropdown.DataSource = null;
            teamCaptainDropdown.DataSource = selectedPlayers;
            teamCaptainDropdown.DisplayMember = "FullName";

        }

        private void CreateNewPlayerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamPersonCreatorForm personForm = new TeamPersonCreatorForm();
            
            personForm.Show();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {

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
            PersonModel p = (PersonModel)teamCaptainDropdown.SelectedItem;
            if( p!= null)
            {
                captain = p;
            }
        }
    }
}
