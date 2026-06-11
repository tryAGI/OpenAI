#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VectorStoresCreateVectorStoreFileBatchCommandApiCommand
{
    private static Argument<string> VectorStoreId { get; } = new(
        name: @"vector-store-id")
    {
        Description = @"The ID of the vector store for which to create a File Batch.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> FileIds { get; } = new(
        name: @"--file-ids")
    {
        Description = @"A list of [File](/docs/api-reference/files) IDs that the vector store should use. Useful for tools like `file_search` that can access files.  If `attributes` or `chunking_strategy` are provided, they will be  applied to all files in the batch. The maximum batch size is 2000 files. This endpoint is recommended for multi-file ingestion and helps reduce per-vector-store write request pressure. Mutually exclusive with `files`.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>?> Files { get; } = new(
        name: @"--files")
    {
        Description = @"A list of objects that each include a `file_id` plus optional `attributes` or `chunking_strategy`. Use this when you need to override metadata for specific files. The global `attributes` or `chunking_strategy` will be ignored and must be specified for each file. The maximum batch size is 2000 files. This endpoint is recommended for multi-file ingestion and helps reduce per-vector-store write request pressure. Mutually exclusive with `file_ids`.",
    };

    private static Option<global::tryAGI.OpenAI.ChunkingStrategyRequestParam?> ChunkingStrategy { get; } = new(
        name: @"--chunking-strategy")
    {
        Description = @"The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.",
    };

    private static Option<object?> Attributes { get; } = new(
        name: @"--attributes")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VectorStoreFileBatchObject value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VectorStoreFileBatchObject value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-vector-store-file-batch", @"Create a vector store file batch.
The maximum number of files in a single batch request is 2000.
Vector store file attach requests are rate limited per vector store (300 requests per minute across both this endpoint and `/vector_stores/{vector_store_id}/files`).
For ingesting multiple files into the same vector store, this batch endpoint is recommended.
");
                        command.Arguments.Add(VectorStoreId);
                        command.Options.Add(FileIds);
                        command.Options.Add(Files);
                        command.Options.Add(ChunkingStrategy);
                        command.Options.Add(Attributes);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
                        var fileIds = CliRuntime.WasSpecified(parseResult, FileIds) ? parseResult.GetValue(FileIds) : __requestBase is not null ? __requestBase.FileIds : default;
                        var files = CliRuntime.WasSpecified(parseResult, Files) ? parseResult.GetValue(Files) : __requestBase is not null ? __requestBase.Files : default;
                        var chunkingStrategy = CliRuntime.WasSpecified(parseResult, ChunkingStrategy) ? parseResult.GetValue(ChunkingStrategy) : __requestBase is not null ? __requestBase.ChunkingStrategy : default;
                        var attributes = CliRuntime.WasSpecified(parseResult, Attributes) ? parseResult.GetValue(Attributes) : __requestBase is not null ? __requestBase.Attributes : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VectorStores.CreateVectorStoreFileBatchAsync(
                                    vectorStoreId: vectorStoreId,
                                    fileIds: fileIds,
                                    files: files,
                                    chunkingStrategy: chunkingStrategy,
                                    attributes: attributes,
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