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


        private static List<ComboBox> t1boxes = new List<ComboBox>();
        private static List<ComboBox> t2boxes = new List<ComboBox>();






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

            if(thisGame.HomeTeamModel.TeamID != 0)
            {

            }


            //DateTime date = thisGame.GameDate;


            sdtp = GlobalConfig.Connection.GetSdtpModel(sdtpID);
            DivisionTeamsModel dtmAway = GlobalConfig.Connection.GetDivisionTeamModel(sdtp.SeasonDivisionsID, thisGame.AwayTeamModel.TeamID);
            DivisionTeamsModel dtmHome = GlobalConfig.Connection.GetDivisionTeamModel(sdtp.SeasonDivisionsID, thisGame.HomeTeamModel.TeamID);

            thisGame.HomeTeamPlayers = GlobalConfig.Connection.GetTeamMembers(dtmHome);
            thisGame.AwayTeamPlayers = GlobalConfig.Connection.GetTeamMembers(dtmAway);

            t1Available = thisGame.HomeTeamPlayers;
            t2Available = thisGame.AwayTeamPlayers;

            WireupTeamComboBoxes(thisGame);

        }

        private void WireupTeamComboBoxes(GameModel gm)
        {
            HomeTeamNameLabel.Text = gm.HomeTeamModel.TeamName;
            AwayTeamNamelabel.Text = gm.AwayTeamModel.TeamName;

            t1boxes = new List<ComboBox>();
            t2boxes = new List<ComboBox>();


            t1boxes.Add(T1P1ComboBox);
            t1boxes.Add(T1P2ComboBox);
            t1boxes.Add(T1P3ComboBox);
            t1boxes.Add(T1P4ComboBox);
            t1boxes.Add(T1P5ComboBox);
            t1boxes.Add(T1P6ComboBox);
            t1boxes.Add(T1P7ComboBox);
            t1boxes.Add(T1P8ComboBox);

            t2boxes.Add(T2P1ComboBox);
            t2boxes.Add(T2P2ComboBox);
            t2boxes.Add(T2P3ComboBox);
            t2boxes.Add(T2P4ComboBox);
            t2boxes.Add(T2P5ComboBox);
            t2boxes.Add(T2P6ComboBox);
            t2boxes.Add(T2P7ComboBox);
            t2boxes.Add(T2P8ComboBox);


            foreach (ComboBox cb in t1boxes)
            {
                // https://stackoverflow.com/questions/4344366/multiple-combo-boxes-with-the-same-data-source-c
                // stops all comboxboxes changing to selected value of one combobox
                cb.BindingContext = new BindingContext();
                cb.DataSource = null;
                cb.DataSource = t1Available;
                cb.DisplayMember = "FullName";
            }

            foreach (ComboBox cb in t2boxes)
            {
                // https://stackoverflow.com/questions/4344366/multiple-combo-boxes-with-the-same-data-source-c
                // stops all comboxboxes changing to selected value of one combobox
                cb.BindingContext = new BindingContext();
                cb.DataSource = null;
                cb.DataSource = t2Available;
                cb.DisplayMember = "FullName";
            }


        }

        private void T1ConfirmteamButton_Click(object sender, EventArgs e)
        {
            bool playersGood = true;
            t1Selected = new List<PersonModel>();
            foreach(ComboBox cb in t1boxes)
            {
                if (t1Selected.Contains((PersonModel)(cb.SelectedValue)))
                {
                    MessageBox.Show("A Player is Selected More Than Once");
                    playersGood = false;
                    break;
                }
                else
                {
                    t1Selected.Add((PersonModel)(cb.SelectedValue));
                }
                
            }
            if(playersGood)
            {
                //TODO find a better way to do this
                thisGame.HomeTeamPlayer1 = t1Selected[0];
                thisGame.HomeTeamPlayer2 = t1Selected[1];
                thisGame.HomeTeamPlayer3 = t1Selected[2];
                thisGame.HomeTeamPlayer4 = t1Selected[3];
                thisGame.HomeTeamPlayer5 = t1Selected[4];
                thisGame.HomeTeamPlayer6 = t1Selected[5];
                thisGame.HomeTeamPlayer7 = t1Selected[6];
                thisGame.HomeTeamPlayer8 = t1Selected[7];

                GlobalConfig.Connection.AddPlayers(thisGame);
               }
            
        }

        private void T2ConfirmteamButton_Click(object sender, EventArgs e)
        {

        }
    }
}
