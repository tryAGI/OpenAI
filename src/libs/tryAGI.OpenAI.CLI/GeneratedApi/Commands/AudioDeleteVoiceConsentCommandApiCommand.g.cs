#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AudioDeleteVoiceConsentCommandApiCommand
{
    private static Argument<string> ConsentId { get; } = new(
        name: @"consent-id")
    {
        Description = @"The ID of the consent recording to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-voice-consent", @"Deletes a voice consent recording.
Delete a consent recording that was uploaded for creating custom voices.

See the [custom voices guide](/docs/guides/text-to-speech#custom-voices). Custom voices are limited to eligible customers.
");
                        command.Arguments.Add(ConsentId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var consentId = parseResult.GetRequiredValue(ConsentId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Audio.DeleteVoiceConsentAsync(
                                    consentId: consentId,
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