#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RolesDeleteOrganizationRoleCommandApiCommand
{
    private static Argument<string> RoleId { get; } = new(
        name: @"role-id")
    {
        Description = @"The ID of the role to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-organization-role", @"Deletes a custom role from the organization.");
                        command.Arguments.Add(RoleId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var roleId = parseResult.GetRequiredValue(RoleId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Roles.DeleteOrganizationRoleAsync(
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