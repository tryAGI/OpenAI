#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsListRunsCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the thread the run belongs to.",
    };    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.
",
    };

    private static Option<global::tryAGI.OpenAI.ListRunsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.
",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.
",
    };

    private static Option<string?> Before { get; } = new(
        name: @"--before")
    {
        Description = @"A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, starting with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.
",
    };

    public static Command Create()
    {
        var command = new Command(@"list-runs", @"Returns a list of runs belonging to a thread.");
                        command.Arguments.Add(ThreadId);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);
                        command.Options.Add(Before);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                        var before = parseResult.GetValue(Before);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Assistants.ListRunsAsync(
                                    threadId: threadId,
                                    limit: limit,
                                    order: order,
                                    after: after,
                                    before: before,
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