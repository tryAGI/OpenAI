#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RealtimeRejectCallCommandApiCommand
{
    private static Argument<string> CallId { get; } = new(
        name: @"call-id")
    {
        Description = @"The identifier for the call provided in the
[`realtime.call.incoming`](/docs/api-reference/webhook-events/realtime/call/incoming)
webhook.",
    };

    private static Option<int?> StatusCode { get; } = new(
        name: @"--status-code")
    {
        Description = @"SIP response code to send back to the caller. Defaults to `603` (Decline)
when omitted.",
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

    public static Command Create()
    {
        var command = new Command(@"reject-call", @"Decline an incoming SIP call by returning a SIP status code to the caller.");
                        command.Arguments.Add(CallId);
                        command.Options.Add(StatusCode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.RealtimeCallRejectRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var callId = parseResult.GetRequiredValue(CallId);
                        var statusCode = CliRuntime.WasSpecified(parseResult, StatusCode) ? parseResult.GetValue(StatusCode) : (__requestBase is { } __StatusCodeBaseValue ? __StatusCodeBaseValue.StatusCode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Realtime.RejectCallAsync(
                                    callId: callId,
                                    statusCode: statusCode,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}