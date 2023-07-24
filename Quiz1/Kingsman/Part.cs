namespace Quiz1.Kingsman;

public class Part
{
    private World world;


    public bool Run()
    {
        var teenager = new Teenager();

        teenager.Teach();
        if (teenager.Test()) return true;

        world.SaveBy(teenager);

        return teenager.IsGentleman();
    }
}

public class Teenager
{
    public void Teach()
    {
    }


    public bool Test()
    {
        return true;
    }

    public bool IsGentleman()
    {
        return true;
    }
}

public class World
{
    public void SaveBy(Teenager teenager)
    {
    }
}