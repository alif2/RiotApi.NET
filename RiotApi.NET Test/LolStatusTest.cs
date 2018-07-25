using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Linq;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class LolStatusTest
    {
        private readonly LolStatusApi _lolStatusApi = new LolStatusApi(new NET.RiotApi("RGAPI-f435204c-c851-4c0f-bc52-75c3ece4e10b", NET.RiotApi.Regions.NA));

        [TestMethod]
        public void WhenRequestServerStatusShouldNonEmptyObject()
        {
            var shardStatus = _lolStatusApi.GetShardStatus();
            var shardServices = shardStatus.Services.ToList();

            Assert.IsNotNull(shardStatus);
            Assert.IsNotNull(shardStatus.Name);
            Assert.IsNotNull(shardStatus.Region);
            Assert.IsNotNull(shardStatus.Hostname);
            Assert.IsNotNull(shardStatus.Slug);
            Assert.IsNotNull(shardStatus.Locales);
            Assert.IsNotNull(shardStatus.Services);
            
            Assert.IsNotNull(shardServices.TrueForAll(t => t.Name != null && t.Incidents.All(u => u.Id > 0)));
        }
    }
}
