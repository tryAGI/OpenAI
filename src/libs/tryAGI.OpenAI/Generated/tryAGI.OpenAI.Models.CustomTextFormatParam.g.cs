
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained free-form text.
    /// </summary>
    public sealed partial class CustomTextFormatParam
    {
        /// <summary>
        /// Unconstrained text format. Always `text`.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CustomTextFormatParamType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomTextFormatParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomTextFormatParamType Type { get; set; } = global::tryAGI.OpenAI.CustomTextFormatParamType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTextFormatParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Unconstrained text format. Always `text`.<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTextFormatParam(
            global::tryAGI.OpenAI.CustomTextFormatParamType type = global::tryAGI.OpenAI.CustomTextFormatParamType.Text)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTextFormatParam" /> class.
        /// </summary>
        public CustomTextFormatParam()
        {
        }
    }
}