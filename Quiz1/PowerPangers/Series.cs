using System.Drawing;

namespace Quiz1.PowerPangers;

public class Series
{
    public void RunSeries()
    {
        var monster = new Monster();

        var heroes = new[]
        {
            new Hero(Color.Blue),
            new Hero(Color.Red),
            new Hero(Color.Yellow),
            new Hero(Color.Black),
            new Hero(Color.Pink)
        };
        var heroCommand = new HeroCommand(heroes);

        heroCommand.Kill(monster);

        monster.SetBig();

        heroCommand.GetZords();

        heroCommand.Kill(monster);
    }
}

public class Monster
{
    public void SetBig()
    {
    }
}

public class Hero
{
    private readonly Color _color;

    public Hero(Color color)
    {
        _color = color;
    }
}

public class HeroCommand
{
    private readonly Hero[] _command;
    private Hero[] command;

    public HeroCommand(Hero[] command)
    {
        _command = command;
    }

    public void Kill(Monster monster)
    {
    }

    public void GetZords()
    {
    }
}