
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerResourcePredicate
    {
        /// <summary>
        /// The type of the object. Always `predicate`.<br/>
        /// Default Value: predicate
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AnswerResourcePredicateType.Predicate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnswerResourcePredicateTypeJsonConverter))]
        public global::tryAGI.OpenAI.AnswerResourcePredicateType Type { get; set; } = global::tryAGI.OpenAI.AnswerResourcePredicateType.Predicate;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourcePredicate" /> class.
        /// </summary>
        /// <param name="probability"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the object. Always `predicate`.<br/>
        /// Default Value: predicate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResourcePredicate(
            double probability,
            string? name,
            global::tryAGI.OpenAI.AnswerResourcePredicateType type = global::tryAGI.OpenAI.AnswerResourcePredicateType.Predicate)
        {
            this.Type = type;
            this.Name = name;
            this.Probability = probability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourcePredicate" /> class.
        /// </summary>
        public AnswerResourcePredicate()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AnswerResourcePredicate"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AnswerResourcePredicate FromProbability(double probability)
        {
            return new AnswerResourcePredicate
            {
                Probability = probability,
            };
        }

    }
}