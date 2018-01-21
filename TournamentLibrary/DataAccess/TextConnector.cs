using System;
using System.Collections.Generic;
using System.Linq;
// textProcessor for using extended methods
using TournamentLibrary.DataAccess.TextProcessor;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // PersonModel.csv will always be this file/name (note fullpath not locked in) 
        private const string PersonFile = "PersonModel.csv";

        public void EditDivision(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateDivisionTeams(TeamModel team)
        {
            throw new NotImplementedException();
        }

        public DivisionModel CreateDivision(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves a new Person to the text file(s).
        /// </summary>
        /// <param name="model">The Person Information</param>
        /// <returns>The Person information, including the unique identifier</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            // List of PersonModels from textfile.
            // Load the text file and convert to a list of PersonModel
            List<PersonModel> people = PersonFile.FullFilePath().LoadFile().convertToPersonModel();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.PersonID).First().PersonID + 1;
            }
            model.PersonID = currentId;

            // add the new record with the new id (max + 1)
            people.Add(model);

            // save the list<string> to the text file
            people.saveToPersonFile(PersonFile);

            return model;
        }

        public List<RosterModel> CreateRoster(RosterModel model)
        {
            throw new NotImplementedException();
        }

        public SeasonModel CreateSeason(SeasonModel model)
        {
            throw new NotImplementedException();
        }

        public SkippedDatesModel CreateSkippedDates(SkippedDatesModel model)
        {
            throw new NotImplementedException();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public VenueModel CreateVenue(VenueModel model)
        {
            throw new NotImplementedException();
        }

        public List<DivisionModel> GetSeasonDivisions()
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetAllPeople()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetDivisionTeams()
        {
            throw new NotImplementedException();
        }

        public List<VenueModel> GetAllVenues()
        {
            throw new NotImplementedException();
        }

        public List<SkippedDatesModel> GetSkippedDates(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        List<PersonModel> IDataConnection.GetLastPerson()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetDivisionTeams(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkippedDates(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteDivisionTeams(TeamModel teammodel)
        {
            throw new NotImplementedException();
        }

        public void EditVenue(VenueModel model)
        {
            throw new NotImplementedException();
        }

        public void EditPerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetTeamMembers(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public CaptainModel CreateTeamCaptain(CaptainModel model)
        {
            throw new NotImplementedException();
        }

        public CaptainModel GetTeamCaptain(TeamModel tm)
        {
            throw new NotImplementedException();
        }

        public List<CaptainModel> GetTeamCaptains(TeamModel tm)
        {
            throw new NotImplementedException();
        }

        public void EditTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void EditRoster(RosterModel model, List<PersonModel> adds, List<PersonModel> removes)
        {
            throw new NotImplementedException();
        }

        public void EditCaptainRemove(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void EditCaptain(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeamCaptain()
        {
            throw new NotImplementedException();
        }

        public List<SeasonModel> GetLastSeason()
        {
            throw new NotImplementedException();
        }

        public List<DivisionModel> GetSeasonDivisions(int i)
        {
            throw new NotImplementedException();
        }

        public SeasonDivisionsModel createSeasonDivisions(SeasonDivisionsModel model)
        {
            throw new NotImplementedException();
        }

        public List<SeasonModel> GetAllSeasons()
        {
            throw new NotImplementedException();
        }

        public SeasonDivisionsModel GetSeasonDivisionModel(DivisionModel dm)
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetDivisionTeams(SeasonDivisionsModel model)
        {
            throw new NotImplementedException();
        }

        public SeasonModel GetSeason(int i)
        {
            throw new NotImplementedException();
        }

        public void CreateDivisionTeams(int sdmID, int teamID)
        {
            throw new NotImplementedException();
        }

        public void DeleteDivisionTeams(int SeasonDivisionsID, int TeamID)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkippedDates(SkippedDatesModel model)
        {
            throw new NotImplementedException();
        }

        public List<SkippedDatesModel> GetSkippedDates(SeasonDivisionsModel model)
        {
            throw new NotImplementedException();
        }

        public DivisionTeamsModel CreateDivisionTeams(DivisionTeamsModel model)
        {
            throw new NotImplementedException();
        }
    }
}
