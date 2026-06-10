#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class FineTuningDeleteCheckpointPermissionCommandApiCommand
{
    private static Argument<string> FineTunedModelCheckpoint { get; } = new(
        name: @"fine-tuned-model-checkpoint")
    {
        Description = @"The ID of the fine-tuned model checkpoint to delete a permission for.
",
    };

    private static Argument<string> PermissionId { get; } = new(
        name: @"permission-id")
    {
        Description = @"The ID of the fine-tuned model checkpoint permission to delete.
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-checkpoint-permission", @"**NOTE:** This endpoint requires an [admin API key](../admin-api-keys).

Organization owners can use this endpoint to delete a permission for a fine-tuned model checkpoint.
");
                        command.Arguments.Add(FineTunedModelCheckpoint);
                        command.Arguments.Add(PermissionId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var fineTunedModelCheckpoint = parseResult.GetRequiredValue(FineTunedModelCheckpoint);
                        var permissionId = parseResult.GetRequiredValue(PermissionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.FineTuning.DeleteCheckpointPermissionAsync(
                                    fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                                    permissionId: permissionId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}