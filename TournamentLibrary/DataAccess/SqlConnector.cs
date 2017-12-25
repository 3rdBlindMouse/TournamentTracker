
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public DivisionModel CreateDivision(DivisionModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves a new Person to the Sql database
        /// </summary>
        /// <param name="model">The Person Information</param>
        /// <returns>The Person information, including the unique identifier</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("tournament")))
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
                model.PersonID = p.Get<int>("@PersonID");


                return model;

            }
        }

        public SeasonModel CreateSeason(SeasonModel model)
        {
            throw new NotImplementedException();
        }

        public SkippedDatesModel CreateSkippedDatesModel(SkippedDatesModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetAllPeople()
        {
            throw new NotImplementedException();
        }
    }
}
