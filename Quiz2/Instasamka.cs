namespace Quiz2;

public class Instasamka
{
    public IEnumerable<Human> Revision(List<object> items)
    {
        foreach (var item in items)
        {
            yield return Buyer(item);
        }
    }
    
    private Human Buyer(object item)
    {
        return new Human("Husband");
    }
}