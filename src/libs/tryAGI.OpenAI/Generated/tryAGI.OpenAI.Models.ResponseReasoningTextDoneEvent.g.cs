
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a reasoning text is completed.
    /// </summary>
    public sealed partial class ResponseReasoningTextDoneEvent
    {
        /// <summary>
        /// The index of the reasoning content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The ID of the item this reasoning text is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item this reasoning text is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The full text of the completed reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the event. Always `response.reasoning_text.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningTextDoneEvent" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the reasoning content part.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item this reasoning text is associated with.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item this reasoning text is associated with.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="text">
        /// The full text of the completed reasoning content.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_text.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningTextDoneEvent(
            int contentIndex,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            string text,
            global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType type)
        {
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningTextDoneEvent" /> class.
        /// </summary>
        public ResponseReasoningTextDoneEvent()
        {
        }
    }
}