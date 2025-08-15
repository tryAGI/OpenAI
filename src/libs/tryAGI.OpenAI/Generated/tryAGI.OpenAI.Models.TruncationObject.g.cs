
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls for how a thread will be truncated prior to the run. Use this to control the initial context window of the run.
    /// </summary>
    public sealed partial class TruncationObject
    {
        /// <summary>
        /// The number of most recent messages from the thread when constructing the context for the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_messages")]
        public int? LastMessages { get; set; }

        /// <summary>
        /// The truncation strategy to use for the thread. The default is `auto`. If set to `last_messages`, the thread will be truncated to the n most recent messages in the thread. When set to `auto`, messages in the middle of the thread will be dropped to fit the context length of the model, `max_prompt_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.TruncationObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TruncationObject" /> class.
        /// </summary>
        /// <param name="lastMessages">
        /// The number of most recent messages from the thread when constructing the context for the run.
        /// </param>
        /// <param name="type">
        /// The truncation strategy to use for the thread. The default is `auto`. If set to `last_messages`, the thread will be truncated to the n most recent messages in the thread. When set to `auto`, messages in the middle of the thread will be dropped to fit the context length of the model, `max_prompt_tokens`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TruncationObject(
            global::tryAGI.OpenAI.TruncationObjectType type,
            int? lastMessages)
        {
            this.Type = type;
            this.LastMessages = lastMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TruncationObject" /> class.
        /// </summary>
        public TruncationObject()
        {
        }
    }
}