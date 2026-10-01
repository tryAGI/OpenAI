
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAgentSessionActionRequiredVariant2
    {
        /// <summary>
        /// The event type. Always `agent.session.action_required`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionActionRequiredVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionActionRequiredVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// The event type. Always `agent.session.action_required`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAgentSessionActionRequiredVariant2(
            global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource data,
            global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionActionRequiredVariant2" /> class.
        /// </summary>
        public WebhookAgentSessionActionRequiredVariant2()
        {
        }

    }
}