#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FineTuningResumeFineTuningCommandApiCommand
{
    private static Argument<string> FineTuningJobId { get; } = new(
        name: @"fine-tuning-job-id")
    {
        Description = @"The ID of the fine-tuning job to resume.
",
    };

    public static Command Create()
    {
        var command = new Command(@"resume-fine-tuning", @"Resume a fine-tune job.
");
                        command.Arguments.Add(FineTuningJobId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var fineTuningJobId = parseResult.GetRequiredValue(FineTuningJobId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.FineTuning.ResumeFineTuningAsync(
                                    fineTuningJobId: fineTuningJobId,
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