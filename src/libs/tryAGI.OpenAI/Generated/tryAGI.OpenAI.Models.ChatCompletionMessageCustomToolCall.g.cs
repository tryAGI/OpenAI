
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A call to a custom tool created by the model.
    /// </summary>
    public sealed partial class ChatCompletionMessageCustomToolCall
    {
        /// <summary>
        /// The custom tool that the model called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom Custom { get; set; }

        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of the tool. Always `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageCustomToolCall" /> class.
        /// </summary>
        /// <param name="custom">
        /// The custom tool that the model called.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="type">
        /// The type of the tool. Always `custom`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageCustomToolCall(
            global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom custom,
            string id,
            global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType type)
        {
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageCustomToolCall" /> class.
        /// </summary>
        public ChatCompletionMessageCustomToolCall()
        {
        }
    }
}