
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAgentSessionCreatedVariant2
    {
        /// <summary>
        /// The event type. Always `agent.session.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionCreatedVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionCreatedVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// The event type. Always `agent.session.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAgentSessionCreatedVariant2(
            global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource data,
            global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionCreatedVariant2" /> class.
        /// </summary>
        public WebhookAgentSessionCreatedVariant2()
        {
        }

    }
}