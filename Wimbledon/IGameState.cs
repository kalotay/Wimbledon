namespace Wimbledon
{
    public interface IGameState
    {
        IGameState Next(Scorer scorer);
    }
}