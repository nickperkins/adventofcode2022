namespace day2;

internal class Round
{
    public static readonly Dictionary<EHandType, int> HandToPoints = new()
    {
        { EHandType.Rock, 1 }, { EHandType.Paper, 2 }, { EHandType.Scissors, 3 }
    };

    public Round(EHandType hand1, EHandType hand2)
    {
        Hand1 = hand1;
        Hand2 = hand2;
    }

    public EHandType Hand1 { get; }
    public EHandType Hand2 { get; }

    public int Score()
    {
        var score = 0;

        if (Hand1 == Hand2)
            score += 3;
        else
            switch (Hand2)
            {
                case EHandType.Rock when Hand1 == EHandType.Scissors:
                case EHandType.Scissors when Hand1 == EHandType.Paper:
                case EHandType.Paper when Hand1 == EHandType.Rock:
                    score += 6;
                    break;
            }

        return score + HandToPoints[Hand2];
    }
}
