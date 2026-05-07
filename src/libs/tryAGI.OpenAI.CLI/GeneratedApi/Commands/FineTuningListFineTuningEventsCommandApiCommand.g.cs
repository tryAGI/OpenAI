#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FineTuningListFineTuningEventsCommandApiCommand
{
    private static Argument<string> FineTuningJobId { get; } = new(
        name: @"fine-tuning-job-id")
    {
        Description = @"The ID of the fine-tuning job to get events for.
",
    };    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last event from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of events to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-fine-tuning-events", @"Get status updates for a fine-tuning job.
");
                        command.Arguments.Add(FineTuningJobId);
                        command.Options.Add(After);
                        command.Options.Add(Limit);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var fineTuningJobId = parseResult.GetRequiredValue(FineTuningJobId);
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.FineTuning.ListFineTuningEventsAsync(
                                    fineTuningJobId: fineTuningJobId,
                                    after: after,
                                    limit: limit,
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