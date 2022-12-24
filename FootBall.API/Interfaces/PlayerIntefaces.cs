namespace FootBall.API.Interfaces
{
    using FootBall.API.Entities;
    public interface IPlayerService
    {
        Player GetMainPlayer(Player player);
    }
}
