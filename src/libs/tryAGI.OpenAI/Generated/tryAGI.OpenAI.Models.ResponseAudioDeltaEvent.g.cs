
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when there is a partial audio response.
    /// </summary>
    public sealed partial class ResponseAudioDeltaEvent
    {
        /// <summary>
        /// A chunk of Base64 encoded response audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// A sequence number for this chunk of the stream response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always `response.audio.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseAudioDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// A chunk of Base64 encoded response audio bytes.
        /// </param>
        /// <param name="sequenceNumber">
        /// A sequence number for this chunk of the stream response.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.audio.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAudioDeltaEvent(
            string delta,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseAudioDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaEvent" /> class.
        /// </summary>
        public ResponseAudioDeltaEvent()
        {
        }
    }
}