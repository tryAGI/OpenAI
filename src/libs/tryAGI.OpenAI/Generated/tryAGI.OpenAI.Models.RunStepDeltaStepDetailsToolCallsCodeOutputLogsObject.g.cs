
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text output from the Code Interpreter tool call as part of a run step.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject
    {
        /// <summary>
        /// The index of the output in the outputs array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

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
        public string? Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the output in the outputs array.
        /// </param>
        /// <param name="logs">
        /// The text output from the Code Interpreter tool call.
        /// </param>
        /// <param name="type">
        /// Always `logs`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(
            int index,
            string? logs,
            string type = "logs")
        {
            this.Index = index;
            this.Type = type;
            this.Logs = logs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject FromIndex(int index)
        {
            return new RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject
            {
                Index = index,
            };
        }

    }
}