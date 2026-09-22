
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reports an error in the Live session, such as an invalid client command. Use error.client_event_id, when present, to identify the command that caused the error.<br/>
    /// Example: {"type":"error","event_id":"evt_error_001","error":{"type":"invalid_request_error","code":"unknown_parameter","message":"Unknown parameter: \u0027session.voice\u0027.","param":"session.voice","client_event_id":"evt_invalid_001"}}
    /// </summary>
    public sealed partial class LiveErrorEvent
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
        /// The event type, always `error`.<br/>
        /// Default Value: error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveErrorEventType.Error</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveErrorEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveErrorEventType Type { get; set; } = global::tryAGI.OpenAI.LiveErrorEventType.Error;

        /// <summary>
        /// Details of the Live error and the client command that caused it, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveLiveError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveErrorEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="error">
        /// Details of the Live error and the client command that caused it, when known.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `error`.<br/>
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveErrorEvent(
            string eventId,
            global::tryAGI.OpenAI.LiveLiveError error,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveErrorEventType type = global::tryAGI.OpenAI.LiveErrorEventType.Error)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveErrorEvent" /> class.
        /// </summary>
        public LiveErrorEvent()
        {
        }

    }
}