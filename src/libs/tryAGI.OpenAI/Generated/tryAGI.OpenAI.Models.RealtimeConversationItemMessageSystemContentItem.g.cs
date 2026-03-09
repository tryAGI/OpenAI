
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemMessageSystemContentItem
    {
        /// <summary>
        /// The content type. Always `input_text` for system messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemContentItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType? Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageSystemContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type. Always `input_text` for system messages.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemMessageSystemContentItem(
            global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType? type,
            string? text)
        {
            this.Type = type;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageSystemContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemMessageSystemContentItem()
        {
        }
    }
}