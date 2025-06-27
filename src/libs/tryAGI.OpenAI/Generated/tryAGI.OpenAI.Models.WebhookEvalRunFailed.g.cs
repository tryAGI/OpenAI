
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an eval run has failed.
    /// </summary>
    public sealed partial class WebhookEvalRunFailed
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the eval run failed.
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
        public required global::tryAGI.OpenAI.WebhookEvalRunFailedData Data { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunFailedObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookEvalRunFailedObject? Object { get; set; }

        /// <summary>
        /// The type of the event. Always `eval.run.failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunFailedTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookEvalRunFailedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvalRunFailed" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the eval run failed.
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
        /// The type of the event. Always `eval.run.failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEvalRunFailed(
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.WebhookEvalRunFailedData data,
            string id,
            global::tryAGI.OpenAI.WebhookEvalRunFailedObject? @object,
            global::tryAGI.OpenAI.WebhookEvalRunFailedType type)
        {
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvalRunFailed" /> class.
        /// </summary>
        public WebhookEvalRunFailed()
        {
        }
    }
}