#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class FineTuningListCheckpointPermissionsCommandApiCommand
{
    private static Argument<string> FineTunedModelCheckpoint { get; } = new(
        name: @"fine-tuned-model-checkpoint")
    {
        Description = @"The ID of the fine-tuned model checkpoint to get permissions for.
",
    };

    private static Option<string?> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"The ID of the project to get permissions for.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last permission ID from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of permissions to retrieve.",
    };

    private static Option<global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"The order in which to retrieve permissions.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-checkpoint-permissions", @"**NOTE:** This endpoint requires an [admin API key](../admin-api-keys).

Organization owners can use this endpoint to view all permissions for a fine-tuned model checkpoint.
");
                        command.Arguments.Add(FineTunedModelCheckpoint);
                        command.Options.Add(ProjectId);
                        command.Options.Add(After);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var fineTunedModelCheckpoint = parseResult.GetRequiredValue(FineTunedModelCheckpoint);
                        var projectId = parseResult.GetValue(ProjectId);
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.FineTuning.ListCheckpointPermissionsAsync(
                                    fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                                    projectId: projectId,
                                    after: after,
                                    limit: limit,
                                    order: order,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}