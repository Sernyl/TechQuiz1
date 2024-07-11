namespace Quiz1.Some_Like_It_Hot;

public class GirlDecorator
{
    private Man character;

    public string[] SayYourShortcomings() => new[]
    {
        "Smoke",
        "Terrible past",
        "3 yers now I've been living with a saxophone player",
        "I can never have children",
        "Oh. I'm a man"
    };
}

public class Man
{
}
