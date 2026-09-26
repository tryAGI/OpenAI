
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningCheckpointPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateFineTuningJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel), TypeInfoPropertyName = "CreateFineTuningJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>), TypeInfoPropertyName = "OneOfCreateFineTuningJobRequestHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize), TypeInfoPropertyName = "CreateFineTuningJobRequestHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>), TypeInfoPropertyName = "OneOfCreateFineTuningJobRequestHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier), TypeInfoPropertyName = "CreateFineTuningJobRequestHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>), TypeInfoPropertyName = "OneOfCreateFineTuningJobRequestHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs), TypeInfoPropertyName = "CreateFineTuningJobRequestHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType), TypeInfoPropertyName = "CreateFineTuningJobRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationWandb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject), TypeInfoPropertyName = "DeleteFineTuningCheckpointPermissionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderLabelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderScoreModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemRole), TypeInfoPropertyName = "EvalItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContent), TypeInfoPropertyName = "EvalItemContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemType), TypeInfoPropertyName = "EvalItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentItem), TypeInfoPropertyName = "EvalItemContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemInputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType), TypeInfoPropertyName = "EvalItemContentOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemInputImageType), TypeInfoPropertyName = "EvalItemInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>), TypeInfoPropertyName = "OneOfFineTuneDPOHyperparametersBetaDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta), TypeInfoPropertyName = "FineTuneDPOHyperparametersBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>), TypeInfoPropertyName = "OneOfFineTuneDPOHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize), TypeInfoPropertyName = "FineTuneDPOHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>), TypeInfoPropertyName = "OneOfFineTuneDPOHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier), TypeInfoPropertyName = "FineTuneDPOHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>), TypeInfoPropertyName = "OneOfFineTuneDPOHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs), TypeInfoPropertyName = "FineTuneDPOHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneMethodType), TypeInfoPropertyName = "FineTuneMethodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>), TypeInfoPropertyName = "OneOfFineTuneReinforcementHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize), TypeInfoPropertyName = "FineTuneReinforcementHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>), TypeInfoPropertyName = "OneOfFineTuneReinforcementHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier), TypeInfoPropertyName = "FineTuneReinforcementHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>), TypeInfoPropertyName = "OneOfFineTuneReinforcementHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs), TypeInfoPropertyName = "FineTuneReinforcementHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort), TypeInfoPropertyName = "FineTuneReinforcementHyperparametersReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>), TypeInfoPropertyName = "OneOfFineTuneReinforcementHyperparametersComputeMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier), TypeInfoPropertyName = "FineTuneReinforcementHyperparametersComputeMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>), TypeInfoPropertyName = "OneOfFineTuneReinforcementHyperparametersEvalIntervalInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval), TypeInfoPropertyName = "FineTuneReinforcementHyperparametersEvalInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>), TypeInfoPropertyName = "OneOfFineTuneReinforcementHyperparametersEvalSamplesInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples), TypeInfoPropertyName = "FineTuneReinforcementHyperparametersEvalSamples2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>), TypeInfoPropertyName = "OneOfGraderStringCheckGraderTextSimilarityGraderPythonGraderScoreModelGraderMulti2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderMulti))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>), TypeInfoPropertyName = "OneOfFineTuneSupervisedHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize), TypeInfoPropertyName = "FineTuneSupervisedHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>), TypeInfoPropertyName = "OneOfFineTuneSupervisedHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier), TypeInfoPropertyName = "FineTuneSupervisedHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>), TypeInfoPropertyName = "OneOfFineTuneSupervisedHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs), TypeInfoPropertyName = "FineTuneSupervisedHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject), TypeInfoPropertyName = "FineTuningCheckpointPermissionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningIntegrationType), TypeInfoPropertyName = "FineTuningIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningIntegrationWandb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1), TypeInfoPropertyName = "FineTuningJobHyperparametersBatchSizeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>), TypeInfoPropertyName = "OneOfFineTuningJobHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier), TypeInfoPropertyName = "FineTuningJobHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>), TypeInfoPropertyName = "OneOfFineTuningJobHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs), TypeInfoPropertyName = "FineTuningJobHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobObject), TypeInfoPropertyName = "FineTuningJobObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobStatus), TypeInfoPropertyName = "FineTuningJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointObject), TypeInfoPropertyName = "FineTuningJobCheckpointObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventObject), TypeInfoPropertyName = "FineTuningJobEventObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventLevel), TypeInfoPropertyName = "FineTuningJobEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventType), TypeInfoPropertyName = "FineTuningJobEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderLabelModelType), TypeInfoPropertyName = "GraderLabelModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderMultiType), TypeInfoPropertyName = "GraderMultiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel>), TypeInfoPropertyName = "OneOfGraderStringCheckGraderTextSimilarityGraderPythonGraderScoreModelGraderLabelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderPythonType), TypeInfoPropertyName = "GraderPythonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderScoreModelType), TypeInfoPropertyName = "GraderScoreModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderScoreModelSamplingParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheckType), TypeInfoPropertyName = "GraderStringCheckType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheckOperation), TypeInfoPropertyName = "GraderStringCheckOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarityType), TypeInfoPropertyName = "GraderTextSimilarityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric), TypeInfoPropertyName = "GraderTextSimilarityEvaluationMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioType), TypeInfoPropertyName = "InputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioInputAudio1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format), TypeInfoPropertyName = "InputAudioInputAudio1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningCheckpointPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject), TypeInfoPropertyName = "ListFineTuningCheckpointPermissionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject), TypeInfoPropertyName = "ListFineTuningJobCheckpointsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject), TypeInfoPropertyName = "ListFineTuningJobEventsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject), TypeInfoPropertyName = "ListPaginatedFineTuningJobsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderResponseMetadataErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ValidateGraderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ValidateGraderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode), TypeInfoPropertyName = "PromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentType), TypeInfoPropertyName = "InputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder), TypeInfoPropertyName = "ListFineTuningCheckpointPermissionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?), TypeInfoPropertyName = "NullableReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateFineTuningJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?), TypeInfoPropertyName = "NullableCreateFineTuningJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>?), TypeInfoPropertyName = "NullableOneOfCreateFineTuningJobRequestHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?), TypeInfoPropertyName = "NullableCreateFineTuningJobRequestHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>?), TypeInfoPropertyName = "NullableOneOfCreateFineTuningJobRequestHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?), TypeInfoPropertyName = "NullableCreateFineTuningJobRequestHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>?), TypeInfoPropertyName = "NullableOneOfCreateFineTuningJobRequestHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?), TypeInfoPropertyName = "NullableCreateFineTuningJobRequestHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType?), TypeInfoPropertyName = "NullableCreateFineTuningJobRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject?), TypeInfoPropertyName = "NullableDeleteFineTuningCheckpointPermissionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemRole?), TypeInfoPropertyName = "NullableEvalItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContent?), TypeInfoPropertyName = "NullableEvalItemContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemType?), TypeInfoPropertyName = "NullableEvalItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentItem?), TypeInfoPropertyName = "NullableEvalItemContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType?), TypeInfoPropertyName = "NullableEvalItemContentOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemInputImageType?), TypeInfoPropertyName = "NullableEvalItemInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>?), TypeInfoPropertyName = "NullableOneOfFineTuneDPOHyperparametersBetaDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?), TypeInfoPropertyName = "NullableFineTuneDPOHyperparametersBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneDPOHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?), TypeInfoPropertyName = "NullableFineTuneDPOHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>?), TypeInfoPropertyName = "NullableOneOfFineTuneDPOHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?), TypeInfoPropertyName = "NullableFineTuneDPOHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneDPOHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?), TypeInfoPropertyName = "NullableFineTuneDPOHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneMethodType?), TypeInfoPropertyName = "NullableFineTuneMethodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneReinforcementHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?), TypeInfoPropertyName = "NullableFineTuneReinforcementHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>?), TypeInfoPropertyName = "NullableOneOfFineTuneReinforcementHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?), TypeInfoPropertyName = "NullableFineTuneReinforcementHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneReinforcementHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?), TypeInfoPropertyName = "NullableFineTuneReinforcementHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort?), TypeInfoPropertyName = "NullableFineTuneReinforcementHyperparametersReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>?), TypeInfoPropertyName = "NullableOneOfFineTuneReinforcementHyperparametersComputeMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?), TypeInfoPropertyName = "NullableFineTuneReinforcementHyperparametersComputeMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneReinforcementHyperparametersEvalIntervalInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?), TypeInfoPropertyName = "NullableFineTuneReinforcementHyperparametersEvalInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneReinforcementHyperparametersEvalSamplesInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?), TypeInfoPropertyName = "NullableFineTuneReinforcementHyperparametersEvalSamples2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>?), TypeInfoPropertyName = "NullableOneOfGraderStringCheckGraderTextSimilarityGraderPythonGraderScoreModelGraderMulti2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneSupervisedHyperparametersBatchSizeInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?), TypeInfoPropertyName = "NullableFineTuneSupervisedHyperparametersBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>?), TypeInfoPropertyName = "NullableOneOfFineTuneSupervisedHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?), TypeInfoPropertyName = "NullableFineTuneSupervisedHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuneSupervisedHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?), TypeInfoPropertyName = "NullableFineTuneSupervisedHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject?), TypeInfoPropertyName = "NullableFineTuningCheckpointPermissionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningIntegrationType?), TypeInfoPropertyName = "NullableFineTuningIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?), TypeInfoPropertyName = "NullableFineTuningJobHyperparametersBatchSizeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>?), TypeInfoPropertyName = "NullableOneOfFineTuningJobHyperparametersLearningRateMultiplierDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?), TypeInfoPropertyName = "NullableFineTuningJobHyperparametersLearningRateMultiplier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuningJobHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?), TypeInfoPropertyName = "NullableFineTuningJobHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobObject?), TypeInfoPropertyName = "NullableFineTuningJobObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobStatus?), TypeInfoPropertyName = "NullableFineTuningJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointObject?), TypeInfoPropertyName = "NullableFineTuningJobCheckpointObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventObject?), TypeInfoPropertyName = "NullableFineTuningJobEventObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventLevel?), TypeInfoPropertyName = "NullableFineTuningJobEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventType?), TypeInfoPropertyName = "NullableFineTuningJobEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderLabelModelType?), TypeInfoPropertyName = "NullableGraderLabelModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderMultiType?), TypeInfoPropertyName = "NullableGraderMultiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel>?), TypeInfoPropertyName = "NullableOneOfGraderStringCheckGraderTextSimilarityGraderPythonGraderScoreModelGraderLabelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderPythonType?), TypeInfoPropertyName = "NullableGraderPythonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderScoreModelType?), TypeInfoPropertyName = "NullableGraderScoreModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheckType?), TypeInfoPropertyName = "NullableGraderStringCheckType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheckOperation?), TypeInfoPropertyName = "NullableGraderStringCheckOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarityType?), TypeInfoPropertyName = "NullableGraderTextSimilarityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric?), TypeInfoPropertyName = "NullableGraderTextSimilarityEvaluationMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioType?), TypeInfoPropertyName = "NullableInputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format?), TypeInfoPropertyName = "NullableInputAudioInputAudio1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject?), TypeInfoPropertyName = "NullableListFineTuningCheckpointPermissionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject?), TypeInfoPropertyName = "NullableListFineTuningJobCheckpointsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject?), TypeInfoPropertyName = "NullableListFineTuningJobEventsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject?), TypeInfoPropertyName = "NullableListPaginatedFineTuningJobsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?), TypeInfoPropertyName = "NullablePromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentType?), TypeInfoPropertyName = "NullableInputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder?), TypeInfoPropertyName = "NullableListFineTuningCheckpointPermissionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningCheckpointPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJob>))]
    internal sealed partial class FineTuningSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FineTuningSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FineTuningSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FineTuningSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningIntegrationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningIntegrationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventLevel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventLevel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderLabelModelType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderLabelModelType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteFineTuningCheckpointPermissionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteFineTuningCheckpointPermissionResponseObjectNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningCheckpointPermissionObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningCheckpointPermissionObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningIntegrationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningIntegrationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersBatchSizeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersBatchSizeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersLearningRateMultiplierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersLearningRateMultiplierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobCheckpointObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventLevel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventLevel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FineTuningJobEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderLabelModelType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderLabelModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderLabelModelType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderLabelModelTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionsOrderNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
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
                    0 => new FineTuningSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}