
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the tool call.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsObject
    {
        /// <summary>
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>> ToolCalls { get; set; }

        /// <summary>
        /// Always `tool_calls`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsObject" /> class.
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
        public RunStepDetailsToolCallsObject(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>> toolCalls,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType type)
        {
            this.ToolCalls = toolCalls ?? throw new global::System.ArgumentNullException(nameof(toolCalls));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsObject()
        {
        }
    }
}