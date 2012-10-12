namespace Wimbledon
{
    public class FortyThirty : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new GameIn();
        }

        protected override IGameState ReceiverScore()
        {
            return new Deuce();
        }
    }
}