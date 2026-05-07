#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class SkillsListSkillsCommandApiCommand
{
     private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items to retrieve",
    };

    private static Option<global::tryAGI.OpenAI.OrderEnum?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order of results by timestamp. Use `asc` for ascending order or `desc` for descending order.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last item from the previous pagination request",
    };

    public static Command Create()
    {
        var command = new Command(@"list-skills", @"List all skills for the current project.");
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Skills.ListSkillsAsync(
                                    limit: limit,
                                    order: order,
                                    after: after,
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