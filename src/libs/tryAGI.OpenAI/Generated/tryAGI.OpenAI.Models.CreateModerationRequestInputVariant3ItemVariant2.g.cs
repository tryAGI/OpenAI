
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object describing text to classify.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant2
    {
        /// <summary>
        /// Always `text`.
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        /// A string of text to classify.<br/>
        /// Example: ...text to classify goes here...
        /// </summary>
        /// <example>...text to classify goes here...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant2" /> class.
        /// </summary>
        /// <param name="text">
        /// A string of text to classify.<br/>
        /// Example: ...text to classify goes here...
        /// </param>
        /// <param name="type">
        /// Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModerationRequestInputVariant3ItemVariant2(
            string text,
            string type = "text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant2" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateModerationRequestInputVariant3ItemVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateModerationRequestInputVariant3ItemVariant2 FromText(string text)
        {
            return new CreateModerationRequestInputVariant3ItemVariant2
            {
                Text = text,
            };
        }

    }
}