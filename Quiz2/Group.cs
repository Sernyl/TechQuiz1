namespace Quiz2.Accademy;

public class Group
{
    public void Start(DateTime day)
    {
        if (day.DayOfWeek == DayOfWeek.Saturday) return;
        
        var singer1 = new Singer();
        var singer2 = new Singer();
        
        Console.WriteLine(singer1.Hello());
        Console.WriteLine(singer2.Hello());
    }

    class Singer
    {
        public string Hello()
        {
            return "Good morning, Country!!!";
        }
    }
}

