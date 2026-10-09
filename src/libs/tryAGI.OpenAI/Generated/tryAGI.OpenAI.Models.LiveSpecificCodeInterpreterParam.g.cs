
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificCodeInterpreterParam
    {
        /// <summary>
        /// The tool to call. Always `code_interpreter`.<br/>
        /// Default Value: code_interpreter
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType.CodeInterpreter</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificCodeInterpreterParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType.CodeInterpreter;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificCodeInterpreterParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `code_interpreter`.<br/>
        /// Default Value: code_interpreter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificCodeInterpreterParam(
            global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType type = global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType.CodeInterpreter)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificCodeInterpreterParam" /> class.
        /// </summary>
        public LiveSpecificCodeInterpreterParam()
        {
        }

    }
}