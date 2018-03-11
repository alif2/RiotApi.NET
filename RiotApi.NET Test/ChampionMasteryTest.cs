using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class ChampionMasteryTest
    {
        [TestMethod]
        public void WhenRequestSummonerMasteryScoreForNegativeSummonerIdShouldReturnZero()
        {
            Assert.IsTrue(ChampionMasteryApi.GetMasteryScoreBySummonerId(-1) == 0);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreShouldReturnInt()
        {
            Assert.IsTrue(ChampionMasteryApi.GetMasteryScoreBySummonerId(5908) >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteryScoreBySummonerByChampionForNegativeSummonerIdShouldThrowException()
        {
            ChampionMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(-1, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteryScoreBySummonerByChampionForNegativeChampionIdShouldThrowException()
        {
            ChampionMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(5908, -1);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreBySummonerByChampionShouldReturnChampionMastery()
        {
            long summonerId = 5908;
            long championId = 1;
            var championMastery = ChampionMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(summonerId, championId);

            Assert.IsNotNull(championMastery);
            Assert.AreEqual(summonerId, championMastery.SummonerId);
            Assert.AreEqual(championId, championMastery.ChampionId);
            Assert.IsTrue(championMastery.ChampionLevel > 0);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreBySummonerForNegativeSummonerIdShouldReturnEmptyList()
        {
            Assert.AreEqual(0, ChampionMasteryApi.GetChampionMasteriesBySummonerId(-1).Count());
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreBySummonerShouldReturnMasteries()
        {
            var championMasteryList = ChampionMasteryApi.GetChampionMasteriesBySummonerId(5908).ToList();
            Assert.IsTrue(championMasteryList.Any());
            Assert.IsTrue(championMasteryList.All(t => t.ChampionId > 0));
        }
    }
}
