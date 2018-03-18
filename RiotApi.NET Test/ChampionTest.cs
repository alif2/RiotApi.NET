using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class ChampionTest
    {
        [TestMethod]
        public void WhenRequestAllChampionsShouldReturnListOfAllChampions()
        {
            var champions = ChampionApi.GetAllChampions();

            Assert.IsNotNull(champions);
            Assert.IsTrue(champions.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestANegativeChampionIdShouldThrowException()
        {
            ChampionApi.GetChampion(-1);
        }

        [TestMethod]
        public void WhenRequestAChampionShouldReturnChampionObject()
        {
            var champion = ChampionApi.GetChampion(TestSettings.ChampionId);

            Assert.IsNotNull(champion);
            Assert.AreEqual(TestSettings.ChampionId, champion.Id);
        }
    } 
}
