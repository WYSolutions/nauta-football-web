using System.Collections.Generic;
using NautaFootball.Core;

namespace NautaFootball.Emails
{
    public interface IScoreBoardService
    {
        IEnumerable<MatchScoreboard> GetScoreboards(int matchday, League league);
    }
}
