namespace Wimbledon.States
{
    public class LoveFifteen : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new FifteenAll();
        }

        protected override IGameState ReceiverScore()
        {
            return new LoveThirty();
        }

        public override string ToString()
        {
            return "Love-Fifteen";
        }
    }
}