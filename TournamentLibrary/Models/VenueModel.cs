using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class VenueModel
    {
        /// <summary>
        /// Unique ID for Venue
        /// </summary>
        public int VenueID { get; set; }
        /// <summary>
        /// Name of venue
        /// </summary>
        public string VenueName { get; set; }
        /// <summary>
        /// Address of venue
        /// </summary>
        public string VenueAddress { get; set; }
        /// contact number for the venue
        /// </summary>
        public string VenuePhone { get; set; }
        /// <summary>
        /// Name of contact person/publican of Venue
        /// </summary>
        public PersonModel ContactPerson { get; set; }
        /// <summary>
        /// number of pool tables at the venue
        /// </summary>
        public int NumberOfPoolTables { get; set; }       
    }
}
