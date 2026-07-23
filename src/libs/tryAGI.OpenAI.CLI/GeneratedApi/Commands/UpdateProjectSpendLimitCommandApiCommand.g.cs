#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UpdateProjectSpendLimitCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project whose hard spend limit is being managed.",
    };

    private static Option<int> ThresholdAmount { get; } = new(
        name: @"--threshold-amount")
    {
        Description = @"The hard spend limit amount, in cents.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency> Currency { get; } = new(
        name: @"--currency")
    {
        Description = @"The currency for the threshold amount. Currently, only `USD` is supported.",
    };

    private static Option<global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval> Interval { get; } = new(
        name: @"--interval")
    {
        Description = @"The time interval for evaluating spend against the threshold. Currently, only `month` is supported.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ProjectSpendLimitResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ProjectSpendLimitResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-project-spend-limit", @"Create or replace a project's hard spend limit.");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(ThresholdAmount);
                        command.Options.Add(Currency);
                        command.Options.Add(Interval);
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
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.UpdateProjectSpendLimitBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var thresholdAmount = parseResult.GetRequiredValue(ThresholdAmount);
                        var currency = CliRuntime.WasSpecified(parseResult, Currency) ? parseResult.GetValue(Currency) : (__requestBase is { } __CurrencyBaseValue ? __CurrencyBaseValue.Currency : default);
                        var interval = CliRuntime.WasSpecified(parseResult, Interval) ? parseResult.GetValue(Interval) : (__requestBase is { } __IntervalBaseValue ? __IntervalBaseValue.Interval : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdateProjectSpendLimitAsync(
                                    projectId: projectId,
                                    thresholdAmount: thresholdAmount,
                                    currency: currency,
                                    interval: interval,
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