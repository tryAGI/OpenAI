
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveCodeInterpreterToolInputParam
    {
        /// <summary>
        /// Default Value: code_interpreter
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType.CodeInterpreter</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveCodeInterpreterToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType.CodeInterpreter;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCodeInterpreterToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: code_interpreter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCodeInterpreterToolInputParam(
            global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType type = global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType.CodeInterpreter)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCodeInterpreterToolInputParam" /> class.
        /// </summary>
        public LiveCodeInterpreterToolInputParam()
        {
        }

    }
}