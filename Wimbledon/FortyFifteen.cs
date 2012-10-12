namespace Wimbledon
{
    public class FortyFifteen : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new GameIn();
        }

        protected override IGameState ReceiverScore()
        {
            return new FortyThirty();
        }
    }
}