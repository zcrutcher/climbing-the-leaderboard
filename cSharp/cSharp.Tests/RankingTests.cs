using NUnit.Framework;

namespace cSharp.Tests
{
    public class Tests
    {
        [TestCase(35, new int[] { 100, 80, 80, 25 }, 3)]
        [TestCase(5, new int[] { 100, 100, 50, 40, 40, 20, 10 }, 6)]
        [TestCase(25, new int[] { 100, 100, 50, 40, 40, 20, 10 }, 4)]
        [TestCase(50, new int[] { 100, 100, 50, 50, 40, 40, 20, 10 }, 2)]
        [TestCase(120, new int[] { 100, 100, 50, 40, 40, 20, 10 }, 1)]

        public void DetermineRank_ReturnsTrue(int score, int[] leaderboards, int expect)
        {
            var rank = new Ranking();
            var result = rank.CalculateRank(score, leaderboards) == expect;

            Assert.True(result);
        }
    }
}