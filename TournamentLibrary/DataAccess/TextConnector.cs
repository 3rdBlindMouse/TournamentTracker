﻿using System;
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

        public DivisionModel CreateDivision(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        public DivisionTeamsModel CreateDivisionTeams(DivisionTeamsModel model)
        {
            throw new NotImplementedException();
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public List<RosterModel> CreateRoster(RosterModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateSDTP(int sid, int dTid, int pid)
        {
            throw new NotImplementedException();
        }

        public void CreateSDTP(int sid, int did, int sDid, int dTid, int tid, int rid, int pid)
        {
            throw new NotImplementedException();
        }

        public void CreateSDTP(sdtpModel sdtp)
        {
            throw new NotImplementedException();
        }

        public SeasonModel CreateSeason(SeasonModel model)
        {
            throw new NotImplementedException();
        }

        public SeasonDivisionsModel createSeasonDivisions(SeasonDivisionsModel model)
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

        public CaptainModel CreateTeamCaptain(CaptainModel model)
        {
            throw new NotImplementedException();
        }

        public VenueModel CreateVenue(VenueModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteDivisionTeams(int SeasonDivisionsID, int TeamID)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayerFromRoster(int pid)
        {
            throw new NotImplementedException();
        }

        public void DeleteSDTP(int sid, int pid)
        {
            throw new NotImplementedException();
        }

        public void DeleteSeasonDivisions(int seasonID, int divisionID)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkippedDates(SkippedDatesModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeamCaptain()
        {
            throw new NotImplementedException();
        }

        public void EditCaptain(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void EditCaptainRemove(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void EditDivision(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        public void EditPerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public void EditRoster(RosterModel model, List<PersonModel> adds, List<PersonModel> removes)
        {
            throw new NotImplementedException();
        }

        public void EditTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void EditVenue(VenueModel model)
        {
            throw new NotImplementedException();
        }

        public List<DivisionModel> GetAllDivisions()
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetAllPeople()
        {
            throw new NotImplementedException();
        }

        public List<SeasonModel> GetAllSeasons()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public List<VenueModel> GetAllVenues()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetDivisionTeams(SeasonDivisionsModel model)
        {
            throw new NotImplementedException();
        }

        public List<DivisionModel> GetDivsNotInThisSeason(int seasonID)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetLastPerson()
        {
            throw new NotImplementedException();
        }

        public List<SeasonModel> GetLastSeason()
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPlayersNotInThisSeason(SeasonDivisionsModel sdm)
        {
            throw new NotImplementedException();
        }

        public SeasonModel GetSeason(int i)
        {
            throw new NotImplementedException();
        }

        public SeasonDivisionsModel GetSeasonDivisionModel(DivisionModel dm)
        {
            throw new NotImplementedException();
        }

        public List<DivisionModel> GetSeasonDivisions(int i)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetSeasonDivisionTeamMembers(int seasonID, int divisionTeamsID)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetSeasonPlayers(SeasonDivisionsModel sdm)
        {
            throw new NotImplementedException();
        }

        public List<DivisionTeamsModel> GetSeasonTeams(SeasonDivisionsModel sdm)
        {
            throw new NotImplementedException();
        }

        public List<SkippedDatesModel> GetSkippedDates(SeasonDivisionsModel model)
        {
            throw new NotImplementedException();
        }

        public List<CaptainModel> GetTeamCaptains(TeamModel tm)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetTeamMembers(DivisionTeamsModel model)
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetTeamsNotInSeason(SeasonDivisionsModel model)
        {
            throw new NotImplementedException();
        }

        List<DivisionModel> IDataConnection.GetDivsNotInThisSeason(int seasonID)
        {
            throw new NotImplementedException();
        }

        SeasonModel IDataConnection.GetLastSeason()
        {
            throw new NotImplementedException();
        }
    }
}
