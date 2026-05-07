#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RolesListOrganizationRolesCommandApiCommand
{
     private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of roles to return. Defaults to 1000.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Cursor for pagination. Provide the value from the previous response's `next` field to continue listing roles.",
    };

    private static Option<global::tryAGI.OpenAI.ListRolesOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for the returned roles.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-organization-roles", @"Lists the roles configured for the organization.");
                        command.Options.Add(Limit);
                        command.Options.Add(After);
                        command.Options.Add(Order);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var after = parseResult.GetValue(After);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Roles.ListOrganizationRolesAsync(
                                    limit: limit,
                                    after: after,
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