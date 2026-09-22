
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookEndpointWithSecretResource
    {
        /// <summary>
        /// The unique ID of the webhook endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always webhook_endpoint.<br/>
        /// Default Value: webhook_endpoint
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject.WebhookEndpoint</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEndpointWithSecretResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject Object { get; set; } = global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject.WebhookEndpoint;

        /// <summary>
        /// The Unix timestamp when the endpoint was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp of the last endpoint configuration or signing-secret change. Initialized at creation; tests and unchanged updates do not advance it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// The human-readable name of the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The HTTPS URL that receives webhook deliveries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The event types that trigger deliveries to this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EventTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret_hint")]
        public string? SigningSecretHint { get; set; }

        /// <summary>
        /// The endpoint's signing secret. This is returned only when the endpoint is created or the secret is rotated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SigningSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointWithSecretResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the webhook endpoint.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp when the endpoint was created.
        /// </param>
        /// <param name="name">
        /// The human-readable name of the endpoint.
        /// </param>
        /// <param name="url">
        /// The HTTPS URL that receives webhook deliveries.
        /// </param>
        /// <param name="eventTypes">
        /// The event types that trigger deliveries to this endpoint.
        /// </param>
        /// <param name="signingSecret">
        /// The endpoint's signing secret. This is returned only when the endpoint is created or the secret is rotated.
        /// </param>
        /// <param name="updatedAt">
        /// The Unix timestamp of the last endpoint configuration or signing-secret change. Initialized at creation; tests and unchanged updates do not advance it.
        /// </param>
        /// <param name="signingSecretHint"></param>
        /// <param name="object">
        /// The object type, which is always webhook_endpoint.<br/>
        /// Default Value: webhook_endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEndpointWithSecretResource(
            string id,
            int createdAt,
            string name,
            string url,
            global::System.Collections.Generic.IList<string> eventTypes,
            string signingSecret,
            int? updatedAt,
            string? signingSecretHint,
            global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject @object = global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject.WebhookEndpoint)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
            this.SigningSecretHint = signingSecretHint;
            this.SigningSecret = signingSecret ?? throw new global::System.ArgumentNullException(nameof(signingSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointWithSecretResource" /> class.
        /// </summary>
        public WebhookEndpointWithSecretResource()
        {
        }

    }
}