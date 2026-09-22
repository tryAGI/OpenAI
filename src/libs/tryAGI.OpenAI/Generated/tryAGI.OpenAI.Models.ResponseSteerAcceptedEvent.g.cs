
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when steering input has been validated and queued. Acceptance means<br/>
    /// the server owns the input, not that it has been applied. The successor's<br/>
    /// `response.created` event is the commit point. If accepted input cannot be<br/>
    /// committed, `response.steer.failed` returns it with the same steering ID.<br/>
    /// When the response stops for client-owned tool output or approval, the input<br/>
    /// remains queued and `response.steer.pending` is emitted after<br/>
    /// `response.completed`. Fill the pending event's `required_input` stubs with<br/>
    /// saved results and send one matching explicit `response.create` per parent.<br/>
    /// Do not resend accepted input while it is still queued.
    /// </summary>
    public sealed partial class ResponseSteerAcceptedEvent
    {
        /// <summary>
        /// The event discriminator. Always `response.steer.accepted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerAcceptedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventType Type { get; set; }

        /// <summary>
        /// The sequence number for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The accepted steering submission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer Steer { get; set; }

        /// <summary>
        /// The WebSocket lane that emitted this event. This field is present when<br/>
        /// the target response's `response.create` event supplied a `stream_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerAcceptedEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
        /// <param name="steer">
        /// The accepted steering submission.
        /// </param>
        /// <param name="type">
        /// The event discriminator. Always `response.steer.accepted`.
        /// </param>
        /// <param name="streamId">
        /// The WebSocket lane that emitted this event. This field is present when<br/>
        /// the target response's `response.create` event supplied a `stream_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerAcceptedEvent(
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer steer,
            global::tryAGI.OpenAI.ResponseSteerAcceptedEventType type,
            string? streamId)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Steer = steer ?? throw new global::System.ArgumentNullException(nameof(steer));
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerAcceptedEvent" /> class.
        /// </summary>
        public ResponseSteerAcceptedEvent()
        {
        }

    }
}