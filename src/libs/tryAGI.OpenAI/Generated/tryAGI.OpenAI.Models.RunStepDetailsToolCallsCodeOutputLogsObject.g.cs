
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text output from the Code Interpreter tool call as part of a run step.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputLogsObject
    {
        /// <summary>
        /// Always `logs`.
        /// </summary>
        /// <default>"logs"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "logs";

        /// <summary>
        /// The text output from the Code Interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        /// <param name="logs">
        /// The text output from the Code Interpreter tool call.
        /// </param>
        /// <param name="type">
        /// Always `logs`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsToolCallsCodeOutputLogsObject(
            string logs,
            string type = "logs")
        {
            this.Type = type;
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeOutputLogsObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStepDetailsToolCallsCodeOutputLogsObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStepDetailsToolCallsCodeOutputLogsObject FromLogs(string logs)
        {
            return new RunStepDetailsToolCallsCodeOutputLogsObject
            {
                Logs = logs,
            };
        }

    }
}