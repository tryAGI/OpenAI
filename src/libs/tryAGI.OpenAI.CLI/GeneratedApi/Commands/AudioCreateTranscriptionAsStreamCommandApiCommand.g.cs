#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AudioCreateTranscriptionAsStreamCommandApiCommand
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
        var command = new Command(@"create-transcription-as-stream", @"Transcribes audio into the input language.

Returns a transcription object in `json`, `diarized_json`, or `verbose_json`
format, or a stream of transcript events.
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

                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.CreateTranscriptionRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = client.Audio.CreateTranscriptionAsStreamAsync(

                                    request: request,
                                    cancellationToken: cancellationToken);

                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteJsonLineAsync(
                                        parseResult,
                                        item,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}