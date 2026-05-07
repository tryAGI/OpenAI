#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ListChatKitThreadItemsCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"Identifier of the ChatKit thread whose items are requested.",
    };    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of thread items to return. Defaults to 20.",
    };

    private static Option<global::tryAGI.OpenAI.OrderEnum?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for results by creation time. Defaults to `desc`.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"List items created after this thread item ID. Defaults to null for the first page.",
    };

    private static Option<string?> Before { get; } = new(
        name: @"--before")
    {
        Description = @"List items created before this thread item ID. Defaults to null for the newest results.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-chat-kit-thread-items", @"List items that belong to a ChatKit thread.");
                        command.Arguments.Add(ThreadId);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);
                        command.Options.Add(Before);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                        var before = parseResult.GetValue(Before);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.ListChatKitThreadItemsAsync(
                                    threadId: threadId,
                                    limit: limit,
                                    order: order,
                                    after: after,
                                    before: before,
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