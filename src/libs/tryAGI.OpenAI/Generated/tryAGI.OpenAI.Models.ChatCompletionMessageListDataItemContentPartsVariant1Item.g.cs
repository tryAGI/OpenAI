
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionMessageListDataItemContentPartsVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListDataItemContentPartsVariant1ItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemImageUrl? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio? InputAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemFile? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageListDataItemContentPartsVariant1Item" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="imageUrl"></param>
        /// <param name="inputAudio"></param>
        /// <param name="file"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageListDataItemContentPartsVariant1Item(
            global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType type,
            string? text,
            global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemImageUrl? imageUrl,
            global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio? inputAudio,
            global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemFile? file)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.InputAudio = inputAudio;
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageListDataItemContentPartsVariant1Item" /> class.
        /// </summary>
        public ChatCompletionMessageListDataItemContentPartsVariant1Item()
        {
        }

    }
}