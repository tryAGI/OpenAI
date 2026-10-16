
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionsSettingsUpdateParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Native Decision API questions evaluated together, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>? Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsSettingsUpdateParam" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="questions">
        /// Native Decision API questions evaluated together, in order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionsSettingsUpdateParam(
            string? model,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>? questions)
        {
            this.Model = model;
            this.Questions = questions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsSettingsUpdateParam" /> class.
        /// </summary>
        public LiveDecisionsSettingsUpdateParam()
        {
        }

    }
}