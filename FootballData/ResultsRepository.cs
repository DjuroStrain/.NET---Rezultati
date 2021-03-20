using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FootballData
{
    public class ResultsRepository
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
        public List<Results> GetResults(Results results)
        {

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string date1 = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            string date2 = DateTime.Now.AddDays(-16).ToString("yyyy-MM-dd");
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
                        LeagueID = (string)item.GetValue("league_id")
                    });
                }

            }
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Belacic_Results";
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
            for (int j = 0; j < leaguesid.Count; j++)
            {
                List<Results> results1 = new List<Results>();
                string URL = $"https://apiv2.apifootball.com/?action=get_events&from={date2}&to={date1}&league_id={leaguesid[j].LeagueID}&APIkey=ef4ca607b6d35d0a6126aed3e863e6e06041a370795da7f6b7f53722bf9b9751";
                string comp = CallRestMethod(URL);
                JArray JSON = JArray.Parse(comp);
                using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
                {
                    oConnection.Open();
                    foreach (JObject item in JSON)
                    {
                        Results results2 = new Results()
                        {
                            HomeTeam2 = (string)item.GetValue("match_hometeam_name"),
                            AwayTeam2 = (string)item.GetValue("match_awayteam_name"),
                            HomeTeamGoals = (string)item.GetValue("match_hometeam_score"),
                            AwayTeamGoals = (string)item.GetValue("match_awayteam_score"),
                            Date2 = (string)item.GetValue("match_date"),
                            LeagueName2 = (string)item.GetValue("league_name")
                        };

                        using (DbCommand oCommand = oConnection.CreateCommand())
                        {
                            oCommand.CommandText = "INSERT INTO [Belacic_Results] (Home_Team, Away_Team,Home_Team_Goals,Away_Team_Goals, Date, League_Name) VALUES ('" + results2.HomeTeam2 + "','" + results2.AwayTeam2 + "','" + results2.HomeTeamGoals + "','" + results2.AwayTeamGoals + "', '" + results2.Date2 + "','" + results2.LeagueName2 + "')";
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
                command1.CommandText = "SELECT Club_Name FROM [Belacic_CompetitionInfo] WHERE League_Name='" + results.LeagueName2 + "'";
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
            List<Results> finalResults = new List<Results>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Belacic_Results] WHERE League_Name='"+results.LeagueName2+"'";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        finalResults.Add(new Results
                        {
                            HomeTeam2 = (string)reader["Home_Team"],
                            HomeTeamGoals = (string)reader["Home_Team_Goals"],
                            AwayTeam2 = (string)reader["Away_Team"],
                            AwayTeamGoals = (string)reader["Away_Team_Goals"],
                            Date2 = (string)reader["Date"],
                            LeagueName2 = (string)reader["League_Name"]

                        });
                        if (a == (i/2)-1)
                         {
                            break;
                        }
                         a += 1;
                    }
                }
            }
            return finalResults;
        }
    }
}
