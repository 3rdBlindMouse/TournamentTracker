using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess.TextProcessor
{
   
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Extension method returns full file path of PersonModel.csv
        /// </summary>
        public static string FullFilePath(this string fileName) // PersonModel.csv
        {
            return $"{ConfigurationManager.AppSettings["filepath"]}\\{fileName}";
        }
        /// <summary>
        /// Loads lines of file if file exists else returns an empty list
        /// </summary>
        /// <param name="file"></param>
        /// <returns>A ist of string</returns>
        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// Takes in a list of strings and converts them to a list of Person Model
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>A list of Person Models</returns>
        public static List<PersonModel> convertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');

                PersonModel p = new PersonModel();
                p.PersonID = int.Parse(columns[0]);
                p.FirstName = columns[1];
                p.LastName = columns[2];
                p.EmailAddress = columns[3];
                p.ContactNumber = columns[4];
                p.Sex = columns[5];
                p.DateOfBirth = DateTime.Parse(columns[6]);

                output.Add(p);
            }
            return output;
        }
        /// <summary>
        /// Take a list of PersonModels and filename
        /// Converts PersonModels lis to a List of string
        /// Saves file
        /// </summary>
        /// <param name="models"></param>
        /// <param name="filename"></param>
        public static void saveToPersonFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach(PersonModel p in models)
            {
                lines.Add($"{p.PersonID},{p.FirstName},{p.LastName},{p.EmailAddress},{p.ContactNumber},{p.Sex},{p.DateOfBirth}");
                File.WriteAllLines(filename.FullFilePath(),lines);
            }
        }
    }
}
