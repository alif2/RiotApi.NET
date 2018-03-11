using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET_Test
{
    [TestClass]
    public class MatchTest
    {
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchWithNegativeIdShouldThrowException()
        {
            MatchApi.GetMatchById(-1);
        }

        [TestMethod]
        public void WhenRequestMatchShouldReturnObject()
        {
            var matchId = 2708038586;
            var match = MatchApi.GetMatchById(matchId);
            Assert.IsNotNull(match);
            Assert.IsTrue(match.Id == matchId);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithNegativeAccountIdShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(-1);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithBeginIndexButNoEndIndexShouldReturnBeginIndexPlus100()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithEndIndexButNotBeginIndexShouldStartAt0()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithEndIndexLessThanStartIndexShouldThrowException()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithRangeGreaterThan100ShouldThrowException()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithEndTimeLessThanBeginTimeShouldThrowException()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithTimeRanageGreaterThan1WeekShouldThrowException()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestRecentMatchesByAccountWithNegativeAccountIdShouldThrowException()
        {
            MatchApi.GetRecentMatchesByAccountId(-1);
        }

        [TestMethod]
        public void WhenRequestRecentMatchesByAccountIdShouldReturn20Matches()
        {
            var matchCount = MatchApi.GetRecentMatchesByAccountId(32766).Matches.Count();
            Assert.AreEqual(20, matchCount);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchTimelineWithNullMatchIdShouldThrowException()
        {
            MatchApi.GetMatchTimelineById(-1);
        }
    }
}
