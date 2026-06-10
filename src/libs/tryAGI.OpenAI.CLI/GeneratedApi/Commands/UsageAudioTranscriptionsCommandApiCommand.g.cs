#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UsageAudioTranscriptionsCommandApiCommand
{
    private static Option<int> StartTime { get; } = new(
        name: @"--start-time")
    {
        Description = @"Start time (Unix seconds) of the query time range, inclusive.",
        Required = true,
    };

    private static Option<int?> EndTime { get; } = new(
        name: @"--end-time")
    {
        Description = @"End time (Unix seconds) of the query time range, exclusive.",
    };

    private static Option<global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth?> BucketWidth { get; } = new(
        name: @"--bucket-width")
    {
        Description = @"Width of each time bucket in response. Currently `1m`, `1h` and `1d` are supported, default to `1d`.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ProjectIds { get; } = new(
        name: @"--project-ids")
    {
        Description = @"Return only usage for these projects.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"Return only usage for these users.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ApiKeyIds { get; } = new(
        name: @"--api-key-ids")
    {
        Description = @"Return only usage for these API keys.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Return only usage for these models.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>?> GroupBy { get; } = new(
        name: @"--group-by")
    {
        Description = @"Group the usage data by the specified fields. Support fields include `project_id`, `user_id`, `api_key_id`, `model` or any combination of them.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Specifies the number of buckets to return.
- `bucket_width=1d`: default: 7, max: 31
- `bucket_width=1h`: default: 24, max: 168
- `bucket_width=1m`: default: 60, max: 1440
",
    };

    private static Option<string?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"A cursor for use in pagination. Corresponding to the `next_page` field from the previous response.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.UsageResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.UsageResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"audio-transcriptions", @"Get audio transcriptions usage details for the organization.");
                        command.Options.Add(StartTime);
                        command.Options.Add(EndTime);
                        command.Options.Add(BucketWidth);
                        command.Options.Add(ProjectIds);
                        command.Options.Add(UserIds);
                        command.Options.Add(ApiKeyIds);
                        command.Options.Add(Models);
                        command.Options.Add(GroupBy);
                        command.Options.Add(Limit);
                        command.Options.Add(Page);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var startTime = parseResult.GetRequiredValue(StartTime);
                        var endTime = parseResult.GetValue(EndTime);
                        var bucketWidth = parseResult.GetValue(BucketWidth);
                        var projectIds = parseResult.GetValue(ProjectIds);
                        var userIds = parseResult.GetValue(UserIds);
                        var apiKeyIds = parseResult.GetValue(ApiKeyIds);
                        var models = parseResult.GetValue(Models);
                        var groupBy = parseResult.GetValue(GroupBy);
                        var limit = parseResult.GetValue(Limit);
                        var page = parseResult.GetValue(Page);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Usage.AudioTranscriptionsAsync(
                                    startTime: startTime,
                                    endTime: endTime,
                                    bucketWidth: bucketWidth,
                                    projectIds: projectIds,
                                    userIds: userIds,
                                    apiKeyIds: apiKeyIds,
                                    models: models,
                                    groupBy: groupBy,
                                    limit: limit,
                                    page: page,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Data",
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
        return command;
    }
}