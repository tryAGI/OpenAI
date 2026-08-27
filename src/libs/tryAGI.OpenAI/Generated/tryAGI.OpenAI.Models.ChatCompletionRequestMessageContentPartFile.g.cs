
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Learn about [file inputs](/docs/guides/text) for text generation.
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartFile
    {
        /// <summary>
        /// The type of the content part. Always `file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile File { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFile" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type">
        /// The type of the content part. Always `file`.
        /// </param>
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartFile(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile file,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType type,
            global::tryAGI.OpenAI.PromptCacheBreakpointParam? promptCacheBreakpoint)
        {
            this.Type = type;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFile" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartFile()
        {
        }

    }
}