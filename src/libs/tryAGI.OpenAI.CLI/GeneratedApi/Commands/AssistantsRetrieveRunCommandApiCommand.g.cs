#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsRetrieveRunCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the [thread](/docs/api-reference/threads) that was run.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The ID of the run to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-run", @"Retrieves a run.");
                        command.Arguments.Add(ThreadId);
                        command.Arguments.Add(RunId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var runId = parseResult.GetRequiredValue(RunId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Assistants.RetrieveRunAsync(
                                    threadId: threadId,
                                    runId: runId,
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