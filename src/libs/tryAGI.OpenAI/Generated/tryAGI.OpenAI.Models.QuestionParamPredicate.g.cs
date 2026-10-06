
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QuestionParamPredicate
    {
        /// <summary>
        /// The type of the object. Always `predicate`.<br/>
        /// Default Value: predicate
        /// </summary>
        /// <default>global::tryAGI.OpenAI.QuestionParamPredicateType.Predicate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.QuestionParamPredicateTypeJsonConverter))]
        public global::tryAGI.OpenAI.QuestionParamPredicateType Type { get; set; } = global::tryAGI.OpenAI.QuestionParamPredicateType.Predicate;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionParamPredicate" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the object. Always `predicate`.<br/>
        /// Default Value: predicate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionParamPredicate(
            string instructions,
            string? name,
            global::tryAGI.OpenAI.QuestionParamPredicateType type = global::tryAGI.OpenAI.QuestionParamPredicateType.Predicate)
        {
            this.Type = type;
            this.Name = name;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionParamPredicate" /> class.
        /// </summary>
        public QuestionParamPredicate()
        {
        }

        /// <summary>
        /// Creates a new <see cref="QuestionParamPredicate"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static QuestionParamPredicate FromInstructions(string instructions)
        {
            return new QuestionParamPredicate
            {
                Instructions = instructions,
            };
        }

    }
}