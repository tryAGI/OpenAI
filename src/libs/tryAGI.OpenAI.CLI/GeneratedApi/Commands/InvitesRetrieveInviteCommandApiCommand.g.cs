#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class InvitesRetrieveInviteCommandApiCommand
{
    private static Argument<string> InviteId { get; } = new(
        name: @"invite-id")
    {
        Description = @"The ID of the invite to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-invite", @"Retrieves an invite.");
                        command.Arguments.Add(InviteId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var inviteId = parseResult.GetRequiredValue(InviteId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Invites.RetrieveInviteAsync(
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