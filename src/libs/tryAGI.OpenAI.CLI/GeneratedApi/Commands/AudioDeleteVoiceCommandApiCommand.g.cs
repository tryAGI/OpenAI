#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioDeleteVoiceCommandApiCommand
{
    private static Argument<string> VoiceId { get; } = new(
        name: @"voice-id")
    {
        Description = @"The ID of the voice to delete.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VoiceDeletedResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VoiceDeletedResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-voice", @"Delete voice
Deletes a voice created from a text prompt or an audio sample.

Requires voice write permission and access to the voice's project. Access to voices created from recordings is limited to eligible customers. See the [custom voices guide](https://developers.openai.com/api/docs/guides/custom-voices).

Deleting a voice does not delete its consent recording. Deleting an already deleted voice returns a 404 error.
");
                        command.Arguments.Add(VoiceId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.DeleteVoiceAsync(
                                    voiceId: voiceId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}