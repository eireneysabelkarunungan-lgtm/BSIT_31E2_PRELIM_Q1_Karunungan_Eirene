namespace TransportChallenge;

public class Airplane : Vehicle, IFlyable
{
    public override string Move()
    {
        return "Flying in the sky.";
    }
}
