
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio(
            string data,
            string format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio" /> class.
        /// </summary>
        public ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio()
        {
        }

    }
}