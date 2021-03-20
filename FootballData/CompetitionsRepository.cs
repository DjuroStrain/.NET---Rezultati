using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace FootballData
{
    public class CompetitionsRepository
    {
        String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }


        public void GetCountries()
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Belacic_Competitions";
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
            List<CompetitionsClass> competitions = new List<CompetitionsClass>();
            string URL = "https://apiv2.apifootball.com/?action=get_leagues&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
            string comp = CallRestMethod(URL);
            JArray JSON = JArray.Parse(comp);
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            {
                oConnection.Open();
                foreach (JObject item in JSON)
                {
                    if ((string)item.GetValue("league_season") == "2020/2021")
                    {
                        CompetitionsClass c1 = new CompetitionsClass()
                        {
                            CountryID = (string)item.GetValue("country_id"),
                            CountryName = (string)item.GetValue("country_name"),
                            LeagueID = (string)item.GetValue("league_id"),
                            LeagueName = (string)item.GetValue("league_name"),
                            LeagueSeason = (string)item.GetValue("league_season")
                        };

                        competitions.Add(c1);
                        if (c1.LeagueName.Contains("'"))
                        {
                            for (int i = 0; i < c1.LeagueName.Length; i++)
                            {
                                c1.LeagueName = c1.LeagueName.Remove(i, 1);
                            }
                        }

                        using (DbCommand oCommand = oConnection.CreateCommand())
                        {
                            oCommand.CommandText = "INSERT INTO [Belacic_Competitions] (Country_Id, Country_Name, League_Id, League_Name, League_Season) VALUES ('" + c1.CountryID + "','" + c1.CountryName + "','" + c1.LeagueID + "', '" + c1.LeagueName + "','" + c1.LeagueSeason + "');";
                            using (DbDataReader oReader = oCommand.ExecuteReader())
                            {

                            }
                        }

                    }
                }
                oConnection.Close();
            }
        }

        public List<CompetitionsClass> GetCompetitons()
        {
            List<CompetitionsClass> competitionsClass = new List<CompetitionsClass>();
            using(DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Belacic_Competitions";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        competitionsClass.Add(new CompetitionsClass()
                        {
                            CountryID = (string)reader["Country_Id"],
                            CountryName = (string)reader["Country_Name"],
                            LeagueID = (string)reader["League_Id"],
                            LeagueName = (string)reader["League_Name"],
                            LeagueSeason = (string)reader["League_Season"]
                        });
                    }
                }
            }
            return competitionsClass;
        }

        public List<CompetitionInfo> GetCompetitonsInfoShort(string LeagueName)
        {
            List<CompetitionInfo> competitionsInfo = new List<CompetitionInfo>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                using (DbCommand command2 = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Belacic_CompetitionInfo WHERE [League_Name]='" + LeagueName + "'";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitionsInfo.Add(new CompetitionInfo
                            {
                                clubName = (string)reader["Club_Name"],
                                TeamId = (string)reader["Team_Id"],
                                LeagueID = (string)reader["League_Id"],
                                LeagueName = (string)reader["League_Name"],
                                Position = (string)reader["Position"],
                                Points = (string)reader["Points"]
                            });
                        }
                    }
                }

            }
            return competitionsInfo;

        }

        public List<CompetitionInfo> GetCompetitonsInfo(string LeagueName)
        {
            List<CompetitionInfo> competitionsInfo = new List<CompetitionInfo>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                using (DbCommand command2 = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Belacic_CompetitionInfo WHERE [League_Name]='"+LeagueName+"'";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitionsInfo.Add(new CompetitionInfo
                            {
                                clubName = (string)reader["Club_Name"],
                                TeamId = (string)reader["Team_Id"],
                                LeagueID = (string)reader["League_Id"],
                                CountryName = (string)reader["Country_Name"],
                                LeagueName = (string)reader["League_Name"],
                                Position = (string)reader["Position"],
                                MatchWin = (string)reader["Match_Win"],
                                MatchDraw = (string)reader["Match_Draw"],
                                MatchLose = (string)reader["Match_Lose"],
                                MatchPlayed = (string)reader["Match_Played"],
                                GoalsScored = (string)reader["Goals_Scored"],
                                GoalsGet = (string)reader["Goals_Get"],
                                Points = (string)reader["Points"]
                            });
                        }
                    }
                }

            }
            return competitionsInfo;
        }
        public List<CompetitionInfo> refreshInfo(CompetitionInfo info)
        {
            //string date = DateTime.Now.ToString("yyyy-MM-dd");
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();
            List<CompetitionsClass> leaguesid = new List<CompetitionsClass>();
            string URL2 = "https://apiv2.apifootball.com/?action=get_leagues&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
            string comp2 = CallRestMethod(URL2);
            JArray JSON2 = JArray.Parse(comp2);
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            {
                oConnection.Open();
                foreach (JObject item in JSON2)
                {
                    leaguesid.Add(new CompetitionsClass
                    {
                        LeagueID = (string)item.GetValue("league_id"),
                    });
                }

            }
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Belacic_CompetitionInfo";
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
            List<CompetitionInfo> competitionInfo = new List<CompetitionInfo>();
            for (int i = 0; i < leaguesid.Count; i++)
            {
                string URL4 = $"https://apiv2.apifootball.com/?action=get_standings&from=2020-09-01&league_id={leaguesid[i].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
                string comp5 = CallRestMethod(URL4);
                JArray JSON5 = JArray.Parse(comp5);
                using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
                {
                    oConnection.Open();
                    foreach (JObject item in JSON5)
                    {
                        CompetitionInfo c1 = new CompetitionInfo()
                        {
                            clubName = (string)item.GetValue("team_name"),
                            TeamId = (string)item.GetValue("team_id"),
                            LeagueID = (string)item.GetValue("league_id"),
                            LeagueName = (string)item.GetValue("league_name"),
                            CountryName = (string)item.GetValue("country_name"),
                            Position = (string)item.GetValue("overall_league_position"),
                            MatchWin = (string)item.GetValue("overall_league_W"),
                            MatchDraw = (string)item.GetValue("overall_league_D"),
                            MatchLose = (string)item.GetValue("overall_league_L"),
                            MatchPlayed = (string)item.GetValue("overall_league_payed"),
                            GoalsScored = (string)item.GetValue("overall_league_GF"),
                            GoalsGet = (string)item.GetValue("overall_league_GA"),
                            Points = (string)item.GetValue("overall_league_PTS")
                        };
                        competitionInfo.Add(c1);

                        if (c1.clubName.Contains("'"))
                        {
                            for (int j = 0; j < c1.clubName.Length; j++)
                            {
                                c1.clubName = c1.clubName.Remove(j, 1);
                            }
                        }

                        if (c1.clubName.Contains("'"))
                        {
                            for (int j = 0; j < c1.clubName.Length; j++)
                            {
                                c1.clubName = c1.clubName.Replace("'", "");
                            }
                        }

                        if (c1.LeagueID.Contains("'"))
                        {
                            for (int j = 0; j < c1.LeagueID.Length; j++)
                            {
                                c1.LeagueID = c1.LeagueID.Remove(j, 1);
                            }
                        }
                        if (c1.LeagueName.Contains("'"))
                        {
                            for (int j = 0; j < c1.LeagueName.Length; j++)
                            {
                                c1.LeagueName = c1.LeagueName.Remove(j, 1);
                            }
                        }

                        if (c1.CountryName.Contains("'"))
                        {
                            for (int j = 0; j < c1.CountryName.Length; j++)
                            {
                                c1.CountryName = c1.CountryName.Remove(j, 1);
                            }
                        }
                        if (c1.Position.Contains("'"))
                        {
                            for (int j = 0; j < c1.Position.Length; j++)
                            {
                                c1.Position = c1.Position.Remove(j, 1);
                            }
                        }

                        using (DbCommand oCommand = oConnection.CreateCommand())
                        {
                            oCommand.CommandText = "INSERT INTO [Belacic_CompetitionInfo] (Club_Name,Team_Id, League_Id,League_Name, Country_Name, Position, Match_Win, Match_Draw, Match_Lose, Match_Played, Goals_Scored, Goals_Get, Points) VALUES ('" + (c1.clubName) + "','" + c1.TeamId + "','" + c1.LeagueID + "','" + c1.LeagueName + "','" + c1.CountryName + "', '" + c1.Position + "','" + c1.MatchWin + "','" + c1.MatchDraw + "','" + c1.MatchLose + "','" + c1.MatchPlayed + "','" + c1.GoalsScored + "','" + c1.GoalsGet + "','" + c1.Points + "');";
                            using (DbDataReader oReader = oCommand.ExecuteReader())
                            {

                            }
                        }

                    }
                    oConnection.Close();
                }
            }

            List<CompetitionInfo> competitionsInfo2 = new List<CompetitionInfo>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                using (DbCommand command2 = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Belacic_CompetitionInfo WHERE League_Name= '" + info.LeagueName + "'";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitionsInfo2.Add(new CompetitionInfo
                            {
                                clubName = (string)reader["Club_Name"],
                                TeamId = (string)reader["Team_Id"],
                                LeagueID = (string)reader["League_Id"],
                                CountryName = (string)reader["Country_Name"],
                                LeagueName = (string)reader["League_Name"],
                                Position = (string)reader["Position"],
                                MatchWin = (string)reader["Match_Win"],
                                MatchDraw = (string)reader["Match_Draw"],
                                MatchLose = (string)reader["Match_Lose"],
                                MatchPlayed = (string)reader["Match_Played"],
                                GoalsScored = (string)reader["Goals_Scored"],
                                GoalsGet = (string)reader["Goals_Get"],
                                Points = (string)reader["Points"]
                            });
                        }
                    }
                }

            }
            return competitionsInfo2;
        }

        public List<TeamInfo> GetTeamInfo(TeamInfo teamInfo)
        {
            List<TeamInfo> TeamInfoList = new List<TeamInfo>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Belacic_TeamInfo WHERE Team_Id ="+teamInfo.TeamId;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TeamInfoList.Add(new TeamInfo
                        {
                            ClubName = (string)reader["Club_Name"],
                            TeamId = (string)reader["Team_Id"],
                            PlayerName = (string)reader["Player_Name"],
                            PlayerNumber = (string)reader["Player_Number"],
                            PlayerCountry = (string)reader["Player_Country"],
                            PlayerPosition = (string)reader["Player_Position"],
                            PlayerAge = (string)reader["Player_Age"]
                        });
                    }
                }
            }
            return TeamInfoList;
        }

        public List<TeamInfo> RefreshTeamInfo(TeamInfo teamInfo)
        {
            List<CompetitionsClass> leaguesid = new List<CompetitionsClass>();
            string URL2 = "https://apiv2.apifootball.com/?action=get_leagues&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
            string comp2 = CallRestMethod(URL2);
            JArray JSON2 = JArray.Parse(comp2);
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            {
                oConnection.Open();
                foreach (JObject item in JSON2)
                {
                    leaguesid.Add(new CompetitionsClass
                    {
                        LeagueID = (string)item.GetValue("league_id"),
                    });
                }

            }
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Belacic_TeamInfo";
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
            for (int j = 0; j < leaguesid.Count; j++)
            {
                List<TeamInfo> lTeamInfo = new List<TeamInfo>();
                string URL9 = $"https://apiv2.apifootball.com/?action=get_teams&league_id={leaguesid[j].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
                string comp9 = CallRestMethod(URL9);
                JArray JSON9 = JArray.Parse(comp9);
                using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
                {
                    oConnection.Open();
                    foreach (JObject item in JSON9)
                    {
                        var json2 = item["players"].ToList();
                        for (int b = 0; b < json2.Count; b++)
                        {
                            TeamInfo c1 = new TeamInfo()
                            {
                                ClubName = (string)item.GetValue("team_name"),
                                TeamId = (string)item.GetValue("team_key"),
                                PlayerName = (string)json2[b]["player_name"],
                                PlayerNumber = (string)json2[b]["player_number"],
                                PlayerCountry = (string)json2[b]["player_country"],
                                PlayerAge = (string)json2[b]["player_age"],
                                PlayerPosition = (string)json2[b]["player_type"],
                            };
                            lTeamInfo.Add(c1);
                            if (c1.PlayerName.Contains("'"))
                            {
                                for (int i = 0; i < c1.PlayerName.Length; i++)
                                {
                                    c1.PlayerName = c1.PlayerName.Remove(i, 1);
                                }
                            }
                            if (c1.PlayerName.Contains("'"))
                            {
                                for (int i = 0; i < c1.PlayerName.Length; i++)
                                {
                                    c1.PlayerName = c1.PlayerName.Replace("'", "\"");
                                }
                            }
                            if (c1.ClubName.Contains("'"))
                            {
                                for (int i = 0; i < c1.ClubName.Length; i++)
                                {
                                    c1.ClubName = c1.ClubName.Remove(i, 1);
                                }
                            }
                            if (c1.ClubName.Contains("'"))
                            {
                                for (int i = 0; i < c1.ClubName.Length; i++)
                                {
                                    c1.ClubName = c1.ClubName.Replace("'", "\"");
                                }
                            }

                            using (DbCommand oCommand = oConnection.CreateCommand())
                            {
                                oCommand.CommandText = "INSERT INTO [Belacic_TeamInfo] (Player_Name,Club_Name,Team_Id, Player_Number,Player_Country,PLayer_Position, Player_Age) VALUES ('" + c1.PlayerName + "','" + c1.ClubName + "','" + c1.TeamId + "', '" + c1.PlayerNumber + "', '" + c1.PlayerCountry + "', '" + c1.PlayerPosition + "', '" + c1.PlayerAge + "');";
                                using (DbDataReader oReader = oCommand.ExecuteReader())
                                {

                                }
                            }
                        }

                    }
                    oConnection.Close();
                }
            }
            List<TeamInfo> TeamInfoList = new List<TeamInfo>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Belacic_TeamInfo WHERE Team_Id =" + teamInfo.TeamId;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TeamInfoList.Add(new TeamInfo
                        {
                            ClubName = (string)reader["Club_Name"],
                            TeamId = (string)reader["Team_Id"],
                            PlayerName = (string)reader["Player_Name"],
                            PlayerNumber = (string)reader["Player_Number"],
                            PlayerCountry = (string)reader["Player_Country"],
                            PlayerPosition = (string)reader["Player_Position"],
                            PlayerAge = (string)reader["Player_Age"]
                        });
                    }
                }
            }
            return TeamInfoList;
        }
    
        
        

        public List<Fixtures> GetFixtures(Fixtures fix)
        {

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string date2 = DateTime.Now.AddDays(16).ToString("yyyy-MM-dd");
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();
            List<CompetitionsClass> leaguesid = new List<CompetitionsClass>();
            string URL2 = "https://apiv2.apifootball.com/?action=get_leagues&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
            string comp2 = CallRestMethod(URL2);
            JArray JSON2 = JArray.Parse(comp2);
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            {
                oConnection.Open();
                foreach (JObject item in JSON2)
                {
                    leaguesid.Add(new CompetitionsClass
                    {
                        LeagueID = (string)item.GetValue("league_id"),
                    });
                }

            }
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Belacic_Fixtures";
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
            for (int j = 0; j < leaguesid.Count; j++)
            {
                List<Fixtures> fixtures2 = new List<Fixtures>();
                string URL = $"https://apiv2.apifootball.com/?action=get_events&from={date}&to={date2}&league_id={leaguesid[j].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
                string comp = CallRestMethod(URL);
                JArray JSON = JArray.Parse(comp);
                using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
                {
                    oConnection.Open();
                    foreach (JObject item in JSON)
                    {
                        Fixtures fixtures1 = new Fixtures()
                        {
                            HomeTeam = (string)item.GetValue("match_hometeam_name"),
                            AwayTeam = (string)item.GetValue("match_awayteam_name"),
                            Date = (string)item.GetValue("match_date"),
                            LeagueName = (string)item.GetValue("league_name")
                        };

                        fixtures2.Add(fixtures1);
                        using (DbCommand oCommand = oConnection.CreateCommand())
                        {
                            oCommand.CommandText = "INSERT INTO [Belacic_Fixtures] (Home_Team, Away_Team, Date, League_Name) VALUES ('" + fixtures1.HomeTeam + "','" + fixtures1.AwayTeam + "', '" + fixtures1.Date + "','" + fixtures1.LeagueName + "')";
                            using (DbDataReader oReader = oCommand.ExecuteReader())
                            {

                            }
                        }


                    }
                    oConnection.Close();

                }

            }
            List<CompetitionInfo> clubCount = new List<CompetitionInfo>();
            using (DbConnection connection1 = new SqlConnection(sSqlConnectionString))
            using (DbCommand command1 = connection1.CreateCommand())
            {
                command1.CommandText = "SELECT Club_Name FROM [Belacic_CompetitionInfo] WHERE League_Name='" + fix.LeagueName + "'";
                connection1.Open();
                using (DbDataReader reader2 = command1.ExecuteReader())
                {
                    while (reader2.Read())
                        clubCount.Add(new CompetitionInfo
                        {
                            clubName = (string)reader2["Club_Name"]
                        });
                }
            }

            int i = clubCount.Count();
            int a = 0;
            List<Fixtures> fixtures = new List<Fixtures>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Belacic_Fixtures] WHERE League_Name='" + fix.LeagueName + "'";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fixtures.Add(new Fixtures
                        {
                            HomeTeam = (string)reader["Home_Team"],
                            AwayTeam = (string)reader["Away_Team"],
                            Date = (string)reader["Date"],
                            LeagueName = (string)reader["League_Name"]

                        });
                        if (a == (i / 2) - 1)
                        {
                            break;
                        }
                        a += 1;
                    }
                }
            }
            return fixtures;
        }


        public List<Fixtures> refreshFixtures(Fixtures fix)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string date2 = DateTime.Now.AddDays(16).ToString("yyyy-MM-dd");
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();
            List<CompetitionsClass> leaguesid = new List<CompetitionsClass>();
            string URL2 = "https://apiv2.apifootball.com/?action=get_leagues&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
            string comp2 = CallRestMethod(URL2);
            JArray JSON2 = JArray.Parse(comp2);
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            {
                oConnection.Open();
                foreach (JObject item in JSON2)
                {
                    leaguesid.Add(new CompetitionsClass
                    {
                        LeagueID = (string)item.GetValue("league_id"),
                    });
                }

            }
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Belacic_Fixtures";
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
            for (int j = 0; j < leaguesid.Count; j++)
            {
                List<Fixtures> fixtures2 = new List<Fixtures>();
                string URL = $"https://apiv2.apifootball.com/?action=get_events&from={date}&to={date2}&league_id={leaguesid[j].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
                string comp = CallRestMethod(URL);
                JArray JSON = JArray.Parse(comp);
                using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
                {
                    oConnection.Open();
                    foreach (JObject item in JSON)
                    {
                        Fixtures fixtures1 = new Fixtures()
                        {
                            HomeTeam = (string)item.GetValue("match_hometeam_name"),
                            AwayTeam = (string)item.GetValue("match_awayteam_name"),
                            Date = (string)item.GetValue("match_date"),
                            LeagueName = (string)item.GetValue("league_name")
                        };

                        fixtures2.Add(fixtures1);
                        using (DbCommand oCommand = oConnection.CreateCommand())
                        {
                            oCommand.CommandText = "INSERT INTO [Belacic_Fixtures] (Home_Team, Away_Team, Date, League_Id) VALUES ('" + fixtures1.HomeTeam + "','" + fixtures1.AwayTeam + "', '" + fixtures1.Date + "','" + fixtures1.LeagueName + "')";
                            using (DbDataReader oReader = oCommand.ExecuteReader())
                            {

                            }
                        }


                    }
                    oConnection.Close();

                }

            }
            //string date = DateTime.Now.ToString("yyyy-MM-dd");
            List<CompetitionInfo> clubCount = new List<CompetitionInfo>();
            using (DbConnection connection1 = new SqlConnection(sSqlConnectionString))
            using (DbCommand command1 = connection1.CreateCommand())
            {
                command1.CommandText = "SELECT Club_Name FROM [Belacic_CompetitionInfo] WHERE League_Id=" + fix.LeagueName;
                connection1.Open();
                using (DbDataReader reader2 = command1.ExecuteReader())
                {
                    while (reader2.Read())
                        clubCount.Add(new CompetitionInfo
                        {
                            clubName = (string)reader2["Club_Name"]
                        });
                }
            }

            int i = clubCount.Count();
            int a = 0;
            List<Fixtures> fixtures = new List<Fixtures>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Belacic_Fixtures] WHERE League_Id=" + fix.LeagueName;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fixtures.Add(new Fixtures
                        {
                            HomeTeam = (string)reader["Home_Team"],
                            AwayTeam = (string)reader["Away_Team"],
                            Date = (string)reader["Date"],
                            LeagueName = (string)reader["League_Name"]
                        });
                        if (a == (i / 2) - 1)
                        {
                            break;
                        }
                        a += 1;
                    }
                }
            }
            return fixtures;
        }
    }
}
