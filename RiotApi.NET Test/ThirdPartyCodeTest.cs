using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class ThirdPartyCodeTest
    {
        private readonly ThirdPartyCodeApi _thirdPartyCodeApi = new ThirdPartyCodeApi(new NET.RiotApi("RGAPI-f435204c-c851-4c0f-bc52-75c3ece4e10b", NET.RiotApi.Regions.NA));

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestThirdPartyCodeBySummonerForNegativeSummonerIdShouldThrowException()
        {
            _thirdPartyCodeApi.GetThirdPartyCode(-1);
        }

        [TestMethod]
        public void WhenRequestThirdPartyCodeBySummonerShouldReturnString()
        {
            var thirdPartyCode = _thirdPartyCodeApi.GetThirdPartyCode(TestSettings.SummonerId);
            Assert.IsFalse(string.IsNullOrEmpty(thirdPartyCode));
        }
    }
}
