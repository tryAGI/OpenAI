
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Forces the model to call the shell tool when a tool call is required.
    /// </summary>
    public sealed partial class LiveSpecificFunctionShellParam
    {
        /// <summary>
        /// The tool to call. Always `shell`.<br/>
        /// Default Value: shell
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType.Shell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificFunctionShellParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType.Shell;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificFunctionShellParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `shell`.<br/>
        /// Default Value: shell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificFunctionShellParam(
            global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType type = global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType.Shell)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificFunctionShellParam" /> class.
        /// </summary>
        public LiveSpecificFunctionShellParam()
        {
        }

    }
}