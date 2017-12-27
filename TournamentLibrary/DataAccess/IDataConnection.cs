using System.Collections.Generic;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public interface IDataConnection
    {
        SeasonModel CreateSeason(SeasonModel model);
        PersonModel CreatePerson(PersonModel model);
        VenueModel CreateVenue(VenueModel model);
        TeamModel CreateTeam(TeamModel model);
        List<RosterModel> CreateRoster(RosterModel model);

        List<PersonModel> GetAllPeople();
        //TODO convert GetLastPerson from list into PersonModel only
        List<PersonModel> GetLastPerson();

        List<VenueModel> GetAllVenues();

        List<TeamModel> GetAllTeams();

        

        DivisionModel CreateDivision(DivisionModel model);
        SkippedDatesModel CreateSkippedDatesModel(SkippedDatesModel model);
    }
}
