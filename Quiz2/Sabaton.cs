namespace Quiz2.Sabaton;

public class Singer
{
    public string GetThemeForSong()
    {
        if (list.Count == 0)
            return "War";
        
        var random = new Random();
        var index = random.Next(list.Count);
        return list[index];
    }
    
    private List<string> list =
    [
        "Great War",
        "World War 2",
        "Great Northern War",
        "Civil War"
    ];
}