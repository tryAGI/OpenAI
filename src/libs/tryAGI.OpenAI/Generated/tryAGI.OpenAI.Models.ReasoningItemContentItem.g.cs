
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReasoningItemContentItem
    {
        /// <summary>
        /// The type of the object. Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemContentItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningItemContentItemType Type { get; set; }

        /// <summary>
        /// A short summary of the reasoning used by the model when generating<br/>
        /// the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `text`.
        /// </param>
        /// <param name="text">
        /// A short summary of the reasoning used by the model when generating<br/>
        /// the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningItemContentItem(
            string text,
            global::tryAGI.OpenAI.ReasoningItemContentItemType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemContentItem" /> class.
        /// </summary>
        public ReasoningItemContentItem()
        {
        }
    }
}