using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class SeasonDivisionsModel
    {
       public SeasonDivisionsModel()
        {

        }

        public SeasonDivisionsModel(int i)
        {
            SeasonID = i;
        }

        public int SeasonDivisionsID { get; set; }
        public int SeasonID { get; set; }
        public int DivisionID { get; set; }
        public DateTime StartDate { get; set; }

        public List<SkippedDatesModel> skippedDates { get; set; }
        public List<TeamModel> teams { get; set; }
    }
}
