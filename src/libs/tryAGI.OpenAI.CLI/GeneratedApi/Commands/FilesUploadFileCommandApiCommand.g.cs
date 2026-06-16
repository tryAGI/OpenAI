#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class FilesUploadFileCommandApiCommand
{
    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"The File object (not file name) to be uploaded.
",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"The File object (not file name) to be uploaded.
",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateFileRequestPurpose> Purpose { get; } = new(
        name: @"--purpose")
    {
        Description = @"The intended purpose of the uploaded file. One of:
- `assistants`: Used in the Assistants API
- `batch`: Used in the Batch API
- `fine-tune`: Used for fine-tuning
- `vision`: Images used for vision fine-tuning
- `user_data`: Flexible file type for any purpose
- `evals`: Used for eval data sets
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.OpenAIFile value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.OpenAIFile value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"upload-file", @"Upload a file that can be used across various endpoints. Individual files
can be up to 512 MB, and each project can store up to 2.5 TB of files in
total. There is no organization-wide storage limit. Uploads to this
endpoint are rate-limited to 1,000 requests per minute per authenticated
user.

- The Assistants API supports files up to 2 million tokens and of specific
  file types. See the [Assistants Tools guide](/docs/assistants/tools) for
  details.
- The Fine-tuning API only supports `.jsonl` files. The input also has
  certain required formats for fine-tuning
  [chat](/docs/api-reference/fine-tuning/chat-input) or
  [completions](/docs/api-reference/fine-tuning/completions-input) models.
- The Batch API only supports `.jsonl` files up to 200 MB in size. The input
  also has a specific required
  [format](/docs/api-reference/batch/request-input).
- For Retrieval or `file_search` ingestion, upload files here first. If
  you need to attach multiple uploaded files to the same vector store, use
  [`/vector_stores/{vector_store_id}/file_batches`](/docs/api-reference/vector-stores-file-batches/createBatch)
  instead of attaching them one by one. Vector store attachment has separate
  limits from file upload, including 2,000 attached files per minute per
  organization.

Please [contact us](https://help.openai.com/) if you need to increase these
storage limits.
");
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(Purpose);                        command.Options.Add(ExpiresAfterOptions.Anchor);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateFileRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var purpose = parseResult.GetRequiredValue(Purpose);

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


                                var response = await client.Files.UploadFileAsync(
                                    file: file,
                                    filename: filename,
                                    purpose: purpose,
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