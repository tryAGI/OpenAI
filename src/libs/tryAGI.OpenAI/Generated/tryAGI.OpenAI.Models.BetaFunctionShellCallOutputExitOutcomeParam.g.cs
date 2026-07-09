
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that the shell commands finished and returned an exit code.
    /// </summary>
    public sealed partial class BetaFunctionShellCallOutputExitOutcomeParam
    {
        /// <summary>
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType.Exit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType Type { get; set; } = global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType.Exit;

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
        /// Initializes a new instance of the <see cref="BetaFunctionShellCallOutputExitOutcomeParam" /> class.
        /// </summary>
        /// <param name="exitCode">
        /// The exit code returned by the shell process.
        /// </param>
        /// <param name="type">
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFunctionShellCallOutputExitOutcomeParam(
            int exitCode,
            global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType type = global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType.Exit)
        {
            this.Type = type;
            this.ExitCode = exitCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionShellCallOutputExitOutcomeParam" /> class.
        /// </summary>
        public BetaFunctionShellCallOutputExitOutcomeParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaFunctionShellCallOutputExitOutcomeParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaFunctionShellCallOutputExitOutcomeParam FromExitCode(int exitCode)
        {
            return new BetaFunctionShellCallOutputExitOutcomeParam
            {
                ExitCode = exitCode,
            };
        }

    }
}