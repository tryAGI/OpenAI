
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an approved safety alert is available for an API project.
    /// </summary>
    public sealed partial class WebhookSafetyAlertCreated
    {
        /// <summary>
        /// The unique ID of the webhook event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `event`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookSafetyAlertCreatedObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp in seconds when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Always `safety.alert.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookSafetyAlertCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebhookSafetyAlertCreatedData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSafetyAlertCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the webhook event.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp in seconds when the event was created.
        /// </param>
        /// <param name="data"></param>
        /// <param name="object">
        /// Always `event`.
        /// </param>
        /// <param name="type">
        /// Always `safety.alert.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSafetyAlertCreated(
            string id,
            int createdAt,
            global::tryAGI.OpenAI.WebhookSafetyAlertCreatedData data,
            global::tryAGI.OpenAI.WebhookSafetyAlertCreatedObject @object,
            global::tryAGI.OpenAI.WebhookSafetyAlertCreatedType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSafetyAlertCreated" /> class.
        /// </summary>
        public WebhookSafetyAlertCreated()
        {
        }

    }
}