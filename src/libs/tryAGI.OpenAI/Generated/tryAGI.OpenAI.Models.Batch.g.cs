
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CancelledAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelling_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CancellingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// The time frame within which the batch should be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionWindow { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The OpenAI API endpoint used by the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of requests with errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::tryAGI.OpenAI.BatchErrors? Errors { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiredAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalizing_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? FinalizingAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? InProgressAt { get; set; }

        /// <summary>
        /// The ID of the input file for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The object type, which is always `batch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BatchObjectJsonConverter))]
        public global::tryAGI.OpenAI.BatchObject Object { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// The request counts for different statuses within the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_counts")]
        public global::tryAGI.OpenAI.BatchRequestCounts? RequestCounts { get; set; }

        /// <summary>
        /// The current status of the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BatchStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="cancelledAt">
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </param>
        /// <param name="cancellingAt">
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </param>
        /// <param name="endpoint">
        /// The OpenAI API endpoint used by the batch.
        /// </param>
        /// <param name="errorFileId">
        /// The ID of the file containing the outputs of requests with errors.
        /// </param>
        /// <param name="errors"></param>
        /// <param name="expiredAt">
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </param>
        /// <param name="failedAt">
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </param>
        /// <param name="finalizingAt">
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </param>
        /// <param name="id"></param>
        /// <param name="inProgressAt">
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </param>
        /// <param name="inputFileId">
        /// The ID of the input file for the batch.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `batch`.
        /// </param>
        /// <param name="outputFileId">
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </param>
        /// <param name="requestCounts">
        /// The request counts for different statuses within the batch.
        /// </param>
        /// <param name="status">
        /// The current status of the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Batch(
            string completionWindow,
            global::System.DateTimeOffset createdAt,
            string endpoint,
            string id,
            string inputFileId,
            global::tryAGI.OpenAI.BatchStatus status,
            global::System.DateTimeOffset? cancelledAt,
            global::System.DateTimeOffset? cancellingAt,
            global::System.DateTimeOffset? completedAt,
            string? errorFileId,
            global::tryAGI.OpenAI.BatchErrors? errors,
            global::System.DateTimeOffset? expiredAt,
            global::System.DateTimeOffset? expiresAt,
            global::System.DateTimeOffset? failedAt,
            global::System.DateTimeOffset? finalizingAt,
            global::System.DateTimeOffset? inProgressAt,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.BatchObject @object,
            string? outputFileId,
            global::tryAGI.OpenAI.BatchRequestCounts? requestCounts)
        {
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
            this.CreatedAt = createdAt;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.Status = status;
            this.CancelledAt = cancelledAt;
            this.CancellingAt = cancellingAt;
            this.CompletedAt = completedAt;
            this.ErrorFileId = errorFileId;
            this.Errors = errors;
            this.ExpiredAt = expiredAt;
            this.ExpiresAt = expiresAt;
            this.FailedAt = failedAt;
            this.FinalizingAt = finalizingAt;
            this.InProgressAt = inProgressAt;
            this.Metadata = metadata;
            this.Object = @object;
            this.OutputFileId = outputFileId;
            this.RequestCounts = requestCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }
    }
}