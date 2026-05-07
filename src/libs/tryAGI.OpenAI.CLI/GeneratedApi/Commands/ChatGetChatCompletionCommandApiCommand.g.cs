#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ChatGetChatCompletionCommandApiCommand
{
    private static Argument<string> CompletionId { get; } = new(
        name: @"completion-id")
    {
        Description = @"The ID of the chat completion to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-chat-completion", @"Get a stored chat completion. Only Chat Completions that have been created
with the `store` parameter set to `true` will be returned.
");
                        command.Arguments.Add(CompletionId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var completionId = parseResult.GetRequiredValue(CompletionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Chat.GetChatCompletionAsync(
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