#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class GroupUsersRemoveGroupUserCommandApiCommand
{
    private static Argument<string> GroupId { get; } = new(
        name: @"group-id")
    {
        Description = @"The ID of the group to update.",
    };

    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"The ID of the user to remove from the group.",
    };

    public static Command Create()
    {
        var command = new Command(@"remove-group-user", @"Removes a user from a group.");
                        command.Arguments.Add(GroupId);
                        command.Arguments.Add(UserId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var groupId = parseResult.GetRequiredValue(GroupId);
                        var userId = parseResult.GetRequiredValue(UserId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.GroupUsers.RemoveGroupUserAsync(
                                    groupId: groupId,
                                    userId: userId,
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