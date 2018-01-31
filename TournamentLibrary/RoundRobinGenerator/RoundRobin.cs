using System;
using System.Collections.Generic;
using TournamentLibrary.Models;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary.RoundRobinGenerator
{
    public class RoundRobin
    {
        private static int seasonID;

        private static int numOfTeams;

        

        // A list to hold teams from each division
        private static List<TeamModel> teams = new List<TeamModel>();

        // A list to hold the divisions in active season
        private static List<DivisionModel> divs = new List<DivisionModel>();
        // A list of all the IDs in active season
        private static List<sdtpModel> sdtps = new List<sdtpModel>();
        // A dictionary to hold the division teams
        private static Dictionary<SeasonDivisionsModel, TeamModel[]> divTeams = new Dictionary<SeasonDivisionsModel, TeamModel[]>();
        // need this just to have available could be any size as they change as needed
        private static TeamModel[] teamsArray = new TeamModel[1];

    public RoundRobin(int sID)
        {
            seasonID = sID;
            sdtps = GlobalConfig.Connection.GetSdtps(seasonID);

            doDivisionStuff();

            //GenerateGames(teamsArray);
            //Array.Reverse(teamsArray);

            //PrintTeamList(teamsArray);
            //generateGames(teamsArray);
            //Console.ReadLine();
        }

        private void doDivisionStuff()
        {       
            divs = GlobalConfig.Connection.GetSeasonDivisions(seasonID);
            foreach(DivisionModel d in divs)
            {
                SeasonDivisionsModel sdm = GlobalConfig.Connection.GetSeasonDivisionModel(d);                  
                // Do team Stuff
                d.DivisionTeams = GlobalConfig.Connection.GetDivisionTeams(sdm);
                int arraySize = d.DivisionTeams.Count;
                teamsArray = new TeamModel[arraySize];

                if ((arraySize % 2) == 1)
                {
                    TeamModel bye = new TeamModel("Bye", 0);
                    teamsArray = new TeamModel[arraySize + 1];                   
                    teamsArray[arraySize] = bye;
                }
                    int i = 0;
                foreach (TeamModel team in d.DivisionTeams)
                {                  
                    team.TeamMembers = GlobalConfig.Connection.GetSeasonDivisionTeamMembers(seasonID, d.DivisionID, team.TeamID);
                    teamsArray[i] = team;                        
                    i++;  
                }
                // add skipped dates to divisionModel
                List<SkippedDatesModel> skDates = GlobalConfig.Connection.GetSkippedDates(sdm);
                foreach(SkippedDatesModel sk in skDates)
                {
                d.DivisionSkippedDates.Add(sk.DateToSkip);                   
                }
                sdm.skippedDates = skDates;
                divTeams.Add(sdm, teamsArray);

                GenerateGames(teamsArray);
            }

        }


        private static void PrintTeamList(TeamModel[] teamsArray)
        {
            foreach (TeamModel team in teamsArray)
            {
                Console.WriteLine(team.TeamName);
            }

            for (int i = 0; i < teamsArray.Length; i++)
            {
                Console.WriteLine($"Team Array position {i} : {teamsArray[i].TeamName}");
            }
        }
        /*
         * Maintains the value and index of the last value in the array, while rotating the remaining values
         */
        private static TeamModel[] RotateTeams(TeamModel[] teamsArray)
        {
            // capture last value in array 
            TeamModel lastPosition = teamsArray[teamsArray.Length - 1];
            // create a smaller array to hold remaining values
            TeamModel[] smallerTeamArray = new TeamModel[teamsArray.Length - 1];
            for (int i = 0; i < smallerTeamArray.Length; i++)
            {
                smallerTeamArray[i] = teamsArray[i];
            }
            // create a temporary smaller array to rotate values
            TeamModel[] tempTeamsArray = new TeamModel[smallerTeamArray.Length];
            // choose how many positions to rotate
            int rotate = 1;
            // populate temp array with rotated values
            for (int i = 0; i < smallerTeamArray.Length; i++)
            {
                tempTeamsArray[i] = smallerTeamArray[(i + rotate) % smallerTeamArray.Length];
            }
            // repopulate larger array with values and positions from smaller temp array
            for (int i = 0; i < teamsArray.Length - 1; i++)
            {
                teamsArray[i] = tempTeamsArray[i];
            }
            // add captured last value from above to final position in array
            teamsArray[teamsArray.Length - 1] = lastPosition;
            return teamsArray;


        }

        private static void GenerateGames(TeamModel[] teams)
        {
            int numberOfTeams = teams.Length;
            int numberofGamesPerRound = numberOfTeams / 2;
            int numberOfRounds = numberOfTeams - 1;


            for (int i = 0; i < numberOfRounds; i++)
            {
                Console.WriteLine($"Round Number {i + 1}");
                for (int g = 0; g < numberofGamesPerRound; g++)
                {

                    //Console.WriteLine($"Round {a + 1}");
                    Console.WriteLine($"{teams[g].TeamName} PLAYS {teams[numberOfTeams - 1 - g].TeamName} ");

                }
                RotateTeams(teams);
            }

        }
    }

}




