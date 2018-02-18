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
        // List of Both Teams Players used for 8 ball combobox
        private static List<PersonModel> allPlayers = new List<PersonModel>();
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
                //TODO work out whats missing here if anything
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
                    PersonModel p = new PersonModel();
                    p = (PersonModel)(cb.SelectedValue);
                    t1Selected.Add(p);
                    if (!allPlayers.Contains(p))
                    {
                        allPlayers.Add(p);
                    }
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
                GlobalConfig.Connection.AddHomePlayers(thisGame);
               }
            wireupEightBallComboBox();
        }

        private void T2ConfirmteamButton_Click(object sender, EventArgs e)
        {
            bool playersGood = true;
            t2Selected = new List<PersonModel>();
            foreach (ComboBox cb in t2boxes)
            {
                if (t2Selected.Contains((PersonModel)(cb.SelectedValue)))
                {
                    MessageBox.Show("A Player is Selected More Than Once");
                    playersGood = false;
                    break;
                }
                else
                {
                    PersonModel p = new PersonModel();
                    p = (PersonModel)(cb.SelectedValue);
                    t2Selected.Add(p);
                    if (!allPlayers.Contains(p))
                    {
                        allPlayers.Add(p);
                    }
                }
                
            }
            if (playersGood)
            {
                //TODO find a better way to do this
                thisGame.AwayTeamPlayer1 = t2Selected[0];
                thisGame.AwayTeamPlayer2 = t2Selected[1];
                thisGame.AwayTeamPlayer3 = t2Selected[2];
                thisGame.AwayTeamPlayer4 = t2Selected[3];
                thisGame.AwayTeamPlayer5 = t2Selected[4];
                thisGame.AwayTeamPlayer6 = t2Selected[5];
                thisGame.AwayTeamPlayer7 = t2Selected[6];
                thisGame.AwayTeamPlayer8 = t2Selected[7];

                GlobalConfig.Connection.AddAwayPlayers(thisGame);
            }
            wireupEightBallComboBox();
        }

        private void wireupEightBallComboBox()
        {
            EightBallsPlayerComboBox.DataSource = null;
            EightBallsPlayerComboBox.DataSource = allPlayers;
            EightBallsPlayerComboBox.DisplayMember = "FullName";
        }

        private void getOtherTeamsButton_Click(object sender, EventArgs e)
        {
            HomeTeamPlayersModel homeTeamPlayers = new HomeTeamPlayersModel();
            homeTeamPlayers = GlobalConfig.Connection.GetHomeTeamPlayers(thisGame);

            //TODO work out how to do this better so much room to make errors here
            thisGame.HomeTeamPlayer1 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer1));
            T1P1ComboBox.SelectedItem = thisGame.HomeTeamPlayer1;
            thisGame.HomeTeamPlayer2 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer2));
            T1P2ComboBox.SelectedItem = thisGame.HomeTeamPlayer2;
            thisGame.HomeTeamPlayer3 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer3));
            T1P3ComboBox.SelectedItem = thisGame.HomeTeamPlayer3;
            thisGame.HomeTeamPlayer4 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer4));
            T1P4ComboBox.SelectedItem = thisGame.HomeTeamPlayer4;
            thisGame.HomeTeamPlayer5 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer5));
            T1P5ComboBox.SelectedItem = thisGame.HomeTeamPlayer5;
            thisGame.HomeTeamPlayer6 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer6));
            T1P6ComboBox.SelectedItem = thisGame.HomeTeamPlayer6;
            thisGame.HomeTeamPlayer7 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer7));
            T1P7ComboBox.SelectedItem = thisGame.HomeTeamPlayer7;
            thisGame.HomeTeamPlayer8 = (PersonModel)thisGame.HomeTeamPlayers.FirstOrDefault((x => x.PersonID == homeTeamPlayers.HomeTeamPlayer8));
            T1P8ComboBox.SelectedItem = thisGame.HomeTeamPlayer8;
            wireupEightBallComboBox();
        }

        private void getAwayTeamButton_Click(object sender, EventArgs e)
        {
            AwayTeamPlayersModel awayTeamPlayers = new AwayTeamPlayersModel();
            awayTeamPlayers = GlobalConfig.Connection.GetAwayTeamPlayers(thisGame);

            thisGame.AwayTeamPlayer1 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer1));
            T2P1ComboBox.SelectedItem = thisGame.AwayTeamPlayer1;
            thisGame.AwayTeamPlayer2 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer2));
            T2P2ComboBox.SelectedItem = thisGame.AwayTeamPlayer2;
            thisGame.AwayTeamPlayer3 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer3));
            T2P3ComboBox.SelectedItem = thisGame.AwayTeamPlayer3;
            thisGame.AwayTeamPlayer4 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer4));
            T2P4ComboBox.SelectedItem = thisGame.AwayTeamPlayer4;
            thisGame.AwayTeamPlayer5 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer5));
            T2P5ComboBox.SelectedItem = thisGame.AwayTeamPlayer5;
            thisGame.AwayTeamPlayer6 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer6));
            T2P6ComboBox.SelectedItem = thisGame.AwayTeamPlayer6;
            thisGame.AwayTeamPlayer7 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer7));
            T2P7ComboBox.SelectedItem = thisGame.AwayTeamPlayer7;
            thisGame.AwayTeamPlayer8 = (PersonModel)thisGame.AwayTeamPlayers.FirstOrDefault((x => x.PersonID == awayTeamPlayers.AwayTeamPlayer8));
            T2P8ComboBox.SelectedItem = thisGame.AwayTeamPlayer8;

            wireupEightBallComboBox();
        }
    }
}
