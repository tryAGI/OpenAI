
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when a fine-tuning job has been cancelled.
    /// </summary>
    public sealed partial class WebhookFineTuningJobCancelled
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the fine-tuning job was cancelled.
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
        public required global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData Data { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobCancelledObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledObject? Object { get; set; }

        /// <summary>
        /// The type of the event. Always `fine_tuning.job.cancelled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobCancelledTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFineTuningJobCancelled" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the fine-tuning job was cancelled.
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
        /// The type of the event. Always `fine_tuning.job.cancelled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookFineTuningJobCancelled(
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData data,
            string id,
            global::tryAGI.OpenAI.WebhookFineTuningJobCancelledObject? @object,
            global::tryAGI.OpenAI.WebhookFineTuningJobCancelledType type)
        {
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFineTuningJobCancelled" /> class.
        /// </summary>
        public WebhookFineTuningJobCancelled()
        {
        }
    }
}