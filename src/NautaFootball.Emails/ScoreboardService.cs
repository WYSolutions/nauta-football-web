using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NautaFootball.Core;
using RestSharp;

namespace NautaFootball.Emails
{
    public class ScoreboardService :IScoreBoardService
    {
        private RestClient client;

        public ScoreboardService()
        {
            client = new RestClient();
        }
        public IEnumerable<MatchScoreboard> GetScoreboards(int matchday, League league)
        {
            return new[]
            {
                new MatchScoreboard {GuestTeam = "Valencia", HomeTeam = "Atletico de Madrid", Score = "3-0"},
                new MatchScoreboard {GuestTeam = "Real Madrid", HomeTeam = "Eibar", Score = "4-1"}
            };
        }
    }
}
