
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Experimental settings to update. Omitted settings keep their current values.
    /// </summary>
    public sealed partial class ExperimentalConfigOverridesParam
    {
        /// <summary>
        /// Whether to give the model periodic current-time reminders. Omit to keep the current setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_awareness")]
        public bool? TimeAwareness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalConfigOverridesParam" /> class.
        /// </summary>
        /// <param name="timeAwareness">
        /// Whether to give the model periodic current-time reminders. Omit to keep the current setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentalConfigOverridesParam(
            bool? timeAwareness)
        {
            this.TimeAwareness = timeAwareness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalConfigOverridesParam" /> class.
        /// </summary>
        public ExperimentalConfigOverridesParam()
        {
        }

    }
}