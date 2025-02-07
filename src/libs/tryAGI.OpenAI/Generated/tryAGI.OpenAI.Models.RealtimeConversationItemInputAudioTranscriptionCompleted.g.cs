
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when input audio transcription is enabled and a transcription succeeds.
    /// </summary>
    public sealed partial class RealtimeConversationItemInputAudioTranscriptionCompleted
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_2122
        /// </summary>
        /// <example>event_2122</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.item.input_audio_transcription.completed".<br/>
        /// Example: conversation.item.input_audio_transcription.completed
        /// </summary>
        /// <example>conversation.item.input_audio_transcription.completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemInputAudioTranscriptionCompletedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemInputAudioTranscriptionCompletedType? Type { get; set; }

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
        /// The transcribed text.<br/>
        /// Example: Hello, how are you?
        /// </summary>
        /// <example>Hello, how are you?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemInputAudioTranscriptionCompleted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_2122
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.item.input_audio_transcription.completed".<br/>
        /// Example: conversation.item.input_audio_transcription.completed
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item.<br/>
        /// Example: msg_003
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part containing the audio.<br/>
        /// Example: 0
        /// </param>
        /// <param name="transcript">
        /// The transcribed text.<br/>
        /// Example: Hello, how are you?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemInputAudioTranscriptionCompleted(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeConversationItemInputAudioTranscriptionCompletedType? type,
            string? itemId,
            int? contentIndex,
            string? transcript)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId;
            this.ContentIndex = contentIndex;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemInputAudioTranscriptionCompleted" /> class.
        /// </summary>
        public RealtimeConversationItemInputAudioTranscriptionCompleted()
        {
        }
    }
}