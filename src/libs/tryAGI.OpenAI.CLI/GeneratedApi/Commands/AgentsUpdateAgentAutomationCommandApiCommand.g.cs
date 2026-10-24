#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsUpdateAgentAutomationCommandApiCommand
{
    private static Argument<string> AutomationId { get; } = new(
        name: @"automation-id")
    {
        Description = @"",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.AutomationTargetParam?> Target { get; } = new(
        name: @"--target")
    {
        Description = @"Replaces the complete target, retaining its type and any creator session.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Replaces all metadata; omit to leave unchanged.",
    };

    private static Option<string?> Expression { get; } = new(
        name: @"--expression")
    {
        Description = @"Only accepted for periodic automations.",
    };

    private static Option<string?> Timezone { get; } = new(
        name: @"--timezone")
    {
        Description = @"Only accepted for periodic automations.",
    };

    private static Option<global::System.DateTimeOffset?> RunAt { get; } = new(
        name: @"--run-at")
    {
        Description = @"A future Unix timestamp in seconds; accepted only before a one-time scheduled invocation exists.",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.AutomationResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.AutomationResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"update-agent-automation", @"Update an automation
Updates supplied fields; target and metadata replace the whole field.");
                        command.Arguments.Add(AutomationId);
                        command.Options.Add(NameOption);
                        command.Options.Add(Target);
                        command.Options.Add(Metadata);
                        command.Options.Add(Expression);
                        command.Options.Add(Timezone);
                        command.Options.Add(RunAt);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.UpdateAutomationParams>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var automationId = parseResult.GetRequiredValue(AutomationId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var target = CliRuntime.WasSpecified(parseResult, Target) ? parseResult.GetValue(Target) : (__requestBase is { } __TargetBaseValue ? __TargetBaseValue.Target : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var expression = CliRuntime.WasSpecified(parseResult, Expression) ? parseResult.GetValue(Expression) : (__requestBase is { } __ExpressionBaseValue ? __ExpressionBaseValue.Expression : default);
                        var timezone = CliRuntime.WasSpecified(parseResult, Timezone) ? parseResult.GetValue(Timezone) : (__requestBase is { } __TimezoneBaseValue ? __TimezoneBaseValue.Timezone : default);
                        var runAt = CliRuntime.WasSpecified(parseResult, RunAt) ? parseResult.GetValue(RunAt) : (__requestBase is { } __RunAtBaseValue ? __RunAtBaseValue.RunAt : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.UpdateAgentAutomationAsync(
                                    automationId: automationId,
                                    name: name,
                                    target: target,
                                    metadata: metadata,
                                    expression: expression,
                                    timezone: timezone,
                                    runAt: runAt,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}