
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Fields shared by periodic and one-time automations.
    /// </summary>
    public sealed partial class AutomationResourcePeriodic
    {
        /// <summary>
        /// The type of the object. Always `periodic`.<br/>
        /// Default Value: periodic
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationResourcePeriodicType.Periodic</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationResourcePeriodicTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationResourcePeriodicType Type { get; set; } = global::tryAGI.OpenAI.AutomationResourcePeriodicType.Periodic;

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
        /// <default>global::tryAGI.OpenAI.AutomationResourcePeriodicObject.AgentAutomation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationResourcePeriodicObjectJsonConverter))]
        public global::tryAGI.OpenAI.AutomationResourcePeriodicObject Object { get; set; } = global::tryAGI.OpenAI.AutomationResourcePeriodicObject.AgentAutomation;

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
        /// The cron expression determining scheduled occurrences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        /// The timezone used to interpret the expression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Whether scheduled delivery is active or paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PeriodicAutomationStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.PeriodicAutomationStatusResource Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationResourcePeriodic" /> class.
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
        /// <param name="expression">
        /// The cron expression determining scheduled occurrences.
        /// </param>
        /// <param name="timezone">
        /// The timezone used to interpret the expression.
        /// </param>
        /// <param name="status">
        /// Whether scheduled delivery is active or paused.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `periodic`.<br/>
        /// Default Value: periodic
        /// </param>
        /// <param name="object">
        /// Always `agent.automation`.<br/>
        /// Default Value: agent.automation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationResourcePeriodic(
            string id,
            global::System.DateTimeOffset createdAt,
            string name,
            global::tryAGI.OpenAI.AutomationTargetResource target,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::tryAGI.OpenAI.AutomationCreatedByResource createdBy,
            string expression,
            string timezone,
            global::tryAGI.OpenAI.PeriodicAutomationStatusResource status,
            global::tryAGI.OpenAI.AutomationResourcePeriodicType type = global::tryAGI.OpenAI.AutomationResourcePeriodicType.Periodic,
            global::tryAGI.OpenAI.AutomationResourcePeriodicObject @object = global::tryAGI.OpenAI.AutomationResourcePeriodicObject.AgentAutomation)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Target = target;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedBy = createdBy;
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationResourcePeriodic" /> class.
        /// </summary>
        public AutomationResourcePeriodic()
        {
        }

    }
}