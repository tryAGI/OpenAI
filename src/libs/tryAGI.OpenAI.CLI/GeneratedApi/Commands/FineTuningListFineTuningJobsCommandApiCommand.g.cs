#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FineTuningListFineTuningJobsCommandApiCommand
{
     private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last job from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of fine-tuning jobs to retrieve.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Optional metadata filter. To filter, use the syntax `metadata[k]=v`. Alternatively, set `metadata=null` to indicate no metadata.
",
    };

    public static Command Create()
    {
        var command = new Command(@"list-fine-tuning-jobs", @"List your organization's fine-tuning jobs
");
                        command.Options.Add(After);
                        command.Options.Add(Limit);
                        command.Options.Add(Metadata);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                        var metadata = parseResult.GetValue(Metadata);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.FineTuning.ListFineTuningJobsAsync(
                                    after: after,
                                    limit: limit,
                                    metadata: metadata,
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