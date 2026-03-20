
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
            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantSupportedModelsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantSupportedModelsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsCodeTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsFunctionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AudioResponseFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AudioResponseFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogActorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogActorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogActorApiKeyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogActorApiKeyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.BatchObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.BatchObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.BatchStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.BatchFileExpirationAfterAnchorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.BatchFileExpirationAfterAnchorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CertificateObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CertificateObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsModeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsModeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsChoiceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsChoiceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionDeletedObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionDeletedObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionListObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionListObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionModalitiesVariant1ItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionModalitiesVariant1ItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceCustomTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceCustomTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioInputAudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioInputAudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageAnnotationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageAnnotationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotImageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerFileListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerFileListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceExpiresAfterAnchorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceExpiresAfterAnchorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceMemoryLimitJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceMemoryLimitNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceNetworkPolicyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceNetworkPolicyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ConversationItemListObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ConversationItemListObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CostsResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CostsResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2FunctionCallJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2FunctionCallNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyExpiresAfterAnchorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyExpiresAfterAnchorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyMemoryLimitJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyMemoryLimitNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEmbeddingRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEmbeddingResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCompletionsRunDataSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCompletionsRunDataSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCustomDataSourceConfigTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCustomDataSourceConfigTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalJsonlRunDataSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalJsonlRunDataSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalLabelModelGraderTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalLabelModelGraderTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalLogsDataSourceConfigTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalLogsDataSourceConfigTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalResponsesRunDataSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalResponsesRunDataSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalStoredCompletionsDataSourceConfigTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalStoredCompletionsDataSourceConfigTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFileRequestPurposeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFileRequestPurposeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestIntegrationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateFineTuningJobRequestIntegrationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestResponseFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModerationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModerationNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestStyleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestStyleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant1TypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant1TypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2TypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2TypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestStreamFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestStreamFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateThreadAndRunRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestChunkingStrategyVariant1JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestChunkingStrategyVariant1NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonTaskJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonTaskNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestResponseFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestResponseFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateUploadRequestPurposeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateUploadRequestPurposeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatTextFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatTextFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteAssistantResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteCertificateResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteCertificateResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteFileResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteFileResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteFineTuningCheckpointPermissionResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteFineTuningCheckpointPermissionResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteMessageResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteThreadResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DoneEventEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DoneEventEventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DoneEventDataJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DoneEventDataNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EasyInputMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EasyInputMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EasyInputMessageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EasyInputMessageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamQuality2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamQuality2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamInputFidelity2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamInputFidelity2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamSize2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamSize2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamOutputFormat2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamOutputFormat2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModeration2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModeration2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamBackground2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamBackground2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EmbeddingObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EmbeddingObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ErrorEventEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ErrorEventEventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalCustomDataSourceConfigTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalCustomDataSourceConfigTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemContentOutputTextTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemContentOutputTextTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemInputImageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemInputImageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalJsonlFileContentSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalJsonlFileContentSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalJsonlFileIdSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalJsonlFileIdSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalListObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalListObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalLogsDataSourceConfigTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalLogsDataSourceConfigTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalResponsesSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalResponsesSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunListObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunListObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunOutputItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunOutputItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunOutputItemListObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunOutputItemListObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalStoredCompletionsDataSourceConfigTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalStoredCompletionsDataSourceConfigTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalStoredCompletionsSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalStoredCompletionsSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileExpirationAfterAnchorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileExpirationAfterAnchorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FilePathTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FilePathTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchRankerJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchRankerNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBetaJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBetaNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBatchSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersBatchSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersLearningRateMultiplierJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersLearningRateMultiplierNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersNEpochsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneDPOHyperparametersNEpochsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneMethodTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneMethodTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersBatchSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersBatchSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersLearningRateMultiplierJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersLearningRateMultiplierNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersNEpochsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersNEpochsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersReasoningEffortJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersReasoningEffortNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersComputeMultiplierJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersComputeMultiplierNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalIntervalJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalIntervalNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalSamplesJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneReinforcementHyperparametersEvalSamplesNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersBatchSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersBatchSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersLearningRateMultiplierJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersLearningRateMultiplierNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersNEpochsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneSupervisedHyperparametersNEpochsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningCheckpointPermissionObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningCheckpointPermissionObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningIntegrationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersBatchSizeVariant1JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersBatchSizeVariant1NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersLearningRateMultiplierJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersLearningRateMultiplierNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobCheckpointObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventLevelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventLevelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningJobEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderLabelModelTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderLabelModelTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderMultiTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderMultiTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderPythonTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderPythonTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderScoreModelTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderScoreModelTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderStringCheckTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderStringCheckTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderStringCheckOperationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderStringCheckOperationNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityEvaluationMetricJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityEvaluationMetricNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupDeletedResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupDeletedResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupRoleAssignmentObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupRoleAssignmentObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupUserAssignmentObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupUserAssignmentObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupUserDeletedResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GroupUserDeletedResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseBackgroundJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseBackgroundNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseOutputFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseOutputFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseQualityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseQualityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputAudioTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputAudioTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputAudioInputAudio1FormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputAudioInputAudio1FormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteProjectRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteProjectRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteDeleteResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteDeleteResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteListResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteListResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteRequestRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteRequestRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteRequestProjectRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InviteRequestProjectRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListAuditLogsResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListAuditLogsResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListBatchesResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListBatchesResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListCertificatesResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListCertificatesResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListModelsResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListModelsResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputStatus2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputStatus2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPApprovalRequestTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPApprovalRequestTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseResourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseResourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPListToolsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPListToolsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentRefusalObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentRefusalObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessagePhaseJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessagePhaseNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant1EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant2EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant3EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant4EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant5EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetention2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetention2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFileObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFileObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFilePurposeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFilePurposeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFileStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFileStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputAudioTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputAudioTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.PredictionContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.PredictionContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyOwnerTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyOwnerTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyDeleteResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyDeleteResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyListResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyListResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectCreateRequestGeographyJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectCreateRequestGeographyNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupDeletedResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupDeletedResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectListResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectListResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitListResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitListResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountApiKeyObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountApiKeyObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountDeleteResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountDeleteResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountListResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountListResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserCreateRequestRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserCreateRequestRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserDeleteResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserDeleteResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserUpdateRequestRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserUpdateRequestRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.PublicRoleListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.PublicRoleListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemCreateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemCreateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemDeleteTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemDeleteTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemRetrieveTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemRetrieveTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemTruncateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemTruncateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventInputAudioBufferAppendTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventInputAudioBufferAppendTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventInputAudioBufferClearTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventInputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventInputAudioBufferCommitTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventInputAudioBufferCommitTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventOutputAudioBufferClearTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventOutputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventResponseCancelTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventResponseCancelTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventResponseCreateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventResponseCreateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventSessionUpdateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventSessionUpdateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventTranscriptionSessionUpdateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventTranscriptionSessionUpdateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseOutputAudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseOutputAudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsOutputAudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsOutputAudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsConversationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsConversationNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemDeletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemDeletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemRetrievedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemRetrievedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemTruncatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemTruncatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferClearedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferClearedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferCommittedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferCommittedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferSpeechStartedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferSpeechStartedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferSpeechStoppedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventInputAudioBufferSpeechStoppedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventMCPListToolsCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventMCPListToolsCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventMCPListToolsFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventMCPListToolsFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventMCPListToolsInProgressTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventMCPListToolsInProgressTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventRateLimitsUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventRateLimitsUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventRateLimitsUpdatedRateLimitNameJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventRateLimitsUpdatedRateLimitNameNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioTranscriptDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioTranscriptDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioTranscriptDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseAudioTranscriptDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartAddedPartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartAddedPartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartDonePartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseContentPartDonePartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseFunctionCallArgumentsDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseFunctionCallArgumentsDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallArgumentsDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallArgumentsDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallInProgressTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallInProgressTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseTextDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseTextDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseTextDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseTextDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventTranscriptionSessionCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventTranscriptionSessionCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventTranscriptionSessionUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventTranscriptionSessionUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemCreateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemCreateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemDeleteTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemDeleteTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemRetrieveTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemRetrieveTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemTruncateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemTruncateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferAppendTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferAppendTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferClearTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferCommitTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferCommitTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventOutputAudioBufferClearTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventOutputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCancelTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCancelTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCreateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCreateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventSessionUpdateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventSessionUpdateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventTranscriptionSessionUpdateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventTranscriptionSessionUpdateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemWithReferenceContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretRequestExpiresAfterAnchorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretRequestExpiresAfterAnchorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalRequestTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalRequestTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalResponseTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPHTTPErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPHTTPErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPListToolsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPListToolsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPProtocolErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPProtocolErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolExecutionErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolExecutionErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsConversationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsConversationNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDeletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDeletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemRetrievedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemRetrievedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemTruncatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemTruncatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferClearedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferClearedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferCommittedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferCommittedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStartedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStartedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStoppedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStoppedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsInProgressTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsInProgressTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferClearedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferClearedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStartedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStartedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStoppedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStoppedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedRateLimitNameJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedRateLimitNameNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedPartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedPartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDonePartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDonePartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallInProgressTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallInProgressTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventTranscriptionSessionUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventTranscriptionSessionUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionInputAudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionInputAudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionOutputAudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionOutputAudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionTracingTracingConfigurationEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionTracingTracingConfigurationEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionMaxResponseOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionMaxResponseOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionIncludeVariant1ItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionIncludeVariant1ItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestTracingEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestTracingEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestMaxResponseOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestMaxResponseOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATracingEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATracingEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseTracingEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseTracingEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATracingTracingConfigurationEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATracingTracingConfigurationEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGATypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGATypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGAIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGAIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningSummary2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningSummary2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummary2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummary2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseVariant3ObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseVariant3ObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseVariant3StatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseVariant3StatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCreatedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseErrorCodeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseErrorCodeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseErrorEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseErrorEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFailedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFailedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextGrammarTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextGrammarTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextPythonTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextPythonTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallGeneratingEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallGeneratingEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallInProgressEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallInProgressEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallPartialImageEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallPartialImageEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseInProgressEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseItemListObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseItemListObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallFailedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallFailedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallInProgressEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallInProgressEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsFailedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsFailedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsInProgressEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsInProgressEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseModalitiesVariant1ItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseModalitiesVariant1ItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationAddedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationAddedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponsePropertiesTruncation2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponsePropertiesTruncation2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseQueuedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseQueuedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventPartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventPartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseTextDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseTextDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventResponseCreateVariant1TypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventResponseCreateVariant1TypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RoleObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RoleObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RoleDeletedResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RoleDeletedResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RoleListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RoleListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectRequiredActionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectLastErrorCodeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant1EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant2EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant3EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant4EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant5EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant6EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant7EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant1EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant2EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant3EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant4EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant5EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant6EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant7EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant8EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant9EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant10EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpeechAudioDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpeechAudioDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpeechAudioDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpeechAudioDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadStreamEventVariant1EventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextDeltaEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextDeltaEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextDoneEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextDoneEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextSegmentEventTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextSegmentEventTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionChunkingStrategyEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionChunkingStrategyEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionDiarizedSegmentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionDiarizedSegmentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionIncludeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionIncludeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UploadStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UploadStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UploadObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UploadObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UploadPartObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UploadPartObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageModerationsResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageModerationsResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresResultObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresResultObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserDeleteResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserDeleteResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserListResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserListResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserRoleAssignmentObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserRoleAssignmentObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserRoleUpdateRequestRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserRoleUpdateRequestRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VadConfigTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VadConfigTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileContentResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileContentResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VerbosityEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VerbosityEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceConsentDeletedResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceConsentDeletedResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceConsentListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceConsentListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceConsentResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceConsentResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionFindTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionFindTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionOpenPageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionOpenPageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchApproximateLocationWebSearchApproximateLocation1TypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchApproximateLocationWebSearchApproximateLocation1TypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCancelledObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCancelledObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCancelledTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCancelledTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCompletedObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCompletedObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchExpiredObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchExpiredObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchExpiredTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchExpiredTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchFailedObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchFailedObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookBatchFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunCanceledObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunCanceledObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunCanceledTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunCanceledTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunFailedObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunFailedObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunSucceededObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunSucceededObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunSucceededTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEvalRunSucceededTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobCancelledObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobCancelledObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobCancelledTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobCancelledTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobFailedObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobFailedObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobSucceededObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobSucceededObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobSucceededTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookFineTuningJobSucceededTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookRealtimeCallIncomingObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookRealtimeCallIncomingObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookRealtimeCallIncomingTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookRealtimeCallIncomingTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCancelledObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCancelledObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCancelledTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCancelledTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCompletedObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCompletedObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseFailedObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseFailedObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseIncompleteObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseIncompleteObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseIncompleteTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebhookResponseIncompleteTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.IncludeEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.IncludeEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TextContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TextContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SummaryTextContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SummaryTextContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClickButtonTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClickButtonTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClickParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClickParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DoubleClickActionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DoubleClickActionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DragParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DragParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.KeyPressActionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.KeyPressActionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MoveParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MoveParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ScreenshotParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ScreenshotParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ScrollParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ScrollParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TypeParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TypeParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WaitParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WaitParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RankerVersionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RankerVersionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerEnvironmentJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerEnvironmentNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUsePreviewToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUsePreviewToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerMemoryLimitJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerMemoryLimitNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputFidelityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputFidelityNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerReferenceParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerReferenceParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomTextFormatParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomTextFormatParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GrammarSyntax1JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GrammarSyntax1NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomGrammarFormatParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomGrammarFormatParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApproximateLocationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApproximateLocationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SearchContextSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SearchContextSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SearchContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SearchContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchPreviewToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchPreviewToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputStatusEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputStatusEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputLogsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputLogsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputImageTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputImageTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentResourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentResourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerReferenceResourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContainerReferenceResourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellCallOutputStatusEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellCallOutputStatusEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MCPToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DetailEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DetailEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallItemStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallItemStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputTextContentParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputTextContentParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentParamAutoParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentParamAutoParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputFileContentParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputFileContentParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchCallItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchCallItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompactionSummaryItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompactionSummaryItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusParamNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusParamNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputItemParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputItemParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ItemReferenceParamType2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ItemReferenceParamType2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ConversationResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ConversationResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompactionBodyTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompactionBodyTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedConversationResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedConversationResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OrderEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OrderEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoModelEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoModelEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoSecondsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoSecondsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedVideoResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedVideoResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoContentVariantJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoContentVariantNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TruncationEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TruncationEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TokenCountsResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TokenCountsResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompactResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CompactResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedSkillResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedSkillResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillVersionResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillVersionResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillVersionListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillVersionListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedSkillVersionResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedSkillVersionResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatSessionStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatSessionStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatSessionResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatSessionResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ExpiresAfterParamAnchorJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ExpiresAfterParamAnchorNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageInputTextTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageInputTextTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageQuotedTextTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageQuotedTextTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AttachmentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AttachmentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileAnnotationSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileAnnotationSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileAnnotationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FileAnnotationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UrlAnnotationSourceTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UrlAnnotationSourceTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UrlAnnotationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UrlAnnotationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskGroupItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskGroupItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskGroupItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TaskGroupItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadItemListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadItemListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ActiveStatusTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ActiveStatusTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LockedStatusTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.LockedStatusTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClosedStatusTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ClosedStatusTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedThreadResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedThreadResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadListResourceObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadListResourceObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateBatchRequestEndpointJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateBatchRequestEndpointNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateBatchRequestCompletionWindowJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateBatchRequestCompletionWindowNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListAssistantsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListAssistantsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListChatCompletionsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListChatCompletionsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetChatCompletionMessagesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetChatCompletionMessagesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListContainersOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListContainersOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListContainerFilesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListContainerFilesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListConversationItemsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListConversationItemsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListEvalsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListEvalsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListEvalsOrderByJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListEvalsOrderByNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunsStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunsStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunOutputItemsStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunOutputItemsStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunOutputItemsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetEvalRunOutputItemsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFilesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFilesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningCheckpointPermissionsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AdminApiKeysListOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AdminApiKeysListOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListOrganizationCertificatesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListOrganizationCertificatesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetCertificateIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetCertificateIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCostsBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCostsBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCostsGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCostsGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListGroupsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListGroupsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListGroupRoleAssignmentsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListGroupRoleAssignmentsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListGroupUsersOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListGroupUsersOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectCertificatesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectCertificatesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectGroupsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectGroupsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRolesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRolesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCompletionsBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCompletionsBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCompletionsGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageCompletionsGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesSourceJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesSourceNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesSizeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesSizeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageModerationsBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageModerationsBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageModerationsGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageModerationsGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresBucketWidthJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresBucketWidthNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresGroupByItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresGroupByItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListUserRoleAssignmentsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListUserRoleAssignmentsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectGroupRoleAssignmentsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectGroupRoleAssignmentsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectRolesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectRolesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectUserRoleAssignmentsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListProjectUserRoleAssignmentsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListInputItemsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListInputItemsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListMessagesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListMessagesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRunsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRunsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateRunIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateRunIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRunStepsOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRunStepsOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRunStepsIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListRunStepsIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetRunStepIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.GetRunStepIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListVectorStoresOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListVectorStoresOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesOrderJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesFilterJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallsItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageContentPartJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageContentPartJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ChunkingStrategyRequestParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputsVariant1ItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FiltersItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerActionJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputResourceJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.Content5JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ConversationItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ConversationParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillsItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.NetworkPolicyJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateModelResponsePropertiesJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateResponseJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpeechResponseStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.DeletedConversationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalGraderLabelModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalGraderPythonJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalGraderScoreModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalGraderStringCheckJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalGraderTextSimilarityJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemContentJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemContentItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneChatCompletionRequestAssistantMessageJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputResourceJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolCallResourceJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputContentJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageResourceJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.InputParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ItemResourceJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsCompactionJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputContentJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputMessageContentJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.Session2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponseStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventResponseCreateJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ResponsesServerEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.StopConfigurationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TextResponseFormatConfigurationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadStreamEventJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptionChunkingStrategyJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnnotationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContentItem3JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.Filters2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.NetworkPolicy2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.NetworkPolicy3JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.SkillsItem2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant1JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.Format2JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ToolsItem13JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant12JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutcomeJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OperationJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OutputVariant2ItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant13JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.VideoModelJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ItemFieldJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ContentItem4JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnnotationsItem3JsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.ThreadItemJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.StatusJsonConverter),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateEmbeddingRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig, global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig, global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplate, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReference>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalResponsesSource>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.OpenAIFile, object>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.UsageCompletionsResult, global::tryAGI.OpenAI.UsageEmbeddingsResult, global::tryAGI.OpenAI.UsageModerationsResult, global::tryAGI.OpenAI.UsageImagesResult, global::tryAGI.OpenAI.UsageAudioSpeechesResult, global::tryAGI.OpenAI.UsageAudioTranscriptionsResult, global::tryAGI.OpenAI.UsageVectorStoresResult, global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult, global::tryAGI.OpenAI.CostsResult>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.ImageRefParam2>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>),

            typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>),

            typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AddUploadPartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdminApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdminApiKeyOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApiKeyList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AdminApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssignedRoleDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectToolResources2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantSupportedModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsCodeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogExternalKeyRegistered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogExternalKeyRemoved))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogScimEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogScimDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteSent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteSentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteAccepted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogLoginFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogLogoutFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogOrganizationUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogOrganizationUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectArchived))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRateLimitUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRateLimitDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserAddedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificateCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificateUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificateDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesActivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesDeactivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchErrorsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchFileExpirationAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BatchFileExpirationAfterAnchor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Certificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CertificateObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CertificateCertificateDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionDeletedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionFunctionCallOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionFunctions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionListObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamOptionsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterFileOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterFileOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CodeInterpreterFileOutputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterFileOutputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterTextOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterTextOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompleteUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoubleClickAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DragParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.KeyPressAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MoveParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScreenshotParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScrollParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TypeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallSafetyCheckParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerResourceExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerResourceExpiresAfterAnchor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerResourceMemoryLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerResourceNetworkPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerResourceNetworkPolicyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Content5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPListTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemListObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationParam2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResultAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResources2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsShared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchContextSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2Audio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StopConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PredictionContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceLogprobs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateCompletionRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateCompletionResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateContainerBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateContainerFileBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateEmbeddingRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEmbeddingRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEmbeddingRequestEncodingFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Embedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEmbeddingResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEmbeddingResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceSamplingParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalJsonlFileContentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalJsonlFileIdSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalStoredCompletionsSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalItemSimpleInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalLabelModelGrader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalLabelModelGraderType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateEvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig, global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig, global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderStringCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderTextSimilarity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderScoreModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplate, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParamsText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalResponsesSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalResponsesSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFileRequestPurpose))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileExpirationAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningCheckpointPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationWandb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateGroupBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateGroupUserBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFidelity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMessageRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRequestContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.IncludeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamOptionsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContextManagementParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResources2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionInclude))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VadConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateUploadRequestPurpose))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVectorStoreFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVoiceConsentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteAssistantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteAssistantResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteCertificateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteCertificateResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteFileResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteMessageResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteThreadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteThreadResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedConversationResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedRoleAssignmentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoneEventEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoneEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessagePhase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageRefParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EmbeddingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorEventEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Eval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalCustomDataSourceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalLogsDataSourceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderLabelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalCustomDataSourceConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderLabelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderPythonVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderScoreModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderScoreModelVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalGraderTextSimilarityVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemInputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalItemInputImageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalJsonlFileContentSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalJsonlFileIdSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalListObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalLogsDataSourceConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalResponsesSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunResultCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunPerModelUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunListObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemSampleUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalRunOutputItemListObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EvalStoredCompletionsSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileExpirationAfterAnchor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FilePathType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchRanker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneDPOMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneMethodType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderMulti))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningIntegrationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningIntegrationWandb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobCheckpointObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FineTuningJobEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderLabelModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderMultiType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderPythonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderScoreModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderScoreModelSamplingParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheckType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderStringCheckOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarityType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Group))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupDeletedResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupResourceWithSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupRoleAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupRoleAssignmentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserAssignmentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserDeletedResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Image2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolInputImageMask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenActionEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioInputAudio1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Invite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteProjectRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteDeleteResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteListResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteProjectGroupBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteRequestProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteRequestProjectRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAssistantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAuditLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListBatchesResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListCertificatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Certificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListCertificatesResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OpenAIFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningCheckpointPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListModelsResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Model17>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Model17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellExecAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LogProbProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPListToolsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPListToolsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolConnectorId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentRefusalObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextObjectText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaObjectDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetails2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsResponses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsCompaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequestToolResources2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyCertificateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequestToolResources2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NoiseReductionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFilePurpose))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RefusalContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PredictionContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectCreateRequestGeography))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectListResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserCreateRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserUpdateRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicCreateOrganizationRoleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicRoleListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicRoleListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDeleteType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieve))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieveType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppendType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClearType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommitType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClearType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsageOutputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsShared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCP))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrieved))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferClearedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommitted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommittedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStartedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStopped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStoppedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgressType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgressType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCallCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCallReferRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCallRejectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPListTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemWithReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Session2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPListToolsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseUsageOutputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseOutputModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAClientSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Reasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningSummary2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Conversation22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCreatedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFailedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextGrammar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextGrammarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextPythonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseInProgressEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseItemListObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseLogProbTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsePropertiesTruncation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseQueuedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseQueuedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsesClientEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsesServerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleDeletedResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunCompletionUsageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunGraderResponseMetadataErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectRequiredAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunToolCallObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepCompletionUsageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaObjectDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectLastError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant1Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant2Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant3Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant4Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant5Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant6Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant7Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant8Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant9Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStreamEventVariant10Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunToolCallObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunToolCallObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubmitToolOutputsRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectToolResources2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToggleCertificatesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerUsePreviewTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchPreviewTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceCustomType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCPType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificApplyPatchParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificFunctionShellParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceTypesType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionChunkingStrategyEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateGroupBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateVoiceConsentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Upload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.OpenAIFile, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadCertificateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadPartObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucketObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UsageCompletionsResult, global::tryAGI.OpenAI.UsageEmbeddingsResult, global::tryAGI.OpenAI.UsageModerationsResult, global::tryAGI.OpenAI.UsageImagesResult, global::tryAGI.OpenAI.UsageAudioSpeechesResult, global::tryAGI.OpenAI.UsageAudioTranscriptionsResult, global::tryAGI.OpenAI.UsageVectorStoresResult, global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult, global::tryAGI.OpenAI.CostsResult>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UsageCompletionsResult, global::tryAGI.OpenAI.UsageEmbeddingsResult, global::tryAGI.OpenAI.UsageModerationsResult, global::tryAGI.OpenAI.UsageImagesResult, global::tryAGI.OpenAI.UsageAudioSpeechesResult, global::tryAGI.OpenAI.UsageAudioTranscriptionsResult, global::tryAGI.OpenAI.UsageVectorStoresResult, global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult, global::tryAGI.OpenAI.CostsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserDeleteResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserListResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRoleAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRoleAssignmentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRoleUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRoleUpdateRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VadConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ValidateGraderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ValidateGraderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VoiceConsentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionFind))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionFindType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionOpenPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolFilters2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCancelledData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCancelledObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCancelledType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCompletedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCompletedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchExpired))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchExpiredData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchExpiredObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchExpiredType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchFailedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchFailedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookBatchFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunCanceled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunCanceledData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunCanceledObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunCanceledType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunFailedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunFailedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunSucceeded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunSucceededData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunSucceededObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookEvalRunSucceededType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobCancelledObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobCancelledType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobFailedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobFailedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobSucceeded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobSucceededObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookFineTuningJobSucceededType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookRealtimeCallIncoming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookRealtimeCallIncomingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookRealtimeCallIncomingObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookRealtimeCallIncomingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCancelledData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCancelledObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCancelledType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCompletedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCompletedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseCompletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseFailedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseFailedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseIncomplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseIncompleteData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseIncompleteObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebhookResponseIncompleteType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillReferenceParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileCitationBodyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlCitationBodyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnnotationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TopLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningTextContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RefusalContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickButtonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoubleClickActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CoordParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DragParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.KeyPressActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MoveParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScreenshotParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScrollParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TypeParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchExecutionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RankerVersionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HybridSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Filters2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerMemoryLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalSkillParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomTextFormatParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomTextFormatParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GrammarSyntax1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomGrammarFormatParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Format2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApproximateLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApproximateLocationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SearchContextSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SearchContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellExecActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellCallOutputStatusEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Outcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Operation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DetailEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellActionParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemReferenceParamType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenInputUsageDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionBodyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateConversationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateConversationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedConversationResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrderEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoModelEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageRefParam2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoSeconds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoMultipartBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoJsonBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoCharacterBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoCharacterResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoReferenceInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoEditMultipartBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoEditJsonBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoExtendMultipartBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoExtendJsonBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVideoResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVideoResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoContentVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoRemixBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenCountsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenCountsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenCountsResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactResponseMethodPublicBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemFieldDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSkillBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SetDefaultSkillVersionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSkillResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSkillResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillVersionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillVersionResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillVersionListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillVersionListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillVersionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSkillVersionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSkillVersionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSkillVersionResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatkitWorkflowTracing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatkitWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, int?, bool?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionRateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionFileUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionChatkitConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatSessionResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WorkflowTracingParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WorkflowParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ExpiresAfterParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ExpiresAfterParamAnchor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RateLimitsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutomaticThreadTitlingParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileUploadParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HistoryParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatkitConfigurationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatSessionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageInputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageInputTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageQuotedText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageQuotedTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AttachmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Attachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoice8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InferenceOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileAnnotationSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileAnnotationSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileAnnotationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlAnnotationSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlAnnotationSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlAnnotationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnnotationsItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WidgetMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WidgetMessageItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WidgetMessageItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClientToolCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClientToolCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClientToolCallItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClientToolCallItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskGroupTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskGroupItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskGroupItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TaskGroupItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadItemListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadItemListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ActiveStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ActiveStatusType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LockedStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LockedStatusType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClosedStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClosedStatusType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedThreadResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedThreadResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadListResourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DragPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateBatchRequestEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateBatchRequestCompletionWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateConversationItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateEvalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdminApiKeysCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAssistantsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListContainersOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListContainerFilesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListConversationItemsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListEvalsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListEvalsOrderBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetEvalRunsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetEvalRunsStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdminApiKeysListOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAuditLogsEffectiveAt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrganizationCertificatesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetCertificateIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCostsBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCostsGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListGroupsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListGroupUsersOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectCertificatesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectGroupsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRolesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageModerationsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresBucketWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectGroupRoleAssignmentsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectRolesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListInputItemsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListMessagesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateRunIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ListRunStepsIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetRunStepIncludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoresOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteEvalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteEvalRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdminApiKeysDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AdminApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CodeInterpreterFileOutputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateEvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.List<byte[]>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.IncludeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContextManagementParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionInclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ImageRefParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.GroupResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Image2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InviteProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Invite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InviteRequestProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssistantObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Certificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OpenAIFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningCheckpointPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Model17>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProbProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssignedRoleDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunToolCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageTimeBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UsageCompletionsResult, global::tryAGI.OpenAI.UsageEmbeddingsResult, global::tryAGI.OpenAI.UsageModerationsResult, global::tryAGI.OpenAI.UsageImagesResult, global::tryAGI.OpenAI.UsageAudioSpeechesResult, global::tryAGI.OpenAI.UsageAudioTranscriptionsResult, global::tryAGI.OpenAI.UsageVectorStoresResult, global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult, global::tryAGI.OpenAI.CostsResult>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VoiceConsentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebSearchActionSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CoordParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LocalSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem13>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SearchContentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VideoResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<byte[]>, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillVersionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseOutputText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TaskGroupTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetCertificateIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCostsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageModerationsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateRunIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ListRunStepsIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetRunStepIncludeItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}