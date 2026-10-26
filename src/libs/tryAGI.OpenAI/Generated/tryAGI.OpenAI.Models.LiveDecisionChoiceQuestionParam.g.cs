
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionChoiceQuestionParam
    {
        /// <summary>
        /// Default Value: choice
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType.Choice</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionChoiceQuestionParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType.Choice;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item>> Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionChoiceParam> Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionChoiceQuestionParam" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="choices"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: choice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionChoiceQuestionParam(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item>> instructions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionChoiceParam> choices,
            string? name,
            global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType type = global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType.Choice)
        {
            this.Type = type;
            this.Name = name;
            this.Instructions = instructions;
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionChoiceQuestionParam" /> class.
        /// </summary>
        public LiveDecisionChoiceQuestionParam()
        {
        }

    }
}