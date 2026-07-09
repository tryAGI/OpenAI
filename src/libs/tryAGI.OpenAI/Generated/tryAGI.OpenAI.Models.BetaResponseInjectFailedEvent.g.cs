
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when injected input could not be committed to a response. The event<br/>
    /// returns the uncommitted raw input so the client can retry it in another<br/>
    /// response when appropriate.
    /// </summary>
    public sealed partial class BetaResponseInjectFailedEvent
    {
        /// <summary>
        /// The event discriminator. Always `response.inject.failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectFailedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventType Type { get; set; }

        /// <summary>
        /// The ID of the response that rejected the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// The raw input items that were not committed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem> Input { get; set; }

        /// <summary>
        /// Information about why the input was not committed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResponseInjectFailedEventError Error { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaResponseInjectFailedEvent" /> class.
        /// </summary>
        /// <param name="responseId">
        /// The ID of the response that rejected the input.
        /// </param>
        /// <param name="input">
        /// The raw input items that were not committed.
        /// </param>
        /// <param name="error">
        /// Information about why the input was not committed.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
        /// <param name="type">
        /// The event discriminator. Always `response.inject.failed`.
        /// </param>
        /// <param name="streamId">
        /// The multiplexed WebSocket stream that emitted the event. This field is<br/>
        /// present only when WebSocket multiplexing is enabled separately.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseInjectFailedEvent(
            string responseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem> input,
            global::tryAGI.OpenAI.BetaResponseInjectFailedEventError error,
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaResponseInjectFailedEventType type,
            string? streamId)
        {
            this.Type = type;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.SequenceNumber = sequenceNumber;
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseInjectFailedEvent" /> class.
        /// </summary>
        public BetaResponseInjectFailedEvent()
        {
        }

    }
}