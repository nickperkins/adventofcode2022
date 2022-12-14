using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Net.Http.Headers;

namespace Day3;

internal static class Program
{
    private static void Main(string[] args)
    {
        var p = Priority.Instance;

        var sacks = new Collection<Rucksack>();

        foreach (var line in File.ReadLines(Path.Combine(AppContext.BaseDirectory, "input.txt")))
        {
            sacks.Add(new Rucksack(line));
        }

        Console.WriteLine(sacks.Sum(c => p.GetPriority(c.DuplicateItems())));

        var groups = new Collection<Group>();

        var groupedSacks = sacks.Select((elem, index) => new { elem, index }).GroupBy(x => x.index / 3);

        foreach (var group in groupedSacks)
        {
            groups.Add(new Group(group.Select(x => x.elem).ToList()));
        }
        
        Console.WriteLine(groups.Sum(g => p.GetPriority(g.GetGroupBadge())));

    }
}
