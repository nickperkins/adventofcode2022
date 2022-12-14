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

    public static Priority Instance
    {
        get
        {
            if (_instance != null) return _instance;
            _instance = new Priority();
            return _instance;
        }
    }

    public int GetPriority(char item)
    {
        return _dataValues.FindIndex(x => x == item) + 1;
    }
}
