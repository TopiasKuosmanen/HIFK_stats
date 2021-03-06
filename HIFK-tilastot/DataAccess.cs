﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HIFK_tilastot
{
    public class DataAccess
    {
        string dataBase = "HIFKDB";

        public List<Person> GetPlayersToEdit(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Person>("dbo.GetPlayersToEdit @Name", new { Name = name }).ToList();
                return output;
            }
        }

        public List<Game> GetOnThisDayGames()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Game>("dbo.GamesOnThisDay", new { }).ToList();
                return output;
            }
        }

        public List<Person> GetBirthdays()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Person>("dbo.BirthdayProcedure", new { }).ToList();
                return output;
            }
        }

        public List<Game> GetGamesToDelete()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Game>("dbo.GetAllGames", new { }).ToList();
                return output;
            }
        }

        public Person AddNewReferee(string firstname, string lastname, DateTime birthday)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Person>("dbo.AddReferee @FirstName, @LastName, @BirthDate",
                    new
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        BirthDate = birthday
                    });

                return output;
            }
        }

        public League AddLeague(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<League>("dbo.AddNewLeague @LeagueName",
                    new
                    {
                        LeagueName = name
                    });
                return output;
            }
        }

        public List<Game> GetAllGames() // List games when adding results
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Game>("dbo.GetGameWithoutTheResult", new { }).ToList();
                return output;
            }
        }

        public List<STATS> GetAllStats(string leagues, string opponents, DateTime start, DateTime end, string player)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<STATS>("dbo.GetStatsWithParameters @Leagues, @Opponents, @Startingday, @EndingDay, @Player",
                    new
                    {
                        Leagues = leagues,
                        Opponents = opponents,
                        StartingDay = start,
                        EndingDay = end,
                        Player = player
                    }).ToList();
                return output;
            }
        }

        public List<OpponentGoal> GetOpponentGoals(string leagues, string opponents, DateTime start, DateTime end, bool winner, bool penalty, int? min, int? max)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<OpponentGoal>("dbo.GetOpponentGoals @Leagues, @Opponents, @StartingDay, @EndingDay, @Winner, @Penalty, @Min, @Max",
                    new
                    {
                        Leagues = leagues,
                        Opponents = opponents,
                        StartingDay = start,
                        EndingDay = end,
                        Winner = winner,
                        Penalty = penalty,
                        Min = min,
                        Max = max
                    }).ToList();
                return output;
            }
        }

        public List<GOAL> GetGoals(string leagues, string opponents, DateTime start, DateTime end, string player, bool winner, bool penalty, string assist, int? min, int? max)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<GOAL>("dbo.GetGoals @Leagues, @Opponents, @StartingDay, @EndingDay, @Player, @Winner, @Penalty, @Assist, @Min, @Max",
                    new
                    {
                        Leagues = leagues,
                        Opponents = opponents,
                        StartingDay = start,
                        EndingDay = end,
                        Player = player,
                        Winner = winner,
                        Penalty = penalty,
                        Assist = assist,
                        Min = min,
                        Max = max
                    }).ToList();
                return output;
            }
        }

        public List<Person> GetPlayersNames() // Used in AddNewPlayer; checking duplicate values
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Person>("dbo.GetPlayersNames", new { }).ToList();
                return output;
            }
        }

        public List<PlayerPosition> GetPlayersPositions(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<PlayerPosition>("dbo.GetPlayersPositions @Id", new { Id = id }).ToList();
                return output;
            }
        }

        public List<League> GetLeagues()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<League>("dbo.LeagueProcedure", new { }).ToList();
                return output;
            }
        }

        public Game DeleteGame(string serie, int id, string result)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Game>("dbo.DeleteGame @League, @GameId, @Result",
                    new
                    {
                        League = serie,
                        GameId = id,
                        Result = result
                    });
                return output;
            }
        }

        public List<PlayerNationality> GetPlayersNationalities(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<PlayerNationality>("dbo.GetPlayersNationalities @Id", new { Id = id }).ToList();
                return output;
            }
        }

        public List<Opponent> GetOpponents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Opponent>("dbo.OpponentProcedure", new { }).ToList();
                return output;
            }
        }

        public Person UpdatePlayerInformation(int playerid, string firstname, string lastname, int number, int year, DateTime contractends, DateTime bday)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Person>("dbo.UpdatePlayer @Id, @FirstName, @LastName, @Number, @YearOfAccession, @ContractEndDate, @BirthDate",
                    new
                    {
                        Id = playerid,
                        FirstName = firstname,
                        LastName = lastname,
                        Number = number,
                        YearOfAccession = year,
                        ContractEndDate = contractends,
                        BirthDate = bday
                    });
                return output;
            }
        }

        public List<Person> GetAllPlayers(DateTime date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Person>("dbo.GetAllPlayers @DateTime", new { DateTime = date }).ToList();
                return output;
            }
        }

        public List<Stadium> GetStadiums()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Stadium>("dbo.StadiumProcedure", new { }).ToList();
                return output;
            }
        }

        public List<STATS> GetPlayerStats(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<STATS>("dbo.Player_FilterByName @PlayerName", new { PlayerName = name }).ToList();
                return output;
            }
        }

        public List<Stadium> GetStadiumByTeam(string team)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Stadium>("dbo.HomeStadiumByTeam @Team", new { Team = team }).ToList(); 
                return output;
            }
        }



        public List<Game> GetResults(string league, DateTime startingday, DateTime endingday)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Game>("dbo.ResultsByLeague @League, @StartingDay, @EndingDay", new { League = league, StartingDay = startingday, EndingDay = endingday }).ToList();
                return output;
            }
        }

        public List<Game> GetFixtures(string league)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Game>("dbo.FixturesByLeague @League", new { League = league, }).ToList();
                return output;
            }
        }

        public Person AddNewPlayer(string firstname, string lastname, int shirtnumber, int startingyear, DateTime contractends, DateTime birthday, string position, string nationality)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Person>("dbo.AddPlayerProcedure @FirstName, @LastName, @Number, @YearOfAccession, @ContractEndDate, @BirthDate", 
                    new { FirstName = firstname, LastName = lastname, Number = shirtnumber,
                          YearOfAccession = startingyear, ContractEndDate = contractends, BirthDate = birthday });

                return output;
            }
        }

        public List<Person> GetPersonId(string firstname, string lastname, DateTime birthday) // Used in AddNewPlayer to add a nationality
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output2 = connection.Query<Person>("dbo.PersonByNameAndBirthday @FirstName, @LastName, @Birthday",
                    new { FirstName = firstname, LastName = lastname, Birthday = birthday }).ToList();
                return output2;
            }

        }

        public Game AddNewGame(string league, string opponent, DateTime datetime, Boolean homegame, string stadium, Boolean extratime, Boolean penalties)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Game>("dbo.AddGameProcedure @League, @Opponent, @DateTime, @Homegame, @Stadium, @ExtraTime, @Penalties",
                    new
                    {
                        League = league,
                        Opponent = opponent,
                        DateTime = datetime,
                        Homegame = homegame,
                        Stadium = stadium,
                        ExtraTime = extratime,
                        Penalties = penalties

                    });
                return output;
            }
        }

        public Person AddPlayerToStatsTables(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Person>("dbo.AddPlayerToStatsTables @PlayerId",
                    new
                    {
                        PlayerId = id
                    });
                return output;
            }
        }

        public Person AddPositions(int id, string position)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Person>("dbo.AddPlayersPosition @PlayerId, @Position",
                    new
                    {
                        PlayerId = id,
                        Position = position
                    });
                return output;
            }
        }

        public List<Person> GetAllReferees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<Person>("dbo.GetAllReferees", new { }).ToList();
                return output;
            }
        }

        public Person AddNationalities(int id, string nationality)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Person>("dbo.AddPlayersNationality @PlayerId, @Nationality",
                    new
                    {
                        PlayerId = id,
                        Nationality = nationality
                    });
                return output;
            }
        }


        public List<PlayerNationality> GetNationalities()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<PlayerNationality>("dbo.NationalityProcedure", new { }).ToList();
                return output;
            }
        }
        public List<PlayerPosition> GetPositions()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.Query<PlayerPosition>("dbo.PositionProcedure", new { }).ToList();
                return output;
            }
        }

        public Game AddResult(int id, string result, int resultcode, int? attendance, int? referee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Game>("dbo.AddResult @Id, @Result, @ResultCode, @Attendance, @Referee",
                    new
                    {
                        Id = id,
                        Result = result,
                        ResultCode = resultcode,
                        Attendance = attendance,
                        Referee = referee
                    });
                return output;
            }
        }

        public STATS AddStats(string league, int playerid, int gameid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<STATS>("dbo.AddStats @League, @PlayerId, @GameId",
                    new
                    {
                        League = league,
                        PlayerId = playerid,
                        GameId = gameid,
                    });
                return output;
            }
        }

        public STATS AddStatsByGameId(string league, int playerid, int gameid, int goals, int assists, int yc, int rc, int pm, int starting, int sub, int bench)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<STATS>("dbo.AddStatsByGameId @League, @PlayerId, @GameId, @Goals, @Assists, @YellowCards, @RedCards, @PlayedMinutes, @StartingXI, @SubstitutedIn, @OnTheBench",
                    new
                    {
                        League = league,
                        PlayerId = playerid,
                        GameId = gameid,
                        Goals = goals,
                        Assists = assists,
                        YellowCards = yc,
                        RedCards = rc,
                        PlayedMinutes = pm,
                        StartingXI = starting,
                        SubstitutedIn = sub,
                        OnTheBench = bench
                    });
                return output;
            }
        }

        public Opponent AddNewOpponent(string team, string stadium)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Opponent>("dbo.AddNewOpponent @Team, @Stadium",
                    new
                    {
                        Team = team,
                        Stadium = stadium
                    });

                return output;
            }
        }

        public Stadium AddNewStadium(string stadium, int capacity, string turf)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<Stadium>("dbo.AddNewStadium @StadiumName, @Capacity, @Turf",
                    new
                    {
                        StadiumName = stadium,
                        Capacity = capacity,
                        Turf = turf
                    });

                return output;
            }
        }
        public GOAL AddGoal(int gameid, string goal, bool winner, int player, int? assist, bool penalty, int minute)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<GOAL>("dbo.AddGoal @GameId, @Goal, @Winner, @Player, @Assist, @Penalty, @Minute",
                    new
                    {
                        GameId = gameid,
                        Goal = goal,
                        Winner = winner,
                        Player = player,
                        Assist = assist,
                        Penalty = penalty,
                        Minute = minute
                    });

                return output;
            }
        }
        public OpponentGoal AddOpponentGoal(int gameid, string goal, bool winner, bool penalty, int minute)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal($"{dataBase}")))
            {
                var output = connection.ExecuteScalar<OpponentGoal>("dbo.AddOpponentsGoal @GameId, @Goal, @Winner, @Penalty, @Minute",
                    new
                    {
                        GameId = gameid,
                        Goal = goal,
                        Winner = winner,
                        Penalty = penalty,
                        Minute = minute
                    });

                return output;
            }
        }

    }

}
