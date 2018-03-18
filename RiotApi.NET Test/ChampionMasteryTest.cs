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
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteriesBySummonerForNegativeSummonerIdShouldThrowException()
        {
            ChampionMasteryApi.GetChampionMasteriesBySummonerId(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteriesBySummonerShouldReturnMasteries()
        {
            var championMasteryList = ChampionMasteryApi.GetChampionMasteriesBySummonerId(TestSettings.SummonerId).ToList();
            Assert.IsTrue(championMasteryList.Any());
            Assert.IsTrue(championMasteryList.All(t => t.ChampionId > 0));
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
            ChampionMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(TestSettings.SummonerId, -1);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreBySummonerByChampionShouldReturnChampionMastery()
        {
            var championMastery = ChampionMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(TestSettings.SummonerId, TestSettings.ChampionId);

            Assert.IsNotNull(championMastery);
            Assert.AreEqual(TestSettings.SummonerId, championMastery.SummonerId);
            Assert.AreEqual(TestSettings.ChampionId, championMastery.ChampionId);
            Assert.IsTrue(championMastery.ChampionLevel > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteryScoreForNegativeSummonerIdShouldThrowException()
        {
            ChampionMasteryApi.GetMasteryScoreBySummonerId(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreShouldReturnInt()
        {
            Assert.IsTrue(ChampionMasteryApi.GetMasteryScoreBySummonerId(TestSettings.SummonerId) >= 0);
        }
    }
}
