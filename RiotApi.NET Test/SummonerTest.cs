using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class SummonerTest
    {
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNegativeSummonerIdShouldThrowException()
        {
            SummonerApi.GetSummoner(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerByIdShouldReturnSummonerObject()
        {
            var summoner = SummonerApi.GetSummoner(TestSettings.SummonerId);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(TestSettings.SummonerId, summoner.Id);
            Assert.AreEqual(TestSettings.AccountId, summoner.AccountId);
            Assert.IsTrue(summoner.Level > 0);
            Assert.AreEqual(TestSettings.SummonerName, summoner.Name);
            Assert.IsTrue(summoner.ProfileIconId > 0);
            Assert.IsTrue(summoner.RevisionDate > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullSummonerNameShouldThrowException()
        {
            SummonerApi.GetSummoner(null);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestEmptySummonerNameShouldThrowException()
        {
            SummonerApi.GetSummoner(string.Empty);
        }

        [TestMethod]
        public void WhenRequestSummonerByNameShouldReturnSummonerObject()
        {
            var summoner = SummonerApi.GetSummoner(TestSettings.SummonerName);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(TestSettings.SummonerName, summoner.Name);
            Assert.AreEqual(TestSettings.AccountId, summoner.AccountId);
            Assert.IsTrue(summoner.Level > 0);
            Assert.AreEqual(TestSettings.SummonerId, summoner.Id);
            Assert.IsTrue(summoner.ProfileIconId > 0);
            Assert.IsTrue(summoner.RevisionDate > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNegativeAccountIdShouldThrowException()
        {
            SummonerApi.GetSummonerByAccountId(-1);
        }

        [TestMethod]
        public void WhenRequestSummonerByAccountIdShouldReturnSummonerObject()
        {
            var summoner = SummonerApi.GetSummonerByAccountId(TestSettings.AccountId);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(TestSettings.SummonerName, summoner.Name);
            Assert.AreEqual(TestSettings.AccountId, summoner.AccountId);
            Assert.IsTrue(summoner.Level > 0);
            Assert.AreEqual(TestSettings.SummonerId, summoner.Id);
            Assert.IsTrue(summoner.ProfileIconId > 0);
            Assert.IsTrue(summoner.RevisionDate > 0);
        }
    }
}
