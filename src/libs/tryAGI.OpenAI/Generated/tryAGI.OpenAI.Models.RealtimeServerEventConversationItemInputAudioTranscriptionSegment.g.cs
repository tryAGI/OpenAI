
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an input audio transcription segment is identified for an item.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemInputAudioTranscriptionSegment
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `conversation.item.input_audio_transcription.segment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType Type { get; set; }

        /// <summary>
        /// The ID of the item containing the input audio content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the input audio content part within the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The text for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The segment identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The detected speaker label for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Speaker { get; set; } = default!;

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public float Start { get; set; } = default!;

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public float End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionSegment" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.input_audio_transcription.segment`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item containing the input audio content.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the input audio content part within the item.
        /// </param>
        /// <param name="text">
        /// The text for this segment.
        /// </param>
        /// <param name="id">
        /// The segment identifier.
        /// </param>
        /// <param name="speaker">
        /// The detected speaker label for this segment.
        /// </param>
        /// <param name="start">
        /// Start time of the segment in seconds.
        /// </param>
        /// <param name="end">
        /// End time of the segment in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemInputAudioTranscriptionSegment(
            string eventId,
            string itemId,
            int contentIndex,
            string text,
            string id,
            string speaker,
            float start,
            float end,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ContentIndex = contentIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
            this.Start = start;
            this.End = end;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionSegment" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionSegment()
        {
        }
    }
}