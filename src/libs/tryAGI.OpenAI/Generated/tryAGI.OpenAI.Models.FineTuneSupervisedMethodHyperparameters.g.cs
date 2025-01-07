
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneSupervisedMethodHyperparameters
    {
        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize?, int?>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersLearningRateMultiplier?, double?>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersNEpochs?, int?>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneSupervisedMethodHyperparameters" /> class.
        /// </summary>
        /// <param name="batchSize">
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="learningRateMultiplier">
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuneSupervisedMethodHyperparameters(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize?, int?>? batchSize,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneSupervisedMethodHyperparameters" /> class.
        /// </summary>
        public FineTuneSupervisedMethodHyperparameters()
        {
        }
    }
}