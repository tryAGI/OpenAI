
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D86D24328ABCBBA8 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D86D24328ABCBBA8 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D86D24328ABCBBA8(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EvalItemContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EvalItemContentItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneMethodType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneMethodType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemContentOutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemContentOutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBetaJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBetaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersLearningRateMultiplierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersLearningRateMultiplierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersNEpochsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersNEpochsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneMethodType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneMethodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneMethodType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneMethodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersLearningRateMultiplierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersLearningRateMultiplierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersNEpochsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersNEpochsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersComputeMultiplierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersComputeMultiplierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalSamplesJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalSamplesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersLearningRateMultiplierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersLearningRateMultiplierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersNEpochsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersNEpochsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderMultiTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderMultiTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderPythonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderPythonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderScoreModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderScoreModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityEvaluationMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityEvaluationMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioInputAudio1FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioInputAudio1FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_887498FFA805A692(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_350D1C42BFD9D754(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_952828133D79EAE4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9B82F5617E524F86(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C663A3EC366B0351(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequest(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparameters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestHyperparameters(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestHyperparametersBatchSize2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestHyperparametersLearningRateMultiplier2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestHyperparametersNEpochs2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestIntegration(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestIntegrationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationWandb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestIntegrationWandb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateFineTuningJobRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentOutputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContentOutputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContentOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemInputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemInputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemInputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparameters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneDPOHyperparameters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneDPOHyperparametersBatchSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneDPOHyperparametersBeta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneDPOHyperparametersLearningRateMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneDPOHyperparametersNEpochs2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOMethod))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneDPOMethod(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneMethod))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneMethod(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneMethodType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneMethodType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparameters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparametersBatchSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparametersComputeMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparametersEvalInterval2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparametersEvalSamples2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparametersLearningRateMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparametersNEpochs2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementHyperparametersReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementMethod))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneReinforcementMethod(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparameters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneSupervisedHyperparameters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneSupervisedHyperparametersBatchSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneSupervisedHyperparametersLearningRateMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneSupervisedHyperparametersNEpochs2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedMethod))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneSupervisedMethod(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderMulti))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderMulti(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderMultiType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderMultiType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderPython))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderPython(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderPythonType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderPythonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderScoreModel(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModelSamplingParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderScoreModelSamplingParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModelType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderScoreModelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheck))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderStringCheck(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderStringCheckOperation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderStringCheckType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderTextSimilarity(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderTextSimilarityEvaluationMetric2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderTextSimilarityType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudioInputAudio1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudioInputAudio1Format2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTextContentType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_71BAA7C8453093AD(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C4D2D3C93B3FACD9(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D1E9BA06CCA9E76B(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_13B53ACABE210EB9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3D2D1FC406683A2D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DF4929221D0AAA8F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_09CEB760E8D95705(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_23ACC0855664BCF3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_ECD55F2DFAD0619E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4E37F1E4747A567F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_CD678F91961EA7BB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A634E82CDDF9BB5B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A323BAF9835FF427(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1F78C07E8FDE81D4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C17E26000920F6C0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BEF266F9147682F0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B07EAD259BFB2AEE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningEffortEnum2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_AE05E7DAAD42B299(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateFineTuningJobRequestHyperparametersBatchSize2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateFineTuningJobRequestHyperparametersLearningRateMultiplier2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateFineTuningJobRequestHyperparametersNEpochs2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateFineTuningJobRequestIntegrationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateFineTuningJobRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemContentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemContentOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemInputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneDPOHyperparametersBatchSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneDPOHyperparametersBeta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneDPOHyperparametersLearningRateMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneDPOHyperparametersNEpochs2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneMethodType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneMethodType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneReinforcementHyperparametersBatchSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneReinforcementHyperparametersComputeMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneReinforcementHyperparametersEvalInterval2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneReinforcementHyperparametersEvalSamples2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneReinforcementHyperparametersLearningRateMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneReinforcementHyperparametersNEpochs2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneReinforcementHyperparametersReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneSupervisedHyperparametersBatchSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneSupervisedHyperparametersLearningRateMultiplier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneSupervisedHyperparametersNEpochs2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderMultiType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderMultiType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderPythonType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderPythonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModelType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderScoreModelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderStringCheckOperation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderStringCheckType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderTextSimilarityEvaluationMetric2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderTextSimilarityType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputAudioInputAudio1Format2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputAudioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputTextContentType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_27740FFF5196236B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3E7E8845D7CB2839(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_343E4069D909E4B5(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_DF880933C3E87A08(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2EFA7B1192A4DB76(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_8DE93FDC642335DA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7F8AD2087F0D4743(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_BB66E70876C50B06(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_B19F8764845EE826(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_341D03F833093F90(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_824A5770948FABB9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_B86C54E9C826EAD0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7F0286A00BD85E09(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_1E85C046DEA63043(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7C65FC040EF67B3D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2572CA251E033D3E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_61F3E8DE917D3EAC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableReasoningEffortEnum2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D64E05E278D4AE77(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D55B69E73AC8685C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E868131C1412E9D7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItemContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_561CF6464C64928C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}