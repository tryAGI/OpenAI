
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that allows the model to execute shell commands.
    /// </summary>
    public sealed partial class FunctionShellToolParam
    {
        /// <summary>
        /// The type of the shell tool. Always `shell`.<br/>
        /// Default Value: shell
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FunctionShellToolParamType.Shell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionShellToolParamType Type { get; set; } = global::tryAGI.OpenAI.FunctionShellToolParamType.Shell;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public global::tryAGI.OpenAI.EnvironmentVariant1? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellToolParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the shell tool. Always `shell`.<br/>
        /// Default Value: shell
        /// </param>
        /// <param name="environment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellToolParam(
            global::tryAGI.OpenAI.EnvironmentVariant1? environment,
            global::tryAGI.OpenAI.FunctionShellToolParamType type = global::tryAGI.OpenAI.FunctionShellToolParamType.Shell)
        {
            this.Type = type;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellToolParam" /> class.
        /// </summary>
        public FunctionShellToolParam()
        {
        }
    }
}