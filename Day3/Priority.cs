namespace Day3;

public sealed class Priority
{
    private readonly List<char> _dataValues;

    private Priority()
    {
        _dataValues = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToList();
        _dataValues.AddRange(Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c));
    }

    private static Priority? _instance;

    public static Priority GetInstance()
    {
        if (_instance != null) return _instance;
        return _instance ??= new Priority();
    }

    public int GetPriority(char item)
    {
        return _dataValues.FindIndex(x => x == item) + 1;
    }
}
