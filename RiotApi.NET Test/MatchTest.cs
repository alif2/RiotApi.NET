using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotApi.NET;
using RiotApi.NET.Objects;
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
            MatchApi.GetMatchesByAccountId(-1, null);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithBeginIndexButNoEndIndexShouldReturnBeginIndexPlus100()
        {
            var beginIndex = 0;
            var matches = MatchApi.GetMatchesByAccountId(32766, new OptionalParameters { BeginIndex = beginIndex });
            Assert.IsTrue(matches.EndIndex == beginIndex + 100);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithEndIndexButNotBeginIndexShouldStartAt0()
        {
            var matches = MatchApi.GetMatchesByAccountId(32766, new OptionalParameters{ EndIndex = 50 });
            Assert.IsTrue(matches.StartIndex == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndIndexLessThanStartIndexShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, new OptionalParameters { BeginIndex = 2, EndIndex = 1 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithRangeGreaterThan100ShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, new OptionalParameters { BeginIndex = 200, EndIndex = 1 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndTimeLessThanBeginTimeShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, new OptionalParameters { BeginTime = 1000, EndTime = 0 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithTimeRanageGreaterThan1WeekShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(32766, new OptionalParameters { BeginTime = 1517443200, EndTime = 1520808582 });
        }

        [TestMethod]
        public void WhenRequestMatchByAccountShouldReturnObject()
        {
            var matches = MatchApi.GetMatchesByAccountId(32766, new OptionalParameters(new List<int>{11}, new List<int>{420}, new List<int>{75}, 20, 25, 1518425747064L));
            Assert.IsTrue(matches.Matches.Count() == 1);
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
            var matchTimeline = MatchApi.GetMatchTimelineById(2717074144);
            Assert.IsTrue(matchTimeline.Frames.Any());
            Assert.IsTrue(matchTimeline.FrameInterval > 0);
        }
    }
}
