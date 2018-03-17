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
                var activeGame = SpectatorApi.GetActiveGame(32766);
                Assert.IsNotNull(activeGame.GameId);
                Assert.IsTrue(activeGame.GameId > 0);
                Assert.IsTrue(activeGame.GameLength > 0);
                
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
