
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
        /// <default>"agent.environment.suspended"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent.environment.suspended";

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
            string type = "agent.environment.suspended")
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

        /// <summary>
        /// Creates a new <see cref="WebhookAgentEnvironmentSuspendedVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebhookAgentEnvironmentSuspendedVariant2 FromData(global::tryAGI.OpenAI.AgentEnvironmentEvent data)
        {
            return new WebhookAgentEnvironmentSuspendedVariant2
            {
                Data = data,
            };
        }

    }
}