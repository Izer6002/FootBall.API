namespace FootBall.API.Interfaces
{
    using FootBall.API.Entities;
    public interface IPRefereeService
    {
        Referee GetHeadReferee(Referee referee);
    }
}
