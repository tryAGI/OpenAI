#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UserOrganizationRoleAssignmentsUnassignOrganizationRoleFromUserCommandApiCommand
{
    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"The ID of the user to modify.",
    };

    private static Argument<string> RoleId { get; } = new(
        name: @"role-id")
    {
        Description = @"The ID of the organization role to remove from the user.",
    };

    public static Command Create()
    {
        var command = new Command(@"unassign-organization-role-from-user", @"Unassigns an organization role from a user within the organization.");
                        command.Arguments.Add(UserId);
                        command.Arguments.Add(RoleId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);
                        var roleId = parseResult.GetRequiredValue(RoleId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.UserOrganizationRoleAssignments.UnassignOrganizationRoleFromUserAsync(
                                    userId: userId,
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