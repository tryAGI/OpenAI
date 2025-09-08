
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Granular configuration for tracing.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestGATracingEnum2
    {
        /// <summary>
        /// The group id to attach to this trace to enable filtering and<br/>
        /// grouping in the Traces Dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The arbitrary metadata to attach to this trace to enable<br/>
        /// filtering in the Traces Dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The name of the workflow to attach to this trace. This is used to<br/>
        /// name the trace in the Traces Dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGATracingEnum2" /> class.
        /// </summary>
        /// <param name="groupId">
        /// The group id to attach to this trace to enable filtering and<br/>
        /// grouping in the Traces Dashboard.
        /// </param>
        /// <param name="metadata">
        /// The arbitrary metadata to attach to this trace to enable<br/>
        /// filtering in the Traces Dashboard.
        /// </param>
        /// <param name="workflowName">
        /// The name of the workflow to attach to this trace. This is used to<br/>
        /// name the trace in the Traces Dashboard.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestGATracingEnum2(
            string? groupId,
            object? metadata,
            string? workflowName)
        {
            this.GroupId = groupId;
            this.Metadata = metadata;
            this.WorkflowName = workflowName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGATracingEnum2" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestGATracingEnum2()
        {
        }
    }
}