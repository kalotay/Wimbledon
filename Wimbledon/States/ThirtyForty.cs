namespace Wimbledon.States
{
    public class ThirtyForty : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new Deuce();
        }

        protected override IGameState ReceiverScore()
        {
            return new GameOut();
        }
    }
}