namespace Wimbledon.States
{
    public class FifteenThirty : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new ThirtyAll();
        }

        protected override IGameState ReceiverScore()
        {
            return new FifteenForty();
        }
    }
}