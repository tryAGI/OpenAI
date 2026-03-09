
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls diagnostic tracing during the session.
    /// </summary>
    public sealed partial class WorkflowTracingParam
    {
        /// <summary>
        /// Whether tracing is enabled during the session. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTracingParam" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether tracing is enabled during the session. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowTracingParam(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTracingParam" /> class.
        /// </summary>
        public WorkflowTracingParam()
        {
        }
    }
}