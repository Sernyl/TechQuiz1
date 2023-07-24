namespace Quiz1.GroundhogDay;

public class Day
{
    private readonly Action _dayAction;

    public Day(Action dayAction)
    {
        _dayAction = dayAction;
    }

    private void LiveDay()
    {
        while (true)
            try
            {
                WakeUp();
                _dayAction();
                return;
            }
            catch
            {
            }
    }

    public void WakeUp()
    {
    }
}