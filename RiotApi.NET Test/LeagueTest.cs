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
    }
}
