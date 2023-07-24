namespace Quiz1.Inception;

public class Film
{
    private const int LastDreamLevel = int.MaxValue;

    private readonly Human _human;

    public Film(Human human)
    {
        _human = human;
    }

    public void VisitInnerDream(int dreamLevel, int neededDreamLevel)
    {
        if (dreamLevel == neededDreamLevel)
        {
            _human.DoSomething();
            return;
        }

        if (dreamLevel > 3 && _human.IsDied) VisitInnerDream(LastDreamLevel, neededDreamLevel);
        VisitInnerDream(dreamLevel + 1, neededDreamLevel);
    }
}

public class Human
{
    public bool IsDied;

    public void DoSomething()
    {
    }
}