#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FilesListFilesCommandApiCommand
{
     private static Option<string?> Purpose { get; } = new(
        name: @"--purpose")
    {
        Description = @"Only return files with the given purpose.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of objects to be returned. Limit can range between 1 and 10,000, and the default is 10,000.
",
    };

    private static Option<global::tryAGI.OpenAI.ListFilesOrder?> Order { get; } = new(
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

    public static Command Create()
    {
        var command = new Command(@"list-files", @"Returns a list of files.");
                        command.Options.Add(Purpose);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var purpose = parseResult.GetValue(Purpose);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Files.ListFilesAsync(
                                    purpose: purpose,
                                    limit: limit,
                                    order: order,
                                    after: after,
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