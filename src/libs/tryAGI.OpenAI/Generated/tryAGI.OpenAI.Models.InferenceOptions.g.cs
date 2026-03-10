
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Model and tool overrides applied when generating the assistant response.
    /// </summary>
    public sealed partial class InferenceOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::tryAGI.OpenAI.ToolChoice8? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceOptions" /> class.
        /// </summary>
        /// <param name="toolChoice"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceOptions(
            global::tryAGI.OpenAI.ToolChoice8? toolChoice,
            string? model)
        {
            this.ToolChoice = toolChoice;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceOptions" /> class.
        /// </summary>
        public InferenceOptions()
        {
        }
    }
}