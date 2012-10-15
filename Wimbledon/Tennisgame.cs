using Wimbledon.States;

namespace Wimbledon
{
    public class Tennisgame
    {
        private IGameState _currentState;

        public Tennisgame()
        {
            _currentState = new LoveAll();
        }

        public string GetCurrentScore()
        {
            return _currentState.ToString();
        }

        public void ScoreServer()
        {
            NextState(Scorer.Server);
        }

        private void NextState(Scorer scorer)
        {
            _currentState = _currentState.Next(scorer);
        }

        public void ScoreReciever()
        {
            NextState(Scorer.Receiver);
        }

        public string GetWinner()
        {
            var gameState = _currentState.GetType();

            if (gameState == typeof(GameIn))
            {
                return "Server";
            }

            if (gameState == typeof(GameOut))
            {
                return "Receiver";
            }

            return null;
        }
    }
}