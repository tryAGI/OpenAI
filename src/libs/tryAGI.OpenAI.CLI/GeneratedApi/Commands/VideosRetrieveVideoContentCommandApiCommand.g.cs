#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VideosRetrieveVideoContentCommandApiCommand
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

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"retrieve-video-content", @"Download the generated video bytes or a derived preview asset.

Streams the rendered video content for the specified video job.");
                        command.Arguments.Add(VideoId);
                        command.Options.Add(Variant);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var videoId = parseResult.GetRequiredValue(VideoId);
                        var variant = parseResult.GetValue(Variant);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Videos.RetrieveVideoContentAsync(
                                    videoId: videoId,
                                    variant: variant,
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