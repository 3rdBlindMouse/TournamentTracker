using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class DoublesModel
    {
        /// <summary>
        /// Unique ID for doubles game
        /// </summary>
        public int DoublesID { get; set; }
        /// <summary>
        /// ID of Game this doubles is a part of
        /// </summary>
        public int GameID { get; set; }
        /// <summary>
        /// Home team pair of players
        /// </summary>
        public PairModel HomeTeamPair { get; set; }
        /// <summary>
        /// Away team pair of players
        /// </summary>
        public PairModel AwayTeamPair { get; set; }
        /// <summary>
        /// Winning Pair
        /// </summary>
        public PairModel WinningPair { get; set; }
        /// <summary>
        /// Winning Team
        /// </summary>
        public TeamModel WinningTeam { get; set; }
        /// <summary>
        /// Score value for winning a doubles game
        /// </summary>
        public int DoublesScoreValue { get; set; }
    }
}
