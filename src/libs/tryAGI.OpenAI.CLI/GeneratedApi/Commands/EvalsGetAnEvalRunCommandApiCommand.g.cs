#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EvalsGetAnEvalRunCommandApiCommand
{
    private static Argument<string> EvalId { get; } = new(
        name: @"eval-id")
    {
        Description = @"The ID of the evaluation to retrieve runs for.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The ID of the run to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-an-eval-run", @"Get an evaluation run by ID.
");
                        command.Arguments.Add(EvalId);
                        command.Arguments.Add(RunId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var evalId = parseResult.GetRequiredValue(EvalId);
                        var runId = parseResult.GetRequiredValue(RunId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Evals.GetAnEvalRunAsync(
                                    evalId: evalId,
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