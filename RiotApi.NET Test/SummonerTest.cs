using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class SummonerTest
    {
        private readonly SummonerApi _summonerApi = new SummonerApi(new NET.RiotApi("RGAPI-f435204c-c851-4c0f-bc52-75c3ece4e10b", NET.RiotApi.Regions.NA));

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNegativeSummonerIdShouldThrowException()
        {
            _summonerApi.GetSummoner(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerByIdShouldReturnSummonerObject()
        {
            var summoner = _summonerApi.GetSummoner(TestSettings.SummonerId);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(TestSettings.SummonerId, summoner.Id);
            Assert.AreEqual(TestSettings.AccountId, summoner.AccountId);
            Assert.IsTrue(summoner.SummonerLevel > 0);
            Assert.AreEqual(TestSettings.SummonerName, summoner.Name);
            Assert.IsTrue(summoner.ProfileIconId > 0);
            Assert.IsTrue(summoner.RevisionDate > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullSummonerNameShouldThrowException()
        {
            _summonerApi.GetSummoner(null);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptySummonerNameShouldThrowException()
        {
            _summonerApi.GetSummoner(string.Empty);
        }

        [TestMethod]
        public void WhenRequestSummonerByNameShouldReturnSummonerObject()
        {
            var summoner = _summonerApi.GetSummoner(TestSettings.SummonerName);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(TestSettings.SummonerName, summoner.Name);
            Assert.AreEqual(TestSettings.AccountId, summoner.AccountId);
            Assert.IsTrue(summoner.SummonerLevel > 0);
            Assert.AreEqual(TestSettings.SummonerId, summoner.Id);
            Assert.IsTrue(summoner.ProfileIconId > 0);
            Assert.IsTrue(summoner.RevisionDate > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNegativeAccountIdShouldThrowException()
        {
            _summonerApi.GetSummonerByAccountId(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerByAccountIdShouldReturnSummonerObject()
        {
            var summoner = _summonerApi.GetSummonerByAccountId(TestSettings.AccountId);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(TestSettings.SummonerName, summoner.Name);
            Assert.AreEqual(TestSettings.AccountId, summoner.AccountId);
            Assert.IsTrue(summoner.SummonerLevel > 0);
            Assert.AreEqual(TestSettings.SummonerId, summoner.Id);
            Assert.IsTrue(summoner.ProfileIconId > 0);
            Assert.IsTrue(summoner.RevisionDate > 0);
        }
    }
}
