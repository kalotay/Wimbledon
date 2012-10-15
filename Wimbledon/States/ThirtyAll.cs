namespace Wimbledon.States
{
    public class ThirtyAll : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new FortyThirty();
        }

        protected override IGameState ReceiverScore()
        {
            return new ThirtyForty();
        }

        public override string ToString()
        {
            return "Thirty-All";
        }
    }
}