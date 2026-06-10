#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VideosCreateVideoExtendCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>> Video { get; } = new(
        name: @"--video")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Updated text prompt that directs the extension generation.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.VideoSeconds> Seconds { get; } = new(
        name: @"--seconds")
    {
        Description = @"Length of the newly generated extension segment in seconds (allowed values: 4, 8, 12, 16, 20).",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VideoResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VideoResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-video-extend", @"Create an extension of a completed video.");
                        command.Options.Add(Video);
                        command.Options.Add(Prompt);
                        command.Options.Add(Seconds);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var video = parseResult.GetRequiredValue(Video);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var seconds = parseResult.GetRequiredValue(Seconds);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Videos.CreateVideoExtendAsync(
                                    video: video,
                                    prompt: prompt,
                                    seconds: seconds,
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