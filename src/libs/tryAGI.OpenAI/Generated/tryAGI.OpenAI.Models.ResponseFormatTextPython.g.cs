
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configure the model to generate valid Python code. See the<br/>
    /// [custom grammars guide](https://platform.openai.com/docs/guides/custom-grammars) for more details.
    /// </summary>
    public sealed partial class ResponseFormatTextPython
    {
        /// <summary>
        /// The type of response format being defined. Always `python`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextPythonTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseFormatTextPythonType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatTextPython" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format being defined. Always `python`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatTextPython(
            global::tryAGI.OpenAI.ResponseFormatTextPythonType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatTextPython" /> class.
        /// </summary>
        public ResponseFormatTextPython()
        {
        }
    }
}