
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when a fine-tuning job has failed.
    /// </summary>
    public sealed partial class WebhookFineTuningJobFailed
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the fine-tuning job failed.
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
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedData Data { get; set; } = default!;

        /// <summary>
        /// The object of the event. Always `event`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobFailedObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedObject? Object { get; set; }

        /// <summary>
        /// The type of the event. Always `fine_tuning.job.failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobFailedTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFineTuningJobFailed" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the fine-tuning job failed.
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
        /// The type of the event. Always `fine_tuning.job.failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookFineTuningJobFailed(
            global::System.DateTimeOffset createdAt,
            string id,
            global::tryAGI.OpenAI.WebhookFineTuningJobFailedData data,
            global::tryAGI.OpenAI.WebhookFineTuningJobFailedObject? @object,
            global::tryAGI.OpenAI.WebhookFineTuningJobFailedType type)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFineTuningJobFailed" /> class.
        /// </summary>
        public WebhookFineTuningJobFailed()
        {
        }
    }
}