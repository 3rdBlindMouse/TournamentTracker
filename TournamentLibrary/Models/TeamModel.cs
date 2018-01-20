using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class TeamModel
    {
        public TeamModel()
        {
        }

        public TeamModel(string name, int id)
        {
            TeamName = name;
            TeamID = id;
        }

        /// <summary>
        /// Unique ID of team
        /// </summary>
        public int TeamID { get; set; }
        /// <summary>
        /// ID of Division Team belongs to
        /// </summary>
        public int DivisionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DivisionTeamsID { get; set; }
        /// <summary>
        /// Name of team
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Team's Home
        /// </summary>
        /// //TODO work something out with venue probably a new class in between.
        public int TeamVenue { get; set; }
        public VenueModel Venue { get; set; }
        /// <summary>
        /// List of team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; }
        /// <summary>
        /// Team captain
        /// </summary>
        public int TeamCaptain { get; set; }
        public PersonModel Captain { get; set; }
        
    }
}
