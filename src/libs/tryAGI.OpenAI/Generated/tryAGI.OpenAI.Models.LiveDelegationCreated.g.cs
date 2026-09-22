
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the Live model delegates work to your application or a Responses backend. Contains delegation metadata and the position on the session timeline where the work was delegated.<br/>
    /// Example: {"type":"session.delegation.created","event_id":"evt_delegation_001","offset_ms":3600,"delegation":{"id":"del_abc123","type":"delegation","target":"client"}}
    /// </summary>
    public sealed partial class LiveDelegationCreated
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
        /// The event type, always `session.delegation.created`.<br/>
        /// Default Value: session.delegation.created
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDelegationCreatedType.SessionDelegationCreated</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDelegationCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDelegationCreatedType Type { get; set; } = global::tryAGI.OpenAI.LiveDelegationCreatedType.SessionDelegationCreated;

        /// <summary>
        /// The position on the Live session timeline where the delegation was created, in milliseconds from the beginning of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OffsetMs { get; set; }

        /// <summary>
        /// The delegated work identifier and destination. This object contains metadata, not the task text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDelegationItem Delegation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="offsetMs">
        /// The position on the Live session timeline where the delegation was created, in milliseconds from the beginning of the session.
        /// </param>
        /// <param name="delegation">
        /// The delegated work identifier and destination. This object contains metadata, not the task text.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.delegation.created`.<br/>
        /// Default Value: session.delegation.created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDelegationCreated(
            string eventId,
            int offsetMs,
            global::tryAGI.OpenAI.LiveDelegationItem delegation,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveDelegationCreatedType type = global::tryAGI.OpenAI.LiveDelegationCreatedType.SessionDelegationCreated)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.OffsetMs = offsetMs;
            this.Delegation = delegation ?? throw new global::System.ArgumentNullException(nameof(delegation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationCreated" /> class.
        /// </summary>
        public LiveDelegationCreated()
        {
        }

    }
}