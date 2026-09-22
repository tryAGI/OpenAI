
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A reasoning summary content part.
    /// </summary>
    public sealed partial class SummaryTextResource
    {
        /// <summary>
        /// The content type. Always `summary_text`.<br/>
        /// Default Value: summary_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SummaryTextResourceType.SummaryText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SummaryTextResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.SummaryTextResourceType Type { get; set; } = global::tryAGI.OpenAI.SummaryTextResourceType.SummaryText;

        /// <summary>
        /// The reasoning summary text.
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
        /// Initializes a new instance of the <see cref="SummaryTextResource" /> class.
        /// </summary>
        /// <param name="text">
        /// The reasoning summary text.
        /// </param>
        /// <param name="type">
        /// The content type. Always `summary_text`.<br/>
        /// Default Value: summary_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryTextResource(
            string text,
            global::tryAGI.OpenAI.SummaryTextResourceType type = global::tryAGI.OpenAI.SummaryTextResourceType.SummaryText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryTextResource" /> class.
        /// </summary>
        public SummaryTextResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SummaryTextResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SummaryTextResource FromText(string text)
        {
            return new SummaryTextResource
            {
                Text = text,
            };
        }

    }
}