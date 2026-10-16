
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Questions evaluated using the current transcript and the session's shared Decision items.
    /// </summary>
    public sealed partial class LiveDecisionQuestionsInputParam2
    {
        /// <summary>
        /// Native Decision API questions evaluated together, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionQuestionsInputParam2" /> class.
        /// </summary>
        /// <param name="questions">
        /// Native Decision API questions evaluated together, in order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionQuestionsInputParam2(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> questions)
        {
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionQuestionsInputParam2" /> class.
        /// </summary>
        public LiveDecisionQuestionsInputParam2()
        {
        }

    }
}