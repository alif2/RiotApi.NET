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
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestANegativeChampionIdShouldThrowException()
        {
            ChampionApi.GetChampion(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestChampionIdTooBigShouldThrowException()
        {
            ChampionApi.GetChampion(int.MaxValue);
        }

        [TestMethod]
        public void WhenRequestAChampionShouldReturnChampionObject()
        {
            var champion = ChampionApi.GetChampion(1);

            Assert.IsNotNull(champion);
            Assert.IsTrue(champion.Id == 1);
        }

        [TestMethod]
        public void WhenRequestAChampionShouldReturnChampionObject2()
        {
            var champion = ChampionApi.GetChampion(412);

            Assert.IsNotNull(champion);
            Assert.IsTrue(champion.Id == 412);
        }

        [TestMethod]
        public void WhenRequestAllChampionsShouldReturnListOfAllChampions()
        {
            var champions = ChampionApi.GetAllChampions();

            Assert.IsNotNull(champions);
            Assert.IsTrue(champions.Any());
        }
    } 
}
