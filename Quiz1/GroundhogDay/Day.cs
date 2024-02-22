namespace Quiz1.GroundhogDay;

public class Day
{
    private readonly Action _dayAction;

    public Day(string liveHistory)
    {
        prewiousDayHistory = dayAction;
        
    }

    public void LiveDay()
    {
        while (true)
            try
            {
                foreach(var character in otherCharacters)
                {
                    character.WakeUp();
                }
                var dayHistory
                prewiousDayHistory += prewiousDayHistory;
                return;
            }
            catch
            {
            }
    }

    
    private Character mainCharacter;
    private Character[] otherCharacters;
    private string prewiousDayHistory = "All events of the day";
}

public class Character
{
    public void WakeUp()
    {
    }

    public void SetHistory(string history)
    {
    }

    public void RevertHistory()
    {
    }
}
