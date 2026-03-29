
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
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_variables")]
        public object? StateVariables { get; set; }

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
        /// <param name="tracing">
        /// Tracing settings applied to the workflow.
        /// </param>
        /// <param name="version"></param>
        /// <param name="stateVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatkitWorkflow(
            string id,
            global::tryAGI.OpenAI.ChatkitWorkflowTracing tracing,
            string? version,
            object? stateVariables)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.StateVariables = stateVariables;
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