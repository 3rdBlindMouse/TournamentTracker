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
        /// A description of the current season
        /// </summary>
        public string SeasonDescription { get; set; }

        /// <summary>
        /// A list of the divisions in the current Season
        /// </summary>
        public List<DivisionModel> SeasonDivisions { get; set; }

        public SeasonModel()
        {

        }

        /// <summary>
        /// used to create a "Heading" for Season combo boxes
        /// allows a SeasonModel to be created and added to a List that is about to become a datasource
        /// </summary>
        /// <param name="name"></param>
        public SeasonModel(string name, int i)
        {
            SeasonName = name;
            SeasonID= i;
        }

       
    }
}