
using System;
using NUnit.Framework;

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
        for (var i = 0; i &lt; 3; ++i)
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
        for (var i = 0; i &lt; 4; i++)
        {
            _game = _game.ScoreServer();
        }
        var winner = _game.GetWinner();
        Assert.That(winner, Is.EqualTo("Server"));
    }
    [Test]
    public void TestThatServerScoresFourTimesThenScoreIsGame()
    {
        for (var i = 0; i &lt; 4; i++)
        {
            _game = _game.ScoreServer();
        }
        var score = _game.GetCurrentScore();
        Assert.That(score, Is.EqualTo("Game"));
    }
    [Test]
    public void TestThatRecieverScoresFourTimesThenScoreIsGame()
    {
        for (var i = 0; i &lt; 4; i++)
        {
            _game = _game.ScoreReciever();
        }
        var score = _game.GetCurrentScore();
        Assert.That(score, Is.EqualTo("Game"));
    }
    [Test]
    public void TestThatRecieverScoresFourTimesThenWinnerIsReciever()
    {
        for (var i = 0; i &lt; 4; i++)
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
        for (var i = 0; i &lt; 4; i++)
        {
            _game = _game.ScoreReciever();
        }
        _game = _game.ScoreServer();
    }
    [Test]
    public void TestBothPlayersScoresFourTimesThenScoreIsDeuce()
    {
        for (var i = 0; i &lt; 4; ++i)
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
        for (var i = 0; i &lt; 3; ++i)
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
        for (var i = 0; i &lt; 3; ++i)
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
        for (var i = 0; i &lt; 3; ++i)
        {
            _game = _game.ScoreServer();
            _game = _game.ScoreReciever();
        }
        _game = _game.ScoreReciever();
        var score = _game.GetCurrentScore();
        Assert.That(score, Is.EqualTo("Advantage Out"));
    }
}

public class Tennisgame
{
    private readonly int _serverScore;
    private readonly int _recieverScore;
    private readonly string _winner;

    public Tennisgame()
    {

    }
    private Tennisgame(int serverScore, int recieverScore)
    {
        _serverScore = serverScore;
        _recieverScore = recieverScore;
        if (_serverScore &gt; 3 &amp;&amp; _serverScore - _recieverScore &gt;= 2)
        {
            _winner = "Server";
        }
        else if (_recieverScore &gt; 3 &amp;&amp; _recieverScore - _serverScore &gt;= 2)
        {
            _winner = "Reciever";
        }
    }

    public string GetCurrentScore()
    {
        if (_winner != null)
        {
            return "Game";
        }
        if (_recieverScore == _serverScore &amp;&amp; _recieverScore &gt;= 3)
        {
            return "Deuce";
        }
        if (_serverScore &gt;= 3 &amp;&amp; _recieverScore &gt;= 3)
        {
            return "Advantage " + (_serverScore &gt; _recieverScore ? "In" : "Out");
        }
        string server = ConvertScore(_serverScore);
        string reciever = _recieverScore == _serverScore ? "All" : ConvertScore(_recieverScore);
        return string.Format("{0}-{1}", server, reciever);
    }

    private static string ConvertScore(int score)
    {
        switch (score)
        {
            case 0:
                return "Love";
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            case 3:
                return "Forty";
            default:
                return "";
        }
    }

    public Tennisgame ScoreServer()
    {
        if (_winner != null)
        {
            throw new Exception();
        }
        return new Tennisgame(_serverScore + 1, _recieverScore);
    }

    public Tennisgame ScoreReciever()
    {
        if (_winner != null)
        {
            throw new Exception();
        }
        return new Tennisgame(_serverScore, _recieverScore + 1);
    }

    public string GetWinner()
    {
        return _winner;
    }
}
