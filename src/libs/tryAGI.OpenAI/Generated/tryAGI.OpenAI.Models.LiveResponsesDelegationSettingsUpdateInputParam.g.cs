
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates to the Responses backend of an existing Live session. Omitted settings retain their current values.
    /// </summary>
    public sealed partial class LiveResponsesDelegationSettingsUpdateInputParam
    {
        /// <summary>
        /// The Responses backend model to use for subsequent delegated requests. Omit to keep the current backend model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::tryAGI.OpenAI.LiveResponsesServiceTier? ServiceTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.LiveDelegationReasoningInputParam? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::tryAGI.OpenAI.LiveDelegationTextInputParam? Text { get; set; }

        /// <summary>
        /// Tools available to the Responses backend while it handles tasks delegated by the Live model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>? Tools { get; set; }

        /// <summary>
        /// Controls which tool the Responses backend uses when handling a task delegated by the Live model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponsesDelegationSettingsUpdateInputParam" /> class.
        /// </summary>
        /// <param name="model">
        /// The Responses backend model to use for subsequent delegated requests. Omit to keep the current backend model.
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="serviceTier"></param>
        /// <param name="reasoning"></param>
        /// <param name="text"></param>
        /// <param name="tools">
        /// Tools available to the Responses backend while it handles tasks delegated by the Live model.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which tool the Responses backend uses when handling a task delegated by the Live model.
        /// </param>
        /// <param name="parallelToolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveResponsesDelegationSettingsUpdateInputParam(
            string? model,
            string? instructions,
            int? maxOutputTokens,
            global::tryAGI.OpenAI.LiveResponsesServiceTier? serviceTier,
            global::tryAGI.OpenAI.LiveDelegationReasoningInputParam? reasoning,
            global::tryAGI.OpenAI.LiveDelegationTextInputParam? text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>? tools,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>? toolChoice,
            bool? parallelToolCalls)
        {
            this.Model = model;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.ServiceTier = serviceTier;
            this.Reasoning = reasoning;
            this.Text = text;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponsesDelegationSettingsUpdateInputParam" /> class.
        /// </summary>
        public LiveResponsesDelegationSettingsUpdateInputParam()
        {
        }

    }
}