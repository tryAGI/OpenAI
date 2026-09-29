#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AssistantsCreateThreadAndRunAsStreamCommandApiCommand
{
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
        Description = @"The ID of the [Model](https://developers.openai.com/api/reference/resources/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.",
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
    private static readonly CreateThreadAndRunRequestOptionSet CreateThreadAndRunRequestOptionSetOptions = CreateThreadAndRunRequestOptionSet.Create();
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
        var command = new Command(commandName ?? @"create-thread-and-run-as-stream", @"Create thread and run
Create a thread and run it in one request.");
                        command.Options.Add(Thread);
                        command.Options.Add(Model);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolResources);
                        command.Options.Add(Metadata);
                        command.Options.Add(TruncationStrategy);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(ResponseFormat);                        command.Options.Add(CreateThreadAndRunRequestOptionSetOptions.AssistantId);
                        command.Options.Add(CreateThreadAndRunRequestOptionSetOptions.Instructions);
                        command.Options.Add(CreateThreadAndRunRequestOptionSetOptions.Temperature);
                        command.Options.Add(CreateThreadAndRunRequestOptionSetOptions.TopP);
                        command.Options.Add(CreateThreadAndRunRequestOptionSetOptions.MaxPromptTokens);
                        command.Options.Add(CreateThreadAndRunRequestOptionSetOptions.MaxCompletionTokens);
                        command.Options.Add(CreateThreadAndRunRequestOptionSetOptions.ParallelToolCalls);
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
                        var thread = CliRuntime.WasSpecified(parseResult, Thread) ? parseResult.GetValue(Thread) : (__requestBase is { } __ThreadBaseValue ? __ThreadBaseValue.Thread : default);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var toolResources = CliRuntime.WasSpecified(parseResult, ToolResources) ? parseResult.GetValue(ToolResources) : (__requestBase is { } __ToolResourcesBaseValue ? __ToolResourcesBaseValue.ToolResources : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var truncationStrategy = CliRuntime.WasSpecified(parseResult, TruncationStrategy) ? parseResult.GetValue(TruncationStrategy) : (__requestBase is { } __TruncationStrategyBaseValue ? __TruncationStrategyBaseValue.TruncationStrategy : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);                        var assistantId = parseResult.GetRequiredValue(CreateThreadAndRunRequestOptionSetOptions.AssistantId);
                        var instructions = CliRuntime.WasSpecified(parseResult, CreateThreadAndRunRequestOptionSetOptions.Instructions) ? parseResult.GetValue(CreateThreadAndRunRequestOptionSetOptions.Instructions) : (__requestBase is { } __InstructionsBaseValue ? __InstructionsBaseValue.Instructions : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, CreateThreadAndRunRequestOptionSetOptions.Temperature) ? parseResult.GetValue(CreateThreadAndRunRequestOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, CreateThreadAndRunRequestOptionSetOptions.TopP) ? parseResult.GetValue(CreateThreadAndRunRequestOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var maxPromptTokens = CliRuntime.WasSpecified(parseResult, CreateThreadAndRunRequestOptionSetOptions.MaxPromptTokens) ? parseResult.GetValue(CreateThreadAndRunRequestOptionSetOptions.MaxPromptTokens) : (__requestBase is { } __MaxPromptTokensBaseValue ? __MaxPromptTokensBaseValue.MaxPromptTokens : default);
                        var maxCompletionTokens = CliRuntime.WasSpecified(parseResult, CreateThreadAndRunRequestOptionSetOptions.MaxCompletionTokens) ? parseResult.GetValue(CreateThreadAndRunRequestOptionSetOptions.MaxCompletionTokens) : (__requestBase is { } __MaxCompletionTokensBaseValue ? __MaxCompletionTokensBaseValue.MaxCompletionTokens : default);
                        var parallelToolCalls = CliRuntime.WasSpecified(parseResult, CreateThreadAndRunRequestOptionSetOptions.ParallelToolCalls) ? parseResult.GetValue(CreateThreadAndRunRequestOptionSetOptions.ParallelToolCalls) : (__requestBase is { } __ParallelToolCallsBaseValue ? __ParallelToolCallsBaseValue.ParallelToolCalls : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Assistants.CreateThreadAndRunAsStreamAsync(
                                    thread: thread,
                                    model: model,
                                    tools: tools,
                                    toolResources: toolResources,
                                    metadata: metadata,
                                    truncationStrategy: truncationStrategy,
                                    toolChoice: toolChoice,
                                    responseFormat: responseFormat,
                                    assistantId: assistantId,
                                    instructions: instructions,
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