
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned after the Live session finishes finalizing, with the close reason, final session snapshot, and cumulative audio usage. A connection closing without this event does not confirm successful finalization.<br/>
    /// Example: {"type":"session.closed","event_id":"evt_closed_001","client_event_id":"evt_close_001","reason":"close_requested","session":{"id":"live_abc123","model":"gpt-live-1","status":"active","expires_at":1788555600,"instructions":"Help the caller plan a restaurant reservation. Confirm details before booking.","input":[],"audio":{"format":{"type":"audio/pcm","rate":24000},"output":{"voice":"marin"}},"delegation":{"type":"client"}},"usage":{"seconds":45.8}}
    /// </summary>
    public sealed partial class LiveSessionClosed
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
        /// The event type, always `session.closed`.<br/>
        /// Default Value: session.closed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionClosedType.SessionClosed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionClosedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionClosedType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionClosedType.SessionClosed;

        /// <summary>
        /// Why the Live session ended: `close_requested` for an application close or hangup request, `expired` for the session duration limit, `content` for a safety filter, `remote_hangup` for a graceful remote disconnect, or `connection_lost` for an unexpected primary or upstream disconnection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5?> Reason { get; set; }

        /// <summary>
        /// The resolved Live session configuration and server-assigned session metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSessionResourceParam Session { get; set; }

        /// <summary>
        /// The final cumulative Live audio usage after session finalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSessionUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionClosed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="reason">
        /// Why the Live session ended: `close_requested` for an application close or hangup request, `expired` for the session duration limit, `content` for a safety filter, `remote_hangup` for a graceful remote disconnect, or `connection_lost` for an unexpected primary or upstream disconnection.
        /// </param>
        /// <param name="session">
        /// The resolved Live session configuration and server-assigned session metadata.
        /// </param>
        /// <param name="usage">
        /// The final cumulative Live audio usage after session finalization.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.closed`.<br/>
        /// Default Value: session.closed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionClosed(
            string eventId,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5?> reason,
            global::tryAGI.OpenAI.LiveSessionResourceParam session,
            global::tryAGI.OpenAI.LiveSessionUsage usage,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveSessionClosedType type = global::tryAGI.OpenAI.LiveSessionClosedType.SessionClosed)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.Reason = reason;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionClosed" /> class.
        /// </summary>
        public LiveSessionClosed()
        {
        }

    }
}