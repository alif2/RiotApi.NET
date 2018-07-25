using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class LeagueTest
    {
        private readonly LeagueApi _leagueApi = new LeagueApi(new NET.RiotApi("RGAPI-f435204c-c851-4c0f-bc52-75c3ece4e10b", NET.RiotApi.Regions.NA));

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptyLeagueIdShouldThrowException()
        {
            _leagueApi.GetLeague(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullLeagueIdShouldThrowException()
        {
            _leagueApi.GetLeague(null);
        }

        [TestMethod]
        public void WhenRequestLeagueShouldReturnObject()
        {
            var league = _leagueApi.GetLeague(TestSettings.LeagueId);
            Assert.AreEqual(TestSettings.LeagueId, league.LeagueId);
            Assert.IsNotNull(league.Tier);
            Assert.IsNotNull(league.Name);
            Assert.IsNotNull(league.Entries);
            Assert.IsNotNull(league.Queue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptyMasterLeagueIdShouldThrowException()
        {
            _leagueApi.GetMasterLeague(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullMasterLeagueIdShouldThrowException()
        {
            _leagueApi.GetMasterLeague(null);
        }

        [TestMethod]
        public void WhenRequestMasterLeagueShouldReturnObject()
        {
            var masterLeague = _leagueApi.GetMasterLeague(TestSettings.Queue);
            Assert.IsNotNull(masterLeague.LeagueId);
            Assert.AreEqual("MASTER", masterLeague.Tier);
            Assert.IsNotNull(masterLeague.Name);
            Assert.IsNotNull(masterLeague.Entries);
            Assert.AreEqual(TestSettings.Queue, masterLeague.Queue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptyChallengerLeagueIdShouldThrowException()
        {
            _leagueApi.GetChallengerLeague(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullChallengerLeagueIdShouldThrowException()
        {
            _leagueApi.GetChallengerLeague(null);
        }

        [TestMethod]
        public void WhenRequestChallengerLeagueShouldReturnObject()
        {
            var challengerLeague = _leagueApi.GetChallengerLeague(TestSettings.Queue);
            Assert.IsNotNull(challengerLeague.LeagueId);
            Assert.AreEqual("CHALLENGER", challengerLeague.Tier);
            Assert.IsNotNull(challengerLeague.Name);
            Assert.IsNotNull(challengerLeague.Entries);
            Assert.AreEqual(TestSettings.Queue, challengerLeague.Queue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestLeaguePositionForNegativeSummonerIdShouldThrowException()
        {
            _leagueApi.GetLeaguePositions(-1);
        }

        [TestMethod]
        public void WhenRequestLeaguePositionShouldReturnObject()
        {
            var leaguePositions = _leagueApi.GetLeaguePositions(TestSettings.SummonerId);

            Assert.IsNotNull(leaguePositions);

            foreach (var position in leaguePositions)
            {
                Assert.IsNotNull(position.PlayerOrTeamId);
                Assert.IsNotNull(position.LeagueId);
                Assert.IsNotNull(position.LeagueName);
                Assert.IsNotNull(position.PlayerOrTeamName);
                Assert.IsNotNull(position.Rank);
                Assert.IsNotNull(position.Tier);
            }
        }
    }
}
