
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaTokenCountsBody
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::tryAGI.OpenAI.BetaResponseTextParam? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.BetaReasoning? Reasoning { get; set; }

        /// <summary>
        /// The truncation strategy to use for the model response. - `auto`: If the input to this Response exceeds the model's context window size, the model will truncate the response to fit the context window by dropping items from the beginning of the conversation. - `disabled` (default): If the input size will exceed the context window size for a model, the request will fail with a 400 error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaTruncationEnumJsonConverter))]
        public global::tryAGI.OpenAI.BetaTruncationEnum? Truncation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// A model-owned style preset to apply to this request. Omit this parameter to use the model's default style. Supported values may expand over time. Values must be at most 64 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaPersonalityEnumJsonConverter))]
        public global::tryAGI.OpenAI.BetaPersonalityEnum? Personality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::tryAGI.OpenAI.BetaConversationParam? Conversation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::tryAGI.OpenAI.BetaToolChoiceParam? ToolChoice { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaTokenCountsBody" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="tools"></param>
        /// <param name="text"></param>
        /// <param name="reasoning"></param>
        /// <param name="instructions"></param>
        /// <param name="personality">
        /// A model-owned style preset to apply to this request. Omit this parameter to use the model's default style. Supported values may expand over time. Values must be at most 64 characters.
        /// </param>
        /// <param name="conversation"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTokenCountsBody(
            string? model,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? input,
            string? previousResponseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? tools,
            global::tryAGI.OpenAI.BetaResponseTextParam? text,
            global::tryAGI.OpenAI.BetaReasoning? reasoning,
            string? instructions,
            global::tryAGI.OpenAI.BetaPersonalityEnum? personality,
            global::tryAGI.OpenAI.BetaConversationParam? conversation,
            global::tryAGI.OpenAI.BetaToolChoiceParam? toolChoice,
            bool? parallelToolCalls)
        {
            this.Model = model;
            this.Input = input;
            this.PreviousResponseId = previousResponseId;
            this.Tools = tools;
            this.Text = text;
            this.Reasoning = reasoning;
            this.Instructions = instructions;
            this.Personality = personality;
            this.Conversation = conversation;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTokenCountsBody" /> class.
        /// </summary>
        public BetaTokenCountsBody()
        {
        }

    }
}