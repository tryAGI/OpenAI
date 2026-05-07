#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class EvalsListEvalsCommandApiCommand
{
     private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last eval from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of evals to retrieve.",
    };

    private static Option<global::tryAGI.OpenAI.ListEvalsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for evals by timestamp. Use `asc` for ascending order or `desc` for descending order.",
    };

    private static Option<global::tryAGI.OpenAI.ListEvalsOrderBy?> OrderBy { get; } = new(
        name: @"--order-by")
    {
        Description = @"Evals can be ordered by creation time or last updated time. Use
`created_at` for creation time or `updated_at` for last updated time.
",
    };

    public static Command Create()
    {
        var command = new Command(@"list-evals", @"List evaluations for a project.
");
                        command.Options.Add(After);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(OrderBy);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var orderBy = parseResult.GetValue(OrderBy);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Evals.ListEvalsAsync(
                                    after: after,
                                    limit: limit,
                                    order: order,
                                    orderBy: orderBy,
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