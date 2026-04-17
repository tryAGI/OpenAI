using System.CommandLine;

namespace tryAGI.OpenAI.Cli;

internal static class CliOptions
{
    public static Option<string?> ApiKey { get; } = new(
        name: "--api-key",
        aliases: ["-k"])
    {
        Description = "OpenAI API key. Falls back to $OPENAI_API_KEY and `dotnet user-secrets`.",
    };

    public static Option<string?> BaseUrl { get; } = new(
        name: "--base-url")
    {
        Description = "Override the OpenAI API base URL. Falls back to $OPENAI_BASE_URL.",
    };

    public static Option<bool> Json { get; } = new(
        name: "--json")
    {
        Description = "Emit raw JSON instead of a human-readable summary.",
    };

    public static Option<string?> Output { get; } = new(
        name: "--output",
        aliases: ["-o"])
    {
        Description = "Write response to this file path instead of stdout.",
    };
}
