
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when function-call arguments are finalized.
    /// </summary>
    public sealed partial class ResponseFunctionCallArgumentsDoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType Type { get; set; }

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The function-call arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDoneEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item.
        /// </param>
        /// <param name="arguments">
        /// The function-call arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFunctionCallArgumentsDoneEvent(
            string itemId,
            int outputIndex,
            string arguments,
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDoneEvent" /> class.
        /// </summary>
        public ResponseFunctionCallArgumentsDoneEvent()
        {
        }
    }
}