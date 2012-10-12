namespace Wimbledon
{
    public class ThirtyLove : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new FortyLove();
        }

        protected override IGameState ReceiverScore()
        {
            return new ThirtyFifteen();
        }

        public override string ToString()
        {
            return "Thirty-Love";
        }
    }
}