
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Learn about [audio inputs](/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartAudio
    {
        /// <summary>
        /// The type of the content part. Always `input_audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::tryAGI.OpenAI.PromptCacheBreakpointParam? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudio" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type">
        /// The type of the content part. Always `input_audio`.
        /// </param>
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartAudio(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio inputAudio,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType type,
            global::tryAGI.OpenAI.PromptCacheBreakpointParam? promptCacheBreakpoint)
        {
            this.Type = type;
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudio" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartAudio()
        {
        }

    }
}