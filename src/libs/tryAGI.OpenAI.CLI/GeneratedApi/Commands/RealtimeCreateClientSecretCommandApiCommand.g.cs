#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RealtimeCreateClientSecretCommandApiCommand
{

      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
      };

    public static Command Create()
    {
        var command = new Command(@"create-client-secret", @"Create a Realtime client secret with an associated session configuration.

Client secrets are short-lived tokens that can be passed to a client app,
such as a web frontend or mobile client, which grants access to the Realtime API without
leaking your main API key. You can configure a custom TTL for each client secret.

You can also attach session configuration options to the client secret, which will be
applied to any sessions created using that client secret, but these can also be overridden
by the client connection.

[Learn more about authentication with client secrets over WebRTC](/docs/guides/realtime-webrtc).

Returns the created client secret and the effective session object. The client secret is a string that looks like `ek_1234`.
");

          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              if (hasRequestJson == hasRequestFile)
              {
                  result.AddError("Specify exactly one of --request-json or --request-file.");
              }
          });
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {

                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Realtime.CreateClientSecretAsync(

                                    request: request,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}