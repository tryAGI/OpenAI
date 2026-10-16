
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An input item was removed from future decisions.<br/>
    /// Example: {"type":"decision.item.deleted","event_id":"evt_item_deleted_1","client_event_id":"remove_browser_1","item_id":"msg_browser_1"}
    /// </summary>
    public sealed partial class LiveDecisionItemDeleted
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
        /// Default Value: decision.item.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionItemDeletedType.DecisionItemDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionItemDeletedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionItemDeletedType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionItemDeletedType.DecisionItemDeleted;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemDeleted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="itemId"></param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// Default Value: decision.item.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionItemDeleted(
            string eventId,
            string itemId,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveDecisionItemDeletedType type = global::tryAGI.OpenAI.LiveDecisionItemDeletedType.DecisionItemDeleted)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemDeleted" /> class.
        /// </summary>
        public LiveDecisionItemDeleted()
        {
        }

    }
}