using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class LeagueTest
    {
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptyLeagueIdShouldThrowException()
        {
            LeagueApi.GetLeague(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullLeagueIdShouldThrowException()
        {
            LeagueApi.GetLeague(null);
        }

        [TestMethod]
        public void WhenRequestLeagueShouldReturnObject()
        {
            var league = LeagueApi.GetLeague(TestSettings.LeagueId);
            Assert.AreEqual(TestSettings.LeagueId, league.Id);
            Assert.IsNotNull(league.Tier);
            Assert.IsNotNull(league.Name);
            Assert.IsNotNull(league.Entries);
            Assert.IsNotNull(league.Queue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptyMasterLeagueIdShouldThrowException()
        {
            LeagueApi.GetMasterLeague(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullMasterLeagueIdShouldThrowException()
        {
            LeagueApi.GetMasterLeague(null);
        }

        [TestMethod]
        public void WhenRequestMasterLeagueShouldReturnObject()
        {
            var masterLeague = LeagueApi.GetMasterLeague(TestSettings.Queue);
            Assert.IsNotNull(masterLeague.Id);
            Assert.AreEqual("MASTER", masterLeague.Tier);
            Assert.IsNotNull(masterLeague.Name);
            Assert.IsNotNull(masterLeague.Entries);
            Assert.AreEqual(TestSettings.Queue, masterLeague.Queue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptyChallengerLeagueIdShouldThrowException()
        {
            LeagueApi.GetChallengerLeague(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullChallengerLeagueIdShouldThrowException()
        {
            LeagueApi.GetChallengerLeague(null);
        }

        [TestMethod]
        public void WhenRequestChallengerLeagueShouldReturnObject()
        {
            var challengerLeague = LeagueApi.GetChallengerLeague(TestSettings.Queue);
            Assert.IsNotNull(challengerLeague.Id);
            Assert.AreEqual("CHALLENGER", challengerLeague.Tier);
            Assert.IsNotNull(challengerLeague.Name);
            Assert.IsNotNull(challengerLeague.Entries);
            Assert.AreEqual(TestSettings.Queue, challengerLeague.Queue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestLeaguePositionForNegativeSummonerIdShouldThrowException()
        {
            LeagueApi.GetLeaguePositions(-1);
        }

        [TestMethod]
        public void WhenRequestLeaguePositionShouldReturnObject()
        {
            var leaguePositions = LeagueApi.GetLeaguePositions(TestSettings.SummonerId);

            Assert.IsNotNull(leaguePositions);

            foreach (var position in leaguePositions)
            {
                Assert.IsNotNull(position.Id);
                Assert.IsNotNull(position.LeagueId);
                Assert.IsNotNull(position.LeagueName);
                Assert.IsNotNull(position.Name);
                Assert.IsNotNull(position.Rank);
                Assert.IsNotNull(position.Tier);
            }
        }
    }
}
