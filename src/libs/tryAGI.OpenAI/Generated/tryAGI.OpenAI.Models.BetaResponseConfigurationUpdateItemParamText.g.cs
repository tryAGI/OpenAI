
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text output configuration for subsequent responses.
    /// </summary>
    public sealed partial class BetaResponseConfigurationUpdateItemParamText
    {
        /// <summary>
        /// Use a JSON schema for structured output or text to return to plain text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Format6JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Format6 Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdateItemParamText" /> class.
        /// </summary>
        /// <param name="format">
        /// Use a JSON schema for structured output or text to return to plain text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseConfigurationUpdateItemParamText(
            global::tryAGI.OpenAI.Format6 format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdateItemParamText" /> class.
        /// </summary>
        public BetaResponseConfigurationUpdateItemParamText()
        {
        }

    }
}