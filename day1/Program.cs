using System.Globalization;
using System.Resources;

namespace day1;

internal static class Program
{
    private static void Main(string[] args)
    {
        var rm = new ResourceManager("day1.AOCResources", typeof(Program).Assembly);
        var culture = new CultureInfo("en-AU");

        var calorieCount = new List<int>();

        // Read in the data file line by line
        var temp = 0;
        foreach (var line in File.ReadLines(Path.Combine(AppContext.BaseDirectory, "input.txt")))
        {
            var lineValue = int.TryParse(line, out var tmp) ? (int?)tmp : null;
            if (lineValue != null)
            {
                temp += (int)lineValue;
            }
            else
            {
                calorieCount.Add(temp);
                temp = 0;
            }
        }

        // Part 1
        Console.WriteLine(rm.GetString("Part", culture) + " 1: {0}", calorieCount.Max());

        // Part 2
        calorieCount.Sort();
        calorieCount.Reverse();
        Console.WriteLine(rm.GetString("Part", culture) + " 2: {0}",
            calorieCount.Take(3).Aggregate(0, (acc, x) => acc + x));
    }
}
