namespace Day3;

public class Rucksack
{
    private char[] _compartment1;
    private char[] _compartment2;
    private char[] _contents;

    public char[] GetCompartment1() => (char[])_compartment1;

    public char[] GetCompartment2() => (char[])_compartment2;
    
    public char[] GetContents() => _contents;

    public Rucksack(string contents)
    {
        if (contents == null)
        {
            throw new ArgumentNullException(nameof(contents));
        }
        var compartmentSize = contents.Length / 2;

        _contents = contents.ToCharArray();
        _compartment1 = contents.ToCharArray(0, compartmentSize);
        _compartment2 = contents.ToCharArray(compartmentSize, compartmentSize);
        
    }

    public char DuplicateItems()
    {
        foreach (var c in GetCompartment1())
        {
            if (GetCompartment2().Contains(c)) return c;
        }

        throw new NoDuplicateFoundException("No duplicate found");
    }
}
