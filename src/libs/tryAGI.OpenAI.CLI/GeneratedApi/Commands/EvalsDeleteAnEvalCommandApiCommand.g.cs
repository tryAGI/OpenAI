#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EvalsDeleteAnEvalCommandApiCommand
{
    private static Argument<string> EvalId { get; } = new(
        name: @"eval-id")
    {
        Description = @"The ID of the evaluation to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-an-eval", @"Delete an evaluation.
");
                        command.Arguments.Add(EvalId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var evalId = parseResult.GetRequiredValue(EvalId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Evals.DeleteAnEvalAsync(
                                    evalId: evalId,
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