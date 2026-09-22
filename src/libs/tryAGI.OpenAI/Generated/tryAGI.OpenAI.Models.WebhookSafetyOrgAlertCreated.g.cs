
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an approved safety alert is available for an enterprise workspace.
    /// </summary>
    public sealed partial class WebhookSafetyOrgAlertCreated
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookSafetyOrgAlertCreatedObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp in seconds when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Always `safety.org_alert.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookSafetyOrgAlertCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSafetyOrgAlertCreated" /> class.
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
        /// Always `safety.org_alert.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSafetyOrgAlertCreated(
            string id,
            int createdAt,
            global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedData data,
            global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedObject @object,
            global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSafetyOrgAlertCreated" /> class.
        /// </summary>
        public WebhookSafetyOrgAlertCreated()
        {
        }

    }
}