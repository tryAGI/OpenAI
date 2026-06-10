#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi;

internal static class CliOptions
{
    public static Option<string?> ApiKey { get; } = new("--api-key", ["-k"])
    {
        Description = @"API key. Falls back to configured environment variables, dotnet user-secrets, and the optional credential file.",
        Recursive = true,
    };

    public static Option<string?> BaseUrl { get; } = new("--base-url")
    {
        Description = "Override the API base URL.",
        Recursive = true,
    };

    public static Option<bool> Json { get; } = new("--json")
    {
        Description = "Render structured responses as raw JSON instead of human-readable text.",
        Recursive = true,
    };

    public static Option<string?> Output { get; } = new("--output", ["-o"])
    {
        Description = "Write response content to this file path instead of stdout.",
        Recursive = true,
    };

    public static Option<string?> OutputDirectory { get; } = new("--output-dir")
    {
        Description = "Write one file per returned item when the response contains multiple resources.",
        Recursive = true,
    };
}