namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Errors thrown by OpenAISharp.
/// </summary>
public sealed class OpenAIException : Exception
{
    public OpenAIException(string message) : base(message)
    {
    }
}
