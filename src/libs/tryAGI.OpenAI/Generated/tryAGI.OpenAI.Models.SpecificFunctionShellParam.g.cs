
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Forces the model to call the shell tool when a tool call is required.
    /// </summary>
    public sealed partial class SpecificFunctionShellParam
    {
        /// <summary>
        /// The tool to call. Always `shell`.<br/>
        /// Default Value: shell
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SpecificFunctionShellParamType.Shell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.SpecificFunctionShellParamType Type { get; set; } = global::tryAGI.OpenAI.SpecificFunctionShellParamType.Shell;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificFunctionShellParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `shell`.<br/>
        /// Default Value: shell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpecificFunctionShellParam(
            global::tryAGI.OpenAI.SpecificFunctionShellParamType type = global::tryAGI.OpenAI.SpecificFunctionShellParamType.Shell)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificFunctionShellParam" /> class.
        /// </summary>
        public SpecificFunctionShellParam()
        {
        }
    }
}