namespace Day3;

public class NoGroupBadgeFoundException : Exception
{
    public NoGroupBadgeFoundException() : base("No Group Badge Found")
    {
    }
    
    public NoGroupBadgeFoundException(string? message) : base(message)
    {
    }
    
    public NoGroupBadgeFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
