#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UsersRetrieveUserCommandApiCommand
{
    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"The ID of the user.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-user", @"Retrieves a user by their identifier.");
                        command.Arguments.Add(UserId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Users.RetrieveUserAsync(
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