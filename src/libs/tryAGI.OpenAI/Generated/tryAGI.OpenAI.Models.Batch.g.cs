
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `batch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BatchObjectJsonConverter))]
        public global::tryAGI.OpenAI.BatchObject Object { get; set; }

        /// <summary>
        /// The OpenAI API endpoint used by the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Model ID used to process the batch, like `gpt-5-2025-08-07`. OpenAI<br/>
        /// offers a wide range of models with different capabilities, performance<br/>
        /// characteristics, and price points. Refer to the [model<br/>
        /// guide](/docs/models) to browse and compare available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::tryAGI.OpenAI.BatchErrors? Errors { get; set; }

        /// <summary>
        /// The ID of the input file for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// The time frame within which the batch should be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionWindow { get; set; }

        /// <summary>
        /// The current status of the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BatchStatus Status { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of requests with errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_at")]
        public int? InProgressAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalizing_at")]
        public int? FinalizingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public int? FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public int? ExpiredAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelling_at")]
        public int? CancellingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        public int? CancelledAt { get; set; }

        /// <summary>
        /// The request counts for different statuses within the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_counts")]
        public global::tryAGI.OpenAI.BatchRequestCounts? RequestCounts { get; set; }

        /// <summary>
        /// Represents token usage details including input tokens, output tokens, a<br/>
        /// breakdown of output tokens, and the total tokens used. Only populated on<br/>
        /// batches created after September 7, 2025.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.OpenAI.BatchUsage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="endpoint">
        /// The OpenAI API endpoint used by the batch.
        /// </param>
        /// <param name="inputFileId">
        /// The ID of the input file for the batch.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed.
        /// </param>
        /// <param name="status">
        /// The current status of the batch.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `batch`.
        /// </param>
        /// <param name="model">
        /// Model ID used to process the batch, like `gpt-5-2025-08-07`. OpenAI<br/>
        /// offers a wide range of models with different capabilities, performance<br/>
        /// characteristics, and price points. Refer to the [model<br/>
        /// guide](/docs/models) to browse and compare available models.
        /// </param>
        /// <param name="errors"></param>
        /// <param name="outputFileId">
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </param>
        /// <param name="errorFileId">
        /// The ID of the file containing the outputs of requests with errors.
        /// </param>
        /// <param name="inProgressAt">
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </param>
        /// <param name="finalizingAt">
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </param>
        /// <param name="failedAt">
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </param>
        /// <param name="expiredAt">
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </param>
        /// <param name="cancellingAt">
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </param>
        /// <param name="cancelledAt">
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </param>
        /// <param name="requestCounts">
        /// The request counts for different statuses within the batch.
        /// </param>
        /// <param name="usage">
        /// Represents token usage details including input tokens, output tokens, a<br/>
        /// breakdown of output tokens, and the total tokens used. Only populated on<br/>
        /// batches created after September 7, 2025.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Batch(
            string id,
            string endpoint,
            string inputFileId,
            string completionWindow,
            global::tryAGI.OpenAI.BatchStatus status,
            int createdAt,
            global::tryAGI.OpenAI.BatchObject @object,
            string? model,
            global::tryAGI.OpenAI.BatchErrors? errors,
            string? outputFileId,
            string? errorFileId,
            int? inProgressAt,
            int? expiresAt,
            int? finalizingAt,
            int? completedAt,
            int? failedAt,
            int? expiredAt,
            int? cancellingAt,
            int? cancelledAt,
            global::tryAGI.OpenAI.BatchRequestCounts? requestCounts,
            global::tryAGI.OpenAI.BatchUsage? usage,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Model = model;
            this.Errors = errors;
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
            this.Status = status;
            this.OutputFileId = outputFileId;
            this.ErrorFileId = errorFileId;
            this.CreatedAt = createdAt;
            this.InProgressAt = inProgressAt;
            this.ExpiresAt = expiresAt;
            this.FinalizingAt = finalizingAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.ExpiredAt = expiredAt;
            this.CancellingAt = cancellingAt;
            this.CancelledAt = cancelledAt;
            this.RequestCounts = requestCounts;
            this.Usage = usage;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }
    }
}