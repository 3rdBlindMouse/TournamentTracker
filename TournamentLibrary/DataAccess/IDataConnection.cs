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
        List<DivisionModel> GetAllDivisions();
        List<VenueModel> GetAllVenues();

        List<TeamModel> GetAllTeams();
        List<TeamModel> GetDivisionTeams(DivisionModel model);

        

        DivisionModel CreateDivision(DivisionModel model);
        SkippedDatesModel CreateSkippedDates(SkippedDatesModel model);
        List<SkippedDatesModel> GetSkippedDates(DivisionModel model);
        void CreateDivisionTeams(TeamModel teammodel);
        void EditDivision(DivisionModel model);
    }
}
