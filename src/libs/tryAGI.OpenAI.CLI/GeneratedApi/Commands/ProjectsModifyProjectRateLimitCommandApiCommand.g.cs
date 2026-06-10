#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ProjectsModifyProjectRateLimitCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };

    private static Argument<string> RateLimitId { get; } = new(
        name: @"rate-limit-id")
    {
        Description = @"The ID of the rate limit.",
    };

    private static Option<int?> MaxRequestsPer1Minute { get; } = new(
        name: @"--max-requests-per-1-minute")
    {
        Description = @"The maximum requests per minute.",
    };

    private static Option<int?> MaxTokensPer1Minute { get; } = new(
        name: @"--max-tokens-per-1-minute")
    {
        Description = @"The maximum tokens per minute.",
    };

    private static Option<int?> MaxImagesPer1Minute { get; } = new(
        name: @"--max-images-per-1-minute")
    {
        Description = @"The maximum images per minute. Only relevant for certain models.",
    };

    private static Option<long?> MaxAudioMegabytesPer1Minute { get; } = new(
        name: @"--max-audio-megabytes-per-1-minute")
    {
        Description = @"The maximum audio megabytes per minute. Only relevant for certain models.",
    };

    private static Option<int?> MaxRequestsPer1Day { get; } = new(
        name: @"--max-requests-per-1-day")
    {
        Description = @"The maximum requests per day. Only relevant for certain models.",
    };

    private static Option<int?> Batch1DayMaxInputTokens { get; } = new(
        name: @"--batch-1-day-max-input-tokens")
    {
        Description = @"The maximum batch input tokens per day. Only relevant for certain models.",
    };
      private static Option<string?> Input { get; } = new("--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ProjectRateLimit value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ProjectRateLimit value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"modify-project-rate-limit", @"Updates a project rate limit.");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(RateLimitId);
                        command.Options.Add(MaxRequestsPer1Minute);
                        command.Options.Add(MaxTokensPer1Minute);
                        command.Options.Add(MaxImagesPer1Minute);
                        command.Options.Add(MaxAudioMegabytesPer1Minute);
                        command.Options.Add(MaxRequestsPer1Day);
                        command.Options.Add(Batch1DayMaxInputTokens);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError("Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var rateLimitId = parseResult.GetRequiredValue(RateLimitId);
                        var maxRequestsPer1Minute = parseResult.GetValue(MaxRequestsPer1Minute) ?? __requestBase?.MaxRequestsPer1Minute;
                        var maxTokensPer1Minute = parseResult.GetValue(MaxTokensPer1Minute) ?? __requestBase?.MaxTokensPer1Minute;
                        var maxImagesPer1Minute = parseResult.GetValue(MaxImagesPer1Minute) ?? __requestBase?.MaxImagesPer1Minute;
                        var maxAudioMegabytesPer1Minute = parseResult.GetValue(MaxAudioMegabytesPer1Minute) ?? __requestBase?.MaxAudioMegabytesPer1Minute;
                        var maxRequestsPer1Day = parseResult.GetValue(MaxRequestsPer1Day) ?? __requestBase?.MaxRequestsPer1Day;
                        var batch1DayMaxInputTokens = parseResult.GetValue(Batch1DayMaxInputTokens) ?? __requestBase?.Batch1DayMaxInputTokens;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.ModifyProjectRateLimitAsync(
                                    projectId: projectId,
                                    rateLimitId: rateLimitId,
                                    maxRequestsPer1Minute: maxRequestsPer1Minute,
                                    maxTokensPer1Minute: maxTokensPer1Minute,
                                    maxImagesPer1Minute: maxImagesPer1Minute,
                                    maxAudioMegabytesPer1Minute: maxAudioMegabytesPer1Minute,
                                    maxRequestsPer1Day: maxRequestsPer1Day,
                                    batch1DayMaxInputTokens: batch1DayMaxInputTokens,
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