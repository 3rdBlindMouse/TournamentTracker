﻿using System;
using System.Collections.Generic;
using TournamentLibrary.Models;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary.RoundRobinGenerator
{
    public class RoundRobin
    {
        private static int seasonID;

        private static int numOfTeams;

        private static Team[] teamsArray = new Team[numOfTeams];

        // A list to hold teams from each division
        private static List<TeamModel> teams = new List<TeamModel>();

        // A list to hold the divisions in active season
        private static List<DivisionModel> divs = new List<DivisionModel>();
        // A list of all the IDs in active season
        private static List<sdtpModel> sdtps = new List<sdtpModel>();


    public RoundRobin(int sID)
        {
            seasonID = sID;
            sdtps = GlobalConfig.Connection.GetSdtps(seasonID);

            doDivisionStuff(sdtps);
           



            teamsArray = GenerateTeams(teamsArray);
            //PrintTeamList(teamsArray);
            GenerateGames(teamsArray);
            //Array.Reverse(teamsArray);

            //PrintTeamList(teamsArray);
            //generateGames(teamsArray);
            Console.ReadLine();
        }

        private void doDivisionStuff(List<sdtpModel> sdtps)
        {
            //foreach(sdtpModel s in sdtps)
            //{
                divs = GlobalConfig.Connection.GetSeasonDivisions(seasonID);
                foreach(DivisionModel d in divs)
                {
                    SeasonDivisionsModel sdm = GlobalConfig.Connection.GetSeasonDivisionModel(d);                  
                    // Do team Stuff
                    d.DivisionTeams = GlobalConfig.Connection.GetDivisionTeams(sdm);
                    foreach(TeamModel team in d.DivisionTeams)
                    {
                        team.TeamMembers = GlobalConfig.Connection.GetSeasonDivisionTeamMembers(seasonID, d.DivisionID, team.TeamID);
                    }
                    // add skipped dates to divisionModel
                    List<SkippedDatesModel> skDates = GlobalConfig.Connection.GetSkippedDates(sdm);
                        foreach(SkippedDatesModel sk in skDates)
                        {
                        d.DivisionSkippedDates.Add(sk.DateToSkip);

                        }
                    
                }
            //}
        }

        private Team[] GenerateTeams(Team[] teamsArray)
        {
            int numOfTeams = teamsArray.Length;
            if ((numOfTeams % 2) == 1)
            {
                teamsArray = new Team[numOfTeams + 1];
                Team bye = new Team(teamsArray.Length - 1, "--BYE-");
                teamsArray[numOfTeams] = bye;
            }
            for (int i = 0; i < numOfTeams; i++)
            {
                Team team = new Team(i + 1, "Team " + ((i + 1).ToString()));
                teamsArray[i] = team;
            }

            return teamsArray;
        }

        private static void PrintTeamList(Team[] teamsArray)
        {
            foreach (Team team in teamsArray)
            {
                Console.WriteLine(team.teamName);
            }

            for (int i = 0; i < teamsArray.Length; i++)
            {
                Console.WriteLine($"Team Array position {i} : {teamsArray[i].teamName}");
            }
        }
        /*
         * Maintains the value and index of the last value in the array, while rotating the remaining values
         */
        private static Team[] RotateTeams(Team[] teamsArray)
        {
            // capture last value in array 
            Team lastPosition = teamsArray[teamsArray.Length - 1];
            // create a smaller array to hold remaining values
            Team[] smallerTeamArray = new Team[teamsArray.Length - 1];
            for (int i = 0; i < smallerTeamArray.Length; i++)
            {
                smallerTeamArray[i] = teamsArray[i];
            }
            // create a temporary smaller array to rotate values
            Team[] tempTeamsArray = new Team[smallerTeamArray.Length];
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

        private static void GenerateGames(Team[] teams)
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
                    Console.WriteLine($"{teams[g].teamName} PLAYS {teams[numberOfTeams - 1 - g].teamName} ");

                }
                RotateTeams(teams);
            }

        }
    }

}

class Team
{
    public int teamId { get; set; }
    public string teamName { get; set; }

    public Team(int id, string name)
    {
        this.teamId = id;
        this.teamName = name;
    }
}


