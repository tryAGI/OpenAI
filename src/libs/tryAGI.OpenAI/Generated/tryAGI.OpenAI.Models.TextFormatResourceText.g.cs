
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Generates ordinary text without a structured-output constraint.
    /// </summary>
    public sealed partial class TextFormatResourceText
    {
        /// <summary>
        /// The type of the object. Always `text`.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TextFormatResourceTextType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TextFormatResourceTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.TextFormatResourceTextType Type { get; set; } = global::tryAGI.OpenAI.TextFormatResourceTextType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFormatResourceText" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `text`.<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextFormatResourceText(
            global::tryAGI.OpenAI.TextFormatResourceTextType type = global::tryAGI.OpenAI.TextFormatResourceTextType.Text)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFormatResourceText" /> class.
        /// </summary>
        public TextFormatResourceText()
        {
        }

    }
}