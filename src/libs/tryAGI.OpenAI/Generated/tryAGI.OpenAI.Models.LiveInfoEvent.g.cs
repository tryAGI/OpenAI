
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An informational notice about the Live session, such as the event permissions applied to a frontend data channel.<br/>
    /// Example: {"type":"info","event_id":"evt_info_001","code":"data_channel_permissions","message":"The frontend data channel is configured with restricted event permissions."}
    /// </summary>
    public sealed partial class LiveInfoEvent
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
        /// The event type, always `info`.<br/>
        /// Default Value: info
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInfoEventType.Info</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInfoEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInfoEventType Type { get; set; } = global::tryAGI.OpenAI.LiveInfoEventType.Info;

        /// <summary>
        /// A machine-readable code for the notice, such as `data_channel_permissions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable explanation of the Live session notice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInfoEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="code">
        /// A machine-readable code for the notice, such as `data_channel_permissions`.
        /// </param>
        /// <param name="message">
        /// A human-readable explanation of the Live session notice.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `info`.<br/>
        /// Default Value: info
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInfoEvent(
            string eventId,
            string code,
            string message,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveInfoEventType type = global::tryAGI.OpenAI.LiveInfoEventType.Info)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInfoEvent" /> class.
        /// </summary>
        public LiveInfoEvent()
        {
        }

    }
}