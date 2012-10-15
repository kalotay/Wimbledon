namespace Wimbledon.States
{
    public class LoveThirty : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new FifteenThirty();
        }

        protected override IGameState ReceiverScore()
        {
            return new LoveForty();
        }

        public override string ToString()
        {
            return "Love-Thirty";
        }
    }
}