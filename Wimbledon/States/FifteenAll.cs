namespace Wimbledon.States
{
    public class FifteenAll : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new ThirtyFifteen();
        }

        protected override IGameState ReceiverScore()
        {
            return new FifteenThirty();
        }

        public override string ToString()
        {
            return "Fifteen-All";
        }
    }
}