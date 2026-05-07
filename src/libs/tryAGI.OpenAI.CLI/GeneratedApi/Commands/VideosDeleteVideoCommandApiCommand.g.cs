#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VideosDeleteVideoCommandApiCommand
{
    private static Argument<string> VideoId { get; } = new(
        name: @"video-id")
    {
        Description = @"The identifier of the video to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-video", @"Permanently delete a completed or failed video and its stored assets.");
                        command.Arguments.Add(VideoId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var videoId = parseResult.GetRequiredValue(VideoId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Videos.DeleteVideoAsync(
                                    videoId: videoId,
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