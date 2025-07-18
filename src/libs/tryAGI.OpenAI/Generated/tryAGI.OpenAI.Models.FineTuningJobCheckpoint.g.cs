
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The `fine_tuning.job.checkpoint` object represents a model checkpoint for a fine-tuning job that is ready to use.
    /// </summary>
    public sealed partial class FineTuningJobCheckpoint
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the checkpoint was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The name of the fine-tuned checkpoint model that is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model_checkpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FineTunedModelCheckpoint { get; set; }

        /// <summary>
        /// The name of the fine-tuning job that this checkpoint was created from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuning_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FineTuningJobId { get; set; }

        /// <summary>
        /// The checkpoint identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Metrics at the step number during the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics Metrics { get; set; }

        /// <summary>
        /// The object type, which is always "fine_tuning.job.checkpoint".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobCheckpointObjectJsonConverter))]
        public global::tryAGI.OpenAI.FineTuningJobCheckpointObject Object { get; set; }

        /// <summary>
        /// The step number that the checkpoint was created at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StepNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobCheckpoint" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the checkpoint was created.
        /// </param>
        /// <param name="fineTunedModelCheckpoint">
        /// The name of the fine-tuned checkpoint model that is created.
        /// </param>
        /// <param name="fineTuningJobId">
        /// The name of the fine-tuning job that this checkpoint was created from.
        /// </param>
        /// <param name="id">
        /// The checkpoint identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="metrics">
        /// Metrics at the step number during the fine-tuning job.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "fine_tuning.job.checkpoint".
        /// </param>
        /// <param name="stepNumber">
        /// The step number that the checkpoint was created at.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningJobCheckpoint(
            global::System.DateTimeOffset createdAt,
            string fineTunedModelCheckpoint,
            string fineTuningJobId,
            string id,
            global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics metrics,
            int stepNumber,
            global::tryAGI.OpenAI.FineTuningJobCheckpointObject @object)
        {
            this.CreatedAt = createdAt;
            this.FineTunedModelCheckpoint = fineTunedModelCheckpoint ?? throw new global::System.ArgumentNullException(nameof(fineTunedModelCheckpoint));
            this.FineTuningJobId = fineTuningJobId ?? throw new global::System.ArgumentNullException(nameof(fineTuningJobId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.StepNumber = stepNumber;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobCheckpoint" /> class.
        /// </summary>
        public FineTuningJobCheckpoint()
        {
        }
    }
}