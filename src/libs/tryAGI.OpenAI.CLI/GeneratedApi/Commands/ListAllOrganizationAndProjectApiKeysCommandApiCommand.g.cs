#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ListAllOrganizationAndProjectApiKeysCommandApiCommand
{
     private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Return keys with IDs that come after this ID in the pagination order.",
    };

    private static Option<global::tryAGI.OpenAI.AdminApiKeysListOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Order results by creation time, ascending or descending.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of keys to return.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-all-organization-and-project-api-keys", @"List organization API keys
Retrieve a paginated list of organization admin API keys.");
                        command.Options.Add(After);
                        command.Options.Add(Order);
                        command.Options.Add(Limit);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var after = parseResult.GetValue(After);
                        var order = parseResult.GetValue(Order);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.ListAllOrganizationAndProjectApiKeysAsync(
                                    after: after,
                                    order: order,
                                    limit: limit,
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