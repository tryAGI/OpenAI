
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The per-line training example of a fine-tuning input file for chat models using the dpo method.<br/>
    /// Input messages may contain text or image content only. Audio and file input messages<br/>
    /// are not currently supported for fine-tuning.
    /// </summary>
    public sealed partial class FineTunePreferenceRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.FineTunePreferenceRequestInputInput? Input { get; set; }

        /// <summary>
        /// The non-preferred completion message for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_preferred_output")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage>>? NonPreferredOutput { get; set; }

        /// <summary>
        /// The preferred completion message for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_output")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage>>? PreferredOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInput" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="nonPreferredOutput">
        /// The non-preferred completion message for the output.
        /// </param>
        /// <param name="preferredOutput">
        /// The preferred completion message for the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTunePreferenceRequestInput(
            global::tryAGI.OpenAI.FineTunePreferenceRequestInputInput? input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage>>? nonPreferredOutput,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage>>? preferredOutput)
        {
            this.Input = input;
            this.NonPreferredOutput = nonPreferredOutput;
            this.PreferredOutput = preferredOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInput" /> class.
        /// </summary>
        public FineTunePreferenceRequestInput()
        {
        }
    }
}