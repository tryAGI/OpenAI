#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UploadsCreateUploadCommandApiCommand
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
        var command = new Command(@"create-upload", @"Creates an intermediate [Upload](/docs/api-reference/uploads/object) object
that you can add [Parts](/docs/api-reference/uploads/part-object) to.
Currently, an Upload can accept at most 8 GB in total and expires after an
hour after you create it.

Once you complete the Upload, we will create a
[File](/docs/api-reference/files/object) object that contains all the parts
you uploaded. This File is usable in the rest of our platform as a regular
File object.

For certain `purpose` values, the correct `mime_type` must be specified.
Please refer to documentation for the
[supported MIME types for your use case](/docs/assistants/tools/file-search#supported-files).

For guidance on the proper filename extensions for each purpose, please
follow the documentation on [creating a
File](/docs/api-reference/files/create).

Returns the Upload object with status `pending`.
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

                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.CreateUploadRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Uploads.CreateUploadAsync(

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