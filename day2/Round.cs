namespace day2;

class Round
{
    public static readonly Dictionary<EHandType, int> HandToPoints = new()
    {
        { EHandType.Rock, 1 }, { EHandType.Paper, 2 }, { EHandType.Scissors, 3 },
    };
    
    public EHandType Hand1 { get; private set; }
    public EHandType Hand2 { get; private set; }

    public Round(EHandType hand1, EHandType hand2)
    {
        Hand1 = hand1;
        Hand2 = hand2;
    }

    public int Score()
    {
        var score = 0;

        if (this.Hand1 == this.Hand2)
        {
            score += 3;
        }
        else switch (this.Hand2)
        {
            case EHandType.Rock when this.Hand1 == EHandType.Scissors:
            case EHandType.Scissors when this.Hand1 == EHandType.Paper:
            case EHandType.Paper when this.Hand1 == EHandType.Rock:
                score += 6;
                break;
        }

        return score + HandToPoints[this.Hand2];
    }
}