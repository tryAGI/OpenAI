
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when steering input is rejected or cannot be committed to a<br/>
    /// successor response. Returns the original, uncommitted input so the client<br/>
    /// can carry it into `response.create` when appropriate. Invalid input must<br/>
    /// be corrected before retrying.<br/>
    /// Failures after acceptance include the same steering ID. Failures before an<br/>
    /// ID is allocated omit `steer.id`. A lost connection or missing acknowledgement<br/>
    /// leaves the outcome unknown; it is not proof that the input was rejected.
    /// </summary>
    public sealed partial class BetaResponseSteerFailedEvent
    {
        /// <summary>
        /// The event discriminator. Always `response.steer.failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerFailedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventType Type { get; set; }

        /// <summary>
        /// The sequence number for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The steering submission that could not be committed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer Steer { get; set; }

        /// <summary>
        /// Information about why the input could not be committed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResponseSteerFailedEventError Error { get; set; }

        /// <summary>
        /// The WebSocket lane that emitted this event, when the target response is<br/>
        /// available and its `response.create` event supplied a `stream_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerFailedEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
        /// <param name="steer">
        /// The steering submission that could not be committed.
        /// </param>
        /// <param name="error">
        /// Information about why the input could not be committed.
        /// </param>
        /// <param name="type">
        /// The event discriminator. Always `response.steer.failed`.
        /// </param>
        /// <param name="streamId">
        /// The WebSocket lane that emitted this event, when the target response is<br/>
        /// available and its `response.create` event supplied a `stream_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseSteerFailedEvent(
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer steer,
            global::tryAGI.OpenAI.BetaResponseSteerFailedEventError error,
            global::tryAGI.OpenAI.BetaResponseSteerFailedEventType type,
            string? streamId)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Steer = steer ?? throw new global::System.ArgumentNullException(nameof(steer));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerFailedEvent" /> class.
        /// </summary>
        public BetaResponseSteerFailedEvent()
        {
        }

    }
}