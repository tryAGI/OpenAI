
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An Eval object with a data source config and testing criteria.<br/>
    /// An Eval represents a task to be done for your LLM integration.<br/>
    /// Like:<br/>
    ///  - Improve the quality of my chatbot<br/>
    ///  - See how well my chatbot handles customer support<br/>
    ///  - Check if o4-mini is better at my usecase than gpt-4o
    /// </summary>
    public sealed partial class Eval
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the eval was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Configuration of data sources used in runs of the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig> DataSourceConfig { get; set; }

        /// <summary>
        /// Unique identifier for the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The name of the evaluation.<br/>
        /// Example: Chatbot effectiveness Evaluation
        /// </summary>
        /// <example>Chatbot effectiveness Evaluation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The object type.<br/>
        /// Default Value: eval
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalObject.Eval</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalObjectJsonConverter))]
        public global::tryAGI.OpenAI.EvalObject Object { get; set; } = global::tryAGI.OpenAI.EvalObject.Eval;

        /// <summary>
        /// A list of testing criteria.<br/>
        /// Default Value: eval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testing_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>> TestingCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the eval was created.
        /// </param>
        /// <param name="dataSourceConfig">
        /// Configuration of data sources used in runs of the evaluation.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the evaluation.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="name">
        /// The name of the evaluation.<br/>
        /// Example: Chatbot effectiveness Evaluation
        /// </param>
        /// <param name="object">
        /// The object type.<br/>
        /// Default Value: eval
        /// </param>
        /// <param name="testingCriteria">
        /// A list of testing criteria.<br/>
        /// Default Value: eval
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Eval(
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig> dataSourceConfig,
            string id,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string name,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>> testingCriteria,
            global::tryAGI.OpenAI.EvalObject @object = global::tryAGI.OpenAI.EvalObject.Eval)
        {
            this.CreatedAt = createdAt;
            this.DataSourceConfig = dataSourceConfig;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TestingCriteria = testingCriteria ?? throw new global::System.ArgumentNullException(nameof(testingCriteria));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        public Eval()
        {
        }
    }
}