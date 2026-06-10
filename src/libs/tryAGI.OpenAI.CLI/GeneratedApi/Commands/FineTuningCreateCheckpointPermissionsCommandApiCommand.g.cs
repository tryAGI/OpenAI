#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class FineTuningCreateCheckpointPermissionsCommandApiCommand
{
    private static Argument<string> FineTunedModelCheckpoint { get; } = new(
        name: @"fine-tuned-model-checkpoint")
    {
        Description = @"The ID of the fine-tuned model checkpoint to create a permission for.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>> ProjectIds { get; } = new(
        name: @"--project-ids")
    {
        Description = @"The project identifiers to grant access to.",
        Required = true,
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
        var command = new Command(@"create-checkpoint-permissions", @"**NOTE:** Calling this endpoint requires an [admin API key](../admin-api-keys).

This enables organization owners to share fine-tuned models with other projects in their organization.
");
                        command.Arguments.Add(FineTunedModelCheckpoint);
                        command.Options.Add(ProjectIds);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var fineTunedModelCheckpoint = parseResult.GetRequiredValue(FineTunedModelCheckpoint);
                        var projectIds = parseResult.GetRequiredValue(ProjectIds);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.FineTuning.CreateCheckpointPermissionsAsync(
                                    fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                                    projectIds: projectIds,
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