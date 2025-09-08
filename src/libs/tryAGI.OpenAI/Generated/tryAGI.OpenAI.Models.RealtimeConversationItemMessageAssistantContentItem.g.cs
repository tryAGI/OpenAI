
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemMessageAssistantContentItem
    {
        /// <summary>
        /// Base64-encoded audio bytes, these will be parsed as the format specified in the session output audio type configuration. This defaults to PCM 16-bit 24kHz mono if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The transcript of the audio content, this will always be present if the output type is `audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The content type, `output_text` or `output_audio` depending on the session `output_modalities` configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantContentItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageAssistantContentItem" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes, these will be parsed as the format specified in the session output audio type configuration. This defaults to PCM 16-bit 24kHz mono if not specified.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio content, this will always be present if the output type is `audio`.
        /// </param>
        /// <param name="type">
        /// The content type, `output_text` or `output_audio` depending on the session `output_modalities` configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemMessageAssistantContentItem(
            string? audio,
            string? text,
            string? transcript,
            global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType? type)
        {
            this.Audio = audio;
            this.Text = text;
            this.Transcript = transcript;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageAssistantContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemMessageAssistantContentItem()
        {
        }
    }
}