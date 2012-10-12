namespace Wimbledon
{
    public class Deuce : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new AdvantageIn();
        }

        protected override IGameState ReceiverScore()
        {
            return new AdvantageOut();
        }

        public override string ToString()
        {
            return "Deuce";
        }
    }
}