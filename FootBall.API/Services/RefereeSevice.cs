namespace FootBall.API.Services
{
    using FootBall.API.Entities;
    using FootBall.API.Interfaces;
    public class RefereeService : IPRefereeService
    {
        public Referee GetConcrettePlayer(Referee referee)
        {
            if (referee == null || referee.Name.Length < 3 || referee.Secondname.Length < 5)
            {
                return null;
            }
            return referee;
        }

        public Referee GetHeadReferee(Referee referee)
        {
            throw new NotImplementedException();
        }
    }
}

