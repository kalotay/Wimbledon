namespace Wimbledon.States
{
    public class LoveAll : NonTerminalGameState
    {

        public override string ToString()
        {
            return "Love-All";
        }

        protected override IGameState ServerScore()
        {
            return new FifteenLove();
        }

        protected override IGameState ReceiverScore()
        {
            return new LoveFifteen();
        }
    }
}