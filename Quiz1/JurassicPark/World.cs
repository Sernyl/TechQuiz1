public class World
{
    private List<Organism> organisms;

    public void PrepareWorld(Tree[] trees)
    {
        var dnas = trees.SelectMany(t => t.Resin.Mosquito).Select(m => m.Blood);
        foreach (var dna in dnas) organisms.Add(new Organism(dna));
    }

    public void Run()
    {
        foreach (var organism in organisms) organism.SetFree();
    }
}

public class Tree
{
    public Resin Resin { get; set; }
}

public class Resin
{
    public Mosquito[] Mosquito { get; set; }
}

public class Mosquito
{
    public Blood Blood { get; set; }
}

public class Blood
{
}

public class Organism
{
    public Organism(Blood blood)
    {
    }

    public void SetFree()
    {
    }
}
