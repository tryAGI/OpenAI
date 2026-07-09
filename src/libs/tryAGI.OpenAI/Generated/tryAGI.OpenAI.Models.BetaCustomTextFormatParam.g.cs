
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained free-form text.
    /// </summary>
    public sealed partial class BetaCustomTextFormatParam
    {
        /// <summary>
        /// Unconstrained text format. Always `text`.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaCustomTextFormatParamType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCustomTextFormatParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaCustomTextFormatParamType Type { get; set; } = global::tryAGI.OpenAI.BetaCustomTextFormatParamType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCustomTextFormatParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Unconstrained text format. Always `text`.<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCustomTextFormatParam(
            global::tryAGI.OpenAI.BetaCustomTextFormatParamType type = global::tryAGI.OpenAI.BetaCustomTextFormatParamType.Text)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCustomTextFormatParam" /> class.
        /// </summary>
        public BetaCustomTextFormatParam()
        {
        }

    }
}