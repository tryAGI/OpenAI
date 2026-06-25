namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Errors thrown by OpenAISharp.
/// </summary>
public sealed class OpenAIException : Exception
{
    /// <inheritdoc />
    public OpenAIException()
    {
    }

    /// <inheritdoc />
    public OpenAIException(string message) : base(message)
    {
    }

    /// <inheritdoc />
    public OpenAIException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
