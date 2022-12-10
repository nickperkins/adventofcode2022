namespace day2;

public static class Strategy
{
    public static readonly Dictionary<char, EResult> InputToResult = new()
    {
        { 'X', EResult.Lose }, { 'Y', EResult.Draw }, { 'Z', EResult.Win }
    };

    public static EHandType CorrectHand(EHandType hand, EResult result)
    {
        if (result == EResult.Draw) return hand;

        switch (hand)
        {
            case EHandType.Rock:
                return result == EResult.Win ? EHandType.Paper : EHandType.Scissors;
            case EHandType.Paper:
                return result == EResult.Win ? EHandType.Scissors : EHandType.Rock;
            case EHandType.Scissors:
                return result == EResult.Win ? EHandType.Rock : EHandType.Paper;
            default:
                throw new ArgumentOutOfRangeException(nameof(hand), hand, null);
        }
    }
}
