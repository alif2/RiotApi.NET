using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class ChampionTest
    {
        private readonly ChampionApi _championApi = new ChampionApi(new NET.RiotApi("RGAPI-f435204c-c851-4c0f-bc52-75c3ece4e10b", NET.RiotApi.Regions.NA));

        [TestMethod]
        public void WhenRequestAllChampionsShouldReturnListOfAllChampions()
        {
            var champions = _championApi.GetAllChampions();

            Assert.IsNotNull(champions);
            Assert.IsTrue(champions.Champions.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestANegativeChampionIdShouldThrowException()
        {
            _championApi.GetChampion(-1);
        }

        [TestMethod]
        public void WhenRequestAChampionShouldReturnChampionObject()
        {
            var champion = _championApi.GetChampion(TestSettings.ChampionId);

            Assert.IsNotNull(champion);
            Assert.AreEqual(TestSettings.ChampionId, champion.Id);
        }
    } 
}
