
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionCompleted
    {
        /// <summary>
        /// Default Value: decision.completed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionCompletedType.DecisionCompleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionCompletedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionCompletedType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionCompletedType.DecisionCompleted;

        /// <summary>
        /// The native Decision API response, including its model, ordered answers, and token usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionResponse Decision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionCompleted" /> class.
        /// </summary>
        /// <param name="decision">
        /// The native Decision API response, including its model, ordered answers, and token usage.
        /// </param>
        /// <param name="type">
        /// Default Value: decision.completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionCompleted(
            global::tryAGI.OpenAI.DecisionResponse decision,
            global::tryAGI.OpenAI.LiveDecisionCompletedType type = global::tryAGI.OpenAI.LiveDecisionCompletedType.DecisionCompleted)
        {
            this.Type = type;
            this.Decision = decision ?? throw new global::System.ArgumentNullException(nameof(decision));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionCompleted" /> class.
        /// </summary>
        public LiveDecisionCompleted()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionCompleted"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionCompleted FromDecision(global::tryAGI.OpenAI.DecisionResponse decision)
        {
            return new LiveDecisionCompleted
            {
                Decision = decision,
            };
        }

    }
}