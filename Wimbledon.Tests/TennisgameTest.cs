using NUnit.Framework;

namespace Wimbledon.Tests
{
    [TestFixture]
    public class TennisgameTest
    {
        private Tennisgame _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Tennisgame();
        }

        [Test]
        public void TestInitiationNotNull()
        {
            Assert.That(_game, Is.Not.Null);
        }

        [Test]
        public void TestInitialScoreIsLoveAll()
        {
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Love-All"));
        }
        
        [Test]
        public void TestServerScoresThenScoreIsFifteenLove()
        {
            _game = _game.ScoreServer();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Fifteen-Love"));
        }

        
        [Test]
        public void TestRecieverScoresThenScoreIsLoveFifteen()
        {
            _game = _game.ScoreReciever();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Love-Fifteen"));
        }

        [Test]
        public void TestBothPlayersScoresThenScoreIsFifteenAll()
        {
            _game = _game.ScoreServer();
            _game = _game.ScoreReciever();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Fifteen-All"));
        }
        
        [Test]
        public void TestServerScoresTwiceThenScoreIsThirtyLove()
        {
            _game = _game.ScoreServer();
            _game = _game.ScoreServer();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Thirty-Love"));
        }
        /*
        [Test]
        public void TestBothPlayersScoresTwiceThenScoreIsThirtyAll()
        {
            _game = _game.ScoreServer();
            _game = _game.ScoreServer();
            _game = _game.ScoreReciever();
            _game = _game.ScoreReciever();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Thirty-All"));
        }
        [Test]
        public void TestRecieverScoresThreeTimesThenScoreIsLoveForty()
        {
            _game = _game.ScoreReciever();
            _game = _game.ScoreReciever();
            _game = _game.ScoreReciever();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Love-Forty"));
        }
        [Test]
        public void TestBothPlayersScoresThreeTimesThenScoreIsDeuce()
        {
            for (var i = 0; i < 3; ++i)
            {
                _game = _game.ScoreServer();
                _game = _game.ScoreReciever();
            }
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Deuce"));
        }
        [Test]
        public void TestThatServerScoresFourTimesThenServerIsWinner()
        {
            for (var i = 0; i < 4; i++)
            {
                _game = _game.ScoreServer();
            }
            var winner = _game.GetWinner();
            Assert.That(winner, Is.EqualTo("Server"));
        }
        [Test]
        public void TestThatServerScoresFourTimesThenScoreIsGame()
        {
            for (var i = 0; i < 4; i++)
            {
                _game = _game.ScoreServer();
            }
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Game"));
        }
        [Test]
        public void TestThatRecieverScoresFourTimesThenScoreIsGame()
        {
            for (var i = 0; i < 4; i++)
            {
                _game = _game.ScoreReciever();
            }
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Game"));
        }
        [Test]
        public void TestThatRecieverScoresFourTimesThenWinnerIsReciever()
        {
            for (var i = 0; i < 4; i++)
            {
                _game = _game.ScoreReciever();
            }
            var winner = _game.GetWinner();
            Assert.That(winner, Is.EqualTo("Reciever"));
        }
        [Test]
        public void TestInitialWinnerIsNull()
        {
            var winner = _game.GetWinner();
            Assert.That(winner, Is.Null);
        }
        [Test, ExpectedException]
        public void TestThatNoMorePointsIsAllowedAfterGame()
        {
            for (var i = 0; i < 4; i++)
            {
                _game = _game.ScoreReciever();
            }
            _game = _game.ScoreServer();
        }
        [Test]
        public void TestBothPlayersScoresFourTimesThenScoreIsDeuce()
        {
            for (var i = 0; i < 4; ++i)
            {
                _game = _game.ScoreServer();
                _game = _game.ScoreReciever();
            }
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Deuce"));
        }
        [Test]
        public void TestServerScoresFourTimesAndRecieverScoresThreeThenTheScoreIsAdvantageIn()
        {
            for (var i = 0; i < 3; ++i)
            {
                _game = _game.ScoreServer();
                _game = _game.ScoreReciever();
            }
            _game = _game.ScoreServer();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Advantage In"));
        }
        [Test]
        public void TestServerScoresFourTimesAndRecieverScoresThreeThenTheWinnerIsNull()
        {
            for (var i = 0; i < 3; ++i)
            {
                _game = _game.ScoreServer();
                _game = _game.ScoreReciever();
            }
            _game = _game.ScoreServer();
            var winner = _game.GetWinner();
            Assert.That(winner, Is.Null);
        }
        [Test]
        public void TestServerScoresThreeTimesAndRecieverScoresFourThenTheScoreIsAdvantageOut()
        {
            for (var i = 0; i < 3; ++i)
            {
                _game = _game.ScoreServer();
                _game = _game.ScoreReciever();
            }
            _game = _game.ScoreReciever();
            var score = _game.GetCurrentScore();
            Assert.That(score, Is.EqualTo("Advantage Out"));
        } */
    }
}