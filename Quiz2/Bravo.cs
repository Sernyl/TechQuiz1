using System.Drawing;

namespace Quiz2.Bravo;

public class City : IComparable<City>
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
    
    public bool HasTransport(string infrastructure)
    {
        switch (infrastructure)
        {
            case "Steamship":
            case "Tram":
                return true;
            default:
                return false;
        }
    }
    
    public bool IsTheBest => true;
    public Color SidewalkColor => Color.Blue;

    public int CompareTo(City? other)
    {
        return 1;
    }
}