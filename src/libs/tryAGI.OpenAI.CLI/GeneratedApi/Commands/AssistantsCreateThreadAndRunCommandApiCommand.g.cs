#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AssistantsCreateThreadAndRunCommandApiCommand
{
    private static Option<string> AssistantId { get; } = new(
        name: @"--assistant-id")
    {
        Description = @"The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateThreadRequest?> Thread { get; } = new(
        name: @"--thread")
    {
        Description = @"Options to create a new thread. If no thread is provided when running a
request, an empty thread will be created.
",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.",
    };

    private static Option<string?> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"Override the default system message of the assistant. This is useful for modifying the behavior on a per-run basis.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.",
    };

    private static Option<global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources?> ToolResources { get; } = new(
        name: @"--tool-resources")
    {
        Description = @"A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
",
    };

    private static Option<double?> TopP { get; } = new(
        name: @"--top-p")
    {
        Description = @"An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.

We generally recommend altering this or temperature but not both.
",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
");

    private static Option<int?> MaxPromptTokens { get; } = new(
        name: @"--max-prompt-tokens")
    {
        Description = @"The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
",
    };

    private static Option<int?> MaxCompletionTokens { get; } = new(
        name: @"--max-completion-tokens")
    {
        Description = @"The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
",
    };

    private static Option<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>?> TruncationStrategy { get; } = new(
        name: @"--truncation-strategy")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"",
    };

    private static Option<bool?> ParallelToolCalls { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--parallel-tool-calls",
        description: @"Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.");

    private static Option<global::tryAGI.OpenAI.AssistantsApiResponseFormatOption?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models#gpt-4o), [GPT-4 Turbo](/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.

Setting to `{ ""type"": ""json_schema"", ""json_schema"": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).

Setting to `{ ""type"": ""json_object"" }` enables JSON mode, which ensures the message the model generates is valid JSON.

**Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly ""stuck"" request. Also note that the message content may be partially cut off if `finish_reason=""length""`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.RunObject value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.RunObject value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-thread-and-run", @"Create a thread and run it in one request.");
                        command.Options.Add(AssistantId);
                        command.Options.Add(Thread);
                        command.Options.Add(Model);
                        command.Options.Add(Instructions);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolResources);
                        command.Options.Add(Metadata);
                        command.Options.Add(Temperature);
                        command.Options.Add(TopP);
                        command.Options.Add(Stream);
                        command.Options.Add(MaxPromptTokens);
                        command.Options.Add(MaxCompletionTokens);
                        command.Options.Add(TruncationStrategy);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(ParallelToolCalls);
                        command.Options.Add(ResponseFormat);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateThreadAndRunRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var assistantId = parseResult.GetRequiredValue(AssistantId);
                        var thread = CliRuntime.WasSpecified(parseResult, Thread) ? parseResult.GetValue(Thread) : __requestBase is not null ? __requestBase.Thread : default;
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : __requestBase is not null ? __requestBase.Model : default;
                        var instructions = CliRuntime.WasSpecified(parseResult, Instructions) ? parseResult.GetValue(Instructions) : __requestBase is not null ? __requestBase.Instructions : default;
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : __requestBase is not null ? __requestBase.Tools : default;
                        var toolResources = CliRuntime.WasSpecified(parseResult, ToolResources) ? parseResult.GetValue(ToolResources) : __requestBase is not null ? __requestBase.ToolResources : default;
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : __requestBase is not null ? __requestBase.Metadata : default;
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : __requestBase is not null ? __requestBase.Temperature : default;
                        var topP = CliRuntime.WasSpecified(parseResult, TopP) ? parseResult.GetValue(TopP) : __requestBase is not null ? __requestBase.TopP : default;
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : __requestBase is not null ? __requestBase.Stream : default;
                        var maxPromptTokens = CliRuntime.WasSpecified(parseResult, MaxPromptTokens) ? parseResult.GetValue(MaxPromptTokens) : __requestBase is not null ? __requestBase.MaxPromptTokens : default;
                        var maxCompletionTokens = CliRuntime.WasSpecified(parseResult, MaxCompletionTokens) ? parseResult.GetValue(MaxCompletionTokens) : __requestBase is not null ? __requestBase.MaxCompletionTokens : default;
                        var truncationStrategy = CliRuntime.WasSpecified(parseResult, TruncationStrategy) ? parseResult.GetValue(TruncationStrategy) : __requestBase is not null ? __requestBase.TruncationStrategy : default;
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : __requestBase is not null ? __requestBase.ToolChoice : default;
                        var parallelToolCalls = CliRuntime.WasSpecified(parseResult, ParallelToolCalls) ? parseResult.GetValue(ParallelToolCalls) : __requestBase is not null ? __requestBase.ParallelToolCalls : default;
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : __requestBase is not null ? __requestBase.ResponseFormat : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Assistants.CreateThreadAndRunAsync(
                                    assistantId: assistantId,
                                    thread: thread,
                                    model: model,
                                    instructions: instructions,
                                    tools: tools,
                                    toolResources: toolResources,
                                    metadata: metadata,
                                    temperature: temperature,
                                    topP: topP,
                                    stream: stream,
                                    maxPromptTokens: maxPromptTokens,
                                    maxCompletionTokens: maxCompletionTokens,
                                    truncationStrategy: truncationStrategy,
                                    toolChoice: toolChoice,
                                    parallelToolCalls: parallelToolCalls,
                                    responseFormat: responseFormat,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Tools",
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