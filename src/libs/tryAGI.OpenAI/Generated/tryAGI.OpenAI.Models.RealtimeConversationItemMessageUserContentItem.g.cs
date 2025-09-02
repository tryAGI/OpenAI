
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemMessageUserContentItem
    {
        /// <summary>
        /// Base64-encoded audio bytes (for `input_audio`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The text content (for `input_text`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Transcript of the audio (for `input_audio`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The content type (`input_text` or `input_audio`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageUserContentItem" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes (for `input_audio`).
        /// </param>
        /// <param name="text">
        /// The text content (for `input_text`).
        /// </param>
        /// <param name="transcript">
        /// Transcript of the audio (for `input_audio`).
        /// </param>
        /// <param name="type">
        /// The content type (`input_text` or `input_audio`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemMessageUserContentItem(
            string? audio,
            string? text,
            string? transcript,
            global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType? type)
        {
            this.Audio = audio;
            this.Text = text;
            this.Transcript = transcript;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageUserContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemMessageUserContentItem()
        {
        }
    }
}