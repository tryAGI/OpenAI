#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record RealtimeSessionCreateRequestGAOptionSet(
    Option<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType> Type,
                     Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>?> OutputModalities,
                     Option<string?> Instructions,
                     Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>?> Include,
                     Option<bool?> ParallelToolCalls)
{
    public static RealtimeSessionCreateRequestGAOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new RealtimeSessionCreateRequestGAOptionSet(
                        Type: new Option<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType>($"--{normalizedPrefix}type")
                {
                    Description = @"The type of session to create. Always `realtime` for the Realtime API.
",
                },
                OutputModalities: new Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>?>($"--{normalizedPrefix}output-modalities")
                {
                    Description = @"The set of modalities the model can respond with. It defaults to `[""audio""]`, indicating
that the model will respond with audio plus a transcript. `[""text""]` can be used to make
the model respond with text only. It is not possible to request both `text` and `audio` at the same time.
",
                },
                Instructions: new Option<string?>($"--{normalizedPrefix}instructions")
                {
                    Description = @"The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. ""be extremely succinct"", ""act friendly"", ""here are examples of good responses"") and on audio behavior (e.g. ""talk quickly"", ""inject emotion into your voice"", ""laugh frequently""). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.

Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
",
                },
                Include: new Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>?>($"--{normalizedPrefix}include")
                {
                    Description = @"Additional fields to include in server outputs.

`item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
",
                },
                ParallelToolCalls: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}parallel-tool-calls", description: @"Whether the model may call multiple tools in parallel. Only supported by
reasoning Realtime models such as `gpt-realtime-2`.
")
        );
    }
}