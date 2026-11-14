
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send one DTMF keypress to the SIP trunk through a Live sideband connection. This command is supported only for SIP calls. A successful send emits `transport.dtmf.sent` on sideband. If you provide `event_id`, the success notification includes it as `client_event_id`; a failure includes it as `error.client_event_id`. Send separate events for multiple keypresses.<br/>
    /// Example: {"type":"transport.dtmf.send","event_id":"evt_dtmf_001","event":"#"}
    /// </summary>
    public sealed partial class LiveTransportDTMFSendParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Default Value: transport.dtmf.send
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportDTMFSendParamType.TransportDtmfSend</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportDTMFSendParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParamType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportDTMFSendParamType.TransportDtmfSend;

        /// <summary>
        /// The DTMF key to send: one of `0`–`9`, `A`–`D`, `*`, or `#`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportDTMFSendParam" /> class.
        /// </summary>
        /// <param name="event">
        /// The DTMF key to send: one of `0`–`9`, `A`–`D`, `*`, or `#`.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// Default Value: transport.dtmf.send
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportDTMFSendParam(
            string @event,
            string? eventId,
            global::tryAGI.OpenAI.LiveTransportDTMFSendParamType type = global::tryAGI.OpenAI.LiveTransportDTMFSendParamType.TransportDtmfSend)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportDTMFSendParam" /> class.
        /// </summary>
        public LiveTransportDTMFSendParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveTransportDTMFSendParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveTransportDTMFSendParam FromEvent(string @event)
        {
            return new LiveTransportDTMFSendParam
            {
                Event = @event,
            };
        }

    }
}