#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RealtimeCreateSessionCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret> ClientSecret { get; } = new(
        name: @"--client-secret")
    {
        Description = @"Ephemeral key returned by the API.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>?> Modalities { get; } = new(
        name: @"--modalities")
    {
        Description = @"The set of modalities the model can respond with. To disable audio,
set this to [""text""].
",
    };

    private static Option<string?> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. ""be extremely succinct"", ""act friendly"", ""here are examples of good responses"") and on audio behavior (e.g. ""talk quickly"", ""inject emotion into your voice"", ""laugh frequently""). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.
Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
",
    };

    private static Option<global::tryAGI.OpenAI.VoiceIdsOrCustomVoice?> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"The voice the model uses to respond. Supported built-in voices are
`alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, `shimmer`, `verse`,
`marin`, and `cedar`. You may also provide a custom voice object with an
`id`, for example `{ ""id"": ""voice_1234"" }`. Voice cannot be changed during
the session once the model has responded with audio at least once.
",
    };

    private static Option<string?> InputAudioFormat { get; } = new(
        name: @"--input-audio-format")
    {
        Description = @"The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
",
    };

    private static Option<string?> OutputAudioFormat { get; } = new(
        name: @"--output-audio-format")
    {
        Description = @"The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription?> InputAudioTranscription { get; } = new(
        name: @"--input-audio-transcription")
    {
        Description = @"Configuration for input audio transcription, defaults to off and can be
set to `null` to turn off once on. Input audio transcription is not native
to the model, since the model consumes audio directly. Transcription runs
asynchronously and should be treated as rough guidance
rather than the representation understood by the model.
",
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"The speed of the model's spoken response. 1.0 is the default speed. 0.25 is
the minimum speed. 1.5 is the maximum speed. This value can only be changed
in between model turns, not while a response is in progress.
",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>?> Tracing { get; } = new(
        name: @"--tracing")
    {
        Description = @"Configuration options for tracing. Set to null to disable tracing. Once
tracing is enabled for a session, the configuration cannot be modified.

`auto` will create a trace for the session with default values for the
workflow name, group id, and metadata.
",
    };

    private static Option<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection?> TurnDetection { get; } = new(
        name: @"--turn-detection")
    {
        Description = @"Configuration for turn detection. Can be set to `null` to turn off. Server
VAD means that the model will detect the start and end of speech based on
audio volume and respond at the end of user speech.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Tools (functions) available to the model.",
    };

    private static Option<string?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"How the model chooses tools. Options are `auto`, `none`, `required`, or
specify a function.
",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>?> MaxResponseOutputTokens { get; } = new(
        name: @"--max-response-output-tokens")
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
    private static readonly PromptVariant1OptionSet PromptOptions = PromptVariant1OptionSet.Create(@"prompt");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.RealtimeSessionCreateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.RealtimeSessionCreateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-session", @"Create an ephemeral API token for use in client-side applications with the
Realtime API. Can be configured with the same session parameters as the
`session.update` client event.

It responds with a session object, plus a `client_secret` key which contains
a usable ephemeral API token that can be used to authenticate browser clients
for the Realtime API.

Returns the created Realtime session object, plus an ephemeral key.
");
                        command.Options.Add(ClientSecret);
                        command.Options.Add(Modalities);
                        command.Options.Add(Instructions);
                        command.Options.Add(Voice);
                        command.Options.Add(InputAudioFormat);
                        command.Options.Add(OutputAudioFormat);
                        command.Options.Add(InputAudioTranscription);
                        command.Options.Add(Speed);
                        command.Options.Add(Tracing);
                        command.Options.Add(TurnDetection);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(Temperature);
                        command.Options.Add(MaxResponseOutputTokens);
                        command.Options.Add(Truncation);                        command.Options.Add(PromptOptions.Id);
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
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.RealtimeSessionCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var clientSecret = parseResult.GetRequiredValue(ClientSecret);
                        var modalities = CliRuntime.WasSpecified(parseResult, Modalities) ? parseResult.GetValue(Modalities) : __requestBase is not null ? __requestBase.Modalities : default;
                        var instructions = CliRuntime.WasSpecified(parseResult, Instructions) ? parseResult.GetValue(Instructions) : __requestBase is not null ? __requestBase.Instructions : default;
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : __requestBase is not null ? __requestBase.Voice : default;
                        var inputAudioFormat = CliRuntime.WasSpecified(parseResult, InputAudioFormat) ? parseResult.GetValue(InputAudioFormat) : __requestBase is not null ? __requestBase.InputAudioFormat : default;
                        var outputAudioFormat = CliRuntime.WasSpecified(parseResult, OutputAudioFormat) ? parseResult.GetValue(OutputAudioFormat) : __requestBase is not null ? __requestBase.OutputAudioFormat : default;
                        var inputAudioTranscription = CliRuntime.WasSpecified(parseResult, InputAudioTranscription) ? parseResult.GetValue(InputAudioTranscription) : __requestBase is not null ? __requestBase.InputAudioTranscription : default;
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : __requestBase is not null ? __requestBase.Speed : default;
                        var tracing = CliRuntime.WasSpecified(parseResult, Tracing) ? parseResult.GetValue(Tracing) : __requestBase is not null ? __requestBase.Tracing : default;
                        var turnDetection = CliRuntime.WasSpecified(parseResult, TurnDetection) ? parseResult.GetValue(TurnDetection) : __requestBase is not null ? __requestBase.TurnDetection : default;
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : __requestBase is not null ? __requestBase.Tools : default;
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : __requestBase is not null ? __requestBase.ToolChoice : default;
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : __requestBase is not null ? __requestBase.Temperature : default;
                        var maxResponseOutputTokens = CliRuntime.WasSpecified(parseResult, MaxResponseOutputTokens) ? parseResult.GetValue(MaxResponseOutputTokens) : __requestBase is not null ? __requestBase.MaxResponseOutputTokens : default;
                        var truncation = CliRuntime.WasSpecified(parseResult, Truncation) ? parseResult.GetValue(Truncation) : __requestBase is not null ? __requestBase.Truncation : default;

                        var __promptBase = __requestBase?.Prompt;                        var promptId = parseResult.GetValue(PromptOptions.Id);
                        var promptVersion = CliRuntime.WasSpecified(parseResult, PromptOptions.Version) ? parseResult.GetValue(PromptOptions.Version) : __promptBase is not null ? __promptBase.Version : default;
                        var __promptSpecified = CliRuntime.WasSpecified(parseResult, PromptOptions.Id) || CliRuntime.WasSpecified(parseResult, PromptOptions.Version);
                        var prompt =
                            __promptSpecified || __promptBase is not null
                                ? new global::tryAGI.OpenAI.PromptVariant1
                                {
	                                Id = promptId!,
                                Version = promptVersion,

                                }
                                : __promptBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Realtime.CreateSessionAsync(
                                    clientSecret: clientSecret,
                                    modalities: modalities,
                                    instructions: instructions,
                                    voice: voice,
                                    inputAudioFormat: inputAudioFormat,
                                    outputAudioFormat: outputAudioFormat,
                                    inputAudioTranscription: inputAudioTranscription,
                                    speed: speed,
                                    tracing: tracing,
                                    turnDetection: turnDetection,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    temperature: temperature,
                                    maxResponseOutputTokens: maxResponseOutputTokens,
                                    truncation: truncation,
                                    prompt: prompt,
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