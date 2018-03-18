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
            var match = MatchApi.GetMatchById(TestSettings.MatchId);
            Assert.IsNotNull(match);
            Assert.AreEqual(TestSettings.MatchId, match.Id);
            Assert.IsTrue(match.QueueId > 0);
            Assert.IsTrue(match.MapId > 0);
            Assert.IsTrue(match.SeasonId > 0);
            Assert.IsNotNull(match.PlatformId);
            Assert.IsNotNull(match.GameVersion);
            Assert.IsNotNull(match.GameMode);
            Assert.IsTrue(match.GameCreation > 0);
            Assert.IsTrue(match.GameDuration > 0);
            Assert.IsTrue(match.Teams.Any());
            Assert.IsTrue(match.ParticipantIdentities.Any());
            Assert.IsTrue(match.Participants.Any());
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
            var beginIndex = 3;
            var matches = MatchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginIndex = beginIndex });
            Assert.AreEqual(beginIndex + 100, matches.EndIndex);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithEndIndexButNotBeginIndexShouldStartAt0()
        {
            var matches = MatchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters{ EndIndex = 50 });
            Assert.AreEqual(0, matches.StartIndex);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndIndexLessThanStartIndexShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginIndex = 2, EndIndex = 1 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithRangeGreaterThan100ShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginIndex = 200, EndIndex = 1 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndTimeLessThanBeginTimeShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginTime = 1000, EndTime = 0 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithTimeRanageGreaterThan1WeekShouldThrowException()
        {
            MatchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginTime = 1517443200, EndTime = 1520808582 });
        }

        [TestMethod]
        public void WhenRequestMatchByAccountShouldReturnObject()
        {
            var matches = MatchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters(new List<int>{11}, new List<int>{420}, new List<int>{75}, 20, 25, 1518425747064L));
            Assert.AreEqual(1, matches.Matches.Count());

            var match = matches.Matches.First();
            Assert.IsNotNull(match);
            Assert.IsTrue(match.GameId > 0);
            Assert.IsNotNull(match.Platform);
            Assert.IsTrue(match.Queue > 0);
            Assert.IsTrue(match.Champion > 0);
            Assert.IsNotNull(match.Role);
            Assert.IsNotNull(match.Lane);
            Assert.IsTrue(match.Season > 0);
            Assert.IsTrue(match.Timestamp > 0);
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
            var matches = MatchApi.GetRecentMatchesByAccountId(TestSettings.AccountId).Matches;
            var matchCount = 0;

            foreach (var match in matches)
            {
                Assert.IsTrue(match.GameId > 0);
                Assert.IsNotNull(match.Platform);
                Assert.IsTrue(match.Queue > 0);
                Assert.IsTrue(match.Champion > 0);
                Assert.IsNotNull(match.Role);
                Assert.IsNotNull(match.Lane);
                Assert.IsTrue(match.Season > 0);
                Assert.IsTrue(match.Timestamp > 0);

                matchCount++;
            }
            
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
            var matchTimeline = MatchApi.GetMatchTimelineById(TestSettings.MatchId);
            Assert.IsTrue(matchTimeline.Frames.Any());
            Assert.IsTrue(matchTimeline.FrameInterval > 0);
        }
    }
}
