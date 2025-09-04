using Quiz2.KiSh;

namespace Quiz2.Instasamka;

public class Singer
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