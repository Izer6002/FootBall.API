namespace FootBall.API.Services
{
    using FootBall.API.Entities;
    using FootBall.API.Interfaces;
    public class PlayerService : IPlayerService
    {
        public Player GetConcrettePlayer(Player player)
        {
            if (player == null || player.Name.Length < 2 || player.Surname.Length < 4)
            {
                return null;
            }
            return player;
        }

        public Player GetMainPlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
