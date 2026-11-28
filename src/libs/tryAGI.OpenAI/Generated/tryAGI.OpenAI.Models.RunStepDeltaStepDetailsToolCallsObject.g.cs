
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the tool call.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsObject
    {
        /// <summary>
        /// Always `tool_calls`.
        /// </summary>
        /// <default>"tool_calls"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_calls";

        /// <summary>
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsObject" /> class.
        /// </summary>
        /// <param name="toolCalls">
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </param>
        /// <param name="type">
        /// Always `tool_calls`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsToolCallsObject(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>>? toolCalls,
            string type = "tool_calls")
        {
            this.Type = type;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsObject()
        {
        }

    }
}