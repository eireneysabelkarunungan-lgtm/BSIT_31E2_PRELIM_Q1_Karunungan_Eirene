namespace TransportChallenge;

public class Boat : Vehicle, ISailable
{
    public override string Move()
    {
        return "Sailing on the water.";
    }
}
