#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EvalsGetEvalRunOutputItemsCommandApiCommand
{
    private static Argument<string> EvalId { get; } = new(
        name: @"eval-id")
    {
        Description = @"The ID of the evaluation to retrieve runs for.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The ID of the run to retrieve output items for.",
    };    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last output item from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of output items to retrieve.",
    };

    private static Option<global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter output items by status. Use `failed` to filter by failed output
items or `pass` to filter by passed output items.
",
    };

    private static Option<global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for output items by timestamp. Use `asc` for ascending order or `desc` for descending order. Defaults to `asc`.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-eval-run-output-items", @"Get a list of output items for an evaluation run.
");
                        command.Arguments.Add(EvalId);
                        command.Arguments.Add(RunId);
                        command.Options.Add(After);
                        command.Options.Add(Limit);
                        command.Options.Add(Status);
                        command.Options.Add(Order);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var evalId = parseResult.GetRequiredValue(EvalId);
                        var runId = parseResult.GetRequiredValue(RunId);
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                        var status = parseResult.GetValue(Status);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Evals.GetEvalRunOutputItemsAsync(
                                    evalId: evalId,
                                    runId: runId,
                                    after: after,
                                    limit: limit,
                                    status: status,
                                    order: order,
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