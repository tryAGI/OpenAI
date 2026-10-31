
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text output configuration for subsequent responses.
    /// </summary>
    public sealed partial class ResponseConfigurationUpdateItemParamText
    {
        /// <summary>
        /// Use a JSON schema for structured output or text to return to plain text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Format3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Format3 Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdateItemParamText" /> class.
        /// </summary>
        /// <param name="format">
        /// Use a JSON schema for structured output or text to return to plain text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseConfigurationUpdateItemParamText(
            global::tryAGI.OpenAI.Format3 format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdateItemParamText" /> class.
        /// </summary>
        public ResponseConfigurationUpdateItemParamText()
        {
        }

    }
}