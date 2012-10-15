using System;

namespace Wimbledon.States
{
    public class GameIn : IGameState
    {
        public IGameState Next(Scorer scorer)
        {
            throw new Exception();
        }

        public override string ToString()
        {
            return "Game";
        }
    }
}