namespace day2;

public static class Hand
{
    public static readonly Dictionary<char, EHandType> InputToHand = new()
    {
        { 'A', EHandType.Rock }, { 'B', EHandType.Paper }, { 'C', EHandType.Scissors }
    };
}
