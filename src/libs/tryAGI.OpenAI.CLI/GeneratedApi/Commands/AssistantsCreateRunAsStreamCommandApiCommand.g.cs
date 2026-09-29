#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AssistantsCreateRunAsStreamCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the thread to run.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"A list of additional fields to include in the response. Currently the only supported value is `step_details.tool_calls[*].file_search.results[*].content` to fetch the file search result content.

See the [file search tool documentation](https://developers.openai.com/api/docs/guides/tools-file-search#retrieval-customization) for more information.
",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The ID of the [Model](https://developers.openai.com/api/reference/resources/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.",
    };

    private static Option<global::tryAGI.OpenAI.ReasoningEffortEnum?> ReasoningEffort { get; } = new(
        name: @"--reasoning-effort")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>?> AdditionalMessages { get; } = new(
        name: @"--additional-messages")
    {
        Description = @"Adds additional messages to the thread before creating the run.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
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

    private static Option<global::tryAGI.OpenAI.AssistantsApiResponseFormatOption?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"Specifies the format that the model must output. Compatible with [GPT-4o](https://developers.openai.com/api/docs/models/gpt-4o), [GPT-4 Turbo](https://developers.openai.com/api/docs/models/gpt-4-turbo), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.

Setting to `{ ""type"": ""json_schema"", ""json_schema"": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](https://developers.openai.com/api/docs/guides/structured-outputs).

Setting to `{ ""type"": ""json_object"" }` enables JSON mode, which ensures the message the model generates is valid JSON.

**Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly ""stuck"" request. Also note that the message content may be partially cut off if `finish_reason=""length""`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
",
    };
    private static readonly CreateRunRequestOptionSet CreateRunRequestOptionSetOptions = CreateRunRequestOptionSet.Create();
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

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-run-as-stream", @"Create run
Create a run.");
                        command.Arguments.Add(ThreadId);
                        command.Options.Add(Include);
                        command.Options.Add(Model);
                        command.Options.Add(ReasoningEffort);
                        command.Options.Add(AdditionalMessages);
                        command.Options.Add(Tools);
                        command.Options.Add(Metadata);
                        command.Options.Add(TruncationStrategy);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(ResponseFormat);                        command.Options.Add(CreateRunRequestOptionSetOptions.AssistantId);
                        command.Options.Add(CreateRunRequestOptionSetOptions.Instructions);
                        command.Options.Add(CreateRunRequestOptionSetOptions.AdditionalInstructions);
                        command.Options.Add(CreateRunRequestOptionSetOptions.Temperature);
                        command.Options.Add(CreateRunRequestOptionSetOptions.TopP);
                        command.Options.Add(CreateRunRequestOptionSetOptions.MaxPromptTokens);
                        command.Options.Add(CreateRunRequestOptionSetOptions.MaxCompletionTokens);
                        command.Options.Add(CreateRunRequestOptionSetOptions.ParallelToolCalls);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateRunRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var include = parseResult.GetValue(Include);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var reasoningEffort = CliRuntime.WasSpecified(parseResult, ReasoningEffort) ? parseResult.GetValue(ReasoningEffort) : (__requestBase is { } __ReasoningEffortBaseValue ? __ReasoningEffortBaseValue.ReasoningEffort : default);
                        var additionalMessages = CliRuntime.WasSpecified(parseResult, AdditionalMessages) ? parseResult.GetValue(AdditionalMessages) : (__requestBase is { } __AdditionalMessagesBaseValue ? __AdditionalMessagesBaseValue.AdditionalMessages : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var truncationStrategy = CliRuntime.WasSpecified(parseResult, TruncationStrategy) ? parseResult.GetValue(TruncationStrategy) : (__requestBase is { } __TruncationStrategyBaseValue ? __TruncationStrategyBaseValue.TruncationStrategy : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);                        var assistantId = parseResult.GetRequiredValue(CreateRunRequestOptionSetOptions.AssistantId);
                        var instructions = CliRuntime.WasSpecified(parseResult, CreateRunRequestOptionSetOptions.Instructions) ? parseResult.GetValue(CreateRunRequestOptionSetOptions.Instructions) : (__requestBase is { } __InstructionsBaseValue ? __InstructionsBaseValue.Instructions : default);
                        var additionalInstructions = CliRuntime.WasSpecified(parseResult, CreateRunRequestOptionSetOptions.AdditionalInstructions) ? parseResult.GetValue(CreateRunRequestOptionSetOptions.AdditionalInstructions) : (__requestBase is { } __AdditionalInstructionsBaseValue ? __AdditionalInstructionsBaseValue.AdditionalInstructions : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, CreateRunRequestOptionSetOptions.Temperature) ? parseResult.GetValue(CreateRunRequestOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, CreateRunRequestOptionSetOptions.TopP) ? parseResult.GetValue(CreateRunRequestOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var maxPromptTokens = CliRuntime.WasSpecified(parseResult, CreateRunRequestOptionSetOptions.MaxPromptTokens) ? parseResult.GetValue(CreateRunRequestOptionSetOptions.MaxPromptTokens) : (__requestBase is { } __MaxPromptTokensBaseValue ? __MaxPromptTokensBaseValue.MaxPromptTokens : default);
                        var maxCompletionTokens = CliRuntime.WasSpecified(parseResult, CreateRunRequestOptionSetOptions.MaxCompletionTokens) ? parseResult.GetValue(CreateRunRequestOptionSetOptions.MaxCompletionTokens) : (__requestBase is { } __MaxCompletionTokensBaseValue ? __MaxCompletionTokensBaseValue.MaxCompletionTokens : default);
                        var parallelToolCalls = CliRuntime.WasSpecified(parseResult, CreateRunRequestOptionSetOptions.ParallelToolCalls) ? parseResult.GetValue(CreateRunRequestOptionSetOptions.ParallelToolCalls) : (__requestBase is { } __ParallelToolCallsBaseValue ? __ParallelToolCallsBaseValue.ParallelToolCalls : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Assistants.CreateRunAsStreamAsync(
                                    threadId: threadId,
                                    include: include,
                                    model: model,
                                    reasoningEffort: reasoningEffort,
                                    additionalMessages: additionalMessages,
                                    tools: tools,
                                    metadata: metadata,
                                    truncationStrategy: truncationStrategy,
                                    toolChoice: toolChoice,
                                    responseFormat: responseFormat,
                                    assistantId: assistantId,
                                    instructions: instructions,
                                    additionalInstructions: additionalInstructions,
                                    temperature: temperature,
                                    topP: topP,
                                    maxPromptTokens: maxPromptTokens,
                                    maxCompletionTokens: maxCompletionTokens,
                                    parallelToolCalls: parallelToolCalls,
                                    cancellationToken: cancellationToken);

                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteResponseLineAsync(
                                        parseResult,
                                        item,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}