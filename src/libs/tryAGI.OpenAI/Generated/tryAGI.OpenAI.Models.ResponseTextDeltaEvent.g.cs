
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when there is an additional text delta.
    /// </summary>
    public sealed partial class ResponseTextDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.output_text.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseTextDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseTextDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the text delta was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the text delta was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the content part that the text delta was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The text delta that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// The sequence number for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// The log probabilities of the tokens in the delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb> Logprobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.output_text.delta`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the text delta was added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the text delta was added to.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that the text delta was added to.
        /// </param>
        /// <param name="delta">
        /// The text delta that was added.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the tokens in the delta.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTextDeltaEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            string delta,
            int sequenceNumber,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb> logprobs,
            global::tryAGI.OpenAI.ResponseTextDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
            this.Logprobs = logprobs ?? throw new global::System.ArgumentNullException(nameof(logprobs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDeltaEvent" /> class.
        /// </summary>
        public ResponseTextDeltaEvent()
        {
        }
    }
}