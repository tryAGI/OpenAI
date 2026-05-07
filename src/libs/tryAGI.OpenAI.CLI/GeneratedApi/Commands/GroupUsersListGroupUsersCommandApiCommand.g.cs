#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupUsersListGroupUsersCommandApiCommand
{
    private static Argument<string> GroupId { get; } = new(
        name: @"group-id")
    {
        Description = @"The ID of the group to inspect.",
    };    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of users to be returned. Limit can range between 0 and 1000, and the default is 100.
",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"A cursor for use in pagination. Provide the ID of the last user from the previous list response to retrieve the next page.
",
    };

    private static Option<global::tryAGI.OpenAI.ListGroupUsersOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Specifies the sort order of users in the list.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-group-users", @"Lists the users assigned to a group.");
                        command.Arguments.Add(GroupId);
                        command.Options.Add(Limit);
                        command.Options.Add(After);
                        command.Options.Add(Order);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var groupId = parseResult.GetRequiredValue(GroupId);
                        var limit = parseResult.GetValue(Limit);
                        var after = parseResult.GetValue(After);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.GroupUsers.ListGroupUsersAsync(
                                    groupId: groupId,
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