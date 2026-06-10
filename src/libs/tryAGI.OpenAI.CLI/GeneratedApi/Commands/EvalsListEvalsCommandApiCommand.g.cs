#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class EvalsListEvalsCommandApiCommand
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.EvalList value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.EvalList value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


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


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}