using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using System;
using System.Collections.Generic;
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
            var beginIndex = 0;
            var matches = MatchApi.GetMatchesByAccountId(32766, beginIndex: beginIndex);
            Assert.IsTrue(matches.EndIndex == beginIndex + 100);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithEndIndexButNotBeginIndexShouldStartAt0()
        {
            var matches = MatchApi.GetMatchesByAccountId(32766, endIndex: 50);
            Assert.IsTrue(matches.StartIndex == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndIndexLessThanStartIndexShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, beginIndex: 2, endIndex: 1);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithRangeGreaterThan100ShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, beginIndex: 200, endIndex: 1);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndTimeLessThanBeginTimeShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, beginTime: 1000, endTime: 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithTimeRanageGreaterThan1WeekShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, beginTime: 1517443200, endTime: 1520808582);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountShouldReturnObject()
        {
            var matches = MatchApi.GetMatchesByAccountId(32766, new List<int>(11), new List<int>(420), new List<int>(75), 20, 25, 1518425747064);
            
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

        [TestMethod]
        public void WhenRequestMatchTimelineShouldReturnObject()
        {
            throw new NotImplementedException();
        }

        // TODO: Currently unavailable for testing
        /**
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchesByTournamentCodeWithNullCodeShouldThrowException()
        {
            MatchApi.GetMatchesByTournamentCode(null);
        }

        [TestMethod]
        public void WhenRequestMatchesByTournamentCodeShouldReturnList()
        {
            var matches = MatchApi.GetMatchesByTournamentCode("NA1234a-1a23b456-a1b2-1abc-ab12-1234567890ab");
            Assert.IsTrue(matches.Any());
        }
 
        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByTournamentCodeAndMatchIdWithNullAndNegativeIdCodeShouldThrowException()
        {
            MatchApi.GetMatchByTournamentCode(-1, null);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByTournamentCodeAndMatchIdWithNegativeIdShouldThrowException()
        {
            MatchApi.GetMatchByTournamentCode(-1, "NA1234a-1a23b456-a1b2-1abc-ab12-1234567890ab");
        } **/
    }
}
