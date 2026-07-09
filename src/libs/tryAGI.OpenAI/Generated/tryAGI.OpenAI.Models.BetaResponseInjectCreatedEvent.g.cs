
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when all injected input items were validated and committed to the<br/>
    /// active response.
    /// </summary>
    public sealed partial class BetaResponseInjectCreatedEvent
    {
        /// <summary>
        /// The event discriminator. Always `response.inject.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectCreatedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType Type { get; set; }

        /// <summary>
        /// The ID of the response that accepted the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// The sequence number for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The multiplexed WebSocket stream that emitted the event. This field is<br/>
        /// present only when WebSocket multiplexing is enabled separately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseInjectCreatedEvent" /> class.
        /// </summary>
        /// <param name="responseId">
        /// The ID of the response that accepted the input.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
        /// <param name="type">
        /// The event discriminator. Always `response.inject.created`.
        /// </param>
        /// <param name="streamId">
        /// The multiplexed WebSocket stream that emitted the event. This field is<br/>
        /// present only when WebSocket multiplexing is enabled separately.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseInjectCreatedEvent(
            string responseId,
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType type,
            string? streamId)
        {
            this.Type = type;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.SequenceNumber = sequenceNumber;
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseInjectCreatedEvent" /> class.
        /// </summary>
        public BetaResponseInjectCreatedEvent()
        {
        }

    }
}