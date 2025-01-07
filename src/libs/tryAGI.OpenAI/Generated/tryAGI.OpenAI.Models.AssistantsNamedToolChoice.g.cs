
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies a tool the model should use. Use to force the model to call a specific tool.
    /// </summary>
    public sealed partial class AssistantsNamedToolChoice
    {
        /// <summary>
        /// The type of the tool. If type is `function`, the function name must be set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AssistantsNamedToolChoiceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsNamedToolChoice" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool. If type is `function`, the function name must be set
        /// </param>
        /// <param name="function"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AssistantsNamedToolChoice(
            global::tryAGI.OpenAI.AssistantsNamedToolChoiceType type,
            global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsNamedToolChoice" /> class.
        /// </summary>
        public AssistantsNamedToolChoice()
        {
        }
    }
}