
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The per-line training example of a fine-tuning input file for chat models using the supervised method.<br/>
    /// Input messages may contain text or image content only. Audio and file input messages<br/>
    /// are not currently supported for fine-tuning.
    /// </summary>
    public sealed partial class FineTuneChatRequestInput
    {
        /// <summary>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage, global::tryAGI.OpenAI.ChatCompletionRequestUserMessage, global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::tryAGI.OpenAI.ChatCompletionRequestToolMessage, global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage>>? Messages { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](https://platform.openai.com/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// A list of tools the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatRequestInput" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](https://platform.openai.com/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may generate JSON inputs for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneChatRequestInput(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage, global::tryAGI.OpenAI.ChatCompletionRequestUserMessage, global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::tryAGI.OpenAI.ChatCompletionRequestToolMessage, global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage>>? messages,
            bool? parallelToolCalls,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? tools)
        {
            this.Messages = messages;
            this.ParallelToolCalls = parallelToolCalls;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatRequestInput" /> class.
        /// </summary>
        public FineTuneChatRequestInput()
        {
        }
    }
}