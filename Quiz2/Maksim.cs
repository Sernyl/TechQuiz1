namespace Quiz2;

public class Maksim
{
    public void Operation()
    {
        var surgeon = new Surgeon();
        var heart = ReachTheHeart();

        surgeon.TakeByHand(heart);
        
        // WARNING: Don't break it
    }


    private Heart ReachTheHeart()
    {
        throw new NotImplementedException();
    }
    
    private void End()
    {
        
    }

    public class Surgeon()
    {
        public void TakeByHand(Heart heart)
        {
            
        }
    }

    public class Heart()
    {
        
    }
    
    
}