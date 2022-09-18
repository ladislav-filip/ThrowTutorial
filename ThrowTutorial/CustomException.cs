namespace ThrowTutorial;

public sealed class CustomException : Exception
{
    public string ParamName { get; }

    public CustomException(string paramName, string message) : base(message)
    {
        ParamName = paramName;
    }
}