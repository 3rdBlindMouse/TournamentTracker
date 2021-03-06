﻿using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public class MySqlConnector : IDataConnection
    {
        private const string db = "tournament";



        /*
         * CREATORS
         */
        /// <summary>
        /// Saves a new Division Model to the Database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The Division information, including the unique identifier</returns>
        public DivisionModel CreateDivision(DivisionModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DivisionID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@DivisionName", model.DivisionName);
                p.Add("@DivisionNumber", model.DivisionNumber);
                connection.Execute("spDivision", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("DivisionID");
                model.DivisionID = Convert.ToInt32(id);

                return model;
            }
        }
        /// <summary>
        /// Saves a new Person to the MySQL database
        /// </summary>
        /// <param name="model">The Person Information</param>
        /// <returns>The Person information, including the unique identifier</returns>
        public PersonModel CreatePerson(PersonModel model)
        {

            // lesson 10 30:30
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PersonID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@email", model.Email);
                p.Add("@phone", model.ContactNumber);
                p.Add("@sex", model.Sex);
                p.Add("@DateOfBirth", model.DateOfBirth);

                connection.Execute("spPerson", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("PersonID");
                model.PersonID = Convert.ToInt32(id);

                return model;

            }
        }
        /// <summary>
        /// Saves a new Roster to the MySQL DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The Roster information, including the unique identifier</returns>
        public List<RosterModel> CreateRoster(RosterModel model)
        {
            List<RosterModel> roster = new List<RosterModel>();
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (PersonModel player in model.players)
                {
                    var p = new DynamicParameters();
                    p.Add("@RosterID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    p.Add("@InPersonID", player.PersonID);
                    p.Add("@InDivisionTeamsID", model.DivisionTeamsID);


                    connection.Execute("spRoster", p, commandType: CommandType.StoredProcedure);


                    // grabs newly created ID from database and returns it as part of the current Person Model
                    // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                    var id = p.Get<int?>("RosterID");
                    model.RosterID = Convert.ToInt32(id);

                    roster.Add(model);
                }
                return roster;
            }
        }
        /// <summary>
        /// Saves a new Season to the MySQL DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The Season information, including the unique identifier</returns>
        public SeasonModel CreateSeason(SeasonModel model)
        {
            // lesson 10 30:30
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@SeasonID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@SeasonName", model.SeasonName);
                p.Add("@SeasonYear", model.SeasonYear);
                p.Add("@SeasonDescription", model.SeasonDescription);


                connection.Execute("spSeason", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("SeasonID");
                model.SeasonID = Convert.ToInt32(id);

                return model;
            }
        }
        /// <summary>
        /// Saves a new SkippedDate to the MySQL DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The SkippedDate information, including the unique identifier</returns>
        public SkippedDatesModel CreateSkippedDates(SkippedDatesModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@SkippedDatesID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@SeasonDivisionsID", model.SeasonDivisionsID);
                p.Add("@DateToSkip", model.DateToSkip);
                connection.Execute("spSkippedDates", p, commandType: CommandType.StoredProcedure);
                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("SkippedDatesID");
                model.SkippedDatesID = Convert.ToInt32(id);
                return model;
            }
        }
        /// <summary>
        /// Saves a new Team to the MySQL DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The Team information, including the unique identifier</returns>
        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@TeamName", model.TeamName);
                // TODO sort venues
                //p.Add("@TeamVenue", model.TeamVenue);
                //p.Add("@DivisionID", 0);
                connection.Execute("spTeam", p, commandType: CommandType.StoredProcedure);
                // grabs newly created ID from database and returns it as part of the current Person Model
                model.TeamID = p.Get<int>("@TeamID");
                return model;
            }
        }
        /// <summary>
        /// Saves a new Venue to the MySQL DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The Venue information, including the unique identifier</returns>
        public VenueModel CreateVenue(VenueModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@VenueID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@VenueName", model.VenueName);
                p.Add("@VenueAddress", model.VenueAddress);
                p.Add("@VenuePhone", model.VenuePhone);
                p.Add("@ContactPerson", model.ContactPerson);
                p.Add("@PoolTables", model.PoolTables);



                connection.Execute("spVenue", p, commandType: CommandType.StoredProcedure);

                // grabs newly created ID from database and returns it as part of the current Person Model
                model.VenueID = p.Get<int>("@VenueID");


                return model;
            }
        }
        /// <summary>
        /// Saves a new Collection of Teams in Selected Dvision to the MySQL DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Nothing atm</returns>
        public DivisionTeamsModel CreateDivisionTeams(DivisionTeamsModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DivisionTeamsID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@InSeasonDivisionsID", model.SeasonDivisionsID);
                p.Add("@InDivisionID", model.DivisionID);
                p.Add("@InTeamID", model.TeamID);


                connection.Execute("spDivisionTeams", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("DivisionTeamsID");
                model.DivisionTeamsID = Convert.ToInt32(id);

                return model;
            }
        }
        /// <summary>
        /// Saves a new TeamCaptain in Selected Dvision to the MySQL DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The TeamCaptain information, including the unique identifier</returns>
        public CaptainModel CreateTeamCaptain(CaptainModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@CaptainID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@InDivisionTeamsID", model.DivisionTeamID);
                p.Add("@InPersonID", model.PersonID);

                connection.Execute("spTeamCaptains", p, commandType: CommandType.StoredProcedure);

                var id = p.Get<int?>("CaptainID");
                model.CaptianID = Convert.ToInt32(id);

                return model;
            }
        }
        /*
         * GETTERS
         */
        /// <summary>
        /// Gets a List of The Divisions in selected selection (at the moment all Divisions in the DB)
        /// </summary>
        /// <returns>A List of ALL Divisions in MySQL DB</returns>
        public List<DivisionModel> GetSeasonDivisions(int id)
        {
            List<DivisionModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var q = new DynamicParameters();
                q.Add("@SeasonID", id);
                output = connection.Query<DivisionModel>("spGetSeasonDivisions", q, commandType: CommandType.StoredProcedure).ToList();

            }
            foreach (DivisionModel d in output)
            {
                d.SeasonID = id;
            }
            return output;
        }
        /// <summary>
        /// Gets a List of all the Teams in a Selected Division
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A List of all the Teams in a Selected Division</returns>
        public List<TeamModel> GetDivisionTeams(SeasonDivisionsModel model)
        {
            List<TeamModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonDivisionsID", model.SeasonDivisionsID);
                output = connection.Query<TeamModel>("spGetDivisionTeams", p, commandType: CommandType.StoredProcedure).ToList();

                //foreach (TeamModel team in output)
                //{
                //    p = new DynamicParameters();
                //    p.Add("@TeamID", team.TeamID);
                //    team.TeamMembers = connection.Query<PersonModel>("spGetRoster", p, commandType: CommandType.StoredProcedure).ToList();
                //}
            }
            return output;
        }
        /// <summary>
        /// Gets a List of The People in selected selection (at the moment all People in the DB)
        /// </summary>
        /// <returns>A List of all the People</returns>
        public List<PersonModel> GetAllPeople()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("spGetAllPeople").ToList();
            }
            return output;
        }
        /// <summary>
        /// Gets a List of The Teams in selected selection (at the moment all People in the DB)
        /// </summary>
        /// <returns>A List of all the Teams</returns>
        public List<TeamModel> GetAllTeams()
        {
            List<TeamModel> output = new List<TeamModel>();
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("spGetAllTeams").ToList();
            }
            return output;
        }
        /// <summary>
        /// Gets a List of The Venues in selected selection (at the moment all People in the DB)
        /// </summary>
        /// <returns>A List of all the Venues</returns>
        public List<VenueModel> GetAllVenues()
        {
            List<VenueModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<VenueModel>("spGetAllVenues").ToList();
            }
            return output;
        }
        /// <summary>
        /// Gets a List of The Last Person created in selected selection (at the moment in the DB)
        /// </summary>
        /// <returns>A List containing the last Person created int he DB</returns>
        public List<PersonModel> GetLastPerson()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("spGetLastPerson").ToList();
            }
            return output;
        }
        /// <summary>
        /// Gets a List of The SkippedDates in selected Division 
        /// </summary>
        /// <returns>A List of The SkippedDates in selected Division </returns>
        public List<SkippedDatesModel> GetSkippedDates(SeasonDivisionsModel model)
        {
            List<SkippedDatesModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonDivisionsID", model.SeasonDivisionsID);
                output = connection.Query<SkippedDatesModel>("spGetSkippedDates", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }
        // <summary>
        /// Gets a List of The TeamMembers in selected Team
        /// </summary>
        /// <returns>A List of The PersonModels in selected Team </returns>
        public List<PersonModel> GetTeamMembers(DivisionTeamsModel model)
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DivisionTeamsID", model.DivisionTeamsID);
                output = connection.Query<PersonModel>("spGetTeamMembers", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }
        // <summary>
        /// Gets a List containing the TeamCaptain of selected Team 
        /// </summary>
        /// <returns>A List containing the Team Captain of selected Team</returns>
        public List<CaptainModel> GetTeamCaptains(TeamModel model)
        {
            List<CaptainModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InTeamID", model.TeamID);
                output = connection.Query<CaptainModel>("spGetTeamCaptain", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        /*
         * EDITORS
         */
        /// <summary>
        /// Modifies Division data in MySQL DB
        /// </summary>
        /// <param name="model"></param>
        public void EditDivision(DivisionModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InDivisionID", model.DivisionID);
                p.Add("@InDivisionName", model.DivisionName);
                p.Add("@InDivisionNumber", model.DivisionNumber);
                connection.Execute("spEditDivision", p, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Modifies Venue data in MySQL DB
        /// </summary>
        /// <param name="model"></param>
        public void EditVenue(VenueModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InVenueID", model.VenueID);
                p.Add("@InVenueName", model.VenueName);
                p.Add("@InVenueAddress", model.VenueAddress);
                p.Add("@InVenuePhone", model.VenuePhone);
                p.Add("@InContactPerson", model.ContactPerson);
                p.Add("@InPoolTables", model.PoolTables);
                connection.Execute("spEditVenue", p, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Modifies Person data in MySQL DB
        /// </summary>
        /// <param name="model"></param>
        public void EditPerson(PersonModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InPersonID", model.PersonID);
                p.Add("@InFirstName", model.FirstName);
                p.Add("@InLastName", model.LastName);
                p.Add("@InEmail", model.Email);
                p.Add("@InPhone", model.ContactNumber);
                p.Add("@InSex", model.Sex);
                p.Add("@InDateOfBirth", model.DateOfBirth);
                connection.Execute("spEditPerson", p, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Modifies Team data in MySQL DB
        /// </summary>
        /// <param name="model"></param>
        public void EditTeam(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InTeamID", model.TeamID);
                p.Add("@InTeamName", model.TeamName);
                p.Add("@InTeamVenue", model.TeamVenue);

                connection.Execute("spEditTeam", p, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Modifies Roster data in MySQL DB
        /// </summary>
        /// <param name="model"></param>
        public void EditRoster(RosterModel model, List<PersonModel> adds, List<PersonModel> removes)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {

                foreach (PersonModel x in adds)
                {
                    var p = new DynamicParameters();
                    p.Add("@InDivisionTeamsID", model.DivisionTeamsID);
                    p.Add("@InPersonID", x.PersonID);
                    connection.Execute("spEditRosterAdd", p, commandType: CommandType.StoredProcedure);
                }

                foreach (PersonModel y in removes)
                {
                    var p = new DynamicParameters();
                    p.Add("@InDivisionTeamsID", model.DivisionTeamsID);
                    p.Add("@InPersonID", y.PersonID);
                    connection.Execute("spEditRosterRemove", p, commandType: CommandType.StoredProcedure);
                }


            }
        }

        public void DeleteSkippedDates(SkippedDatesModel skm)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonDivisionsID", skm.SeasonDivisionsID);
                p.Add("@InDateToRemove", skm.DateToSkip);

                connection.Execute("spDeleteSkippedDates", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteDivisionTeams(int sdID, int teamID)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonDivisionsID", sdID);
                p.Add("@InTeamID", teamID);

                connection.Execute("spDeleteDivisionTeams", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditCaptainRemove(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InTeamID", model.TeamID);
                connection.Execute("spEditCaptainRemove", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditCaptain(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InTeamID", model.TeamID);
                p.Add("@InCaptainID", model.TeamCaptain);
                connection.Execute("spEditCaptain", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteTeamCaptain()
        {
            throw new NotImplementedException();
        }

        public SeasonModel GetLastSeason()
        {
            List<SeasonModel> output = new List<SeasonModel>();
            SeasonModel model = new SeasonModel(); ;

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<SeasonModel>("spGetLastSeason").ToList();
            }

            foreach (SeasonModel sm in output)
            {
                model.SeasonID = sm.SeasonID;
                model.SeasonName = sm.SeasonName;
                model.SeasonYear = sm.SeasonYear;
                model.SeasonDescription = sm.SeasonDescription;
            }

            return model;
        }

        public SeasonDivisionsModel createSeasonDivisions(SeasonDivisionsModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@SeasonDivisionsID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@SeasonID", model.SeasonID);
                p.Add("@DivisionID", model.DivisionID);
                p.Add("@StartDate", model.StartDate.Date);
                connection.Execute("spSeasonDivisions", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("SeasonDivisionsID");
                model.SeasonDivisionsID = Convert.ToInt32(id);

                return model;
            }
        }

        public List<SeasonModel> GetAllSeasons()
        {
            List<SeasonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<SeasonModel>("spGetAllSeasons").ToList();
            }
            return output;
        }

        public SeasonDivisionsModel GetSeasonDivisionModel(DivisionModel model)
        {
            List<SeasonDivisionsModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InDivisionID", model.DivisionID);
                p.Add("@InSeasonID", model.SeasonID);
                output = connection.Query<SeasonDivisionsModel>("spGetSeasonDivisionsModel", p, commandType: CommandType.StoredProcedure).ToList();
            }
            SeasonDivisionsModel sm = new SeasonDivisionsModel();
            foreach (SeasonDivisionsModel x in output)
            {
                sm.SeasonDivisionsID = x.SeasonDivisionsID;
                sm.SeasonID = model.SeasonID;
                sm.DivisionID = model.DivisionID;
                sm.StartDate = x.StartDate;
            }
            return sm;
        }

        public SeasonModel GetSeason(int id)
        {
            List<SeasonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", id);
                output = connection.Query<SeasonModel>("spGetSeason", p, commandType: CommandType.StoredProcedure).ToList();
            }
            SeasonModel sm = new SeasonModel();
            foreach (SeasonModel x in output)
            {

                sm.SeasonID = id;
                sm.SeasonName = x.SeasonName;
                sm.SeasonYear = x.SeasonYear;
                sm.SeasonDescription = x.SeasonDescription;

            }
            return sm;
        }

        public List<DivisionModel> GetAllDivisions()
        {
            List<DivisionModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DivisionModel>("spGetAllDivisions").ToList();
            }
            return output;
        }

        public List<DivisionModel> GetDivsNotInThisSeason(int seasonID)
        {
            List<DivisionModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", seasonID);
                output = connection.Query<DivisionModel>("spGetDivisionsNotInThisSeason", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<TeamModel> GetTeamsNotInSeason(SeasonDivisionsModel model)
        {
            List<TeamModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonDivisionsID", model.SeasonDivisionsID);
                output = connection.Query<TeamModel>("spGetTeamsNotInThisSeason", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public void DeleteSeasonDivisions(int seasonID, int divisionID)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", seasonID);
                p.Add("@InDivisionID", divisionID);
                connection.Execute("spDeleteSeasonDivisions", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<DivisionTeamsModel> GetSeasonTeams(SeasonDivisionsModel sdm)
        {
            List<DivisionTeamsModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", sdm.SeasonID);
                output = connection.Query<DivisionTeamsModel>("spGetSeasonTeams", p, commandType: CommandType.StoredProcedure).ToList();

                //foreach (TeamModel team in output)
                //{
                //    p = new DynamicParameters();
                //    p.Add("@TeamID", team.TeamID);
                //    team.TeamMembers = connection.Query<PersonModel>("spGetRoster", p, commandType: CommandType.StoredProcedure).ToList();
                //}
            }
            return output;
        }

        public List<PersonModel> GetSeasonPlayers(SeasonDivisionsModel sdm)
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", sdm.SeasonID);
                output = connection.Query<PersonModel>("spGetSeasonPlayers", p, commandType: CommandType.StoredProcedure).ToList();

                //}
            }
            return output;
        }

        public List<PersonModel> GetPlayersNotInThisSeason(SeasonDivisionsModel sdm)
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", sdm.SeasonID);
                output = connection.Query<PersonModel>("spGetPlayersNotInThisSeason", p, commandType: CommandType.StoredProcedure).ToList();

                //}
            }
            return output;
        }

        public List<PersonModel> GetSeasonDivisionTeamMembers(int seasonID, int divisionID, int teamID)
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", seasonID);
                p.Add("@InDivisionID", divisionID);
                p.Add("@InTeamID", teamID);
                output = connection.Query<PersonModel>("spGetSeasonDivisionTeamMembers", p, commandType: CommandType.StoredProcedure).ToList();

                //}
            }
            return output;
        }

        public void CreateSDTP(int Sid, int DTid, int Pid)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", Sid);
                p.Add("@InDivisionTeamsID", DTid);
                p.Add("@InPersonID", Pid);
                connection.Execute("spSeasonDivisionTeamPlayers", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeletePlayerFromRoster(int pid)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InPersonID", pid);

                connection.Execute("spDeletePlayerFromRoster", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSDTP(int sid, int pid)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("InSeasonID", sid);
                p.Add("@InPersonID", pid);

                connection.Execute("spDeleteSDTPlayer", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateSDTP(sdtpModel sdtp)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", sdtp.SeasonID);
                p.Add("@InDivisionID", sdtp.DivisionID);
                p.Add("@InSeasonDivisionsID", sdtp.SeasonDivisionsID);
                p.Add("@InDivisionTeamsID", sdtp.DivisionTeamsID);
                p.Add("@InTeamID", sdtp.TeamID);
                p.Add("@InRosterID", sdtp.RosterID);
                p.Add("@InPersonID", sdtp.PersonID);
                connection.Execute("spSeasonDivisionTeamPlayers", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<sdtpModel> GetSdtps(int seasonID)
        {
            List<sdtpModel> output;

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", seasonID);
                output = connection.Query<sdtpModel>("spGetSdtps", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public void AddStartDate(SeasonDivisionsModel sdm)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("InSeasonDivisionsID", sdm.SeasonDivisionsID);
                p.Add("@InStartDate", sdm.StartDate);

                connection.Execute("spAddStartDate", p, commandType: CommandType.StoredProcedure);
            }
        }

        public RoundModel CreateRound(RoundModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@RoundID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@InSeasonDivisionsID", model.SeasonDivisionsID);
                p.Add("@InRoundDate", model.RoundDate);
                p.Add("@InRoundNumber", model.RoundNumber);
                connection.Execute("spRounds", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("RoundID");
                model.RoundID = Convert.ToInt32(id);

                return model;
            }
        }

        public RoundModel getRoundModel(SeasonDivisionsModel sdm, int g)
        {
            List<RoundModel> output;
            RoundModel model = new RoundModel();

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonDivisionsID", sdm.SeasonDivisionsID);
                p.Add("@InRoundNumber", g);
                output = connection.Query<RoundModel>("spGetRoundModel", p, commandType: CommandType.StoredProcedure).ToList();
            }

            foreach (RoundModel r in output)
            {
                model = r;
            }
            return model;
        }

        public GameModel CreateGame(GameModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@GameID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@InGameDate", model.GameDate);
                if (model.HomeTeamModel.TeamID != 0)
                {
                    p.Add("@InHomeTeam", model.HomeTeamModel.TeamID);
                }
                else
                {
                    p.Add("@InHomeTeam", null);
                }
                if (model.AwayTeamModel.TeamID != 0)
                {
                    p.Add("@InAwayTeam", model.AwayTeamModel.TeamID);
                }
                else
                {
                    p.Add("@InAwayTeam", null);
                }
                p.Add("@InRoundID", model.RoundID);
                connection.Execute("spGame", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("GameID");
                model.RoundID = Convert.ToInt32(id);

                return model;
            }
        }

        public TeamModel GetBye()
        {
            List<TeamModel> output;
            TeamModel model = new TeamModel();

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                
                output = connection.Query<TeamModel>("spGetBye", commandType: CommandType.StoredProcedure).ToList();
            }

            foreach (TeamModel t in output)
            {
                model = t;
            }
            return model;
        }

        public bool Login(int userID, string password)
        {
            int count = 0;
            bool login = false;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
               
                p.Add("@InUserID", userID);
                p.Add("@InPassword", password);
              
                var c  = connection.ExecuteScalar("spCheckLogin", p, commandType: CommandType.StoredProcedure);
                count = Convert.ToInt32(c);
                if(count != 0)
                {
                    login = true;
                }
            }
            return login;
           
        }

        public List<DateTime> GetGameDatesForSdtp(int sdtpID)
        {
            List<DateTime> output;

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSdtpID", sdtpID);
                output = connection.Query<DateTime>("spGetGameDatesForSdtp",p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<GameModel> GetGameModels(int sdtpID)
        {
            List<GameModel> output;

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSdtpID", sdtpID);
                output = connection.Query<GameModel>("spGetGameModelsForSdtp", p, commandType: CommandType.StoredProcedure).ToList();
            }            
            return output;
        }

        public sdtpModel GetSdtpModel(int sdtpID)
        {
            List<sdtpModel> output;
            sdtpModel sdtp = new sdtpModel();
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSdtpID", sdtpID);
               
                output = connection.Query<sdtpModel>("spGetSdtpModel", p, commandType: CommandType.StoredProcedure).ToList();
            }

            foreach(sdtpModel model in output)
            {
                sdtp = model;
            }
            return sdtp;
        }

        public DivisionTeamsModel GetDivisionTeamModel(int seasonDivisionsID, int teamID)
        {
            List<DivisionTeamsModel> output;
            DivisionTeamsModel dtm = new DivisionTeamsModel();
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonDivisionsID", seasonDivisionsID);
                p.Add("@InTeamID", teamID);

                output = connection.Query<DivisionTeamsModel>("spGetDivisionTeamModel", p, commandType: CommandType.StoredProcedure).ToList();
            }

            foreach (DivisionTeamsModel model in output)
            {
                dtm = model;
            }
            return dtm;
        }

        public List<PersonModel> GetSeasonPlayers(int seasonID)
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InSeasonID", seasonID);
                output = connection.Query<PersonModel>("spGetSeasonPlayers", p, commandType: CommandType.StoredProcedure).ToList();
                //}
            }
            return output;
        }

        public void CreateLogin(int sdtpID, string password)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("InSdtpID", sdtpID);
                p.Add("@InPassword", password);
                connection.Execute("spCreateLogin", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void AddHomePlayers(GameModel thisGame)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("InGameID", thisGame.GameID);
                p.Add("InHomeTeamPlayer1", thisGame.HomeTeamPlayer1.PersonID);
                p.Add("InHomeTeamPlayer2", thisGame.HomeTeamPlayer2.PersonID);
                p.Add("InHomeTeamPlayer3", thisGame.HomeTeamPlayer3.PersonID);
                p.Add("InHomeTeamPlayer4", thisGame.HomeTeamPlayer4.PersonID);
                p.Add("InHomeTeamPlayer5", thisGame.HomeTeamPlayer5.PersonID);
                p.Add("InHomeTeamPlayer6", thisGame.HomeTeamPlayer6.PersonID);
                p.Add("InHomeTeamPlayer7", thisGame.HomeTeamPlayer7.PersonID);
                p.Add("InHomeTeamPlayer8", thisGame.HomeTeamPlayer8.PersonID);

                connection.Execute("spAddHomeTeamPlayers", p, commandType: CommandType.StoredProcedure);
            }
        }

        public HomeTeamPlayersModel GetHomeTeamPlayers(GameModel Gmodel)
        {
            List<HomeTeamPlayersModel> output;

            HomeTeamPlayersModel model = new HomeTeamPlayersModel();

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InGameID", Gmodel.GameID);
                output = connection.Query<HomeTeamPlayersModel>("spGetHomeTeamPlayers", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach(HomeTeamPlayersModel m in output)
            {
                model = m;
            }
            return model;
        }

        public AwayTeamPlayersModel GetAwayTeamPlayers(GameModel Gmodel)
        {
            List<AwayTeamPlayersModel> output;

            AwayTeamPlayersModel model = new AwayTeamPlayersModel();

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InGameID", Gmodel.GameID);
                output = connection.Query<AwayTeamPlayersModel>("spGetAwayTeamPlayers", p, commandType: CommandType.StoredProcedure).ToList();
            }
            foreach (AwayTeamPlayersModel m in output)
            {
                model = m;
            }
            return model;
        }

        public void AddAwayPlayers(GameModel thisGame)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("InGameID", thisGame.GameID);
                p.Add("InAwayTeamPlayer1", thisGame.AwayTeamPlayer1.PersonID);
                p.Add("InAwayTeamPlayer2", thisGame.AwayTeamPlayer2.PersonID);
                p.Add("InAwayTeamPlayer3", thisGame.AwayTeamPlayer3.PersonID);
                p.Add("InAwayTeamPlayer4", thisGame.AwayTeamPlayer4.PersonID);
                p.Add("InAwayTeamPlayer5", thisGame.AwayTeamPlayer5.PersonID);
                p.Add("InAwayTeamPlayer6", thisGame.AwayTeamPlayer6.PersonID);
                p.Add("InAwayTeamPlayer7", thisGame.AwayTeamPlayer7.PersonID);
                p.Add("InAwayTeamPlayer8", thisGame.AwayTeamPlayer8.PersonID);

                connection.Execute("spAddAwayTeamPlayers", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
    
}


//connection.Open();

//string sp = "spPerson";
//// needed to cast connection as MySqlConnection
//MySqlCommand cmd = new MySqlCommand(sp, (MySqlConnection)connection);
//cmd.CommandType = CommandType.StoredProcedure;
//cmd.Parameters.AddWithValue("@PersonID", 0);
//cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
//cmd.Parameters.AddWithValue("@LastName", model.LastName);
//cmd.Parameters.AddWithValue("@email", model.EmailAddress);
//cmd.Parameters.AddWithValue("@phone", model.ContactNumber);
//cmd.Parameters.AddWithValue("@sex", model.Sex);
//cmd.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth);
//MySqlDataReader rdr = cmd.ExecuteReader();
//connection.Close();
//return model;
//string sp = "spPerson";
// needed to cast connection as MySqlConnection
//MySqlCommand cmd = new MySqlCommand(sp, (MySqlConnection)connection);
//cmd.CommandType = CommandType.StoredProcedure;
//MySqlDataReader rdr = cmd.ExecuteReader();
//connection.Close();