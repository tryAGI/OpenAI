
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Details on why the run is incomplete. Will be `null` if the run is not incomplete.
    /// </summary>
    public sealed partial class RunObjectIncompleteDetails
    {
        /// <summary>
        /// The reason why the run is incomplete. This will point to which specific token limit was reached over the course of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter))]
        public global::OpenAI.RunObjectIncompleteDetailsReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectIncompleteDetails" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason why the run is incomplete. This will point to which specific token limit was reached over the course of the run.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunObjectIncompleteDetails(
            global::OpenAI.RunObjectIncompleteDetailsReason? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectIncompleteDetails" /> class.
        /// </summary>
        public RunObjectIncompleteDetails()
        {
        }
    }
}