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
        CaptainModel CreateTeamCaptain(CaptainModel model);
        List<RosterModel> CreateRoster(RosterModel model);

        List<PersonModel> GetAllPeople();
        List<SeasonModel> GetLastSeason();

        //TODO convert GetLastPerson from list into PersonModel only
        List<PersonModel> GetLastPerson();
        List<DivisionModel> GetSeasonDivisions(int i);
        List<VenueModel> GetAllVenues();

        List<PersonModel> GetTeamMembers(TeamModel model);
        

        List<TeamModel> GetAllTeams();
        List<TeamModel> GetDivisionTeams(SeasonDivisionsModel model);

        

        DivisionModel CreateDivision(DivisionModel model);
        SkippedDatesModel CreateSkippedDates(SkippedDatesModel model);
        List<SkippedDatesModel> GetSkippedDates(DivisionModel model);
        void CreateDivisionTeams(TeamModel teammodel);
        void EditDivision(DivisionModel model);
        void DeleteSkippedDates(DivisionModel model);
        void DeleteDivisionTeams(TeamModel teammodel);
        void EditVenue(VenueModel model);
        void EditPerson(PersonModel model);
        List<CaptainModel> GetTeamCaptains(TeamModel tm);
        void EditTeam(TeamModel model);
        void EditRoster(RosterModel model, List<PersonModel> adds, List<PersonModel> removes);
        void EditCaptainRemove(TeamModel model);
        void EditCaptain(TeamModel model);
        void DeleteTeamCaptain();
        SeasonDivisionsModel createSeasonDivisions(SeasonDivisionsModel model);
        List<SeasonModel> GetAllSeasons();
        SeasonDivisionsModel GetSeasonDivisionModel(DivisionModel dm);
    }
}
