#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ImagesCreateImageEditAsStreamCommandApiCommand
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
        var command = new Command(@"create-image-edit-as-stream", @"Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models (`gpt-image-1.5`, `gpt-image-1`, `gpt-image-1-mini`, and `chatgpt-image-latest`) and `dall-e-2`.
You can call this endpoint with either:

- `multipart/form-data`: use binary uploads via `image` (and optional `mask`).
- `application/json`: use `images` (and optional `mask`) as references with either `image_url` or `file_id`.

Note that JSON requests use `images` (array) instead of the multipart `image` field.
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

                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.CreateImageEditRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = client.Images.CreateImageEditAsStreamAsync(

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