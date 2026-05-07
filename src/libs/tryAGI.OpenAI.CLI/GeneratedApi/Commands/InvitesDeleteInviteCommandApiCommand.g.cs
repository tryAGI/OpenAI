#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class InvitesDeleteInviteCommandApiCommand
{
    private static Argument<string> InviteId { get; } = new(
        name: @"invite-id")
    {
        Description = @"The ID of the invite to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-invite", @"Delete an invite. If the invite has already been accepted, it cannot be deleted.");
                        command.Arguments.Add(InviteId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var inviteId = parseResult.GetRequiredValue(InviteId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Invites.DeleteInviteAsync(
                                    inviteId: inviteId,
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