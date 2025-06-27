
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when a batch API request has been cancelled.
    /// </summary>
    public sealed partial class WebhookBatchCancelled
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the batch API request was cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Event data payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebhookBatchCancelledData Data { get; set; }

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object of the event. Always `event`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCancelledObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookBatchCancelledObject? Object { get; set; }

        /// <summary>
        /// The type of the event. Always `batch.cancelled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCancelledTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookBatchCancelledType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBatchCancelled" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the batch API request was cancelled.
        /// </param>
        /// <param name="data">
        /// Event data payload.
        /// </param>
        /// <param name="id">
        /// The unique ID of the event.
        /// </param>
        /// <param name="object">
        /// The object of the event. Always `event`.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `batch.cancelled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBatchCancelled(
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.WebhookBatchCancelledData data,
            string id,
            global::tryAGI.OpenAI.WebhookBatchCancelledObject? @object,
            global::tryAGI.OpenAI.WebhookBatchCancelledType type)
        {
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBatchCancelled" /> class.
        /// </summary>
        public WebhookBatchCancelled()
        {
        }
    }
}