using Quiz2.KiSh;

namespace Quiz2.Strykalo;

public class Singer
{
    public void Do(TravelVoucher voucher, Human I, Human You)
    {
        if (voucher.IsEnd())
        {
            Breakup(I, You);
            UseTrain(I);
        }
        
        var world = new World(
            new Yacht(), 
            new DateTime(2025, 8, 12), 
            new Human("I"), 
            new Human("You"));
    }

    public class TravelVoucher
    {
        public bool IsEnd()
        {
            throw new NotImplementedException();
        }
    }

    private void UseTrain(Human human)
    {
        throw new NotImplementedException();
    }
    
    private void Breakup(Human one, Human two)
    {
        throw new NotImplementedException();
    }
    
    

    public class World
    {
        public World(params object[] items)
        {
            
        }
    }

    public class Yacht
    {
        
    }
}
