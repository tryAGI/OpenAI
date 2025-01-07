
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when input audio transcription is configured, and a transcription request for a user message failed.
    /// </summary>
    public sealed partial class RealtimeConversationItemInputAudioTranscriptionFailed
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_2324
        /// </summary>
        /// <example>event_2324</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.input_audio_transcription.failed".<br/>
        /// Example: conversation.item.input_audio_transcription.failed
        /// </summary>
        /// <example>conversation.item.input_audio_transcription.failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemInputAudioTranscriptionFailedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemInputAudioTranscriptionFailedType? Type { get; set; }

        /// <summary>
        /// The ID of the user message item.<br/>
        /// Example: msg_003
        /// </summary>
        /// <example>msg_003</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the content part containing the audio.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// Details of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.RealtimeErrorDetails? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemInputAudioTranscriptionFailed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_2324
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.input_audio_transcription.failed".<br/>
        /// Example: conversation.item.input_audio_transcription.failed
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item.<br/>
        /// Example: msg_003
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part containing the audio.<br/>
        /// Example: 0
        /// </param>
        /// <param name="error">
        /// Details of the error.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemInputAudioTranscriptionFailed(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeConversationItemInputAudioTranscriptionFailedType? type,
            string? itemId,
            int? contentIndex,
            global::tryAGI.OpenAI.RealtimeErrorDetails? error)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId;
            this.ContentIndex = contentIndex;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemInputAudioTranscriptionFailed" /> class.
        /// </summary>
        public RealtimeConversationItemInputAudioTranscriptionFailed()
        {
        }
    }
}