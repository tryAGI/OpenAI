#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AssistantsSubmitToolOuputsToRunCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the [thread](https://developers.openai.com/api/docs/assistants/migration) to which this run belongs.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The ID of the run that requires the tool output submission.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>> ToolOutputs { get; } = new(
        name: @"--tool-outputs")
    {
        Description = @"A list of tools for which the outputs are being submitted.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.RunObject value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.RunObject value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"submit-tool-ouputs-to-run", @"Submit tool outputs to run
When a run has the `status: ""requires_action""` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request.
");
                        command.Arguments.Add(ThreadId);
                        command.Arguments.Add(RunId);
                        command.Options.Add(ToolOutputs);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var runId = parseResult.GetRequiredValue(RunId);
                        var toolOutputs = parseResult.GetRequiredValue(ToolOutputs);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Assistants.SubmitToolOuputsToRunAsync(
                                    threadId: threadId,
                                    runId: runId,
                                    toolOutputs: toolOutputs,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Tools",
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
        CustomizeCommand(ref command);
        return command;
    }
}