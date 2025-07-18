
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Per-line training example for reinforcement fine-tuning. Note that `messages` and `tools` are the only reserved keywords.<br/>
    /// Any other arbitrary key-value data can be included on training datapoints and will be available to reference during grading under the `{{ item.XXX }}` template variable.<br/>
    /// Input messages may contain text or image content only. Audio and file input messages<br/>
    /// are not currently supported for fine-tuning.
    /// </summary>
    public sealed partial class FineTuneReinforcementRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage, global::tryAGI.OpenAI.ChatCompletionRequestUserMessage, global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::tryAGI.OpenAI.ChatCompletionRequestToolMessage>> Messages { get; set; }

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
        /// Initializes a new instance of the <see cref="FineTuneReinforcementRequestInput" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="tools">
        /// A list of tools the model may generate JSON inputs for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneReinforcementRequestInput(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage, global::tryAGI.OpenAI.ChatCompletionRequestUserMessage, global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage?, global::tryAGI.OpenAI.ChatCompletionRequestToolMessage>> messages,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? tools)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneReinforcementRequestInput" /> class.
        /// </summary>
        public FineTuneReinforcementRequestInput()
        {
        }
    }
}