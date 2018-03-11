using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class ThirdPartyCodeTest
    {
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestThirdPartyCodeBySummonerForNegativeSummonerIdShouldThrowException()
        {
            ThirdPartyCodeApi.GetThirdPartyCodeBySummonerId(-1);
        }

        [TestMethod]
        public void WhenRequestThirdPartyCodeBySummonerShouldReturnString()
        {
            var thirdPartyCode = ThirdPartyCodeApi.GetThirdPartyCodeBySummonerId(5908);
            Assert.IsFalse(string.IsNullOrEmpty(thirdPartyCode));
        }
    }
}
