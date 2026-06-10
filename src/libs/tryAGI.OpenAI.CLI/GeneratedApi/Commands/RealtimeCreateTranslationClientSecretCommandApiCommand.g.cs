#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RealtimeCreateTranslationClientSecretCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter?> ExpiresAfter { get; } = new(
        name: @"--expires-after")
    {
        Description = @"Configuration for the client secret expiration. Expiration refers to the time after which
a client secret will no longer be valid for creating sessions. The session itself may
continue after that time once started. A secret can be used to create multiple sessions
until it expires.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest> Session { get; } = new(
        name: @"--session")
    {
        Description = @"Realtime translation session configuration. Translation sessions stream source
audio in and translated audio plus transcript deltas out continuously.
",
        Required = true,
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-translation-client-secret", @"Create a Realtime translation client secret with an associated translation session configuration.

Client secrets are short-lived tokens that can be passed to a client app,
such as a web frontend or mobile client, which grants access to the Realtime
Translation API without leaking your main API key. You can configure a custom
TTL for each client secret.

Returns the created client secret and the effective translation session object.
The client secret is a string that looks like `ek_1234`.
");
                        command.Options.Add(ExpiresAfter);
                        command.Options.Add(Session);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var expiresAfter = parseResult.GetValue(ExpiresAfter) ?? __requestBase?.ExpiresAfter;
                        var session = parseResult.GetRequiredValue(Session);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Realtime.CreateTranslationClientSecretAsync(
                                    expiresAfter: expiresAfter,
                                    session: session,
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