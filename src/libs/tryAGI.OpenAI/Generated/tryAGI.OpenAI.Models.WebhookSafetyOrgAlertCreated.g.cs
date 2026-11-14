
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
        /// <default>"event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "event";

        /// <summary>
        /// The Unix timestamp in seconds when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Always `safety.org_alert.created`.
        /// </summary>
        /// <default>"safety.org_alert.created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "safety.org_alert.created";

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
            string @object = "event",
            string type = "safety.org_alert.created")
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