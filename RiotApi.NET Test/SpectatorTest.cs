using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class SpectatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestActiveGameForNullSummonerIdShouldThrowException()
        {
            SpectatorApi.GetActiveGame(-1);
        }

        [TestMethod]
        public void WhenRequestActiveGameForSummonerShouldReturnObject()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void WhenRequestFeaturedGamesShouldReturnObject()
        {
            var featuredGames = SpectatorApi.GetFeaturedGames();
            Assert.IsTrue(featuredGames.ClientRefreshInterval > 0);
            Assert.IsTrue(featuredGames.Games.Any());
        }
    }
}
