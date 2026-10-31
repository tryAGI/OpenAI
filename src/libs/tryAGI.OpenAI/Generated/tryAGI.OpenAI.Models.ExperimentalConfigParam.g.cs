
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Experimental agent settings. These features may change.
    /// </summary>
    public sealed partial class ExperimentalConfigParam
    {
        /// <summary>
        /// Whether to give the model periodic current-time reminders. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_awareness")]
        public bool? TimeAwareness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalConfigParam" /> class.
        /// </summary>
        /// <param name="timeAwareness">
        /// Whether to give the model periodic current-time reminders. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentalConfigParam(
            bool? timeAwareness)
        {
            this.TimeAwareness = timeAwareness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalConfigParam" /> class.
        /// </summary>
        public ExperimentalConfigParam()
        {
        }

    }
}