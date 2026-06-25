namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Errors thrown by OpenAISharp.
/// </summary>
public sealed class OpenAIException : Exception
{
    public OpenAIException()
    {
    }

    public OpenAIException(string message) : base(message)
    {
    }

    public OpenAIException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
