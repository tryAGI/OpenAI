#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class DecisionsCreateDecisionCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use. Only `gpt-6-luna` is supported.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.DecisionInput> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"The input to evaluate for every question. Provide a text string or an ordered array of messages, function calls and outputs, or custom tool calls and outputs. Each tool output must identify a matching call by call ID. User messages and tool outputs can contain text and images; developer and system messages can contain only input text, and assistant messages can contain output text or refusals. Images can be base64 data URLs or publicly accessible HTTP(S) URLs; at most 128 images are allowed per request. Files, audio, and item references are not supported.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>> Questions { get; } = new(
        name: @"--questions")
    {
        Description = @"Ask 1–400 questions about the input. Each question can be a predicate, choice, or score. Answers come back in the same order.",
        Required = true,
    };

    private static Option<string?> SafetyIdentifier { get; } = new(
        name: @"--safety-identifier")
    {
        Description = @"Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.",
    };

    private static Option<string?> PromptCacheKey { get; } = new(
        name: @"--prompt-cache-key")
    {
        Description = @"Partition prompt cache reuse by caller-provided key.",
    };

    private static Option<global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions?> PromptCacheOptions { get; } = new(
        name: @"--prompt-cache-options")
    {
        Description = @"Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](https://developers.openai.com/api/docs/guides/prompt-caching) for current details.",
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
Use this endpoint to quickly answer classification or scoring questions about some input. You can ask multiple questions in one request.");
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(Questions);
                        command.Options.Add(SafetyIdentifier);
                        command.Options.Add(PromptCacheKey);
                        command.Options.Add(PromptCacheOptions);
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
                        var promptCacheKey = CliRuntime.WasSpecified(parseResult, PromptCacheKey) ? parseResult.GetValue(PromptCacheKey) : (__requestBase is { } __PromptCacheKeyBaseValue ? __PromptCacheKeyBaseValue.PromptCacheKey : default);
                        var promptCacheOptions = CliRuntime.WasSpecified(parseResult, PromptCacheOptions) ? parseResult.GetValue(PromptCacheOptions) : (__requestBase is { } __PromptCacheOptionsBaseValue ? __PromptCacheOptionsBaseValue.PromptCacheOptions : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Decisions.CreateDecisionAsync(
                                    model: model,
                                    input: input,
                                    questions: questions,
                                    safetyIdentifier: safetyIdentifier,
                                    promptCacheKey: promptCacheKey,
                                    promptCacheOptions: promptCacheOptions,
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