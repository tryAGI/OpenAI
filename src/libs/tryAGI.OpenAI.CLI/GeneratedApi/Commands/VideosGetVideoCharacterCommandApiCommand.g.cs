#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VideosGetVideoCharacterCommandApiCommand
{
    private static Argument<string> CharacterId { get; } = new(
        name: @"character-id")
    {
        Description = @"The identifier of the character to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-video-character", @"Fetch a character.");
                        command.Arguments.Add(CharacterId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var characterId = parseResult.GetRequiredValue(CharacterId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Videos.GetVideoCharacterAsync(
                                    characterId: characterId,
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