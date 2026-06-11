#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class BatchCreateBatchCommandApiCommand
{
    private static Option<string> InputFileId { get; } = new(
        name: @"--input-file-id")
    {
        Description = @"The ID of an uploaded file that contains requests for the new batch.

See [upload file](/docs/api-reference/files/create) for how to upload a file.

Your input file must be formatted as a [JSONL file](/docs/api-reference/batch/request-input), and must be uploaded with the purpose `batch`. The file can contain up to 50,000 requests, and can be up to 200 MB in size.
",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateBatchRequestEndpoint> Endpoint { get; } = new(
        name: @"--endpoint")
    {
        Description = @"The endpoint to be used for all requests in the batch. Currently `/v1/responses`, `/v1/chat/completions`, `/v1/embeddings`, `/v1/completions`, `/v1/moderations`, `/v1/images/generations`, `/v1/images/edits`, and `/v1/videos` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateBatchRequestCompletionWindow> CompletionWindow { get; } = new(
        name: @"--completion-window")
    {
        Description = @"The time frame within which the batch should be processed. Currently only `24h` is supported.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.BatchFileExpirationAfter?> OutputExpiresAfter { get; } = new(
        name: @"--output-expires-after")
    {
        Description = @"The expiration policy for the output and/or error file that are generated for a batch.",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.Batch value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.Batch value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-batch", @"Creates and executes a batch from an uploaded file of requests");
                        command.Options.Add(InputFileId);
                        command.Options.Add(Endpoint);
                        command.Options.Add(CompletionWindow);
                        command.Options.Add(Metadata);
                        command.Options.Add(OutputExpiresAfter);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateBatchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var inputFileId = parseResult.GetRequiredValue(InputFileId);
                        var endpoint = parseResult.GetRequiredValue(Endpoint);
                        var completionWindow = CliRuntime.WasSpecified(parseResult, CompletionWindow) ? parseResult.GetValue(CompletionWindow) : __requestBase is not null ? __requestBase.CompletionWindow : default;
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : __requestBase is not null ? __requestBase.Metadata : default;
                        var outputExpiresAfter = CliRuntime.WasSpecified(parseResult, OutputExpiresAfter) ? parseResult.GetValue(OutputExpiresAfter) : __requestBase is not null ? __requestBase.OutputExpiresAfter : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Batch.CreateBatchAsync(
                                    inputFileId: inputFileId,
                                    endpoint: endpoint,
                                    completionWindow: completionWindow,
                                    metadata: metadata,
                                    outputExpiresAfter: outputExpiresAfter,
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