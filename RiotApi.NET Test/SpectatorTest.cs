using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class SpectatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestActiveGameForNullSummonerIdShouldThrowException()
        {
            SpectatorApi.GetActiveGame(-1);
        }

        [TestMethod]
        public void WhenRequestActiveGameForSummonerShouldReturnObjectIfInGameElseThrow404()
        {
            try
            {
                var activeGame = SpectatorApi.GetActiveGame(TestSettings.SummonerId);
                Assert.IsNotNull(activeGame);
                Assert.IsTrue(activeGame.GameId > 0);
                Assert.IsTrue(activeGame.GameLength > 0);
                Assert.IsTrue(activeGame.GameId > 0);
                Assert.IsTrue(activeGame.MapId > 0);
                Assert.IsNotNull(activeGame.PlatformId);
                Assert.IsNotNull(activeGame.GameMode);
                Assert.IsNotNull(activeGame.GameType);
                Assert.IsTrue(activeGame.GameStartTime > 0);
                Assert.IsTrue(activeGame.GameLength > 0);
                Assert.IsNotNull(activeGame.Observers);
                Assert.IsTrue(activeGame.GameQueueConfigId > 0);
                Assert.IsNotNull(activeGame.Participants);
                Assert.IsNotNull(activeGame.BannedChampions);
            }
            catch (HttpRequestException exception)
            {
                Assert.AreEqual("Response status code does not indicate success: 404 (Not Found).", exception.Message);
            }
        }

        [TestMethod]
        public void WhenRequestFeaturedGamesShouldReturnObject()
        {
            var featuredGames = SpectatorApi.GetFeaturedGames();
            Assert.IsTrue(featuredGames.ClientRefreshInterval > 0);
            Assert.IsTrue(featuredGames.Games.Any());
        }
    }
}
