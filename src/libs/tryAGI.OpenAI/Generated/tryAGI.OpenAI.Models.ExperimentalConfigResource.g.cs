
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The effective experimental settings for an agent.
    /// </summary>
    public sealed partial class ExperimentalConfigResource
    {
        /// <summary>
        /// Whether the model receives periodic current-time reminders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_awareness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TimeAwareness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalConfigResource" /> class.
        /// </summary>
        /// <param name="timeAwareness">
        /// Whether the model receives periodic current-time reminders.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentalConfigResource(
            bool timeAwareness)
        {
            this.TimeAwareness = timeAwareness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalConfigResource" /> class.
        /// </summary>
        public ExperimentalConfigResource()
        {
        }

    }
}