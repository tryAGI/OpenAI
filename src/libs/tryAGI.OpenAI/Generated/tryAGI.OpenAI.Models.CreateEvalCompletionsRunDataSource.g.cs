
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A CompletionsRunDataSource object describing a model sampling configuration.
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSource
    {
        /// <summary>
        /// Used when sampling from a model. Dictates the structure of the messages passed into the model. Can either be a reference to a prebuilt trajectory (ie, `item.input_trajectory`), or a template with variable references to the `item` namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_messages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesVariant1, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesVariant2>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesVariant1, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesVariant2>? InputMessages { get; set; }

        /// <summary>
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_params")]
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceSamplingParams? SamplingParams { get; set; }

        /// <summary>
        /// Determines what populates the `item` namespace in this run's data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource> Source { get; set; }

        /// <summary>
        /// The type of run data source. Always `completions`.<br/>
        /// Default Value: completions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType.Completions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCompletionsRunDataSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType Type { get; set; } = global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType.Completions;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSource" /> class.
        /// </summary>
        /// <param name="inputMessages">
        /// Used when sampling from a model. Dictates the structure of the messages passed into the model. Can either be a reference to a prebuilt trajectory (ie, `item.input_trajectory`), or a template with variable references to the `item` namespace.
        /// </param>
        /// <param name="model">
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </param>
        /// <param name="samplingParams"></param>
        /// <param name="source">
        /// Determines what populates the `item` namespace in this run's data source.
        /// </param>
        /// <param name="type">
        /// The type of run data source. Always `completions`.<br/>
        /// Default Value: completions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalCompletionsRunDataSource(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource> source,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesVariant1, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesVariant2>? inputMessages,
            string? model,
            global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceSamplingParams? samplingParams,
            global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType type = global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType.Completions)
        {
            this.Source = source;
            this.InputMessages = inputMessages;
            this.Model = model;
            this.SamplingParams = samplingParams;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSource" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSource()
        {
        }
    }
}