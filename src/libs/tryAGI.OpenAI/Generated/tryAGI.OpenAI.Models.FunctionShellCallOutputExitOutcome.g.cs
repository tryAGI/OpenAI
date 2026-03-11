
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that the shell commands finished and returned an exit code.
    /// </summary>
    public sealed partial class FunctionShellCallOutputExitOutcome
    {
        /// <summary>
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType.Exit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType Type { get; set; } = global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType.Exit;

        /// <summary>
        /// Exit code from the shell process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ExitCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputExitOutcome" /> class.
        /// </summary>
        /// <param name="type">
        /// The outcome type. Always `exit`.<br/>
        /// Default Value: exit
        /// </param>
        /// <param name="exitCode">
        /// Exit code from the shell process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellCallOutputExitOutcome(
            int exitCode,
            global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType type = global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType.Exit)
        {
            this.ExitCode = exitCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputExitOutcome" /> class.
        /// </summary>
        public FunctionShellCallOutputExitOutcome()
        {
        }
    }
}