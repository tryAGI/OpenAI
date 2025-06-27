
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when a fine-tuning job has succeeded.
    /// </summary>
    public sealed partial class WebhookFineTuningJobSucceeded
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the fine-tuning job succeeded.
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
        public required global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData Data { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobSucceededObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededObject? Object { get; set; }

        /// <summary>
        /// The type of the event. Always `fine_tuning.job.succeeded`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobSucceededTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFineTuningJobSucceeded" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the fine-tuning job succeeded.
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
        /// The type of the event. Always `fine_tuning.job.succeeded`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookFineTuningJobSucceeded(
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData data,
            string id,
            global::tryAGI.OpenAI.WebhookFineTuningJobSucceededObject? @object,
            global::tryAGI.OpenAI.WebhookFineTuningJobSucceededType type)
        {
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFineTuningJobSucceeded" /> class.
        /// </summary>
        public WebhookFineTuningJobSucceeded()
        {
        }
    }
}