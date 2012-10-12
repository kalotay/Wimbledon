namespace Wimbledon
{
    public abstract class NonTerminalGameState : IGameState
    {
        public IGameState Next(Scorer scorer)
        {
            switch (scorer)
            {
                case Scorer.Receiver:
                    return ReceiverScore();
                case Scorer.Server:
                    return ServerScore();
                default:
                    return this;
            }
        }

        protected abstract IGameState ServerScore();

        protected abstract IGameState ReceiverScore();
    }
}
