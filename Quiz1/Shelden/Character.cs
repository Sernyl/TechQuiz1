namespace Quiz1.BBTShelden;

public class WhoIsThis : Character
{
    public override Character FavoriteCharacter => new Spock();

    public override Job Job => new("Калифорнийскй технологический институт", "Исследователь теории струн");

    public override int CountOfBrothers => 1;

    public override int CountOfSisters => 1;
}

public class Spock : Character
{
    public override Job Job => new("USS Энтерпрайз (NCC-1701)", "Первый помощник капитана", "Научный сотрудник");

    public override int CountOfBrothers => 1;
}

public abstract class Character
{
    protected virtual bool IsNormal => true;

    public virtual Character FavoriteCharacter => null;

    public virtual Job Job => null;

    public virtual int CountOfBrothers => 0;

    public virtual int CountOfSisters => 0;
}

public class Job
{
    private readonly string[] _jobTitle;
    private readonly string _workPlace;

    public Job(string workPlace, params string[] jobTitle)
    {
        _workPlace = workPlace;
        _jobTitle = jobTitle;
    }
}