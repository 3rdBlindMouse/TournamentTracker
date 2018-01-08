using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class VenueModel
    {
        

        public VenueModel()
        {
        }

        /// <summary>
        /// this contructor is used to add "Select Venue" at top of combobox in EditVenueForm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="i"></param>
        public VenueModel(string n, int i )
        {
            this.VenueName = n;
            this.VenueID = i;
        }

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
        public string ContactPerson { get; set; }
        /// <summary>
        /// number of pool tables at the venue
        /// </summary>
        public int PoolTables { get; set; }       
    }
}
