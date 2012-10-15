namespace Wimbledon.States
{
    public class AdvantageIn : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new GameIn();
        }

        protected override IGameState ReceiverScore()
        {
            return new Deuce();
        }

        public override string ToString()
        {
            return "Advantage In";
        }
    }
}