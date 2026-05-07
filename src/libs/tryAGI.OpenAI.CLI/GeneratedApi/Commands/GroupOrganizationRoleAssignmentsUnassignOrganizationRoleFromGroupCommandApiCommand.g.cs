#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupOrganizationRoleAssignmentsUnassignOrganizationRoleFromGroupCommandApiCommand
{
    private static Argument<string> GroupId { get; } = new(
        name: @"group-id")
    {
        Description = @"The ID of the group to modify.",
    };

    private static Argument<string> RoleId { get; } = new(
        name: @"role-id")
    {
        Description = @"The ID of the organization role to remove from the group.",
    };

    public static Command Create()
    {
        var command = new Command(@"unassign-organization-role-from-group", @"Unassigns an organization role from a group within the organization.");
                        command.Arguments.Add(GroupId);
                        command.Arguments.Add(RoleId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var groupId = parseResult.GetRequiredValue(GroupId);
                        var roleId = parseResult.GetRequiredValue(RoleId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.GroupOrganizationRoleAssignments.UnassignOrganizationRoleFromGroupAsync(
                                    groupId: groupId,
                                    roleId: roleId,
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