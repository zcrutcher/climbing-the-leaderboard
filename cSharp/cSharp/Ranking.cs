using System.Linq;

namespace cSharp
{
    public class Ranking
    {
        public int CalculateRank(int score, int[] leaderboards)
        {
            var unique = leaderboards.Distinct().ToList();

            var placement = unique.FindIndex(x => score >= x);

            return placement > -1 ? placement + 1 : unique.Count() + 1;
        }
    }
}
