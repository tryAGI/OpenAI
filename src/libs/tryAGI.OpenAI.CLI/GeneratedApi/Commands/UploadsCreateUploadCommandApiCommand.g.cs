#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UploadsCreateUploadCommandApiCommand
{
    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"The name of the file to upload.
",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateUploadRequestPurpose> Purpose { get; } = new(
        name: @"--purpose")
    {
        Description = @"The intended purpose of the uploaded file.

See the [documentation on File
purposes](/docs/api-reference/files/create#files-create-purpose).
",
        Required = true,
    };

    private static Option<long> Bytes { get; } = new(
        name: @"--bytes")
    {
        Description = @"The number of bytes in the file you are uploading.
",
        Required = true,
    };

    private static Option<string> MimeType { get; } = new(
        name: @"--mime-type")
    {
        Description = @"The MIME type of the file.


This must fall within the supported MIME types for your file purpose. See
the supported MIME types for assistants and vision.
",
        Required = true,
    };
    private static readonly FileExpirationAfterOptionSet ExpiresAfterOptions = FileExpirationAfterOptionSet.Create(@"expires-after");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.Upload value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.Upload value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


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
                        command.Options.Add(Filename);
                        command.Options.Add(Purpose);
                        command.Options.Add(Bytes);
                        command.Options.Add(MimeType);                        command.Options.Add(ExpiresAfterOptions.Anchor);
                        command.Options.Add(ExpiresAfterOptions.Seconds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateUploadRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var purpose = parseResult.GetRequiredValue(Purpose);
                        var bytes = parseResult.GetRequiredValue(Bytes);
                        var mimeType = parseResult.GetRequiredValue(MimeType);

                        var __ExpiresAfterBase = __requestBase is { } __ExpiresAfterBaseValue ? __ExpiresAfterBaseValue.ExpiresAfter : default;                        var expiresAfterAnchor = CliRuntime.WasSpecified(parseResult, ExpiresAfterOptions.Anchor) ? parseResult.GetValue(ExpiresAfterOptions.Anchor) : (__ExpiresAfterBase is { } __ExpiresAfteranchorBaseValue ? __ExpiresAfteranchorBaseValue.Anchor : default);
                        var expiresAfterSeconds = parseResult.GetValue(ExpiresAfterOptions.Seconds);
                        var __ExpiresAfterSpecified = CliRuntime.WasSpecified(parseResult, ExpiresAfterOptions.Anchor) || CliRuntime.WasSpecified(parseResult, ExpiresAfterOptions.Seconds);
                        var expiresAfter =
                            __ExpiresAfterSpecified || __ExpiresAfterBase is not null
                                ? new global::tryAGI.OpenAI.FileExpirationAfter
                                {
	                                Anchor = expiresAfterAnchor,
                                Seconds = expiresAfterSeconds!,

                                }
                                : __ExpiresAfterBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Uploads.CreateUploadAsync(
                                    filename: filename,
                                    purpose: purpose,
                                    bytes: bytes,
                                    mimeType: mimeType,
                                    expiresAfter: expiresAfter,
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