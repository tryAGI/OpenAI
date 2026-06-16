#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class GetInputTokenCountsCommandApiCommand
{
    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"",
    };

    private static Option<string?> PreviousResponseId { get; } = new(
        name: @"--previous-response-id")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.ResponseTextParam?> Text { get; } = new(
        name: @"--text")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.Reasoning?> Reasoning { get; } = new(
        name: @"--reasoning")
    {
        Description = @"",
    };

    private static Option<string?> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.PersonalityEnum?> Personality { get; } = new(
        name: @"--personality")
    {
        Description = @"A model-owned style preset to apply to this request. Omit this parameter to use the model's default style. Supported values may expand over time. Values must be at most 64 characters.",
    };

    private static Option<global::tryAGI.OpenAI.ConversationParam?> Conversation { get; } = new(
        name: @"--conversation")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.ToolChoiceParam?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"",
    };

    private static Option<bool?> ParallelToolCalls { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--parallel-tool-calls",
        description: @"");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.TokenCountsResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.TokenCountsResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-input-token-counts", @"Returns input token counts of the request.

Returns an object with `object` set to `response.input_tokens` and an `input_tokens` count.");
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(PreviousResponseId);
                        command.Options.Add(Tools);
                        command.Options.Add(Text);
                        command.Options.Add(Reasoning);
                        command.Options.Add(Instructions);
                        command.Options.Add(Personality);
                        command.Options.Add(Conversation);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(ParallelToolCalls);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.TokenCountsBody>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);
                        var previousResponseId = CliRuntime.WasSpecified(parseResult, PreviousResponseId) ? parseResult.GetValue(PreviousResponseId) : (__requestBase is { } __PreviousResponseIdBaseValue ? __PreviousResponseIdBaseValue.PreviousResponseId : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var text = CliRuntime.WasSpecified(parseResult, Text) ? parseResult.GetValue(Text) : (__requestBase is { } __TextBaseValue ? __TextBaseValue.Text : default);
                        var reasoning = CliRuntime.WasSpecified(parseResult, Reasoning) ? parseResult.GetValue(Reasoning) : (__requestBase is { } __ReasoningBaseValue ? __ReasoningBaseValue.Reasoning : default);
                        var instructions = CliRuntime.WasSpecified(parseResult, Instructions) ? parseResult.GetValue(Instructions) : (__requestBase is { } __InstructionsBaseValue ? __InstructionsBaseValue.Instructions : default);
                        var personality = CliRuntime.WasSpecified(parseResult, Personality) ? parseResult.GetValue(Personality) : (__requestBase is { } __PersonalityBaseValue ? __PersonalityBaseValue.Personality : default);
                        var conversation = CliRuntime.WasSpecified(parseResult, Conversation) ? parseResult.GetValue(Conversation) : (__requestBase is { } __ConversationBaseValue ? __ConversationBaseValue.Conversation : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);
                        var parallelToolCalls = CliRuntime.WasSpecified(parseResult, ParallelToolCalls) ? parseResult.GetValue(ParallelToolCalls) : (__requestBase is { } __ParallelToolCallsBaseValue ? __ParallelToolCallsBaseValue.ParallelToolCalls : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetInputTokenCountsAsync(
                                    model: model,
                                    input: input,
                                    previousResponseId: previousResponseId,
                                    tools: tools,
                                    text: text,
                                    reasoning: reasoning,
                                    instructions: instructions,
                                    personality: personality,
                                    conversation: conversation,
                                    toolChoice: toolChoice,
                                    parallelToolCalls: parallelToolCalls,
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