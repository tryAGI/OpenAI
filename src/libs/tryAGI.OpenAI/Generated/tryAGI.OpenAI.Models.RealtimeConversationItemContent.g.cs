
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemContent
    {
        /// <summary>
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// ID of a previous conversation item to reference (for `item_reference`<br/>
        /// content types in `response.create` events). These can reference both<br/>
        /// client and server created items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The text content, used for `input_text` and `text` content types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The transcript of the audio, used for `input_audio` and `audio` <br/>
        /// content types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The content type (`input_text`, `input_audio`, `item_reference`, `text`, `audio`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemContentType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemContent" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </param>
        /// <param name="id">
        /// ID of a previous conversation item to reference (for `item_reference`<br/>
        /// content types in `response.create` events). These can reference both<br/>
        /// client and server created items.
        /// </param>
        /// <param name="text">
        /// The text content, used for `input_text` and `text` content types.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio, used for `input_audio` and `audio` <br/>
        /// content types.
        /// </param>
        /// <param name="type">
        /// The content type (`input_text`, `input_audio`, `item_reference`, `text`, `audio`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemContent(
            string? audio,
            string? id,
            string? text,
            string? transcript,
            global::tryAGI.OpenAI.RealtimeConversationItemContentType? type)
        {
            this.Audio = audio;
            this.Id = id;
            this.Text = text;
            this.Transcript = transcript;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemContent" /> class.
        /// </summary>
        public RealtimeConversationItemContent()
        {
        }
    }
}