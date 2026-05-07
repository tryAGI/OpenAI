#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectGroupRoleAssignmentsUnassignProjectRoleFromGroupCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project to modify.",
    };

    private static Argument<string> GroupId { get; } = new(
        name: @"group-id")
    {
        Description = @"The ID of the group whose project role assignment should be removed.",
    };

    private static Argument<string> RoleId { get; } = new(
        name: @"role-id")
    {
        Description = @"The ID of the project role to remove from the group.",
    };

    public static Command Create()
    {
        var command = new Command(@"unassign-project-role-from-group", @"Unassigns a project role from a group within a project.");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(GroupId);
                        command.Arguments.Add(RoleId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var groupId = parseResult.GetRequiredValue(GroupId);
                        var roleId = parseResult.GetRequiredValue(RoleId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.ProjectGroupRoleAssignments.UnassignProjectRoleFromGroupAsync(
                                    projectId: projectId,
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