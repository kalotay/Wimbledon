namespace Wimbledon
{
    public class LoveForty : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new FifteenForty();
        }

        protected override IGameState ReceiverScore()
        {
            return new GameOut();
        }

        public override string ToString()
        {
            return "Love-Forty";
        }
    }
}