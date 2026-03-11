
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Workflow reference and overrides applied to the chat session.
    /// </summary>
    public sealed partial class WorkflowParam
    {
        /// <summary>
        /// Identifier for the workflow invoked by the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Specific workflow version to run. Defaults to the latest deployed version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// State variables forwarded to the workflow. Keys may be up to 64 characters, values must be primitive types, and the map defaults to an empty object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_variables")]
        public object? StateVariables { get; set; }

        /// <summary>
        /// Optional tracing overrides for the workflow invocation. When omitted, tracing is enabled by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::tryAGI.OpenAI.WorkflowTracingParam? Tracing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowParam" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the workflow invoked by the session.
        /// </param>
        /// <param name="version">
        /// Specific workflow version to run. Defaults to the latest deployed version.
        /// </param>
        /// <param name="stateVariables">
        /// State variables forwarded to the workflow. Keys may be up to 64 characters, values must be primitive types, and the map defaults to an empty object.
        /// </param>
        /// <param name="tracing">
        /// Optional tracing overrides for the workflow invocation. When omitted, tracing is enabled by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowParam(
            string id,
            string? version,
            object? stateVariables,
            global::tryAGI.OpenAI.WorkflowTracingParam? tracing)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.StateVariables = stateVariables;
            this.Tracing = tracing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowParam" /> class.
        /// </summary>
        public WorkflowParam()
        {
        }
    }
}