#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UsersDeleteUserCommandApiCommand
{
    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"The ID of the user.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-user", @"Deletes a user from the organization.");
                        command.Arguments.Add(UserId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Users.DeleteUserAsync(
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