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
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestSummonerIdTooBigShouldThrowException()
        {
            SummonerApi.GetSummonerByAccountId(int.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNegativeAccountIdShouldThrowException()
        {
            SummonerApi.GetSummonerByAccountId(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestAccountIdTooBigShouldThrowException()
        {
            SummonerApi.GetSummoner(int.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestNullAccountIdShouldThrowException()
        {
            SummonerApi.GetSummoner(null);
        }

        [TestMethod]
        public void WhenRequestSummonerByIdShouldReturnSummonerObject()
        {
            var summoner = SummonerApi.GetSummoner(5908);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(5908, summoner.Id);
        }

        [TestMethod]
        public void WhenRequestSummonerByAccountIdShouldReturnSummonerObject()
        {
            var summoner = SummonerApi.GetSummonerByAccountId(32766);

            Assert.IsNotNull(summoner);
            Assert.AreEqual(32766, summoner.AccountId);
        }

        [TestMethod]
        public void WhenRequestSummonerByNameShouldReturnSummonerObject()
        {
            var summoner = SummonerApi.GetSummoner("Dyrus");

            Assert.IsNotNull(summoner);
            Assert.AreEqual("Dyrus", summoner.Name);
        }
    }
}
