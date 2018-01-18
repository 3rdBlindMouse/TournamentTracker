using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class SeasonDivisionsModel
    {
        public int SeasonDivisionsID { get; set; }
        public int SeasonID { get; set; }
        public int DivisionID { get; set; }
        public DateTime StartDate { get; set; }
    }
}
