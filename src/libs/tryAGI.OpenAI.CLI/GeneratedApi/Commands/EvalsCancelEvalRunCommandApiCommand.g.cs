#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EvalsCancelEvalRunCommandApiCommand
{
    private static Argument<string> EvalId { get; } = new(
        name: @"eval-id")
    {
        Description = @"The ID of the evaluation whose run you want to cancel.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The ID of the run to cancel.",
    };

    public static Command Create()
    {
        var command = new Command(@"cancel-eval-run", @"Cancel an ongoing evaluation run.
");
                        command.Arguments.Add(EvalId);
                        command.Arguments.Add(RunId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var evalId = parseResult.GetRequiredValue(EvalId);
                        var runId = parseResult.GetRequiredValue(RunId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Evals.CancelEvalRunAsync(
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