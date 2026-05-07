#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsDeleteMessageCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the thread to which this message belongs.",
    };

    private static Argument<string> MessageId { get; } = new(
        name: @"message-id")
    {
        Description = @"The ID of the message to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-message", @"Deletes a message.");
                        command.Arguments.Add(ThreadId);
                        command.Arguments.Add(MessageId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var messageId = parseResult.GetRequiredValue(MessageId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Assistants.DeleteMessageAsync(
                                    threadId: threadId,
                                    messageId: messageId,
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