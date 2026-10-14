
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionResponse
    {
        /// <summary>
        /// The model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Answers in question order. Any question can return a refusal instead of an answer; other questions can still receive answers. A refusal has `type: "refusal"` and the question's `name`, or `null` if it was unnamed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnswerResource> Answers { get; set; }

        /// <summary>
        /// Token usage for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseUsageResource Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used.
        /// </param>
        /// <param name="answers">
        /// Answers in question order. Any question can return a refusal instead of an answer; other questions can still receive answers. A refusal has `type: "refusal"` and the question's `name`, or `null` if it was unnamed.
        /// </param>
        /// <param name="usage">
        /// Token usage for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionResponse(
            string model,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnswerResource> answers,
            global::tryAGI.OpenAI.ResponseUsageResource usage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Answers = answers ?? throw new global::System.ArgumentNullException(nameof(answers));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionResponse" /> class.
        /// </summary>
        public DecisionResponse()
        {
        }

    }
}