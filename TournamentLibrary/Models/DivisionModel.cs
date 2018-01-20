using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class DivisionModel
    {
        /// <summary>
        /// Unique ID for Division
        /// </summary>
        public int DivisionID { get; set; }
        /// <summary>
        /// ID of season this Division is a part of
        /// </summary>
        public int SeasonID { get; set; }
        /// <summary>
        /// Division name
        /// </summary>
        public string DivisionName { get; set; }
        /// <summary>
        /// Division number 
        /// </summary>
        public int DivisionNumber { get; set; }
        /// <summary>
        /// Date this Division begins its games
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// A list of the Rounds that make up this Division
        /// </summary>
        public List<RoundModel> DivisionRounds { get; set; }
        /// <summary>
        /// A List of the Teams in this Division
        /// </summary>
        public List<TeamModel> DivisionTeams { get; set; }
        /// <summary>
        /// A List of the Dates with no games played in this Division 
        /// </summary>
        public List<DateTime> DivisionSkippedDates { get; set; }


        /// <summary>
        /// used to create a "Heading" for division combo boxes
        /// allows a DivisionModel to be created and added to a List that is about to become a datasource
        /// </summary>
        /// <param name="name"></param>
        public DivisionModel(String name, int i)
        {
            DivisionName = name;
            DivisionID = i;
        }

        public DivisionModel()
        {

        }
    }
    
}
