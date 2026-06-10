#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class GetInputTokenCountsCommandApiCommand
{
    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>?> Input { get; } = new(
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

    private static Option<global::tryAGI.OpenAI.TruncationEnum?> Truncation { get; } = new(
        name: @"--truncation")
    {
        Description = @"The truncation strategy to use for the model response. - `auto`: If the input to this Response exceeds the model's context window size, the model will truncate the response to fit the context window by dropping items from the beginning of the conversation. - `disabled` (default): If the input size will exceed the context window size for a model, the request will fail with a 400 error.",
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
                        command.Options.Add(Input);
                        command.Options.Add(PreviousResponseId);
                        command.Options.Add(Tools);
                        command.Options.Add(Text);
                        command.Options.Add(Reasoning);
                        command.Options.Add(Truncation);
                        command.Options.Add(Instructions);
                        command.Options.Add(Personality);
                        command.Options.Add(Conversation);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(ParallelToolCalls);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.TokenCountsBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetValue(Model) ?? __requestBase?.Model;
                        var input = parseResult.GetValue(Input) ?? __requestBase?.Input;
                        var previousResponseId = parseResult.GetValue(PreviousResponseId) ?? __requestBase?.PreviousResponseId;
                        var tools = parseResult.GetValue(Tools) ?? __requestBase?.Tools;
                        var text = parseResult.GetValue(Text) ?? __requestBase?.Text;
                        var reasoning = parseResult.GetValue(Reasoning) ?? __requestBase?.Reasoning;
                        var truncation = parseResult.GetValue(Truncation) ?? __requestBase?.Truncation;
                        var instructions = parseResult.GetValue(Instructions) ?? __requestBase?.Instructions;
                        var personality = parseResult.GetValue(Personality) ?? __requestBase?.Personality;
                        var conversation = parseResult.GetValue(Conversation) ?? __requestBase?.Conversation;
                        var toolChoice = parseResult.GetValue(ToolChoice) ?? __requestBase?.ToolChoice;
                        var parallelToolCalls = parseResult.GetValue(ParallelToolCalls) ?? __requestBase?.ParallelToolCalls;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetInputTokenCountsAsync(
                                    model: model,
                                    input: input,
                                    previousResponseId: previousResponseId,
                                    tools: tools,
                                    text: text,
                                    reasoning: reasoning,
                                    truncation: truncation,
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