namespace Wimbledon.States
{
    public class AdvantageOut : NonTerminalGameState
    {
        protected override IGameState ServerScore()
        {
            return new Deuce();
        }

        protected override IGameState ReceiverScore()
        {
            return new GameOut();
        }

        public override string ToString()
        {
            return "Advantage Out";
        }
    }
}