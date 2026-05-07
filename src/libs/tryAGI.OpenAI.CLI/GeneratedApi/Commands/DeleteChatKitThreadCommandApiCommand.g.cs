#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class DeleteChatKitThreadCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"Identifier of the ChatKit thread to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-chat-kit-thread", @"Delete a ChatKit thread along with its items and stored attachments.");
                        command.Arguments.Add(ThreadId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.DeleteChatKitThreadAsync(
                                    threadId: threadId,
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