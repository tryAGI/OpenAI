#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupOrganizationRoleAssignmentsListGroupOrganizationRoleAssignmentsCommandApiCommand
{
    private static Argument<string> GroupId { get; } = new(
        name: @"group-id")
    {
        Description = @"The ID of the group whose organization role assignments you want to list.",
    };    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of organization role assignments to return.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Cursor for pagination. Provide the value from the previous response's `next` field to continue listing organization roles.",
    };

    private static Option<global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for the returned organization roles.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-group-organization-role-assignments", @"Lists the organization roles assigned to a group within the organization.");
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

                                var response = await client.GroupOrganizationRoleAssignments.ListGroupOrganizationRoleAssignmentsAsync(
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