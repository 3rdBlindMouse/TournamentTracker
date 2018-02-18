using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class GameModel
    {
        /// <summary>
        /// Unique ID for Game
        /// </summary>
        public int GameID { get; set; }
        /// <summary>
        /// ID of the round the current game is involved in
        /// </summary>
        public int RoundID { get; set; }
        /// <summary>
        /// Date of Game
        /// </summary>
        public DateTime GameDate { get; set; }
        /// <summary>
        /// Home Team
        /// </summary>
        public TeamModel HomeTeamModel { get; set; }
        public int HomeTeam { get; set; }
        /// <summary>
        /// Away Team
        /// </summary>
        public TeamModel  AwayTeamModel { get; set; }
        public int AwayTeam { get; set; }
        /// <summary>
        /// List of home team's players
        /// </summary>
        public List<PersonModel> HomeTeamPlayers { get; set; }
        /// <summary>
        /// List of away teams players
        /// </summary>
        public List<PersonModel> AwayTeamPlayers { get; set; }
        /// <summary>
        /// List of singles games in this game
        /// </summary>
        public List<SinglesModel> Singles { get; set; }
        /// <summary>
        /// List of doubles games in this game
        /// </summary>
        public List<DoublesModel> Doubles { get; set; }      
        /// <summary>
        /// Home team Score
        /// </summary>
        public int HomeTeamScore { get; set; }
        /// <summary>
        /// Away Team Score
        /// </summary>
        public int AwayTeamScore { get; set; }
        /// <summary>
        /// Winning Team
        /// </summary>
        public TeamModel WinningTeam { get; set; }

        public PersonModel HomeTeamPlayer1 { get; set; }
        public PersonModel HomeTeamPlayer2 { get; set; }
        public PersonModel HomeTeamPlayer3 { get; set; }
        public PersonModel HomeTeamPlayer4 { get; set; }
        public PersonModel HomeTeamPlayer5 { get; set; }
        public PersonModel HomeTeamPlayer6 { get; set; }
        public PersonModel HomeTeamPlayer7 { get; set; }
        public PersonModel HomeTeamPlayer8 { get; set; }

        public PersonModel AwayTeamPlayer1 { get; set; }
        public PersonModel AwayTeamPlayer2 { get; set; }
        public PersonModel AwayTeamPlayer3 { get; set; }
        public PersonModel AwayTeamPlayer4 { get; set; }
        public PersonModel AwayTeamPlayer5 { get; set; }
        public PersonModel AwayTeamPlayer6 { get; set; }
        public PersonModel AwayTeamPlayer7 { get; set; }
        public PersonModel AwayTeamPlayer8 { get; set; }
    }
}
