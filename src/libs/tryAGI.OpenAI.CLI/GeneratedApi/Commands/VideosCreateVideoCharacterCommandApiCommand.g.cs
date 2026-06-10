#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VideosCreateVideoCharacterCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Display name for this API character.",
    };

    private static Option<byte[]> Video { get; } = new(
        name: @"--video")
    {
        Description = @"Video file used to create a character.",
        Required = true,
    };

    private static Option<string> Videoname { get; } = new(
        name: @"--videoname")
    {
        Description = @"Video file used to create a character.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VideoCharacterResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VideoCharacterResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-video-character", @"Create a character from an uploaded video.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(Video);
                        command.Options.Add(Videoname);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetRequiredValue(NameOption);
                        var video = parseResult.GetRequiredValue(Video);
                        var videoname = parseResult.GetRequiredValue(Videoname);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Videos.CreateVideoCharacterAsync(
                                    name: name,
                                    video: video,
                                    videoname: videoname,
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