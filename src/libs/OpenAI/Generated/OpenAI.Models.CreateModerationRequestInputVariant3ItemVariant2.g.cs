
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// An object describing text to classify.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant2
    {
        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2TypeJsonConverter))]
        public global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type Type { get; set; }

        /// <summary>
        /// A string of text to classify.<br/>
        /// Example: I want to kill them
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}