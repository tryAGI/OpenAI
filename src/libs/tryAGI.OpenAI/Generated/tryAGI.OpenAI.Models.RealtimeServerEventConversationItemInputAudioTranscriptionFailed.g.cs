
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when input audio transcription is configured, and a transcription <br/>
    /// request for a user message failed. These events are separate from other <br/>
    /// `error` events so that the client can identify the related Item.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemInputAudioTranscriptionFailed
    {
        /// <summary>
        /// The index of the content part containing the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// Details of the transcription error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError Error { get; set; }

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the user message item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The event type, must be<br/>
        /// `conversation.item.input_audio_transcription.failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailed" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part containing the audio.
        /// </param>
        /// <param name="error">
        /// Details of the transcription error.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item.
        /// </param>
        /// <param name="type">
        /// The event type, must be<br/>
        /// `conversation.item.input_audio_transcription.failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailed(
            int contentIndex,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError error,
            string eventId,
            string itemId,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType type)
        {
            this.ContentIndex = contentIndex;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailed" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailed()
        {
        }
    }
}