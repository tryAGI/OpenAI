
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that the shell commands finished and returned an exit code.
    /// </summary>
    public sealed partial class BetaFunctionShellCallOutputExitOutcome
    {
        /// <summary>
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType.Exit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType Type { get; set; } = global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType.Exit;

        /// <summary>
        /// Exit code from the shell process.
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
        /// Initializes a new instance of the <see cref="BetaFunctionShellCallOutputExitOutcome" /> class.
        /// </summary>
        /// <param name="exitCode">
        /// Exit code from the shell process.
        /// </param>
        /// <param name="type">
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFunctionShellCallOutputExitOutcome(
            int exitCode,
            global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType type = global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType.Exit)
        {
            this.Type = type;
            this.ExitCode = exitCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionShellCallOutputExitOutcome" /> class.
        /// </summary>
        public BetaFunctionShellCallOutputExitOutcome()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaFunctionShellCallOutputExitOutcome"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaFunctionShellCallOutputExitOutcome FromExitCode(int exitCode)
        {
            return new BetaFunctionShellCallOutputExitOutcome
            {
                ExitCode = exitCode,
            };
        }

    }
}