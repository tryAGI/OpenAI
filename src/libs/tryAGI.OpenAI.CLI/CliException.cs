namespace tryAGI.OpenAI.Cli;

internal sealed class CliException : Exception
{
    public CliException(string message) : base(message) { }
    public CliException(string message, Exception innerException) : base(message, innerException) { }
    public CliException() { }
}
