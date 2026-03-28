
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job. This value will only be returned when running `supervised` jobs.
    /// </summary>
    public sealed partial class FineTuningJobHyperparameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid<br/>
        /// overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle<br/>
        /// through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobHyperparameters" /> class.
        /// </summary>
        /// <param name="batchSize"></param>
        /// <param name="learningRateMultiplier">
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid<br/>
        /// overfitting.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle<br/>
        /// through the training dataset.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningJobHyperparameters(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>? batchSize,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobHyperparameters" /> class.
        /// </summary>
        public FineTuningJobHyperparameters()
        {
        }
    }
}