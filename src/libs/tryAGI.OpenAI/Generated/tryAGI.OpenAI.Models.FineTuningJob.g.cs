
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The `fine_tuning.job` object represents a fine-tuning job that has been created through the API.
    /// </summary>
    public sealed partial class FineTuningJob
    {
        /// <summary>
        /// The object identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.FineTuningJobError2? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        public string? FineTunedModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTimeOffset? FinishedAt { get; set; }

        /// <summary>
        /// The hyperparameters used for the fine-tuning job. This value will only be returned when running `supervised` jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FineTuningJobHyperparameters Hyperparameters { get; set; }

        /// <summary>
        /// The base model that is being fine-tuned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The object type, which is always "fine_tuning.job".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobObjectJsonConverter))]
        public global::tryAGI.OpenAI.FineTuningJobObject Object { get; set; }

        /// <summary>
        /// The organization that owns the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResultFiles { get; set; }

        /// <summary>
        /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FineTuningJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// The file ID used for training. You can retrieve the training data with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>? Integrations { get; set; }

        /// <summary>
        /// The seed used for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_finish")]
        public global::System.DateTimeOffset? EstimatedFinish { get; set; }

        /// <summary>
        /// The method used for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public global::tryAGI.OpenAI.FineTuneMethod? Method { get; set; }

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
        /// Initializes a new instance of the <see cref="FineTuningJob" /> class.
        /// </summary>
        /// <param name="id">
        /// The object identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job. This value will only be returned when running `supervised` jobs.
        /// </param>
        /// <param name="model">
        /// The base model that is being fine-tuned.
        /// </param>
        /// <param name="organizationId">
        /// The organization that owns the fine-tuning job.
        /// </param>
        /// <param name="resultFiles">
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="status">
        /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
        /// </param>
        /// <param name="trainingFile">
        /// The file ID used for training. You can retrieve the training data with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="seed">
        /// The seed used for the fine-tuning job.
        /// </param>
        /// <param name="error"></param>
        /// <param name="fineTunedModel"></param>
        /// <param name="finishedAt"></param>
        /// <param name="object">
        /// The object type, which is always "fine_tuning.job".
        /// </param>
        /// <param name="trainedTokens"></param>
        /// <param name="validationFile"></param>
        /// <param name="integrations"></param>
        /// <param name="estimatedFinish"></param>
        /// <param name="method">
        /// The method used for fine-tuning.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningJob(
            string id,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.FineTuningJobHyperparameters hyperparameters,
            string model,
            string organizationId,
            global::System.Collections.Generic.IList<string> resultFiles,
            global::tryAGI.OpenAI.FineTuningJobStatus status,
            string trainingFile,
            int seed,
            global::tryAGI.OpenAI.FineTuningJobError2? error,
            string? fineTunedModel,
            global::System.DateTimeOffset? finishedAt,
            global::tryAGI.OpenAI.FineTuningJobObject @object,
            int? trainedTokens,
            string? validationFile,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>? integrations,
            global::System.DateTimeOffset? estimatedFinish,
            global::tryAGI.OpenAI.FineTuneMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Error = error;
            this.FineTunedModel = fineTunedModel;
            this.FinishedAt = finishedAt;
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.ResultFiles = resultFiles ?? throw new global::System.ArgumentNullException(nameof(resultFiles));
            this.Status = status;
            this.TrainedTokens = trainedTokens;
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.ValidationFile = validationFile;
            this.Integrations = integrations;
            this.Seed = seed;
            this.EstimatedFinish = estimatedFinish;
            this.Method = method;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJob" /> class.
        /// </summary>
        public FineTuningJob()
        {
        }
    }
}