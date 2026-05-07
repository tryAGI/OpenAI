#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UserOrganizationRoleAssignmentsListUserOrganizationRoleAssignmentsCommandApiCommand
{
    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"The ID of the user to inspect.",
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

    private static Option<global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for the returned organization roles.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-user-organization-role-assignments", @"Lists the organization roles assigned to a user within the organization.");
                        command.Arguments.Add(UserId);
                        command.Options.Add(Limit);
                        command.Options.Add(After);
                        command.Options.Add(Order);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);
                        var limit = parseResult.GetValue(Limit);
                        var after = parseResult.GetValue(After);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.UserOrganizationRoleAssignments.ListUserOrganizationRoleAssignmentsAsync(
                                    userId: userId,
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