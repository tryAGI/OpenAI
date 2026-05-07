#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ConversationsDeleteAnItemCommandApiCommand
{
    private static Argument<string> ConversationId { get; } = new(
        name: @"conversation-id")
    {
        Description = @"The ID of the conversation that contains the item.",
    };

    private static Argument<string> ItemId { get; } = new(
        name: @"item-id")
    {
        Description = @"The ID of the item to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-an-item", @"Delete an item from a conversation with the given IDs.");
                        command.Arguments.Add(ConversationId);
                        command.Arguments.Add(ItemId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                        var itemId = parseResult.GetRequiredValue(ItemId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Conversations.DeleteAnItemAsync(
                                    conversationId: conversationId,
                                    itemId: itemId,
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