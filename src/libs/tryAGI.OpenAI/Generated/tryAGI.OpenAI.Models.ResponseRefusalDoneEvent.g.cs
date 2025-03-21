
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when refusal text is finalized.
    /// </summary>
    public sealed partial class ResponseRefusalDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.refusal.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseRefusalDoneEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the refusal text is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the refusal text is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part that the refusal text is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The refusal text that is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRefusalDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.refusal.done`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the refusal text is finalized.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the refusal text is finalized.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that the refusal text is finalized.
        /// </param>
        /// <param name="refusal">
        /// The refusal text that is finalized.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseRefusalDoneEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            string refusal,
            global::tryAGI.OpenAI.ResponseRefusalDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRefusalDoneEvent" /> class.
        /// </summary>
        public ResponseRefusalDoneEvent()
        {
        }
    }
}