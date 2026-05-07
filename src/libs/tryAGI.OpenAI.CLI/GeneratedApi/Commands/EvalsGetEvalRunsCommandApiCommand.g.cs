#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EvalsGetEvalRunsCommandApiCommand
{
    private static Argument<string> EvalId { get; } = new(
        name: @"eval-id")
    {
        Description = @"The ID of the evaluation to retrieve runs for.",
    };    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last run from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of runs to retrieve.",
    };

    private static Option<global::tryAGI.OpenAI.GetEvalRunsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for runs by timestamp. Use `asc` for ascending order or `desc` for descending order. Defaults to `asc`.",
    };

    private static Option<global::tryAGI.OpenAI.GetEvalRunsStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter runs by status. One of `queued` | `in_progress` | `failed` | `completed` | `canceled`.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-eval-runs", @"Get a list of runs for an evaluation.
");
                        command.Arguments.Add(EvalId);
                        command.Options.Add(After);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(Status);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var evalId = parseResult.GetRequiredValue(EvalId);
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var status = parseResult.GetValue(Status);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Evals.GetEvalRunsAsync(
                                    evalId: evalId,
                                    after: after,
                                    limit: limit,
                                    order: order,
                                    status: status,
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