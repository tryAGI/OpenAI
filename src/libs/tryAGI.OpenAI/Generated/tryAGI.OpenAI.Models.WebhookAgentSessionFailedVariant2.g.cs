
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAgentSessionFailedVariant2
    {
        /// <summary>
        /// The event type. Always `agent.session.failed`.
        /// </summary>
        /// <default>"agent.session.failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent.session.failed";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionFailedVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// The event type. Always `agent.session.failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAgentSessionFailedVariant2(
            global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource data,
            string type = "agent.session.failed")
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionFailedVariant2" /> class.
        /// </summary>
        public WebhookAgentSessionFailedVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebhookAgentSessionFailedVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebhookAgentSessionFailedVariant2 FromData(global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource data)
        {
            return new WebhookAgentSessionFailedVariant2
            {
                Data = data,
            };
        }

    }
}