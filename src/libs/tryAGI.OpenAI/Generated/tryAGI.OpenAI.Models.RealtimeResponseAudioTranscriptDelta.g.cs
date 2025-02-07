
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the model-generated transcription of audio output is updated.
    /// </summary>
    public sealed partial class RealtimeResponseAudioTranscriptDelta
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_4546
        /// </summary>
        /// <example>event_4546</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.audio_transcript.delta".<br/>
        /// Example: response.audio_transcript.delta
        /// </summary>
        /// <example>response.audio_transcript.delta</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseAudioTranscriptDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseAudioTranscriptDeltaType? Type { get; set; }

        /// <summary>
        /// The ID of the response.<br/>
        /// Example: resp_001
        /// </summary>
        /// <example>resp_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The ID of the item.<br/>
        /// Example: msg_008
        /// </summary>
        /// <example>msg_008</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part in the item's content array.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The transcript delta.<br/>
        /// Example: Hello, how can I a
        /// </summary>
        /// <example>Hello, how can I a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseAudioTranscriptDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_4546
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.audio_transcript.delta".<br/>
        /// Example: response.audio_transcript.delta
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.<br/>
        /// Example: resp_001
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.<br/>
        /// Example: msg_008
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.<br/>
        /// Example: 0
        /// </param>
        /// <param name="delta">
        /// The transcript delta.<br/>
        /// Example: Hello, how can I a
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseAudioTranscriptDelta(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseAudioTranscriptDeltaType? type,
            string? responseId,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            string? delta)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseAudioTranscriptDelta" /> class.
        /// </summary>
        public RealtimeResponseAudioTranscriptDelta()
        {
        }
    }
}