using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net.Http;
using RiotApi.NET;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class ChampionMasteryTest
    {
        private readonly ChampionMasteryApi _championMasteryApi = new ChampionMasteryApi(new NET.RiotApi("RGAPI-f435204c-c851-4c0f-bc52-75c3ece4e10b", NET.RiotApi.Regions.NA));

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteriesBySummonerForNegativeSummonerIdShouldThrowException()
        {
            _championMasteryApi.GetChampionMasteriesBySummonerId(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteriesBySummonerShouldReturnMasteries()
        {
            var championMasteryList = _championMasteryApi.GetChampionMasteriesBySummonerId(TestSettings.SummonerId).ToList();
            Assert.IsTrue(championMasteryList.Any());
            Assert.IsTrue(championMasteryList.All(t => t.ChampionId > 0));
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteryScoreBySummonerByChampionForNegativeSummonerIdShouldThrowException()
        {
            _championMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(-1, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteryScoreBySummonerByChampionForNegativeChampionIdShouldThrowException()
        {
            _championMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(TestSettings.SummonerId, -1);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreBySummonerByChampionShouldReturnChampionMastery()
        {
            var championMastery = _championMasteryApi.GetChampionMasteryBySummonerIdAndChampionId(TestSettings.SummonerId, TestSettings.ChampionId);

            Assert.IsNotNull(championMastery);
            Assert.AreEqual(TestSettings.SummonerId, championMastery.PlayerId);
            Assert.AreEqual(TestSettings.ChampionId, championMastery.ChampionId);
            Assert.IsTrue(championMastery.ChampionLevel > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerMasteryScoreForNegativeSummonerIdShouldThrowException()
        {
            _championMasteryApi.GetMasteryScoreBySummonerId(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerMasteryScoreShouldReturnInt()
        {
            Assert.IsTrue(_championMasteryApi.GetMasteryScoreBySummonerId(TestSettings.SummonerId) >= 0);
        }
    }
}
