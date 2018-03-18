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
            ThirdPartyCodeApi.GetThirdPartyCode(-1);
        }

        [TestMethod]
        public void WhenRequestThirdPartyCodeBySummonerShouldReturnString()
        {
            var thirdPartyCode = ThirdPartyCodeApi.GetThirdPartyCode(TestSettings.SummonerId);
            Assert.IsFalse(string.IsNullOrEmpty(thirdPartyCode));
        }
    }
}
