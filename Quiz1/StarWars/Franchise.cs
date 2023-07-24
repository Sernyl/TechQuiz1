namespace Quiz1.StarWars;

public class Franchise
{
    private readonly Dictionary<string, double> numbers = new()
    {
        { "one", 4 },
        { "two", 5 },
        { "three", 6 },
        { "four", 1 },
        { "five", 2 },
        { "six", 3 },
        { "seven", 4.5 },
        { "eight", 7 },
        { "nine", 8 },
        { "ten", 9 }
    };

    public double StringToDouble(string number)
    {
        return numbers[number];
    }
}