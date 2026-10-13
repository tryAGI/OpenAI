#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ProjectsUpdateProjectApiKeyCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };

    private static Argument<string> ApiKeyId { get; } = new(
        name: @"api-key-id")
    {
        Description = @"The ID of the API key.",
    };

    private static Option<int> ExpiresInSeconds { get; } = new(
        name: @"--expires-in-seconds")
    {
        Description = @"Number of seconds from this request until the API key expires. Must comply with the organization and project expiry policies. Expired keys cannot be updated. Retrying resets the expiry relative to the new request.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ProjectApiKey value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ProjectApiKey value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"update-project-api-key", @"Update project API key
Updates the expiration of an existing API key in the project, including a
service-account-owned key. Requires permission to write project API keys.

Provide `expires_in_seconds` to set the expiration relative to this request.
The value must satisfy the organization's and project's expiry policies.
Expired keys cannot be updated. Retrying resets the expiration relative to
the new request. The response contains only the redacted key, not its secret.
");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(ApiKeyId);
                        command.Options.Add(ExpiresInSeconds);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var apiKeyId = parseResult.GetRequiredValue(ApiKeyId);
                        var expiresInSeconds = parseResult.GetRequiredValue(ExpiresInSeconds);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.UpdateProjectApiKeyAsync(
                                    projectId: projectId,
                                    apiKeyId: apiKeyId,
                                    expiresInSeconds: expiresInSeconds,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}