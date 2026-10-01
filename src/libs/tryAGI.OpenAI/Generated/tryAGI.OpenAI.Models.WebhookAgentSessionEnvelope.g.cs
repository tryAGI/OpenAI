
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAgentSessionEnvelope
    {
        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `event`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionEnvelopeObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionEnvelope" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the event.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, when the event was created.
        /// </param>
        /// <param name="object">
        /// The object type. Always `event`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAgentSessionEnvelope(
            string id,
            int createdAt,
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAgentSessionEnvelope" /> class.
        /// </summary>
        public WebhookAgentSessionEnvelope()
        {
        }

    }
}