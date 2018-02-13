using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class SinglesModel
    {
        /// <summary>
        /// Unique ID for singles game
        /// </summary>
        public int SinglesID { get; set; }
        /// <summary>
        /// ID of game this singles matchup is a part of 
        /// </summary>
        public int GameID { get; set; }
        /// <summary>
        /// 1/1 Home Team Player
        /// </summary>
        public PersonModel HomeTeamPlayer { get; set; }
        /// <summary>
        /// 1/1 Away Team Player
        /// </summary>
        public PersonModel AwayTeamPlayer { get; set; }
        /// <summary>
        /// 1/1 Winning Player
        /// </summary>
        public PersonModel WinningPlayer { get; set; }
        /// <summary>
        /// 1/1 Winning Team
        /// </summary>
        public TeamModel WinningTeam { get; set; }
        /// <summary>
        /// Score value for winning a singles game
        /// </summary>
        public int SinglesScoreValue { get; set; }


        public PersonModel HomeTeamPlayer1 { get; set; }
        public PersonModel HomeTeamPlayer2 { get; set; }
        public PersonModel HomeTeamPlayer3 { get; set; }
        public PersonModel HomeTeamPlayer4 { get; set; }
        public PersonModel HomeTeamPlayer5 { get; set; }
        public PersonModel HomeTeamPlayer6 { get; set; }
        public PersonModel HomeTeamPlayer7 { get; set; }
        public PersonModel HomeTeamPlayer8 { get; set; }
    }
}
