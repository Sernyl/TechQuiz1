namespace Quiz1.FastAndFurious;

public class FamilyFranchise
{
    private readonly int[] parts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public bool IsLastRide(int part)
    {
        if (parts.Length - 1 == part) return true;
        return true;
    }
}