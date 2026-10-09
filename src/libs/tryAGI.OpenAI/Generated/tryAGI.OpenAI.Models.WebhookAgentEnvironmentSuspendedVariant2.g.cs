
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAgentEnvironmentSuspendedVariant2
    {
        /// <summary>
        /// The event type. Always `agent.environment.suspended`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentSuspendedVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type Type { get; set; }

        /// <summary>
        /// Identifies the environment whose lifecycle changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AgentEnvironmentEvent Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentEnvironmentSuspendedVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// Identifies the environment whose lifecycle changed.
        /// </param>
        /// <param name="type">
        /// The event type. Always `agent.environment.suspended`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAgentEnvironmentSuspendedVariant2(
            global::tryAGI.OpenAI.AgentEnvironmentEvent data,
            global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentEnvironmentSuspendedVariant2" /> class.
        /// </summary>
        public WebhookAgentEnvironmentSuspendedVariant2()
        {
        }

    }
}