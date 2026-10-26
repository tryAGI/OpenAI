
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An input item was appended for future decisions.<br/>
    /// Example: {"type":"decision.item.created","event_id":"evt_item_1","client_event_id":"browser_1","item":{"id":"msg_browser_1","type":"message","role":"user","content":[{"type":"input_text","text":"Wikipedia is open."}]}}
    /// </summary>
    public sealed partial class LiveDecisionItemCreated
    {
        /// <summary>
        /// The unique ID of the Live server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event_id of the client command associated with this server event, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// Default Value: decision.item.created
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionItemCreatedType.DecisionItemCreated</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionItemCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionItemCreatedType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionItemCreatedType.DecisionItemCreated;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionStoredInputItemParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="item"></param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// Default Value: decision.item.created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionItemCreated(
            string eventId,
            global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam item,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveDecisionItemCreatedType type = global::tryAGI.OpenAI.LiveDecisionItemCreatedType.DecisionItemCreated)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemCreated" /> class.
        /// </summary>
        public LiveDecisionItemCreated()
        {
        }

    }
}