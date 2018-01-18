using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class SkippedDatesModel
    {
        /// <summary>
        /// ID of Current SkippedDates
        /// </summary>
        public int SkippedDatesID { get; set; }
        /// <summary>
        /// ID of Division these dates relate to
        /// </summary>
        public int SeasonDivisionsID { get; set; }
        /// <summary>
        /// Date to skip in current Division
        /// </summary>
        public DateTime DateToSkip { get; set; }

    }
}
