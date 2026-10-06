#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class DecisionsCreateDecisionCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.DecisionInput> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Shared evidence, as a string or an array of user messages containing text and inline images. Non-user roles, function calls, function-call outputs, files, audio, and item references are not supported. At most 128 image parts are allowed across all messages in one request.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>> Questions { get; } = new(
        name: @"--questions")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> SafetyIdentifier { get; } = new(
        name: @"--safety-identifier")
    {
        Description = @"Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.",
    };
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.DecisionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.DecisionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-decision", @"Create a decision
Evaluate ordered classification and scoring questions against shared input. Answers are returned in question order.

Supply input as a string or user messages containing text and inline images. Only user messages with `input_text` and `input_image` parts are supported; non-user roles, function calls, files, audio, and item references are not supported. Images require a data URL, not an external URL or file ID. At most 128 images are allowed across the request.

Each question can return a refusal instead of a scored answer. A refusal has type `refusal` and the corresponding question name, or null if unnamed.");
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(Questions);
                        command.Options.Add(SafetyIdentifier);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.DecisionRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var questions = parseResult.GetRequiredValue(Questions);
                        var safetyIdentifier = CliRuntime.WasSpecified(parseResult, SafetyIdentifier) ? parseResult.GetValue(SafetyIdentifier) : (__requestBase is { } __SafetyIdentifierBaseValue ? __SafetyIdentifierBaseValue.SafetyIdentifier : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Decisions.CreateDecisionAsync(
                                    model: model,
                                    input: input,
                                    questions: questions,
                                    safetyIdentifier: safetyIdentifier,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Answers",
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
        CustomizeCommand(ref command);
        return command;
    }
}