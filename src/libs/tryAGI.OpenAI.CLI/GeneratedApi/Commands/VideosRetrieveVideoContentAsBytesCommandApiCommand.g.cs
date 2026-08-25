#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VideosRetrieveVideoContentAsBytesCommandApiCommand
{
    private static Argument<string> VideoId { get; } = new(
        name: @"video-id")
    {
        Description = @"The identifier of the video whose media to download.",
    };

    private static Option<global::tryAGI.OpenAI.VideoContentVariant?> Variant { get; } = new(
        name: @"--variant")
    {
        Description = @"Which downloadable asset to return. Defaults to the MP4 video.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-video-content-as-bytes", @"Download the generated video bytes or a derived preview asset.

Streams the rendered video content for the specified video job.");
                        command.Arguments.Add(VideoId);
                        command.Options.Add(Variant);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var videoId = parseResult.GetRequiredValue(VideoId);
                        var variant = parseResult.GetValue(Variant);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Videos.RetrieveVideoContentAsBytesAsync(
                                    videoId: videoId,
                                    variant: variant,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}