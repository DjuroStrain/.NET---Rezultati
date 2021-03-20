using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballData
{
    public class CompetitionInfoVMRepository
    {/*
        public CompetitionsRepository _competitionsRepository = new CompetitionsRepository();
        public FixtureRepository _fixtureRepository = new FixtureRepository();
        public List<CompetitionInfoVM> GetInfo(string LeagueId)
        {
            List<CompetitionInfoVM> novi = new List<CompetitionInfoVM>();
            var compInfo = _competitionsRepository.GetCompetitonsInfo();
            var fix = _fixtureRepository.GetFixtures();
            foreach(CompetitionInfo item in compInfo)
            {
                if (item.LeagueID == LeagueId)
                {
                    foreach (Fixtures fix2 in item.TeamId)
                    {
                            novi.Add(new CompetitionInfoVM()
                            {
                                clubName = item.clubName,
                                TeamId = item.TeamId,
                                LeagueID = item.LeagueID,
                                CountryName = item.CountryName,
                                LeagueName = item.LeagueName,
                                Position = item.Position,
                                NextGame = fix.Where(x => x.AwayTeamId == item.TeamId).Select(x => x.HomeTeam).FirstOrDefault()
                            });
                    }
                }
            }
            return novi;
        }*/

        public CompetitionsRepository _competitionsRepository = new CompetitionsRepository();
        /*
        public List<Fixtures> GetFixturesVM(Fixtures fix2)
        {
            List<Fixtures> competitionInfos = new List<Fixtures>();
            var fixtures = _competitionsRepository.GetFixtures();
            int i = 0;
            foreach (var item in fixtures)
            {
                    var newFix = fixtures.Where(x => x.LeagueId == fix2.LeagueId).Select(x => new Fixtures
                    {
                        HomeTeam = x.HomeTeam,
                        AwayTeam = x.AwayTeam,
                        Date = x.Date
                    }).FirstOrDefault();
                    competitionInfos.Add(newFix);
            }
            return competitionInfos;
        }*/
        /*
        public List<Fixtures> GetFixturesVM(Fixtures fix2)
        {
            List<Fixtures> competitionInfos = new List<Fixtures>();
            Fixtures newFixture = new Fixtures();           
            var fixtures = _competitionsRepository.GetFixtures();
            int i = 0;
            foreach (Fixtures fix in fixtures)
            {
                if (fix.LeagueId == fix2.LeagueId)
                {

                    competitionInfos.Add(new Fixtures()
                    {
                        HomeTeam = fix.HomeTeam,
                        AwayTeam = fix.AwayTeam,
                        Date = fix.Date,
                        LeagueId = fix.LeagueId
                    });
                }
            }
            return competitionInfos;
        }*/
    }
}
