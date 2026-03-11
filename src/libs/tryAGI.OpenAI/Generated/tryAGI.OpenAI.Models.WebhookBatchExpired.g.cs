
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when a batch API request has expired.
    /// </summary>
    public sealed partial class WebhookBatchExpired
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the batch API request expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Event data payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.WebhookBatchExpiredData Data { get; set; } = default!;

        /// <summary>
        /// The object of the event. Always `event`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchExpiredObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookBatchExpiredObject? Object { get; set; }

        /// <summary>
        /// The type of the event. Always `batch.expired`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchExpiredTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookBatchExpiredType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBatchExpired" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the batch API request expired.
        /// </param>
        /// <param name="id">
        /// The unique ID of the event.
        /// </param>
        /// <param name="data">
        /// Event data payload.
        /// </param>
        /// <param name="object">
        /// The object of the event. Always `event`.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `batch.expired`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBatchExpired(
            global::System.DateTimeOffset createdAt,
            string id,
            global::tryAGI.OpenAI.WebhookBatchExpiredData data,
            global::tryAGI.OpenAI.WebhookBatchExpiredObject? @object,
            global::tryAGI.OpenAI.WebhookBatchExpiredType type)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBatchExpired" /> class.
        /// </summary>
        public WebhookBatchExpired()
        {
        }
    }
}