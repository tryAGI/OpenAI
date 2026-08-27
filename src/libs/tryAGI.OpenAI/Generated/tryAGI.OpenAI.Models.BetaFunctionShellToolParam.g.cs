
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that allows the model to execute shell commands.
    /// </summary>
    public sealed partial class BetaFunctionShellToolParam
    {
        /// <summary>
        /// The type of the shell tool. Always `shell`.<br/>
        /// Default Value: shell
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaFunctionShellToolParamType.Shell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamType Type { get; set; } = global::tryAGI.OpenAI.BetaFunctionShellToolParamType.Shell;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public global::tryAGI.OpenAI.EnvironmentVariant14? Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionShellToolParam" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="allowedCallers"></param>
        /// <param name="type">
        /// The type of the shell tool. Always `shell`.<br/>
        /// Default Value: shell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFunctionShellToolParam(
            global::tryAGI.OpenAI.EnvironmentVariant14? environment,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? allowedCallers,
            global::tryAGI.OpenAI.BetaFunctionShellToolParamType type = global::tryAGI.OpenAI.BetaFunctionShellToolParamType.Shell)
        {
            this.Type = type;
            this.Environment = environment;
            this.AllowedCallers = allowedCallers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionShellToolParam" /> class.
        /// </summary>
        public BetaFunctionShellToolParam()
        {
        }

    }
}