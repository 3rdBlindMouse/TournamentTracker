using System.Collections.Generic;

namespace TournamentLibrary.Models
{
    public class SeasonModel
    {
        /// <summary>
        /// Unique ID for Season
        /// </summary>
        public int SeasonID { get; set; }
        /// <summary>
        /// Season Name
        /// </summary>
        public string SeasonName { get; set; }
        /// <summary>
        /// unique year for Season
        /// </summary>
        public int SeasonYear { get; set; }
        /// <summary>
        /// A list of the divisions in the current Season
        /// </summary>
        public List<DivisionModel> SeasonDivisions { get; set; }

        public SeasonModel()
        {

        }

        public SeasonModel(string name, int year)
        {
            SeasonName = name;
            SeasonYear = year;
        }
    }
}