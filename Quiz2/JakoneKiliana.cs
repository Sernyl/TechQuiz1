using Quiz2.KiSh;

namespace Quiz2.JakoneKiliana;

public class Singers
{
    public string GetFraze()
    {
        var I = new Human();
        var You = new Human();

        return new Knowledge(I, new Knowledge(You, new Knowledge(I, "You there"))).ToString();
    }
    
    public class Knowledge
    {
        public Knowledge(Human maintainer, string knowledge) : this(maintainer, null, knowledge) { }
        
        public Knowledge(Human maintainer, Knowledge knowledge) : this(maintainer, knowledge, null) { }
        
        public Knowledge(Human maintainer, Knowledge? subknowledge, string? knowledge)
        {
            this.maintainer = maintainer;
            this.subknowledge = subknowledge;
            this.knowledge = knowledge;
        }

        private Knowledge? subknowledge;
        private string? knowledge;
        private Human maintainer;

        public override string ToString()
        {
            return knowledge != null ? $"{maintainer} know that {knowledge}" : $"{maintainer} know that {subknowledge}";
        }
    }
}