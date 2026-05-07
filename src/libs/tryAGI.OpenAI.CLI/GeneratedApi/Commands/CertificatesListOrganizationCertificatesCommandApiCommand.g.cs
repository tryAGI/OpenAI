#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class CertificatesListOrganizationCertificatesCommandApiCommand
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

    private static Option<global::tryAGI.OpenAI.ListOrganizationCertificatesOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and `desc` for descending order.
",
    };

    public static Command Create()
    {
        var command = new Command(@"list-organization-certificates", @"List uploaded certificates for this organization.");
                        command.Options.Add(Limit);
                        command.Options.Add(After);
                        command.Options.Add(Order);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var after = parseResult.GetValue(After);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Certificates.ListOrganizationCertificatesAsync(
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