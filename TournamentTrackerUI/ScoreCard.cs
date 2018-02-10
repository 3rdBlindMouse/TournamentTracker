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
    public partial class ScoreCard : Form
    {
        private static List<GameModel> games = new List<GameModel>();
        // A model to hold current game data based on stdpID and selected Date
        private static GameModel thisGame = new GameModel();
        // T1SelectedTeamMembers
        private static List<PersonModel> t1Selected = new List<PersonModel>();
        // T2SelectedTeamMembers
        private static List<PersonModel> t2Selected = new List<PersonModel>();
        // T1SelectedTeamMembers
        private static List<PersonModel> t1Available = new List<PersonModel>();
        // T2SelectedTeamMembers
        private static List<PersonModel> t2Available = new List<PersonModel>();


        private static List<TeamModel> allTeams = GlobalConfig.Connection.GetAllTeams();

        private static sdtpModel sdtp = new sdtpModel();

        private static int sdtpID;


        public ScoreCard(int loginID)
        {
            InitializeComponent();


            sdtpID = loginID;

            games = GlobalConfig.Connection.GetGameModels(sdtpID);

            

            WireUpDateComboBox(games);

            
        }

        private void CompleteGamesModel()
        {
            
        }

        private void WireUpDateComboBox(List<GameModel> gm)
        {
            
            // Using GameModel as the object that is used in this comboxbox
            // uses GameDate as display member
            // allows gamemodel to be passed for further use
            dateComboBox.DataSource = null;
            dateComboBox.DataSource = gm;
            dateComboBox.DisplayMember = "GameDate";
            
        }

        private void dateComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            thisGame = (GameModel)dateComboBox.SelectedValue;

            
            thisGame.HomeTeamModel = (TeamModel)allTeams.FirstOrDefault(x => x.TeamID == thisGame.HomeTeam);
            thisGame.AwayTeamModel = (TeamModel)allTeams.FirstOrDefault(x => x.TeamID == thisGame.AwayTeam);


            //DateTime date = thisGame.GameDate;


            sdtp = GlobalConfig.Connection.GetSdtpModel(sdtpID);
            DivisionTeamsModel dtmAway = GlobalConfig.Connection.GetDivisionTeamModel(sdtp.SeasonDivisionsID, thisGame.AwayTeamModel.TeamID);
            DivisionTeamsModel dtmHome = GlobalConfig.Connection.GetDivisionTeamModel(sdtp.SeasonDivisionsID, thisGame.HomeTeamModel.TeamID);

            thisGame.HomeTeamPlayers = GlobalConfig.Connection.GetTeamMembers(dtmHome);
            thisGame.AwayTeamPlayers = GlobalConfig.Connection.GetTeamMembers(dtmAway);

            WireupTeamComboBoxes(thisGame);

        }

        private void WireupTeamComboBoxes(GameModel gm)
        {
            HomeTeamNameLabel.Text = gm.HomeTeamModel.TeamName;
            AwayTeamNamelabel.Text = gm.AwayTeamModel.TeamName;
        }
    }
}
