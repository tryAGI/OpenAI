#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class CreateContainerFileCommandApiCommand
{
    private static Argument<string> ContainerId { get; } = new(
        name: @"container-id")
    {
        Description = @"",
    };

    private static Option<string?> FileId { get; } = new(
        name: @"--file-id")
    {
        Description = @"Name of the file to create.",
    };

    private static Option<byte[]?> File { get; } = new(
        name: @"--file")
    {
        Description = @"The File object (not file name) to be uploaded.
",
    };

    private static Option<string?> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"The File object (not file name) to be uploaded.
",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ContainerFileResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ContainerFileResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-container-file", @"Create a Container File

You can send either a multipart/form-data request with the raw file content, or a JSON request with a file ID.

Creates a container file.
");
                        command.Arguments.Add(ContainerId);
                        command.Options.Add(FileId);
                        command.Options.Add(File);
                        command.Options.Add(Filename);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateContainerFileBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var containerId = parseResult.GetRequiredValue(ContainerId);
                        var fileId = CliRuntime.WasSpecified(parseResult, FileId) ? parseResult.GetValue(FileId) : __requestBase is not null ? __requestBase.FileId : default;
                        var file = CliRuntime.WasSpecified(parseResult, File) ? parseResult.GetValue(File) : __requestBase is not null ? __requestBase.File : default;
                        var filename = CliRuntime.WasSpecified(parseResult, Filename) ? parseResult.GetValue(Filename) : __requestBase is not null ? __requestBase.Filename : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateContainerFileAsync(
                                    containerId: containerId,
                                    fileId: fileId,
                                    file: file,
                                    filename: filename,
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