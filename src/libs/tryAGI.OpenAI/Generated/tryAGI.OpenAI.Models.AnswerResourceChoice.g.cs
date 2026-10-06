
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerResourceChoice
    {
        /// <summary>
        /// The type of the object. Always `choice`.<br/>
        /// Default Value: choice
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AnswerResourceChoiceType.Choice</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnswerResourceChoiceTypeJsonConverter))]
        public global::tryAGI.OpenAI.AnswerResourceChoiceType Type { get; set; } = global::tryAGI.OpenAI.AnswerResourceChoiceType.Choice;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Choice values are typed: a string and a boolean with the same text are distinct.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChoiceValueResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChoiceValueResource Choice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceProbabilityResource> Probabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourceChoice" /> class.
        /// </summary>
        /// <param name="choice">
        /// Choice values are typed: a string and a boolean with the same text are distinct.
        /// </param>
        /// <param name="probabilities"></param>
        /// <param name="confidence"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the object. Always `choice`.<br/>
        /// Default Value: choice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResourceChoice(
            global::tryAGI.OpenAI.ChoiceValueResource choice,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceProbabilityResource> probabilities,
            double confidence,
            string? name,
            global::tryAGI.OpenAI.AnswerResourceChoiceType type = global::tryAGI.OpenAI.AnswerResourceChoiceType.Choice)
        {
            this.Type = type;
            this.Name = name;
            this.Choice = choice;
            this.Probabilities = probabilities ?? throw new global::System.ArgumentNullException(nameof(probabilities));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourceChoice" /> class.
        /// </summary>
        public AnswerResourceChoice()
        {
        }

    }
}