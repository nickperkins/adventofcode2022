List<int> calorieCount = new List<int>();

// Read in the data file line by line
int temp = 0;
foreach (string line in System.IO.File.ReadLines(Path.Combine(AppContext.BaseDirectory, "input.txt")))
{
    int? lineValue = int.TryParse(line, out int tmp) ? (int?)tmp : null;
    if (lineValue != null)
    {
        temp += lineValue ?? default(int);
    }
    else
    {
        calorieCount.Add(temp);
        temp = 0;
    }
}

// Part 1
Console.WriteLine("Part 1: {0}", calorieCount.Max());

// Part 2
calorieCount.Sort();
calorieCount.Reverse();
Console.WriteLine("Part 2: {0}", calorieCount.Take(3).Aggregate(0, (acc, x) => acc + x));