using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class PairModel
    {
        /// <summary>
        /// Unique ID of current Pair
        /// </summary>
        public int PairID { get; set; }
        /// <summary>
        /// First Person of the Pair
        /// </summary>
        public PersonModel Player1 { get; set; }
        /// <summary>
        /// Second Person of the Pair
        /// </summary>
        public PersonModel Player2 { get; set; }
    }
}
