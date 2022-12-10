namespace day2;

using System.Globalization;
using System.Resources;

static class Program
{
    private static void Main(string[] args)
    {
        var rm = new ResourceManager("day2", typeof(Program).Assembly);
        var culture = new CultureInfo("en-AU");

        var rounds = new List<Round>();

        // Read in the data file line by line
        foreach (var line in File.ReadLines(Path.Combine(AppContext.BaseDirectory, "input.txt")))
        {
            var opponentHand = Hand.InputToHand[line[0]];
            rounds.Add(new Round(opponentHand,
                Strategy.CorrectHand(opponentHand, Strategy.InputToResult[line[2]])));
        }

        var score = rounds.Sum(round => round.Score());

        
        Console.WriteLine(day2.Program_Main_The_score_for_this_set_is___0_, score);
    }

    
}