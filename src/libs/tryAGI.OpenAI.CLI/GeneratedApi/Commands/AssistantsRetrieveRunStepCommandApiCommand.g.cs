#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsRetrieveRunStepCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the thread to which the run and run step belongs.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The ID of the run to which the run step belongs.",
    };

    private static Argument<string> StepId { get; } = new(
        name: @"step-id")
    {
        Description = @"The ID of the run step to retrieve.",
    };    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"A list of additional fields to include in the response. Currently the only supported value is `step_details.tool_calls[*].file_search.results[*].content` to fetch the file search result content.

See the [file search tool documentation](/docs/assistants/tools/file-search#customizing-file-search-settings) for more information.
",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-run-step", @"Retrieves a run step.");
                        command.Arguments.Add(ThreadId);
                        command.Arguments.Add(RunId);
                        command.Arguments.Add(StepId);
                        command.Options.Add(Include);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var runId = parseResult.GetRequiredValue(RunId);
                        var stepId = parseResult.GetRequiredValue(StepId);
                        var include = parseResult.GetValue(Include);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Assistants.RetrieveRunStepAsync(
                                    threadId: threadId,
                                    runId: runId,
                                    stepId: stepId,
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