namespace Quiz2.Shufutinsky;

public class Singer
{
    public List<DateTime> GetDate()
    {
        var list = new List<DateTime>();

        for (var i = 1; i <= 31; i++)
        {
            list.Add(new DateTime(2025, 9, i));
        }

        list.Reverse();
        
        return list;
    }
}