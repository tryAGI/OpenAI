
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionPredicateQuestionParam
    {
        /// <summary>
        /// Default Value: predicate
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType.Predicate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionPredicateQuestionParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType.Predicate;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item2>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item2>> Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionPredicateQuestionParam" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: predicate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionPredicateQuestionParam(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item2>> instructions,
            string? name,
            global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType type = global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType.Predicate)
        {
            this.Type = type;
            this.Name = name;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionPredicateQuestionParam" /> class.
        /// </summary>
        public LiveDecisionPredicateQuestionParam()
        {
        }

    }
}