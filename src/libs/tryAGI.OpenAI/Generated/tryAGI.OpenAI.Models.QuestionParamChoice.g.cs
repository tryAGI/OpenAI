
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Choose from the supplied options based on the input.
    /// </summary>
    public sealed partial class QuestionParamChoice
    {
        /// <summary>
        /// The type of the object. Always `choice`.<br/>
        /// Default Value: choice
        /// </summary>
        /// <default>global::tryAGI.OpenAI.QuestionParamChoiceType.Choice</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.QuestionParamChoiceTypeJsonConverter))]
        public global::tryAGI.OpenAI.QuestionParamChoiceType Type { get; set; } = global::tryAGI.OpenAI.QuestionParamChoiceType.Choice;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Provide between 2 and 255 choices. Each choice must be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceOptionParam> Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionParamChoice" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="choices">
        /// Provide between 2 and 255 choices. Each choice must be unique.
        /// </param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the object. Always `choice`.<br/>
        /// Default Value: choice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionParamChoice(
            string instructions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceOptionParam> choices,
            string? name,
            global::tryAGI.OpenAI.QuestionParamChoiceType type = global::tryAGI.OpenAI.QuestionParamChoiceType.Choice)
        {
            this.Type = type;
            this.Name = name;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionParamChoice" /> class.
        /// </summary>
        public QuestionParamChoice()
        {
        }

    }
}