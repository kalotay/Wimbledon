namespace Wimbledon
{
    public class FifteenForty : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new ThirtyForty();
        }

        protected override IGameState ReceiverScore()
        {
            return new GameOut();
        }
    }
}