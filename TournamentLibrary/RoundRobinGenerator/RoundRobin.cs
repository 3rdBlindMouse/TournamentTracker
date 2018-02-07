using System;
using System.Collections.Generic;
using TournamentLibrary.Models;
using TournamentLibrary.DataAccess;
using System.Linq;

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


        private static Dictionary<DivisionModel, List<GameModel>> divGames = new Dictionary<DivisionModel, List<GameModel>>();

        private static Dictionary<DivisionModel, List<RoundModel>> divRounds = new Dictionary<DivisionModel, List<RoundModel>>();

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
            foreach (DivisionModel d in divs)
            {
                SeasonDivisionsModel sdm = GlobalConfig.Connection.GetSeasonDivisionModel(d);
                // Do team Stuff
                divTeams = doTeamStuff(sdm, d);

                divRounds = doRoundStuff(sdm, d);
                divGames = GenerateGames(sdm, d,teamsArray);
            }
        }

       

        private Dictionary<DivisionModel, List<GameModel>> GenerateGames
            (SeasonDivisionsModel sdm, DivisionModel d, TeamModel[] teams)
        {
            divGames = new Dictionary<DivisionModel, List<GameModel>>();
            // Create a List to hold games in the division
            List<GameModel> roundGames = new List<GameModel>();
            // New Game Model for each game
            GameModel game = new GameModel();
            int numberOfTeams = teams.Length;
            // 
            int numberofGamesPerRound = numberOfTeams / 2;
            // round robin number of rounds is one less than the number of teams
            int numberOfRounds = numberOfTeams - 1;

            RoundModel rm = new RoundModel();

            
            Console.WriteLine($"{d.DivisionName}");
            for (int i = 0; i < numberOfRounds; i++)
            {
                Console.WriteLine($"Round Number {i + 1}");
                // g + 1 else get a blank team team rounds start at 1
                rm = GlobalConfig.Connection.getRoundModel(sdm, i + 1);
                
                for (int g = 0; g < numberofGamesPerRound; g++)
                {
                    game.RoundID = rm.RoundID;
                    game.GameDate = rm.RoundDate;
                    //Console.WriteLine($"Round {a + 1}");
                    Console.WriteLine($"{teams[g].TeamName} PLAYS {teams[numberOfTeams - 1 - g].TeamName} ");
                    game.HomeTeam = teams[g];
                    game.HomeTeamPlayers = teams[g].TeamMembers;
                    game.AwayTeam = teams[numberOfTeams - 1 - g];
                    game.AwayTeamPlayers = teams[numberOfTeams - 1 - g].TeamMembers;
                    
                    roundGames.Add(game);
                    GlobalConfig.Connection.CreateGame(game);
                    
                }

                RotateTeams(teams);
            }
            divGames.Add(d, roundGames);
            return divGames;
        }


        private Dictionary<DivisionModel, List<RoundModel>> doRoundStuff(SeasonDivisionsModel sdm, DivisionModel d)
        {
            List<RoundModel> rounds = new List<RoundModel>();
            DateTime startDate;
            int RoundNumber = 1;
            DateTime roundDate;

            // Start Date of Division 
            startDate = sdm.StartDate;
            // New Round Model for each Round in Division
            RoundModel rm = new RoundModel();
            // Division ID for round Model
            rm.SeasonDivisionsID = sdm.SeasonDivisionsID;
            // intial date of current date providing date is not a skipped date
            roundDate = startDate;
            int roundLength;
            // If divisionTeamsCount is Odd means a bye is added
            if (d.DivisionTeams.Count % 2 == 1)
            {
                roundLength = d.DivisionTeams.Count;
            }
            else
            // If no bye added number of rounds is one less than number of teams
            {
                roundLength = d.DivisionTeams.Count - 1;
            }
            for (int i = 0; i < roundLength; i++)
            {
                // Iterate round number
                rm.RoundNumber = RoundNumber++;
                // if RoundDate is a skipped date
                if (isSkippedDate(d, roundDate))
                {
                    // could be mutiple skipped dates in a row
                    while (isSkippedDate(d, roundDate))
                    {
                        roundDate = roundDate.AddDays(7);
                        rm.RoundDate = roundDate;
                    }
                }
                else
                {
                    rm.RoundDate = roundDate;
                }
                GlobalConfig.Connection.CreateRound(rm);
                rounds.Add(rm);

                roundDate = roundDate.AddDays(7);
            }
            d.DivisionRounds = rounds;

            divRounds.Add(d, rounds);

            return divRounds;

        }

        private Dictionary<SeasonDivisionsModel, TeamModel[]> doTeamStuff(SeasonDivisionsModel sdm, DivisionModel d)
        {
            d.DivisionTeams = GlobalConfig.Connection.GetDivisionTeams(sdm);
            // TODO work out where teams is best places division or sdm
            sdm.teams = d.DivisionTeams;
            int arraySize = d.DivisionTeams.Count;
            teamsArray = new TeamModel[arraySize];

            if ((arraySize % 2) == 1)
            {
                TeamModel bye = GlobalConfig.Connection.GetBye();
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
            foreach (SkippedDatesModel sk in skDates)
            {
                d.DivisionSkippedDates.Add(sk.DateToSkip);
            }
            sdm.skippedDates = skDates;
            divTeams.Add(sdm, teamsArray);

            return divTeams;
        }

        //private void GenerateRounds(List<DivisionModel> dms)
        //{
        //    List<RoundModel> rounds = new List<RoundModel>();
        //    DateTime startDate;
        //    int RoundNumber = 1;
        //    DateTime roundDate;

        //    foreach(DivisionModel d in divs)
        //    {
        //        SeasonDivisionsModel sdm = GlobalConfig.Connection.GetSeasonDivisionModel(d);
        //        // Start Date of Division 
        //        startDate = d.StartDate;
        //        // New Round Model for each Round in Division
        //        RoundModel rm = new RoundModel();
        //        // Division ID for round Model
        //        rm.SeasonDivisionsID = sdm.SeasonDivisionsID;     
        //        // intial date of current date providing date is not a skipped date
        //        roundDate = startDate;
        //        int roundLength;
        //        // If divisionTeamsCount is Odd means a bye is added
        //        if(d.DivisionTeams.Count %2 == 1)
        //        {
        //            roundLength = d.DivisionTeams.Count;
        //        }
        //        else
        //        // If no bye added number of rounds is one less than number of teams
        //        {
        //            roundLength = d.DivisionTeams.Count - 1;
        //        }
        //        for (int i = 0; i < roundLength; i++)
        //        {
        //            // Iterate round number
        //            rm.RoundNumber = RoundNumber++;
        //            // if RoundDate is a skipped date
        //            if (isSkippedDate(d, roundDate))
        //            {
        //                // could be mutiple skipped dates in a row
        //                while (isSkippedDate(d, roundDate))
        //                {
        //                    roundDate = roundDate.AddDays(7);
        //                    rm.RoundDate = roundDate;
        //                }
        //            }
        //            else
        //            {
        //                rm.RoundDate = roundDate;
        //            }
        //            GlobalConfig.Connection.CreateRound(rm);
        //            rounds.Add(rm);

        //            roundDate = roundDate.AddDays(7);
        //        }
        //        d.DivisionRounds = rounds;
        //    }
        //}

        private static bool isSkippedDate(DivisionModel d, DateTime roundDate)
        {
            bool output = false;

            if (d.DivisionSkippedDates.Any(x => x.Date == roundDate))
            {
                output = true;
            }

            return output;
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


    }
}




