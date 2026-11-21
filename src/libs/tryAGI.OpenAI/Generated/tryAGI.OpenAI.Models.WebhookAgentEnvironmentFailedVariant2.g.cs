
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAgentEnvironmentFailedVariant2
    {
        /// <summary>
        /// The event type. Always `agent.environment.failed`.
        /// </summary>
        /// <default>"agent.environment.failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent.environment.failed";

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
        /// Initializes a new instance of the <see cref="WebhookAgentEnvironmentFailedVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// Identifies the environment whose lifecycle changed.
        /// </param>
        /// <param name="type">
        /// The event type. Always `agent.environment.failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAgentEnvironmentFailedVariant2(
            global::tryAGI.OpenAI.AgentEnvironmentEvent data,
            string type = "agent.environment.failed")
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentEnvironmentFailedVariant2" /> class.
        /// </summary>
        public WebhookAgentEnvironmentFailedVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebhookAgentEnvironmentFailedVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebhookAgentEnvironmentFailedVariant2 FromData(global::tryAGI.OpenAI.AgentEnvironmentEvent data)
        {
            return new WebhookAgentEnvironmentFailedVariant2
            {
                Data = data,
            };
        }

    }
}