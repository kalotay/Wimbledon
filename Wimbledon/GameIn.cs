using System;

namespace Wimbledon
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