namespace Quiz1.GroundhogDay;

public class Day
{
    public Day()
    {
        mainCharacter = new Character();
        otherCharacters = new Character[13];
        for (var i = 0; i < 12; i++)
        {
            otherCharacters[i] = new Character();
        }
    }

    public void LiveDay()
    {
        while (true)
        {
            mainCharacter.WakeUp();
            var dayHistory = mainCharacter.DoActions();

            mainCharacter.SetHistory(mainCharacter.GetLiveExperience() + dayHistory);
        }
    }
    
    private Character mainCharacter;
    private Character[] otherCharacters;
}

public class Character
{
    public void WakeUp()
    {
    }

    public void SetHistory(string history)
    {
    }

    public string DoActions()
    {
        return "";
    }

    public string GetLiveExperience()
    {
        return "";
    }
}
