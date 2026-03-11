
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls diagnostic tracing during the session.
    /// </summary>
    public sealed partial class ChatkitWorkflowTracing
    {
        /// <summary>
        /// Indicates whether tracing is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatkitWorkflowTracing" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates whether tracing is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatkitWorkflowTracing(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatkitWorkflowTracing" /> class.
        /// </summary>
        public ChatkitWorkflowTracing()
        {
        }
    }
}