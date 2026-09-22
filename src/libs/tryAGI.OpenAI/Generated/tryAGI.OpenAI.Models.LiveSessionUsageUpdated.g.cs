
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reports cumulative Live audio usage and, when available, the most recent context-window usage. Delegated Responses token usage is reported separately in response.event events.<br/>
    /// Example: {"type":"session.usage.updated","event_id":"evt_usage_001","usage":{"seconds":32.5},"context_window":{"usage_ratio":0.12}}
    /// </summary>
    public sealed partial class LiveSessionUsageUpdated
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
        /// The event type, always `session.usage.updated`.<br/>
        /// Default Value: session.usage.updated
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionUsageUpdatedType.SessionUsageUpdated</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionUsageUpdatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionUsageUpdatedType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionUsageUpdatedType.SessionUsageUpdated;

        /// <summary>
        /// The cumulative Live audio usage so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSessionUsage Usage { get; set; }

        /// <summary>
        /// The latest measured Live context-window usage. Omitted when the context limit is unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        public global::tryAGI.OpenAI.LiveContextWindowUsage? ContextWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUsageUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="usage">
        /// The cumulative Live audio usage so far.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="contextWindow">
        /// The latest measured Live context-window usage. Omitted when the context limit is unknown.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.usage.updated`.<br/>
        /// Default Value: session.usage.updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionUsageUpdated(
            string eventId,
            global::tryAGI.OpenAI.LiveSessionUsage usage,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveContextWindowUsage? contextWindow,
            global::tryAGI.OpenAI.LiveSessionUsageUpdatedType type = global::tryAGI.OpenAI.LiveSessionUsageUpdatedType.SessionUsageUpdated)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.ContextWindow = contextWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUsageUpdated" /> class.
        /// </summary>
        public LiveSessionUsageUpdated()
        {
        }

    }
}