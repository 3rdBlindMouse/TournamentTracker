using Dapper;
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

        public DivisionModel CreateDivision(DivisionModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DivisionID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@DivisionName", model.DivisionName);
                p.Add("@DivisionNumber", model.DivisionNumber);
                p.Add("@StartDate", model.StartDate);
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

        public List<RosterModel> CreateRoster(RosterModel model)
        {
            List<RosterModel> roster = new List<RosterModel>();
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (PersonModel player in model.players)
                {
                    var p = new DynamicParameters();
                    p.Add("@RosterID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    p.Add("@PersonID", player.PersonID);
                    p.Add("@TeamID", model.TeamID);


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

        public SeasonModel CreateSeason(SeasonModel model)
        {
            // lesson 10 30:30
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@SeasonID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@SeasonName", model.SeasonName);
                p.Add("@SeasonYear", model.SeasonYear);


                connection.Execute("spSeason", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("SeasonID");
                model.SeasonID = Convert.ToInt32(id);

                return model;
            }
        }





        public SkippedDatesModel CreateSkippedDates(SkippedDatesModel model)
        {


            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@SkippedDatesID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@DivisionID", model.DivisionID);
                p.Add("@DateToSkip", model.DateToSkip);


                connection.Execute("spSkippedDates", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("SkippedDatesID");
                model.SkippedDatesID = Convert.ToInt32(id);

                return model;
            }

        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@TeamName", model.TeamName);
                // TODO sort venues
                p.Add("@TeamVenue", model.TeamVenue);
                //p.Add("@DivisionID", 0);


                connection.Execute("spTeam", p, commandType: CommandType.StoredProcedure);

                // grabs newly created ID from database and returns it as part of the current Person Model
                model.TeamID = p.Get<int>("@TeamID");


                return model;

            }
        }

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

        public List<DivisionModel> GetAllDivisions()
        {
            List<DivisionModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DivisionModel>("spGetAllDivisions").ToList();

                foreach (DivisionModel div in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@DivisionID", div.DivisionID);
                    div.DivisionSkippedDates = connection.Query<SkippedDatesModel>("spGetSkippedDates", p, commandType: CommandType.StoredProcedure).ToList();
                    div.DivisionTeams = connection.Query<TeamModel>("spGetDivisionTeams", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }
            return output;
        }

        public List<TeamModel> GetDivisionTeams(DivisionModel model)
        {
            List<TeamModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DivisionID", model.DivisionID);
                output = connection.Query<TeamModel>("spGetDivisionTeams", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (TeamModel team in output)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamID", team.TeamID);
                    team.TeamMembers = connection.Query<PersonModel>("spGetTeamMembers", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }

        public List<PersonModel> GetAllPeople()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("spGetAllPeople").ToList();
            }
            return output;
        }

        public List<TeamModel> GetAllTeams()
        {
            List<TeamModel> output = new List<TeamModel>();
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("spGetAllTeams").ToList();
            }
            return output;
        }

        public List<VenueModel> GetAllVenues()
        {
            List<VenueModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<VenueModel>("spGetAllVenues").ToList();
            }
            return output;
        }

        public List<PersonModel> GetLastPerson()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("spGetLastPerson").ToList();
            }
            return output;


        }

        public List<SkippedDatesModel> GetSkippedDates(DivisionModel model)
        {
            List<SkippedDatesModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DivisionID", model.DivisionID);
                output = connection.Query<SkippedDatesModel>("spGetSkippedDates", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public void CreateDivisionTeams(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DivisionTeamsID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@InDivisionID", model.DivisionID);
                p.Add("@InTeamID", model.TeamID);


                connection.Execute("spDivisionTeams", p, commandType: CommandType.StoredProcedure);


                // grabs newly created ID from database and returns it as part of the current Person Model
                // https://stackoverflow.com/questions/13151861/fetch-last-inserted-id-form-stored-procedure-in-mysql
                var id = p.Get<int?>("DivisionTeamsID");
                //model.DivisionTeamsID = Convert.ToInt32(id);

                //return model;
            }
        }

        public void EditDivision(DivisionModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InDivisionID", model.DivisionID);
                p.Add("@DivisionName", model.DivisionName);
                p.Add("@DivisionNumber", model.DivisionNumber);
                p.Add("@StartDate", model.StartDate);
                connection.Execute("spEditDivision", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSkippedDates(DivisionModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InDivisionID", model.DivisionID);
                
                connection.Execute("spDeleteSkippedDates", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteDivisionTeams(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@InDivisionID", model.DivisionID);
                p.Add("@InTeamID", model.TeamID);

                connection.Execute("spDeleteDivisionTeams", p, commandType: CommandType.StoredProcedure);
            }
        }

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

        public List<PersonModel> GetTeamMembers(TeamModel model)
        {
            List<PersonModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamID", model.TeamID);
                output = connection.Query<PersonModel>("spGetTeamMembers", p, commandType: CommandType.StoredProcedure).ToList();               
            }
            return output;
        }

        public void CreateTeamCaptain(TeamModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@CaptainID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@TeamID", model.TeamID);
                p.Add("@PersonID", model.TeamCaptain);
                
                connection.Execute("spTeamCaptains", p, commandType: CommandType.StoredProcedure);

                var id = p.Get<int?>("CaptainID");
               // model.TeamCaptain = Convert.ToInt32(id);

               // return model;
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