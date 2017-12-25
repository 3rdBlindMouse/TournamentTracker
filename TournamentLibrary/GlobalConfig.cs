using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary
{
    /// <summary>
    /// Always visible to everyone
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// only methods inside global config and change value 
        /// of connections, but everyone can read values.
        /// </summary>
        public static IDataConnection Connection { get; private set; } 
        /// <summary>
        /// will be called at very beginning of application to set up connections
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textfiles"></param>
        public static void InitialiseConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.MySql:
                    MySqlConnector mySql = new MySqlConnector();
                    Connection = mySql;
                    break;
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.textfile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                default:
                    break;
            }
            //if(db == DatabaseType.MySql)
            //{
            //    // TODO - Create the MySQL connection
                
            //}
            //else if(db == DatabaseType.MySql)
            //{
            //    // TODO - Create the SQL connection
                
            //}
            //else if (db == DatabaseType.textfile)
            //{
            //    //TODO - Create Text Connection
                
            //}
        }


        /// <summary>
        /// Retrieves connections string of Database from app.config
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }
    }
}
