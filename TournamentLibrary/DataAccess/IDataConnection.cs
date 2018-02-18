using System;
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
        SeasonModel GetLastSeason();

        //TODO convert GetLastPerson from list into PersonModel only
        List<PersonModel> GetLastPerson();
        List<DivisionModel> GetSeasonDivisions(int i);
        List<DateTime> GetGameDatesForSdtp(int sdtpID);
        List<VenueModel> GetAllVenues();
        
        List<PersonModel> GetTeamMembers(DivisionTeamsModel model);

        

        List<sdtpModel> GetSdtps(int seasonID);

        List<TeamModel> GetAllTeams();
        bool Login(int userID, string password);
        List<TeamModel> GetDivisionTeams(SeasonDivisionsModel model);
        List<GameModel> GetGameModels(int sdtpID);


        DivisionModel CreateDivision(DivisionModel model);
        SkippedDatesModel CreateSkippedDates(SkippedDatesModel model);
        sdtpModel GetSdtpModel(int sdtpID);
        void DeleteSkippedDates(SkippedDatesModel model);


        List<SkippedDatesModel> GetSkippedDates(SeasonDivisionsModel model);



        DivisionTeamsModel CreateDivisionTeams(DivisionTeamsModel model);
        void EditDivision(DivisionModel model);
        
        void DeleteDivisionTeams(int SeasonDivisionsID , int TeamID);
        List<DivisionModel> GetAllDivisions();
        void EditVenue(VenueModel model);
        void EditPerson(PersonModel model);
        List<CaptainModel> GetTeamCaptains(TeamModel tm);
        void EditTeam(TeamModel model);
        void EditRoster(RosterModel model, List<PersonModel> adds, List<PersonModel> removes);
        void EditCaptainRemove(TeamModel model);
        void EditCaptain(TeamModel model);
        List<DivisionModel> GetDivsNotInThisSeason(int seasonID);
        void DeleteTeamCaptain();
        SeasonDivisionsModel createSeasonDivisions(SeasonDivisionsModel model);
        List<SeasonModel> GetAllSeasons();
        SeasonDivisionsModel GetSeasonDivisionModel(DivisionModel dm);
        SeasonModel GetSeason(int i);
        List<TeamModel> GetTeamsNotInSeason(SeasonDivisionsModel model);
        void DeleteSeasonDivisions(int seasonID, int divisionID);
        DivisionTeamsModel GetDivisionTeamModel(int seasonDivisionsID, int teamID);
        List<DivisionTeamsModel> GetSeasonTeams(SeasonDivisionsModel sdm);
        List<PersonModel> GetSeasonPlayers(SeasonDivisionsModel sdm);
        List<PersonModel> GetSeasonPlayers(int seasonID);
        List<PersonModel> GetPlayersNotInThisSeason(SeasonDivisionsModel sdm);
        List<PersonModel> GetSeasonDivisionTeamMembers(int seasonID, int divisionTeamsID, int teamID);
        void CreateSDTP(int sid, int dTid, int pid);
        void DeletePlayerFromRoster(int pid);
        void DeleteSDTP(int sid, int pid);
        void CreateSDTP(sdtpModel sdtp);
        void AddStartDate(SeasonDivisionsModel sdm);
        RoundModel CreateRound(RoundModel rm);
        RoundModel getRoundModel(SeasonDivisionsModel sdm, int g);
        GameModel CreateGame(GameModel game);
        TeamModel GetBye();
        void CreateLogin(int sdtpID, string password);
        void AddHomePlayers(GameModel thisGame);
        HomeTeamPlayersModel GetHomeTeamPlayers(GameModel gameID);
        AwayTeamPlayersModel GetAwayTeamPlayers(GameModel thisGame);
        void AddAwayPlayers(GameModel thisGame);
    }
}
