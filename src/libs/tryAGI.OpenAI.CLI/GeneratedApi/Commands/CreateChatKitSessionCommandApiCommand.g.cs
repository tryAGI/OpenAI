#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class CreateChatKitSessionCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.WorkflowParam> Workflow { get; } = new(
        name: @"--workflow")
    {
        Description = @"Workflow that powers the session.",
        Required = true,
    };

    private static Option<string> User { get; } = new(
        name: @"--user")
    {
        Description = @"A free-form string that identifies your end user; ensures this Session can access other objects that have the same `user` scope.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.ExpiresAfterParam?> ExpiresAfter { get; } = new(
        name: @"--expires-after")
    {
        Description = @"Optional override for session expiration timing in seconds from creation. Defaults to 10 minutes.",
    };

    private static Option<global::tryAGI.OpenAI.RateLimitsParam?> RateLimits { get; } = new(
        name: @"--rate-limits")
    {
        Description = @"Optional override for per-minute request limits. When omitted, defaults to 10.",
    };

    private static Option<global::tryAGI.OpenAI.ChatkitConfigurationParam?> ChatkitConfiguration { get; } = new(
        name: @"--chatkit-configuration")
    {
        Description = @"Optional overrides for ChatKit runtime configuration features",
    };
      private static Option<string?> Input { get; } = new("--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ChatSessionResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ChatSessionResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-chat-kit-session", @"Create a ChatKit session.");
                        command.Options.Add(Workflow);
                        command.Options.Add(User);
                        command.Options.Add(ExpiresAfter);
                        command.Options.Add(RateLimits);
                        command.Options.Add(ChatkitConfiguration);
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
                  result.AddError("Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateChatSessionBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var workflow = parseResult.GetRequiredValue(Workflow);
                        var user = parseResult.GetRequiredValue(User);
                        var expiresAfter = parseResult.GetValue(ExpiresAfter) ?? __requestBase?.ExpiresAfter;
                        var rateLimits = parseResult.GetValue(RateLimits) ?? __requestBase?.RateLimits;
                        var chatkitConfiguration = parseResult.GetValue(ChatkitConfiguration) ?? __requestBase?.ChatkitConfiguration;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateChatKitSessionAsync(
                                    workflow: workflow,
                                    user: user,
                                    expiresAfter: expiresAfter,
                                    rateLimits: rateLimits,
                                    chatkitConfiguration: chatkitConfiguration,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}