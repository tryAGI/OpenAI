
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a web search call is completed.
    /// </summary>
    public sealed partial class ResponseWebSearchCallCompletedEvent
    {
        /// <summary>
        /// Unique ID for the output item associated with the web search call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the web search call is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The sequence number of the web search call being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always `response.web_search_call.completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchCallCompletedEvent" /> class.
        /// </summary>
        /// <param name="itemId">
        /// Unique ID for the output item associated with the web search call.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the web search call is associated with.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of the web search call being processed.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.web_search_call.completed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseWebSearchCallCompletedEvent(
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchCallCompletedEvent" /> class.
        /// </summary>
        public ResponseWebSearchCallCompletedEvent()
        {
        }
    }
}