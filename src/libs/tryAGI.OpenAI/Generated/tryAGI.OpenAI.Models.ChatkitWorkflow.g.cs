
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Workflow metadata and state returned for the session.
    /// </summary>
    public sealed partial class ChatkitWorkflow
    {
        /// <summary>
        /// Identifier of the workflow backing the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? StateVariables { get; set; }

        /// <summary>
        /// Tracing settings applied to the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatkitWorkflowTracing Tracing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatkitWorkflow" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the workflow backing the session.
        /// </param>
        /// <param name="version"></param>
        /// <param name="stateVariables"></param>
        /// <param name="tracing">
        /// Tracing settings applied to the workflow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatkitWorkflow(
            string id,
            string? version,
            object? stateVariables,
            global::tryAGI.OpenAI.ChatkitWorkflowTracing tracing)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.StateVariables = stateVariables ?? throw new global::System.ArgumentNullException(nameof(stateVariables));
            this.Tracing = tracing ?? throw new global::System.ArgumentNullException(nameof(tracing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatkitWorkflow" /> class.
        /// </summary>
        public ChatkitWorkflow()
        {
        }
    }
}