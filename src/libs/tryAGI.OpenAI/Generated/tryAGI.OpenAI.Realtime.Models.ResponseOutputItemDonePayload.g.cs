
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Returned when an Item is done streaming.
    /// </summary>
    public sealed partial class ResponseOutputItemDonePayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseOutputItemDonePayloadTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayloadType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// A realtime conversation item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::tryAGI.OpenAI.Realtime.ConversationItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemDonePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="item">
        /// A realtime conversation item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputItemDonePayload(
            string eventId,
            global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayloadType type,
            string? responseId,
            int? outputIndex,
            global::tryAGI.OpenAI.Realtime.ConversationItem? item)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ResponseId = responseId;
            this.OutputIndex = outputIndex;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemDonePayload" /> class.
        /// </summary>
        public ResponseOutputItemDonePayload()
        {
        }
    }
}