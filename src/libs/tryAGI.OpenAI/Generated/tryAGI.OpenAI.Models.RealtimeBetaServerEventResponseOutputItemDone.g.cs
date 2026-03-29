
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an Item is done streaming. Also emitted when a Response is <br/>
    /// interrupted, incomplete, or cancelled.
    /// </summary>
    public sealed partial class RealtimeBetaServerEventResponseOutputItemDone
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `response.output_item.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType Type { get; set; }

        /// <summary>
        /// The ID of the Response to which the item belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// The index of the output item in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// A single item within a Realtime conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeConversationItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventResponseOutputItemDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="responseId">
        /// The ID of the Response to which the item belongs.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the Response.
        /// </param>
        /// <param name="item">
        /// A single item within a Realtime conversation.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.output_item.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaServerEventResponseOutputItemDone(
            string eventId,
            string responseId,
            int outputIndex,
            global::tryAGI.OpenAI.RealtimeConversationItem item,
            global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.OutputIndex = outputIndex;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventResponseOutputItemDone" /> class.
        /// </summary>
        public RealtimeBetaServerEventResponseOutputItemDone()
        {
        }
    }
}