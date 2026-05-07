#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UsersListUsersCommandApiCommand
{
     private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.
",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Emails { get; } = new(
        name: @"--emails")
    {
        Description = @"Filter by the email address of users.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-users", @"Lists all of the users in the organization.");
                        command.Options.Add(Limit);
                        command.Options.Add(After);
                        command.Options.Add(Emails);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var after = parseResult.GetValue(After);
                        var emails = parseResult.GetValue(Emails);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Users.ListUsersAsync(
                                    limit: limit,
                                    after: after,
                                    emails: emails,
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