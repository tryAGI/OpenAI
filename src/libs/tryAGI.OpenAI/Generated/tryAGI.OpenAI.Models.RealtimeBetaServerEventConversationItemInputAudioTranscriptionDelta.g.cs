
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the text value of an input audio transcription content part is updated.
    /// </summary>
    public sealed partial class RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta
    {
        /// <summary>
        /// The index of the content part in the item's content array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The text delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The log probabilities of the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>? Logprobs { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.input_audio_transcription.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.
        /// </param>
        /// <param name="delta">
        /// The text delta.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the transcription.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.input_audio_transcription.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta(
            string eventId,
            string itemId,
            int? contentIndex,
            string? delta,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>? logprobs,
            global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ContentIndex = contentIndex;
            this.Delta = delta;
            this.Logprobs = logprobs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta" /> class.
        /// </summary>
        public RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta()
        {
        }
    }
}