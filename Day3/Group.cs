using System.Collections.ObjectModel;

namespace Day3;

public class Group
{
    private List<Rucksack> _sacks;

    public Group(IList<Rucksack> sacks)
    {
        if (sacks == null)
        {
            throw new ArgumentNullException(nameof(sacks));
        }
        if (sacks.Count != 3)
        {
            throw new ArgumentException("Incorrect number of sacks in the group.");
        }

        _sacks = (List<Rucksack>)sacks;
    }

    public char GetGroupBadge()
    {
        var sack1 = _sacks[0];
        foreach (char c in sack1.GetContents())
        {
            if (_sacks.TrueForAll(s => s.GetContents().Contains(c)))
            {
                return c;
            }
        }

        throw new NoGroupBadgeFoundException("Unable to find a valid group badge");
    }
}

