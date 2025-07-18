
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object describing text to classify.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant2
    {
        /// <summary>
        /// A string of text to classify.<br/>
        /// Example: I want to kill them
        /// </summary>
        /// <example>I want to kill them</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type Type { get; set; }

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
        /// Example: I want to kill them
        /// </param>
        /// <param name="type">
        /// Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModerationRequestInputVariant3ItemVariant2(
            string text,
            global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant2" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemVariant2()
        {
        }
    }
}