namespace Quiz1.BeloyeSolncePustyni
{
    public class Film
    {
        public void Do(Character character)
        {
            character.OpenFace();
        }
    }

    public class Gulchitay : Character
    {
    }

    public class Abdulla : Character
    {
        protected override void Open()
        {
            throw new ApplicationException();
        }
    }

    public abstract class Character
    {
        public void OpenFace()
        {
            Open();
        }

        protected virtual void Open()
        {

        }
    }
}
