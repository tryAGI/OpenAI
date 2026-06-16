#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VectorStoresCreateVectorStoreFileCommandApiCommand
{
    private static Argument<string> VectorStoreId { get; } = new(
        name: @"vector-store-id")
    {
        Description = @"The ID of the vector store for which to create a File.
",
    };

    private static Option<string> FileId { get; } = new(
        name: @"--file-id")
    {
        Description = @"A [File](/docs/api-reference/files) ID that the vector store should use. Useful for tools like `file_search` that can access files. For multi-file ingestion, we recommend [`file_batches`](/docs/api-reference/vector-stores-file-batches/createBatch) to minimize per-vector-store write requests.",
        Required = true,
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VectorStoreFileObject value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VectorStoreFileObject value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-vector-store-file", @"Create a vector store file by attaching a [File](/docs/api-reference/files) to a [vector store](/docs/api-reference/vector-stores/object).
This endpoint is subject to a per-vector-store write rate limit of 300 requests per minute, shared with `/vector_stores/{vector_store_id}/file_batches`.
For uploading multiple files to the same vector store, use the file batches endpoint to reduce request volume.");
                        command.Arguments.Add(VectorStoreId);
                        command.Options.Add(FileId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
                        var fileId = parseResult.GetRequiredValue(FileId);
                        var chunkingStrategy = CliRuntime.WasSpecified(parseResult, ChunkingStrategy) ? parseResult.GetValue(ChunkingStrategy) : (__requestBase is { } __ChunkingStrategyBaseValue ? __ChunkingStrategyBaseValue.ChunkingStrategy : default);
                        var attributes = CliRuntime.WasSpecified(parseResult, Attributes) ? parseResult.GetValue(Attributes) : (__requestBase is { } __AttributesBaseValue ? __AttributesBaseValue.Attributes : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VectorStores.CreateVectorStoreFileAsync(
                                    vectorStoreId: vectorStoreId,
                                    fileId: fileId,
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