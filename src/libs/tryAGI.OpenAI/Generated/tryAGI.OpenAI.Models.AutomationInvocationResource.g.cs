
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One attempted delivery by an automation.
    /// </summary>
    public sealed partial class AutomationInvocationResource
    {
        /// <summary>
        /// The invocation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `agent.automation.invocation`.<br/>
        /// Default Value: agent.automation.invocation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationInvocationResourceObject.AgentAutomationInvocation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationInvocationResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.AutomationInvocationResourceObject Object { get; set; } = global::tryAGI.OpenAI.AutomationInvocationResourceObject.AgentAutomationInvocation;

        /// <summary>
        /// The automation that owns the invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AutomationId { get; set; }

        /// <summary>
        /// The creation time as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Whether the invocation was manual or scheduled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationInvocationSourceResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationInvocationSourceResource Source { get; set; }

        /// <summary>
        /// The intended occurrence as a Unix timestamp in seconds, or null for manual runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ScheduledAt { get; set; }

        /// <summary>
        /// The target or newly created session ID, or null before one is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Delivery status; completed does not mean the agent's work has finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationInvocationStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationInvocationStatusResource Status { get; set; }

        /// <summary>
        /// Why an occurrence was skipped, or null when it was not skipped.<br/>
        /// Default Value: pending_delivery
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationInvocationResourceSkipReasonJsonConverter))]
        public global::tryAGI.OpenAI.AutomationInvocationResourceSkipReason? SkipReason { get; set; }

        /// <summary>
        /// The permanent delivery failure, or null when no failure occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.AutomationInvocationErrorResource? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationInvocationResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The invocation ID.
        /// </param>
        /// <param name="automationId">
        /// The automation that owns the invocation.
        /// </param>
        /// <param name="createdAt">
        /// The creation time as a Unix timestamp in seconds.
        /// </param>
        /// <param name="source">
        /// Whether the invocation was manual or scheduled.
        /// </param>
        /// <param name="status">
        /// Delivery status; completed does not mean the agent's work has finished.
        /// </param>
        /// <param name="scheduledAt">
        /// The intended occurrence as a Unix timestamp in seconds, or null for manual runs.
        /// </param>
        /// <param name="sessionId">
        /// The target or newly created session ID, or null before one is available.
        /// </param>
        /// <param name="skipReason">
        /// Why an occurrence was skipped, or null when it was not skipped.<br/>
        /// Default Value: pending_delivery
        /// </param>
        /// <param name="error">
        /// The permanent delivery failure, or null when no failure occurred.
        /// </param>
        /// <param name="object">
        /// Always `agent.automation.invocation`.<br/>
        /// Default Value: agent.automation.invocation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationInvocationResource(
            string id,
            string automationId,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.AutomationInvocationSourceResource source,
            global::tryAGI.OpenAI.AutomationInvocationStatusResource status,
            global::System.DateTimeOffset? scheduledAt,
            string? sessionId,
            global::tryAGI.OpenAI.AutomationInvocationResourceSkipReason? skipReason,
            global::tryAGI.OpenAI.AutomationInvocationErrorResource? error,
            global::tryAGI.OpenAI.AutomationInvocationResourceObject @object = global::tryAGI.OpenAI.AutomationInvocationResourceObject.AgentAutomationInvocation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.AutomationId = automationId ?? throw new global::System.ArgumentNullException(nameof(automationId));
            this.CreatedAt = createdAt;
            this.Source = source;
            this.ScheduledAt = scheduledAt;
            this.SessionId = sessionId;
            this.Status = status;
            this.SkipReason = skipReason;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationInvocationResource" /> class.
        /// </summary>
        public AutomationInvocationResource()
        {
        }

    }
}