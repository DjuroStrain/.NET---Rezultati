using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using FootballData;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace AddCompetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string date = DateTime.Now.ToString("yyyy-MM-dd");
            string date2 = DateTime.Now.AddDays(10).ToString("yyyy-MM-dd");
            Console.WriteLine(date);
            Console.ReadKey();
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
            
            for (int a = 0; a < leaguesid.Count; a++)
            {
                Console.WriteLine(leaguesid[a].LeagueID);
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

            List<CompetitionInfo> competitionInfo = new List<CompetitionInfo>();
            
            for (int i = 0; i < leaguesid.Count; i++)
            {
                Console.WriteLine("Idu lige");
                Console.WriteLine(leaguesid[i].LeagueID);
                //Console.ReadLine();
                string URL4 = $"https://apiv2.apifootball.com/?action=get_standings&from=2020-09-12&league_id={leaguesid[i].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
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
                            oCommand.CommandText = "INSERT INTO [Belacic_CompetitionInfo] (Club_Name,Team_Id, League_Id,League_Name, Country_Name, Position) VALUES ('" + (c1.clubName)+"','"+c1.TeamId+"','" + c1.LeagueID + "','"+c1.LeagueName+"','" + c1.CountryName + "', '" + c1.Position + "');";
                            using (DbDataReader oReader = oCommand.ExecuteReader())
                            {

                            }
                        }

                    }
                    oConnection.Close();
                }
      
            }
            Console.ReadLine();
            
            for (int a = 0; a < leaguesid.Count; a++)
            {
                Console.WriteLine("Idu igraci");
                Console.WriteLine(leaguesid[a].LeagueID);
                Console.ReadLine();
                List<TeamInfo> teamInfo = new List<TeamInfo>();
                string URL9 = $"https://apiv2.apifootball.com/?action=get_teams&league_id={leaguesid[a].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
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
                                teamInfo.Add(c1);
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
                                        c1.PlayerName = c1.PlayerName.Replace("'","\"");
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
                                    oCommand.CommandText = "INSERT INTO [Belacic_TeamInfo] (Player_Name,Club_Name,Team_Id, Player_Number,Player_Country,PLayer_Position, Player_Age) VALUES ('" + c1.PlayerName + "','"+c1.ClubName+"','"+c1.TeamId+"', '"+c1.PlayerNumber+"', '"+c1.PlayerCountry+"', '"+c1.PlayerPosition+"', '"+c1.PlayerAge+"');";
                                    using (DbDataReader oReader = oCommand.ExecuteReader())
                                    {

                                    }
                                }
                            }
                        
                    }
                    oConnection.Close();
                }
            }
            /*
            for (int j = 0; j < leaguesid.Count; j++)
             {
                 List<Fixtures> fixtures = new List<Fixtures>();
                 string URL = $"https://apiv2.apifootball.com/?action=get_events&from={date}&to=2021-31-06&league_id={leaguesid[j].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
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
                             HomeTeamId = (string)item.GetValue("match_hometeam_id"),
                             AwayTeam = (string)item.GetValue("match_awayteam_name"),
                             AwayTeamId = (string)item.GetValue("match_awayteam_id"),
                             Date = (string)item.GetValue("match_date"),
                             LeagueId = (string)item.GetValue("league_id")
                         };

                         fixtures.Add(fixtures1);
                         using (DbCommand oCommand = oConnection.CreateCommand())
                         {
                             oCommand.CommandText = "INSERT INTO [Belacic_Fixtures] (Home_Team, Home_Team_Id, Away_Team, Away_Team_Id, Date, League_Id) VALUES ('"+fixtures1.HomeTeam+"','"+fixtures1.HomeTeamId+"','"+fixtures1.AwayTeam+"', '"+fixtures1.AwayTeamId+"', '"+fixtures1.Date+"','"+fixtures1.LeagueId+"')";
                             using (DbDataReader oReader = oCommand.ExecuteReader())
                             {

                             }
                         }


                     }
                     oConnection.Close();

                 }

             }
            */

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string date1 = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            string date2 = DateTime.Now.AddDays(-16).ToString("yyyy-MM-dd");

            Console.WriteLine(date);
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.ReadKey();
        }
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
        
    }

}
