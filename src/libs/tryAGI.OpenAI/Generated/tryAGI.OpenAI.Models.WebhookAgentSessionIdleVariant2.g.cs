
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAgentSessionIdleVariant2
    {
        /// <summary>
        /// The event type. Always `agent.session.idle`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionIdleVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookAgentSessionIdleVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// The event type. Always `agent.session.idle`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAgentSessionIdleVariant2(
            global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource data,
            global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionIdleVariant2" /> class.
        /// </summary>
        public WebhookAgentSessionIdleVariant2()
        {
        }

    }
}