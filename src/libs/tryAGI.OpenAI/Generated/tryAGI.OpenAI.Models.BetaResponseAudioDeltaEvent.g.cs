
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when there is a partial audio response.
    /// </summary>
    public sealed partial class BetaResponseAudioDeltaEvent
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always `response.audio.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType Type { get; set; }

        /// <summary>
        /// A sequence number for this chunk of the stream response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// A chunk of Base64 encoded response audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseAudioDeltaEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// A sequence number for this chunk of the stream response.
        /// </param>
        /// <param name="delta">
        /// A chunk of Base64 encoded response audio bytes.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.audio.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseAudioDeltaEvent(
            int sequenceNumber,
            string delta,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType type)
        {
            this.Agent = agent;
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseAudioDeltaEvent" /> class.
        /// </summary>
        public BetaResponseAudioDeltaEvent()
        {
        }

    }
}