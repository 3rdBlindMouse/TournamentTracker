using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class RoundModel
    {
        /// <summary>
        /// Unique ID for round
        /// </summary>
        public int RoundID { get; set; }
        /// <summary>
        /// ID of Division this Round is part of
        /// </summary>
        public int DivisionID { get; set; }
        /// <summary>
        /// Number of the Current Round
        /// </summary>
        public int RoundNumber { get; set; }
        /// <summary>
        /// Date of round
        /// </summary>
        public DateTime RoundDate { get; set; }
        /// <summary>
        /// A list of all the games played in the current round
        /// </summary>
        public List<GameModel> RoundGames { get; set; }
    }
}
