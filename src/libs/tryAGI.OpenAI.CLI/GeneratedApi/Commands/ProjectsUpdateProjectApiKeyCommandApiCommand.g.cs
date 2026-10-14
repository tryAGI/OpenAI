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

    private static Option<int?> ExpiresInSeconds { get; } = new(
        name: @"--expires-in-seconds")
    {
        Description = @"Number of seconds from this request until the API key expires. Must comply with the organization and project expiry policies. Expired keys cannot be updated. Retrying resets the expiry relative to the new request. Omit to keep the current expiration.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Scopes { get; } = new(
        name: @"--scopes")
    {
        Description = @"Replace the API key scope restrictions. Omit to leave scopes unchanged. An empty array removes key restrictions (All permissions), subject to the owner's effective permissions. Use [""api.all.read""] for read-only access. Scopes do not change the owner's roles or grant administrative permissions.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
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
Updates the scopes and/or expiration of an existing API key in the project, including a
service-account-owned key. Requires permission to write project API keys.

Provide at least one of `scopes` or `expires_in_seconds`. Omitted fields stay
unchanged; neither field accepts `null`. Both changes are saved together.

`scopes` replaces the key's scope restrictions using the same scope identifiers
as the dashboard. An empty array means All permissions, subject to the owner's
effective access; it does not mean no access. Use `[""api.all.read""]` for read-only
access or specific scopes such as `[""api.files.read""]` for restricted access.
This does not change user or service-account roles or grant admin permissions.
Scope changes follow the same authentication-cache propagation as dashboard edits.

Provide `expires_in_seconds` to set the expiration relative to this request.
The value must satisfy the organization's and project's expiry policies.
Expired keys cannot be updated. Retrying resets the expiration relative to
the new request. The response contains only the redacted key, not its secret.
");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(ApiKeyId);
                        command.Options.Add(ExpiresInSeconds);
                        command.Options.Add(Scopes);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.UpdateProjectApiKeyBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var apiKeyId = parseResult.GetRequiredValue(ApiKeyId);
                        var expiresInSeconds = CliRuntime.WasSpecified(parseResult, ExpiresInSeconds) ? parseResult.GetValue(ExpiresInSeconds) : (__requestBase is { } __ExpiresInSecondsBaseValue ? __ExpiresInSecondsBaseValue.ExpiresInSeconds : default);
                        var scopes = CliRuntime.WasSpecified(parseResult, Scopes) ? parseResult.GetValue(Scopes) : (__requestBase is { } __ScopesBaseValue ? __ScopesBaseValue.Scopes : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.UpdateProjectApiKeyAsync(
                                    projectId: projectId,
                                    apiKeyId: apiKeyId,
                                    expiresInSeconds: expiresInSeconds,
                                    scopes: scopes,
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