
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an input audio transcription segment is identified for an item.
    /// </summary>
    public sealed partial class RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.input_audio_transcription.segment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType Type { get; set; }

        /// <summary>
        /// The ID of the item containing the input audio content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the input audio content part within the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The text for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The segment identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The detected speaker label for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Speaker { get; set; }

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Start { get; set; }

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment" /> class.
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
        public RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment(
            string eventId,
            string itemId,
            int contentIndex,
            string text,
            string id,
            string speaker,
            float start,
            float end,
            global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType type)
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
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment" /> class.
        /// </summary>
        public RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment()
        {
        }
    }
}