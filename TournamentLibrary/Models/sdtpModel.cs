using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    /// <summary>
    /// A model used to hold the IDs of models identifiable from a person in a team....
    /// add some better description eventually
    /// </summary>
    public class sdtpModel
    {
        public int sdtpID { get; set; }
        public int SeasonID { get; set; }
        public int DivisionID { get; set; }
        public int SeasonDivisionsID { get; set; }
        public int TeamID { get; set; }
        public int DivisionTeamsID { get; set; }
        public int RosterID { get; set; }
        public int PersonID { get; set; }


        public sdtpModel()
        {

        }
    }
  
}
