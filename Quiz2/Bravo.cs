using System.Drawing;

namespace Quiz2.Bravo;

public class ThisCity : City, IComparable<City>
{
    public bool HasInfrastructure(string infrastructure)
    {
        switch (infrastructure)
        {
            case "River":
            case "Boulevard":
            case "Bridge":
                return true;
            default:
                return false;
        }
    }
    
    public override bool IsTheBest => true;
    public Color SidewalkColor => Color.Blue;

    public int CompareTo(City? other)
    {
        return 1;
    }
}

public abstract class City
{
    public abstract bool IsTheBest { get; }
}