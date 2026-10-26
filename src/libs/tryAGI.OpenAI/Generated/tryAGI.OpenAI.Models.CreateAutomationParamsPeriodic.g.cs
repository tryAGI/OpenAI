
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAutomationParamsPeriodic
    {
        /// <summary>
        /// The type of the object. Always `periodic`.<br/>
        /// Default Value: periodic
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateAutomationParamsPeriodicType.Periodic</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateAutomationParamsPeriodicTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodicType Type { get; set; } = global::tryAGI.OpenAI.CreateAutomationParamsPeriodicType.Periodic;

        /// <summary>
        /// A human-readable name for the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The session an automation invocation targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationTargetParam Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// A standard five-field cron expression defining scheduled occurrences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        /// The IANA timezone used to interpret the cron expression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomationParamsPeriodic" /> class.
        /// </summary>
        /// <param name="name">
        /// A human-readable name for the automation.
        /// </param>
        /// <param name="target">
        /// The session an automation invocation targets.
        /// </param>
        /// <param name="expression">
        /// A standard five-field cron expression defining scheduled occurrences.
        /// </param>
        /// <param name="timezone">
        /// The IANA timezone used to interpret the cron expression.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="type">
        /// The type of the object. Always `periodic`.<br/>
        /// Default Value: periodic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAutomationParamsPeriodic(
            string name,
            global::tryAGI.OpenAI.AutomationTargetParam target,
            string expression,
            string timezone,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.CreateAutomationParamsPeriodicType type = global::tryAGI.OpenAI.CreateAutomationParamsPeriodicType.Periodic)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Target = target;
            this.Metadata = metadata;
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomationParamsPeriodic" /> class.
        /// </summary>
        public CreateAutomationParamsPeriodic()
        {
        }

    }
}