
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTunePreferenceRequestInputInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::OpenAI.OneOf<global::OpenAI.ChatCompletionRequestSystemMessage, global::OpenAI.ChatCompletionRequestUserMessage, global::OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::OpenAI.ChatCompletionRequestToolMessage, global::OpenAI.ChatCompletionRequestFunctionMessage>>? Messages { get; set; }

        /// <summary>
        /// A list of tools the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInputInput" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="tools">
        /// A list of tools the model may generate JSON inputs for.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTunePreferenceRequestInputInput(
            global::System.Collections.Generic.IList<global::OpenAI.OneOf<global::OpenAI.ChatCompletionRequestSystemMessage, global::OpenAI.ChatCompletionRequestUserMessage, global::OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::OpenAI.ChatCompletionRequestToolMessage, global::OpenAI.ChatCompletionRequestFunctionMessage>>? messages,
            global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? tools,
            bool? parallelToolCalls)
        {
            this.Messages = messages;
            this.Tools = tools;
            this.ParallelToolCalls = parallelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInputInput" /> class.
        /// </summary>
        public FineTunePreferenceRequestInputInput()
        {
        }
    }
}