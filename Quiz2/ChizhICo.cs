using Quiz2.KiSh;

namespace Quiz2.ChizhICo;

public class Via
{
    public IEnumerable<Human> GetBand()
    {
        yield return drummer;
        yield return guitarist;
        yield return rhythm;
        yield return buss;
        yield return ionica;
    }

    public Human GetMaster()
    {
        return teacher;
    }
    
    private Drummer drummer = new Drummer();
    private Guitarist guitarist = new Guitarist();
    private Rhythm rhythm = new Rhythm();
    private Buss buss = new Buss();
    private Ionica ionica = new Ionica();
    
    private Accordion teacher = new Accordion();
}


public class Musician : Human
{
}

public class Drummer : Musician
{
}

public class Guitarist : Musician
{
}
    
public class Rhythm : Musician
{
}

public class Buss : Musician
{
}

public class Ionica : Musician
{
}

public class Accordion : Musician
{
    
}