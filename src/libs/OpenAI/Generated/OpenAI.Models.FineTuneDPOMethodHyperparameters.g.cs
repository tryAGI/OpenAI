
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneDPOMethodHyperparameters
    {
        /// <summary>
        /// The beta value for the DPO method. A higher beta value will increase the weight of the penalty between the policy and reference model.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<global::OpenAI.FineTuneDPOMethodHyperparametersBeta?, double?>))]
        public global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersBeta?, double?>? Beta { get; set; }

        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<global::OpenAI.FineTuneDPOMethodHyperparametersBatchSize?, int?>))]
        public global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<global::OpenAI.FineTuneDPOMethodHyperparametersLearningRateMultiplier?, double?>))]
        public global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<global::OpenAI.FineTuneDPOMethodHyperparametersNEpochs?, int?>))]
        public global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethodHyperparameters" /> class.
        /// </summary>
        /// <param name="beta">
        /// The beta value for the DPO method. A higher beta value will increase the weight of the penalty between the policy and reference model.<br/>
        /// Default Value: auto
        /// </param>
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
        public FineTuneDPOMethodHyperparameters(
            global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersBeta?, double?>? beta,
            global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersBatchSize?, int?>? batchSize,
            global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::OpenAI.OneOf<global::OpenAI.FineTuneDPOMethodHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.Beta = beta;
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethodHyperparameters" /> class.
        /// </summary>
        public FineTuneDPOMethodHyperparameters()
        {
        }
    }
}