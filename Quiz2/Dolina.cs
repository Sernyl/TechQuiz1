namespace Quiz2;

public class Dolina
{
    string GetMain()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            ["Alpha"] = "Quick brown fox",
            ["Bravo"] = "Silent night", 
            ["Charlie"] = "Bright future",
            ["Delta"] = "Ancient wisdom",
            ["Echo"] = "Digital world",
            ["Main"] = "Weather in the house",
            ["Foxtrot"] = "Creative mind",
            ["Golf"] = "Peaceful place",
            ["Hotel"] = "Happy moment",
            ["India"] = "Endless possibilities",
            ["Juliet"] = "Beautiful sunset"
        };

        return dictionary["Main"];
    }
}