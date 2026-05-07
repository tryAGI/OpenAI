#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ConversationsRetrieveAConversationCommandApiCommand
{
    private static Argument<string> ConversationId { get; } = new(
        name: @"conversation-id")
    {
        Description = @"The ID of the conversation to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-aconversation", @"Get a conversation");
                        command.Arguments.Add(ConversationId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Conversations.RetrieveAConversationAsync(
                                    conversationId: conversationId,
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