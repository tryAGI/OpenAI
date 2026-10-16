
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionsSettingsInputParam
    {
        /// <summary>
        /// Native Decision API questions evaluated together, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionQuestion> Questions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsSettingsInputParam" /> class.
        /// </summary>
        /// <param name="questions">
        /// Native Decision API questions evaluated together, in order.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionsSettingsInputParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionQuestion> questions,
            string model)
        {
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsSettingsInputParam" /> class.
        /// </summary>
        public LiveDecisionsSettingsInputParam()
        {
        }

    }
}