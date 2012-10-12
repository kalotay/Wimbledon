namespace Wimbledon
{
    public class FifteenLove : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new ThirtyLove();
        }

        protected override IGameState ReceiverScore()
        {
            return new FifteenAll();
        }

        public override string ToString()
        {
            return "Fifteen-Love";
        }
    }
}