namespace Wimbledon
{
    public class FortyLove : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new GameIn();
        }

        protected override IGameState ReceiverScore()
        {
            return new FortyFifteen();
        }
    }
}