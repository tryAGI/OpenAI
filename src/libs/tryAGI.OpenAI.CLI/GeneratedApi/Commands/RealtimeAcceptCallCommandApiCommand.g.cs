#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RealtimeAcceptCallCommandApiCommand
{
    private static Argument<string> CallId { get; } = new(
        name: @"call-id")
    {
        Description = @"The identifier for the call provided in the
[`realtime.call.incoming`](/docs/api-reference/webhook-events/realtime/call/incoming)
webhook.",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The Realtime model used for this session.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio?> Audio { get; } = new(
        name: @"--audio")
    {
        Description = @"Configuration for input and output audio.
",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>?> Tracing { get; } = new(
        name: @"--tracing")
    {
        Description = @"Realtime API can write session traces to the [Traces Dashboard](https://platform.openai.com/logs?api=traces). Set to null to disable tracing. Once
tracing is enabled for a session, the configuration cannot be modified.

`auto` will create a trace for the session with default values for the
workflow name, group id, and metadata.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Tools available to the model.",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"How the model chooses tools. Provide one of the string modes or force a specific
function/MCP tool.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeReasoning?> Reasoning { get; } = new(
        name: @"--reasoning")
    {
        Description = @"Configuration for reasoning-capable Realtime models such as `gpt-realtime-2`.
",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>?> MaxOutputTokens { get; } = new(
        name: @"--max-output-tokens")
    {
        Description = @"Maximum number of output tokens for a single assistant response,
inclusive of tool calls. Provide an integer between 1 and 4096 to
limit output tokens, or `inf` for the maximum available tokens for a
given model. Defaults to `inf`.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeTruncation?> Truncation { get; } = new(
        name: @"--truncation")
    {
        Description = @"When the number of tokens in a conversation exceeds the model's input token limit, the conversation be truncated, meaning messages (starting from the oldest) will not be included in the model's context. A 32k context model with 4,096 max output tokens can only include 28,224 tokens in the context before truncation occurs.

Clients can configure truncation behavior to truncate with a lower max token limit, which is an effective way to control token usage and cost.

Truncation will reduce the number of cached tokens on the next turn (busting the cache), since messages are dropped from the beginning of the context. However, clients can also configure truncation to retain messages up to a fraction of the maximum context size, which will reduce the need for future truncations and thus improve the cache rate.

Truncation can be disabled entirely, which means the server will never truncate but would instead return an error if the conversation exceeds the model's input token limit.
",
    };
    private static readonly RealtimeSessionCreateRequestGAOptionSet RealtimeSessionCreateRequestGAOptionSetOptions = RealtimeSessionCreateRequestGAOptionSet.Create();

    private static readonly PromptVariant1OptionSet PromptOptions = PromptVariant1OptionSet.Create(@"prompt");
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

    public static Command Create()
    {
        var command = new Command(@"accept-call", @"Accept an incoming SIP call and configure the realtime session that will
handle it.");
                        command.Arguments.Add(CallId);
                        command.Options.Add(Model);
                        command.Options.Add(Audio);
                        command.Options.Add(Tracing);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(Reasoning);
                        command.Options.Add(MaxOutputTokens);
                        command.Options.Add(Truncation);                        command.Options.Add(RealtimeSessionCreateRequestGAOptionSetOptions.Type);
                        command.Options.Add(RealtimeSessionCreateRequestGAOptionSetOptions.OutputModalities);
                        command.Options.Add(RealtimeSessionCreateRequestGAOptionSetOptions.Instructions);
                        command.Options.Add(RealtimeSessionCreateRequestGAOptionSetOptions.Include);
                        command.Options.Add(RealtimeSessionCreateRequestGAOptionSetOptions.ParallelToolCalls);                        command.Options.Add(PromptOptions.Id);
                        command.Options.Add(PromptOptions.Version);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var callId = parseResult.GetRequiredValue(CallId);
                        var model = parseResult.GetValue(Model) ?? __requestBase?.Model;
                        var audio = parseResult.GetValue(Audio) ?? __requestBase?.Audio;
                        var tracing = parseResult.GetValue(Tracing) ?? __requestBase?.Tracing;
                        var tools = parseResult.GetValue(Tools) ?? __requestBase?.Tools;
                        var toolChoice = parseResult.GetValue(ToolChoice) ?? __requestBase?.ToolChoice;
                        var reasoning = parseResult.GetValue(Reasoning) ?? __requestBase?.Reasoning;
                        var maxOutputTokens = parseResult.GetValue(MaxOutputTokens) ?? __requestBase?.MaxOutputTokens;
                        var truncation = parseResult.GetValue(Truncation) ?? __requestBase?.Truncation;                        var type = parseResult.GetValue(RealtimeSessionCreateRequestGAOptionSetOptions.Type) ?? __requestBase?.Type;
                        var outputModalities = parseResult.GetValue(RealtimeSessionCreateRequestGAOptionSetOptions.OutputModalities) ?? __requestBase?.OutputModalities;
                        var instructions = parseResult.GetValue(RealtimeSessionCreateRequestGAOptionSetOptions.Instructions) ?? __requestBase?.Instructions;
                        var include = parseResult.GetValue(RealtimeSessionCreateRequestGAOptionSetOptions.Include) ?? __requestBase?.Include;
                        var parallelToolCalls = parseResult.GetValue(RealtimeSessionCreateRequestGAOptionSetOptions.ParallelToolCalls) ?? __requestBase?.ParallelToolCalls;
                        var promptId = parseResult.GetValue(PromptOptions.Id);
                        var promptVersion = parseResult.GetValue(PromptOptions.Version) ?? __requestBase?.Prompt?.Version;
                        var __promptSpecified = CliRuntime.WasSpecified(parseResult, PromptOptions.Id) || CliRuntime.WasSpecified(parseResult, PromptOptions.Version);
                        var prompt =
                            __promptSpecified || __requestBase?.Prompt is not null
                                ? new global::tryAGI.OpenAI.PromptVariant1
                                {
                                Id = promptId,
                                Version = promptVersion,
                                }
                                : __requestBase?.Prompt;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Realtime.AcceptCallAsync(
                                    callId: callId,
                                    model: model,
                                    audio: audio,
                                    tracing: tracing,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    reasoning: reasoning,
                                    maxOutputTokens: maxOutputTokens,
                                    truncation: truncation,
                                    type: type,
                                    outputModalities: outputModalities,
                                    instructions: instructions,
                                    include: include,
                                    parallelToolCalls: parallelToolCalls,
                                    prompt: prompt,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}