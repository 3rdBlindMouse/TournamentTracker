using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class RosterModel
    {
        /// <summary>
        /// Unique ID for Division
        /// </summary>
        public int RosterID { get; set; }
        /// <summary>
        /// ID of team
        /// </summary>
        public int DivisionTeamsID { get; set; }
        public List<PersonModel> players { get; set; }
    }
}
