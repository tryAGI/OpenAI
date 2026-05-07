#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ChatDeleteChatCompletionCommandApiCommand
{
    private static Argument<string> CompletionId { get; } = new(
        name: @"completion-id")
    {
        Description = @"The ID of the chat completion to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-chat-completion", @"Delete a stored chat completion. Only Chat Completions that have been
created with the `store` parameter set to `true` can be deleted.
");
                        command.Arguments.Add(CompletionId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var completionId = parseResult.GetRequiredValue(CompletionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Chat.DeleteChatCompletionAsync(
                                    completionId: completionId,
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