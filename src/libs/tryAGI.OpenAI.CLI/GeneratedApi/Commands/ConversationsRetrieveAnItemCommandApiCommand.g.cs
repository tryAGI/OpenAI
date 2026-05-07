#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ConversationsRetrieveAnItemCommandApiCommand
{
    private static Argument<string> ConversationId { get; } = new(
        name: @"conversation-id")
    {
        Description = @"The ID of the conversation that contains the item.",
    };

    private static Argument<string> ItemId { get; } = new(
        name: @"item-id")
    {
        Description = @"The ID of the item to retrieve.",
    };    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"Additional fields to include in the response. See the `include`
parameter for [listing Conversation items above](/docs/api-reference/conversations/list-items#conversations_list_items-include) for more information.
",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-an-item", @"Get a single item from a conversation with the given IDs.");
                        command.Arguments.Add(ConversationId);
                        command.Arguments.Add(ItemId);
                        command.Options.Add(Include);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                        var itemId = parseResult.GetRequiredValue(ItemId);
                        var include = parseResult.GetValue(Include);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Conversations.RetrieveAnItemAsync(
                                    conversationId: conversationId,
                                    itemId: itemId,
                                    include: include,
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