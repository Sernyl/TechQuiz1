namespace Quiz1.BriliantovayaRuka;

public class Song
{
    public Song()
    {
        var wolf = new Character();
        var owl = new Character();

        var hare = new Character();
        hare.Fears = new[] { wolf, owl };
        hare.Action = MowTrynGrass;
    }

    private void MowTrynGrass()
    {
    }
}

public class Character
{
    public Character[] Fears { get; set; }
    public Action Action { get; set; }
}