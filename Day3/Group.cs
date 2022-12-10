namespace Day3;

public class Group
{
    private List<Rucksack> _sacks;

    public Group(List<Rucksack> sacks)
    {
        if (sacks.Count != 3)
        {
            throw new ArgumentException("Incorrect number of sacks in the group.");
        }

        _sacks = sacks;
    }

    public char GetGroupBadge()
    {
        var sack1 = _sacks[0];
        foreach (char c in sack1.Contents)
        {
            if (_sacks.TrueForAll(s => s.Contents.Contains(c)))
            {
                return c;
            }
        }

        throw new Exception("Unable to find a valid group badge");
    }
}
