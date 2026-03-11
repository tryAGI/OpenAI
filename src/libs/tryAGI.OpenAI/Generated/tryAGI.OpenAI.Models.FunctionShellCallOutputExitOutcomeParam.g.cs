
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that the shell commands finished and returned an exit code.
    /// </summary>
    public sealed partial class FunctionShellCallOutputExitOutcomeParam
    {
        /// <summary>
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType.Exit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType Type { get; set; } = global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType.Exit;

        /// <summary>
        /// The exit code returned by the shell process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExitCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputExitOutcomeParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </param>
        /// <param name="exitCode">
        /// The exit code returned by the shell process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellCallOutputExitOutcomeParam(
            int exitCode,
            global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType type = global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType.Exit)
        {
            this.ExitCode = exitCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputExitOutcomeParam" /> class.
        /// </summary>
        public FunctionShellCallOutputExitOutcomeParam()
        {
        }
    }
}