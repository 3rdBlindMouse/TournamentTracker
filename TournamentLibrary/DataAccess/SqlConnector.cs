
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
        public void EditDivision(DivisionModel model)
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
                p.Add("@email", model.Email);
                p.Add("@phone", model.ContactNumber);
                p.Add("@sex", model.Sex);
                p.Add("@DateOfBirth", model.DateOfBirth);

                connection.Execute("spPerson", p, commandType: CommandType.StoredProcedure);

                // grabs newly created ID from database and returns it as part of the current Person Model
                model.PersonID = p.Get<int>("@PersonID");


                return model;

            }
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
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("tournament")))
            {
                var p = new DynamicParameters();
                p.Add("@TeamID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@TeamName", model.TeamName);
                //p.Add("@TeamVenue", model.TeamVenue);


                connection.Execute("spTeam", p, commandType: CommandType.StoredProcedure);

                // grabs newly created ID from database and returns it as part of the current Person Model
                model.TeamID = p.Get<int>("@TeamID");


                return model;
            }
            }

        public VenueModel CreateVenue(VenueModel model)
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

        public List<TeamModel> GetDivisionTeams()
        {
            throw new NotImplementedException();
        }

        public List<VenueModel> GetAllVenues()
        {
            throw new NotImplementedException();
        }

        public PersonModel GetLastPerson()
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

        public void CreateDivisionTeams(TeamModel teammodel)
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public DivisionModel CreateDivision(DivisionModel model)
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
    }
}
