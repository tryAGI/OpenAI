#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VectorStoresListVectorStoreFilesInABatchCommandApiCommand
{
    private static Argument<string> VectorStoreId { get; } = new(
        name: @"vector-store-id")
    {
        Description = @"The ID of the vector store that the files belong to.",
    };

    private static Argument<string> BatchId { get; } = new(
        name: @"batch-id")
    {
        Description = @"The ID of the file batch that the files belong to.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.
",
    };

    private static Option<global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.
",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.
",
    };

    private static Option<string?> Before { get; } = new(
        name: @"--before")
    {
        Description = @"A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, starting with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.
",
    };

    private static Option<global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter?> Filter { get; } = new(
        name: @"--filter")
    {
        Description = @"Filter by file status. One of `in_progress`, `completed`, `failed`, `cancelled`.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ListVectorStoreFilesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ListVectorStoreFilesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-vector-store-files-in-abatch", @"Returns a list of vector store files in a batch.");
                        command.Arguments.Add(VectorStoreId);
                        command.Arguments.Add(BatchId);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);
                        command.Options.Add(Before);
                        command.Options.Add(Filter);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
                        var batchId = parseResult.GetRequiredValue(BatchId);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                        var before = parseResult.GetValue(Before);
                        var filter = parseResult.GetValue(Filter);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VectorStores.ListVectorStoreFilesInABatchAsync(
                                    vectorStoreId: vectorStoreId,
                                    batchId: batchId,
                                    limit: limit,
                                    order: order,
                                    after: after,
                                    before: before,
                                    filter: filter,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}