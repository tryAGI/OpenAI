
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningJobRequest
    {
        /// <summary>
        /// The name of the model to fine-tune. You can select one of the<br/>
        /// [supported models](/docs/guides/fine-tuning#which-models-can-be-fine-tuned).<br/>
        /// Example: gpt-4o-mini
        /// </summary>
        /// <example>gpt-4o-mini</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.AnyOfJsonConverter<string, global::OpenAI.CreateFineTuningJobRequestModel?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.AnyOf<string, global::OpenAI.CreateFineTuningJobRequestModel?> Model { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains training data.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.<br/>
        /// The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input), [completions](/docs/api-reference/fine-tuning/completions-input) format, or if the fine-tuning method uses the [preference](/docs/api-reference/fine-tuning/preference-input) format.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </summary>
        /// <example>file-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// The hyperparameters used for the fine-tuning job.<br/>
        /// This value is now deprecated in favor of `method`, and should be passed in under the `method` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::OpenAI.CreateFineTuningJobRequestHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// A string of up to 64 characters that will be added to your fine-tuned model name.<br/>
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains validation data.<br/>
        /// If you provide this file, the data is used to generate validation<br/>
        /// metrics periodically during fine-tuning. These metrics can be viewed in<br/>
        /// the fine-tuning results file.<br/>
        /// The same data should not be present in both train and validation files.<br/>
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </summary>
        /// <example>file-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// A list of integrations to enable for your fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::OpenAI.CreateFineTuningJobRequestIntegration>? Integrations { get; set; }

        /// <summary>
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.<br/>
        /// If a seed is not specified, one will be generated for you.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The method used for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public global::OpenAI.FineTuneMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the model to fine-tune. You can select one of the<br/>
        /// [supported models](/docs/guides/fine-tuning#which-models-can-be-fine-tuned).<br/>
        /// Example: gpt-4o-mini
        /// </param>
        /// <param name="trainingFile">
        /// The ID of an uploaded file that contains training data.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.<br/>
        /// The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input), [completions](/docs/api-reference/fine-tuning/completions-input) format, or if the fine-tuning method uses the [preference](/docs/api-reference/fine-tuning/preference-input) format.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </param>
        /// <param name="suffix">
        /// A string of up to 64 characters that will be added to your fine-tuned model name.<br/>
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
        /// </param>
        /// <param name="validationFile">
        /// The ID of an uploaded file that contains validation data.<br/>
        /// If you provide this file, the data is used to generate validation<br/>
        /// metrics periodically during fine-tuning. These metrics can be viewed in<br/>
        /// the fine-tuning results file.<br/>
        /// The same data should not be present in both train and validation files.<br/>
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="seed">
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.<br/>
        /// If a seed is not specified, one will be generated for you.<br/>
        /// Example: 42
        /// </param>
        /// <param name="method">
        /// The method used for fine-tuning.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateFineTuningJobRequest(
            global::OpenAI.AnyOf<string, global::OpenAI.CreateFineTuningJobRequestModel?> model,
            string trainingFile,
            string? suffix,
            string? validationFile,
            global::System.Collections.Generic.IList<global::OpenAI.CreateFineTuningJobRequestIntegration>? integrations,
            int? seed,
            global::OpenAI.FineTuneMethod? method)
        {
            this.Model = model;
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.Suffix = suffix;
            this.ValidationFile = validationFile;
            this.Integrations = integrations;
            this.Seed = seed;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequest" /> class.
        /// </summary>
        public CreateFineTuningJobRequest()
        {
        }
    }
}