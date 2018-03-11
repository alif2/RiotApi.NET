using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Linq;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class LolStatusTest
    {
        [TestMethod]
        public void WhenRequestServerStatusShouldNonEmptyObject()
        {
            var shardStatus = LolStatusApi.GetShardStatus();
            var shardServices = shardStatus.Services.ToList();

            Assert.IsNotNull(shardStatus);
            Assert.IsNotNull(shardStatus.Name);
            Assert.IsNotNull(shardStatus.Services);
            Assert.IsNotNull(shardStatus.Slug);
            Assert.IsNotNull(shardServices.TrueForAll(t => t.Name != null && t.Incidents.All(u => u.Id > 0)));
        }
    }
}
