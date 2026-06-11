#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class SpendAlertsUpdateProjectSpendAlertCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project to update.",
    };

    private static Argument<string> AlertId { get; } = new(
        name: @"alert-id")
    {
        Description = @"The ID of the spend alert to update.",
    };
    private static readonly CreateSpendAlertBodyOptionSet CreateSpendAlertBodyOptionSetOptions = CreateSpendAlertBodyOptionSet.Create();

    private static readonly SpendAlertNotificationChannelOptionSet NotificationChannelOptions = SpendAlertNotificationChannelOptionSet.Create(@"notification-channel");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ProjectSpendAlert value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ProjectSpendAlert value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-project-spend-alert", @"Updates a project spend alert.");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(AlertId);                        command.Options.Add(CreateSpendAlertBodyOptionSetOptions.ThresholdAmount);
                        command.Options.Add(CreateSpendAlertBodyOptionSetOptions.Currency);
                        command.Options.Add(CreateSpendAlertBodyOptionSetOptions.Interval);                        command.Options.Add(NotificationChannelOptions.Type);
                        command.Options.Add(NotificationChannelOptions.Recipients);
                        command.Options.Add(NotificationChannelOptions.SubjectPrefix);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateSpendAlertBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var alertId = parseResult.GetRequiredValue(AlertId);                        var thresholdAmount = parseResult.GetRequiredValue(CreateSpendAlertBodyOptionSetOptions.ThresholdAmount);
                        var currency = CliRuntime.WasSpecified(parseResult, CreateSpendAlertBodyOptionSetOptions.Currency) ? parseResult.GetValue(CreateSpendAlertBodyOptionSetOptions.Currency) : __requestBase is not null ? __requestBase.Currency : default;
                        var interval = CliRuntime.WasSpecified(parseResult, CreateSpendAlertBodyOptionSetOptions.Interval) ? parseResult.GetValue(CreateSpendAlertBodyOptionSetOptions.Interval) : __requestBase is not null ? __requestBase.Interval : default;

                        var __notificationChannelBase = __requestBase?.NotificationChannel;                        var notificationChannelType = CliRuntime.WasSpecified(parseResult, NotificationChannelOptions.Type) ? parseResult.GetValue(NotificationChannelOptions.Type) : __notificationChannelBase is not null ? __notificationChannelBase.Type : default;
                        var notificationChannelRecipients = parseResult.GetValue(NotificationChannelOptions.Recipients);
                        var notificationChannelSubjectPrefix = CliRuntime.WasSpecified(parseResult, NotificationChannelOptions.SubjectPrefix) ? parseResult.GetValue(NotificationChannelOptions.SubjectPrefix) : __notificationChannelBase is not null ? __notificationChannelBase.SubjectPrefix : default;
                        var __notificationChannelSpecified = CliRuntime.WasSpecified(parseResult, NotificationChannelOptions.Type) || CliRuntime.WasSpecified(parseResult, NotificationChannelOptions.Recipients) || CliRuntime.WasSpecified(parseResult, NotificationChannelOptions.SubjectPrefix);
                        var notificationChannel =
                            __notificationChannelSpecified || __notificationChannelBase is not null
                                ? new global::tryAGI.OpenAI.SpendAlertNotificationChannel
                                {
                                Type = notificationChannelType,
                                Recipients = notificationChannelRecipients!,
                                SubjectPrefix = notificationChannelSubjectPrefix,
                                }
                                : __notificationChannelBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SpendAlerts.UpdateProjectSpendAlertAsync(
                                    projectId: projectId,
                                    alertId: alertId,
                                    thresholdAmount: thresholdAmount,
                                    currency: currency,
                                    interval: interval,
                                    notificationChannel: notificationChannel!,
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