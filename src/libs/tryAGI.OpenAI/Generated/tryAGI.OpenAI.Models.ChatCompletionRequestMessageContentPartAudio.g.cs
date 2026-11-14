
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Learn about [audio inputs](https://developers.openai.com/api/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartAudio
    {
        /// <summary>
        /// The type of the content part. Always `input_audio`.
        /// </summary>
        /// <default>"input_audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_audio";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Marks the exact end of a reusable prompt prefix. When `ttl` is omitted, the breakpoint inherits the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
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
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. When `ttl` is omitted, the breakpoint inherits the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
        /// <param name="type">
        /// The type of the content part. Always `input_audio`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartAudio(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio inputAudio,
            global::tryAGI.OpenAI.PromptCacheBreakpointParam? promptCacheBreakpoint,
            string type = "input_audio")
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

        /// <summary>
        /// Creates a new <see cref="ChatCompletionRequestMessageContentPartAudio"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartAudio FromInputAudio(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio inputAudio)
        {
            return new ChatCompletionRequestMessageContentPartAudio
            {
                InputAudio = inputAudio,
            };
        }

    }
}