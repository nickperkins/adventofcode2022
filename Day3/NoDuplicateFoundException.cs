namespace Day3;

public class NoDuplicateFoundException : Exception
{
    public NoDuplicateFoundException() : base("No Duplicate Found")
    {
    }

    public NoDuplicateFoundException(string? message) : base(message)
    {
    }
    
    public NoDuplicateFoundException(string? message, Exception? exception) : base(message, exception)
    {
    }
}
