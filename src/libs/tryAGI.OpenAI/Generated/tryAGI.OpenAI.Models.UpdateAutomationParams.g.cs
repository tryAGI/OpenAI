
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates configuration; timing fields must match the stored automation type.
    /// </summary>
    public sealed partial class UpdateAutomationParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Replaces the complete target, retaining its type and any creator session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetParamJsonConverter))]
        public global::tryAGI.OpenAI.AutomationTargetParam? Target { get; set; }

        /// <summary>
        /// Replaces all metadata; omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Only accepted for periodic automations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        public string? Expression { get; set; }

        /// <summary>
        /// Only accepted for periodic automations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// A future Unix timestamp in seconds; accepted only before a one-time scheduled invocation exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? RunAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutomationParams" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="target">
        /// Replaces the complete target, retaining its type and any creator session.
        /// </param>
        /// <param name="metadata">
        /// Replaces all metadata; omit to leave unchanged.
        /// </param>
        /// <param name="expression">
        /// Only accepted for periodic automations.
        /// </param>
        /// <param name="timezone">
        /// Only accepted for periodic automations.
        /// </param>
        /// <param name="runAt">
        /// A future Unix timestamp in seconds; accepted only before a one-time scheduled invocation exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAutomationParams(
            string? name,
            global::tryAGI.OpenAI.AutomationTargetParam? target,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? expression,
            string? timezone,
            global::System.DateTimeOffset? runAt)
        {
            this.Name = name;
            this.Target = target;
            this.Metadata = metadata;
            this.Expression = expression;
            this.Timezone = timezone;
            this.RunAt = runAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutomationParams" /> class.
        /// </summary>
        public UpdateAutomationParams()
        {
        }

    }
}