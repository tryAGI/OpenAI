
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An asynchronous outbound SIP setup failure. Delivered only to sideband observers.<br/>
    /// Example: {"type":"transport.failed","event_id":"event_call_4","session_id":"live_u0_123","error":{"type":"call_error","code":"provider_invite_failed","message":"provider rejected the call","param":""}}
    /// </summary>
    public sealed partial class LiveTransportFailed
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The canonical Live session ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Default Value: transport.failed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportFailedType.TransportFailed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportFailedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportFailedType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportFailedType.TransportFailed;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveTransportCallError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportFailed" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="sessionId">
        /// The canonical Live session ID.
        /// </param>
        /// <param name="error"></param>
        /// <param name="type">
        /// Default Value: transport.failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportFailed(
            string eventId,
            string sessionId,
            global::tryAGI.OpenAI.LiveTransportCallError error,
            global::tryAGI.OpenAI.LiveTransportFailedType type = global::tryAGI.OpenAI.LiveTransportFailedType.TransportFailed)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportFailed" /> class.
        /// </summary>
        public LiveTransportFailed()
        {
        }

    }
}