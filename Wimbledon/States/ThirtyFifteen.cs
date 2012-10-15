namespace Wimbledon.States
{
    public class ThirtyFifteen : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new FortyFifteen();
        }

        protected override IGameState ReceiverScore()
        {
            return new ThirtyAll();
        }
    }
}