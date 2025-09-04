namespace Quiz2;

public class Horror
{
    public void Do()
    {
        using (var stranger = new Human())
        {
            var house = new House(Oldman);
            house.Income(stranger);
        
            stranger.Eating();
            stranger.ListeningTo(Oldman);
        }
    }

    private Human Oldman = new Human();
}

public class House
{
    public House(Human master)
    {
        
    }
    
    public void Income(Human human)
    {
        
    }
}

public class Human : IDisposable
{
    public Human()
    {
        
    }
    
    public Human(string name)
    {
            
    }

    public void Eating()
    {
        
    }

    public void ListeningTo(Human human)
    {
        
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}