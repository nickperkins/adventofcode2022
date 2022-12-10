namespace Day3;

public class Rucksack
{
    public char[] Compartment1 { get; private set;}
    public char[] Compartment2 { get; private set;  }
    public char[] Contents { get; private set; }

    public Rucksack(string contents)
    {
        var compartmentSize = contents.Length / 2;

        Contents = contents.ToCharArray();
        Compartment1 = contents.ToCharArray(0, compartmentSize);
        Compartment2 = contents.ToCharArray(compartmentSize, compartmentSize);
        
    }

    public char DuplicateItems()
    {
        foreach (var c in Compartment1)
        {
            if (Compartment2.Contains(c)) return c;
        }

        throw new Exception("No duplicate found");
    }
}
