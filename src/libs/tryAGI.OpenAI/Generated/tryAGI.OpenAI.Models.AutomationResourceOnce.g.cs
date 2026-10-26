
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Fields shared by periodic and one-time automations.
    /// </summary>
    public sealed partial class AutomationResourceOnce
    {
        /// <summary>
        /// The type of the object. Always `once`.<br/>
        /// Default Value: once
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationResourceOnceType.Once</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationResourceOnceTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationResourceOnceType Type { get; set; } = global::tryAGI.OpenAI.AutomationResourceOnceType.Once;

        /// <summary>
        /// The automation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `agent.automation`.<br/>
        /// Default Value: agent.automation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationResourceOnceObject.AgentAutomation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationResourceOnceObjectJsonConverter))]
        public global::tryAGI.OpenAI.AutomationResourceOnceObject Object { get; set; } = global::tryAGI.OpenAI.AutomationResourceOnceObject.AgentAutomation;

        /// <summary>
        /// The creation time as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The automation's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The session configuration or existing session receiving invocations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationTargetResource Target { get; set; }

        /// <summary>
        /// Custom string key-value pairs attached to the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Service-recorded provenance; callers cannot supply this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationCreatedByResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationCreatedByResource CreatedBy { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, of the scheduled occurrence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset RunAt { get; set; }

        /// <summary>
        /// Completion means the schedule has finished, not the agent's work.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OnceAutomationStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OnceAutomationStatusResource Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationResourceOnce" /> class.
        /// </summary>
        /// <param name="id">
        /// The automation ID.
        /// </param>
        /// <param name="createdAt">
        /// The creation time as a Unix timestamp in seconds.
        /// </param>
        /// <param name="name">
        /// The automation's display name.
        /// </param>
        /// <param name="target">
        /// The session configuration or existing session receiving invocations.
        /// </param>
        /// <param name="metadata">
        /// Custom string key-value pairs attached to the automation.
        /// </param>
        /// <param name="createdBy">
        /// Service-recorded provenance; callers cannot supply this field.
        /// </param>
        /// <param name="runAt">
        /// The Unix timestamp, in seconds, of the scheduled occurrence.
        /// </param>
        /// <param name="status">
        /// Completion means the schedule has finished, not the agent's work.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `once`.<br/>
        /// Default Value: once
        /// </param>
        /// <param name="object">
        /// Always `agent.automation`.<br/>
        /// Default Value: agent.automation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationResourceOnce(
            string id,
            global::System.DateTimeOffset createdAt,
            string name,
            global::tryAGI.OpenAI.AutomationTargetResource target,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::tryAGI.OpenAI.AutomationCreatedByResource createdBy,
            global::System.DateTimeOffset runAt,
            global::tryAGI.OpenAI.OnceAutomationStatusResource status,
            global::tryAGI.OpenAI.AutomationResourceOnceType type = global::tryAGI.OpenAI.AutomationResourceOnceType.Once,
            global::tryAGI.OpenAI.AutomationResourceOnceObject @object = global::tryAGI.OpenAI.AutomationResourceOnceObject.AgentAutomation)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Target = target;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedBy = createdBy;
            this.RunAt = runAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationResourceOnce" /> class.
        /// </summary>
        public AutomationResourceOnce()
        {
        }

    }
}