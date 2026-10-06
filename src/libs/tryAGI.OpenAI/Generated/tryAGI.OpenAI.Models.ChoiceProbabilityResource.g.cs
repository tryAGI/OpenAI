
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChoiceProbabilityResource
    {
        /// <summary>
        /// Choice values are typed: a string and a boolean with the same text are distinct.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChoiceValueResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChoiceValueResource Value { get; set; }

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
        /// Initializes a new instance of the <see cref="ChoiceProbabilityResource" /> class.
        /// </summary>
        /// <param name="value">
        /// Choice values are typed: a string and a boolean with the same text are distinct.
        /// </param>
        /// <param name="probability"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChoiceProbabilityResource(
            global::tryAGI.OpenAI.ChoiceValueResource value,
            double probability)
        {
            this.Value = value;
            this.Probability = probability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceProbabilityResource" /> class.
        /// </summary>
        public ChoiceProbabilityResource()
        {
        }

    }
}