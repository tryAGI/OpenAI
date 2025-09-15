
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A schema representing an evaluation run.
    /// </summary>
    public sealed partial class EvalRun
    {
        /// <summary>
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Information about the run's data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunDataSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EvalRunDataSource DataSource { get; set; }

        /// <summary>
        /// An object representing an error response from the Eval API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EvalApiError Error { get; set; }

        /// <summary>
        /// The identifier of the associated evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalId { get; set; }

        /// <summary>
        /// Unique identifier for the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard.<br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The model that is evaluated, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The name of the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of the object. Always "eval.run".<br/>
        /// Default Value: eval.run
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalRunObject.EvalRun</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunObjectJsonConverter))]
        public global::tryAGI.OpenAI.EvalRunObject Object { get; set; } = global::tryAGI.OpenAI.EvalRunObject.EvalRun;

        /// <summary>
        /// Usage statistics for each model during the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_model_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerModelUsageItem> PerModelUsage { get; set; }

        /// <summary>
        /// Results per testing criteria applied during the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_testing_criteria_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult> PerTestingCriteriaResults { get; set; }

        /// <summary>
        /// The URL to the rendered evaluation run report on the UI dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReportUrl { get; set; }

        /// <summary>
        /// Counters summarizing the outcomes of the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EvalRunResultCounts ResultCounts { get; set; }

        /// <summary>
        /// The status of the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRun" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </param>
        /// <param name="dataSource">
        /// Information about the run's data source.
        /// </param>
        /// <param name="error">
        /// An object representing an error response from the Eval API.
        /// </param>
        /// <param name="evalId">
        /// The identifier of the associated evaluation.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the evaluation run.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard.<br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="model">
        /// The model that is evaluated, if applicable.
        /// </param>
        /// <param name="name">
        /// The name of the evaluation run.
        /// </param>
        /// <param name="object">
        /// The type of the object. Always "eval.run".<br/>
        /// Default Value: eval.run
        /// </param>
        /// <param name="perModelUsage">
        /// Usage statistics for each model during the evaluation run.
        /// </param>
        /// <param name="perTestingCriteriaResults">
        /// Results per testing criteria applied during the evaluation run.
        /// </param>
        /// <param name="reportUrl">
        /// The URL to the rendered evaluation run report on the UI dashboard.
        /// </param>
        /// <param name="resultCounts">
        /// Counters summarizing the outcomes of the evaluation run.
        /// </param>
        /// <param name="status">
        /// The status of the evaluation run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRun(
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.EvalRunDataSource dataSource,
            global::tryAGI.OpenAI.EvalApiError error,
            string evalId,
            string id,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string model,
            string name,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerModelUsageItem> perModelUsage,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult> perTestingCriteriaResults,
            string reportUrl,
            global::tryAGI.OpenAI.EvalRunResultCounts resultCounts,
            string status,
            global::tryAGI.OpenAI.EvalRunObject @object = global::tryAGI.OpenAI.EvalRunObject.EvalRun)
        {
            this.CreatedAt = createdAt;
            this.DataSource = dataSource;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.EvalId = evalId ?? throw new global::System.ArgumentNullException(nameof(evalId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PerModelUsage = perModelUsage ?? throw new global::System.ArgumentNullException(nameof(perModelUsage));
            this.PerTestingCriteriaResults = perTestingCriteriaResults ?? throw new global::System.ArgumentNullException(nameof(perTestingCriteriaResults));
            this.ReportUrl = reportUrl ?? throw new global::System.ArgumentNullException(nameof(reportUrl));
            this.ResultCounts = resultCounts ?? throw new global::System.ArgumentNullException(nameof(resultCounts));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRun" /> class.
        /// </summary>
        public EvalRun()
        {
        }
    }
}