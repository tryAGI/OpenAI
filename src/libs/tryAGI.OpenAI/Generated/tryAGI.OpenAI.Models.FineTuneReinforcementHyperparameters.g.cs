
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The hyperparameters used for the reinforcement fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneReinforcementHyperparameters
    {
        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Multiplier on amount of compute used for exploring search space during training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>? ComputeMultiplier { get; set; }

        /// <summary>
        /// The number of training steps between evaluation runs.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>? EvalInterval { get; set; }

        /// <summary>
        /// Number of evaluation samples to generate per training step.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_samples")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>? EvalSamples { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Level of reasoning effort.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersReasoningEffortJsonConverter))]
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneReinforcementHyperparameters" /> class.
        /// </summary>
        /// <param name="batchSize">
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="computeMultiplier">
        /// Multiplier on amount of compute used for exploring search space during training.
        /// </param>
        /// <param name="evalInterval">
        /// The number of training steps between evaluation runs.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="evalSamples">
        /// Number of evaluation samples to generate per training step.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="learningRateMultiplier">
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.
        /// </param>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="reasoningEffort">
        /// Level of reasoning effort.<br/>
        /// Default Value: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneReinforcementHyperparameters(
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>? batchSize,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>? computeMultiplier,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>? evalInterval,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>? evalSamples,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>? nEpochs,
            global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort? reasoningEffort)
        {
            this.BatchSize = batchSize;
            this.ComputeMultiplier = computeMultiplier;
            this.EvalInterval = evalInterval;
            this.EvalSamples = evalSamples;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneReinforcementHyperparameters" /> class.
        /// </summary>
        public FineTuneReinforcementHyperparameters()
        {
        }
    }
}