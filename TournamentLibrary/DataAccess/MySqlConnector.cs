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
                //var p = new DynamicParameters();
                //p.Add("@DivisionID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                //p.Add("@DivisionName", model.DivisionName);
                //p.Add("@DivisionNumber", model.DivisionNumber);
                //p.Add("@email", model.);
                //p.Add("@phone", model.ContactNumber);
                //p.Add("@sex", model.Sex);
                //p.Add("@DateOfBirth", model.DateOfBirth);

                //connection.Execute("spPerson", p, commandType: CommandType.StoredProcedure);
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
                p.Add("@email", model.EmailAddress);
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





        public SkippedDatesModel CreateSkippedDatesModel(SkippedDatesModel model)
        {


            return model;

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