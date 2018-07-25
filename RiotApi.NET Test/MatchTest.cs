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
        private readonly MatchApi _matchApi = new MatchApi(new NET.RiotApi("RGAPI-f435204c-c851-4c0f-bc52-75c3ece4e10b", NET.RiotApi.Regions.NA));

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchWithNegativeIdShouldThrowException()
        {
            _matchApi.GetMatchById(-1);
        }

        [TestMethod]
        public void WhenRequestMatchShouldReturnObject()
        {
            var match = _matchApi.GetMatchById(TestSettings.MatchId);
            Assert.IsNotNull(match);
            Assert.AreEqual(TestSettings.MatchId, match.GameId);
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
            _matchApi.GetMatchesByAccountId(-1, null);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithBeginIndexButNoEndIndexShouldReturnBeginIndexPlus100()
        {
            var beginIndex = 3;
            var matches = _matchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginIndex = beginIndex });
            Assert.AreEqual(beginIndex + 100, matches.EndIndex);
        }

        [TestMethod]
        public void WhenRequestMatchByAccountWithEndIndexButNotBeginIndexShouldStartAt0()
        {
            var matches = _matchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters{ EndIndex = 50 });
            Assert.AreEqual(0, matches.StartIndex);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndIndexLessThanStartIndexShouldThrowException()
        {
            _matchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginIndex = 2, EndIndex = 1 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithRangeGreaterThan100ShouldThrowException()
        {
            _matchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginIndex = 200, EndIndex = 1 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithEndTimeLessThanBeginTimeShouldThrowException()
        {
            _matchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginTime = 1000, EndTime = 0 });
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchByAccountWithTimeRanageGreaterThan1WeekShouldThrowException()
        {
            _matchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters { BeginTime = 1517443200, EndTime = 1520808582 });
        }

        [TestMethod]
        public void WhenRequestMatchByAccountShouldReturnObject()
        {
            var matches = _matchApi.GetMatchesByAccountId(TestSettings.AccountId, new OptionalParameters(new List<int>{11}, new List<int>{420}, new List<int>{75}));
            Assert.IsTrue(matches.Matches.Any());

            var match = matches.Matches.First();
            Assert.IsNotNull(match);
            Assert.IsTrue(match.GameId > 0);
            Assert.IsNotNull(match.PlatformId);
            Assert.IsTrue(match.Queue > 0);
            Assert.IsTrue(match.Champion > 0);
            Assert.IsNotNull(match.Role);
            Assert.IsNotNull(match.Lane);
            Assert.IsTrue(match.Season > 0);
            Assert.IsTrue(match.Timestamp > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public void WhenRequestMatchTimelineWithNullMatchIdShouldThrowException()
        {
            _matchApi.GetMatchTimelineById(-1);
        }

        [TestMethod]
        public void WhenRequestMatchTimelineShouldReturnObject()
        {
            var matchTimeline = _matchApi.GetMatchTimelineById(TestSettings.MatchId);
            Assert.IsTrue(matchTimeline.Frames.Any());
            Assert.IsTrue(matchTimeline.FrameInterval > 0);
        }
    }
}
