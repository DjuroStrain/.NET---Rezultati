using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballData
{
    public class CompetitionInfo
    {
        public string clubName { get; set; }
        public string TeamId { get; set; }
        public string LeagueID { get; set; }
        public string CountryName { get; set; }
        public string LeagueName { get; set; }
        public string Position { get; set; }
        public string MatchPlayed { get; set;}
        public string MatchWin { get; set; }
        public string MatchDraw { get; set; }
        public string MatchLose { get; set; }
        public string GoalsScored { get; set; }
        public string GoalsGet { get; set; }
        public string Points { get; set; }
    }
}
