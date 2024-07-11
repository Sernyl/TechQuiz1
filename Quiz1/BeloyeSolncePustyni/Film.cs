namespace Quiz1.Film
{
    public class Gulchitay : Character
    {
    }

    public class Abdulla : Character
    {
        public override void Open()
        {
            throw new ApplicationException();
        }
    }

    public abstract class Character
    {
        public virtual void Open()
        {
        }
    }
}
