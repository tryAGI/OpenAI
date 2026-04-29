
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AudioTranscriptionModelJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AudioTranscriptionModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.FileInputDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.FileInputDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ImageDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ImageDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputFileContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputFileContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputImageContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputImageContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputTextContentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputTextContentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.MCPToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.MCPToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.MCPToolConnectorIdJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.MCPToolConnectorIdNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.MCPToolRequireApprovalVariant1Enum2JsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.MCPToolRequireApprovalVariant1Enum2NullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.NoiseReductionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.NoiseReductionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemCreateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemCreateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemDeleteTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemDeleteTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemRetrieveTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemRetrieveTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemTruncateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventConversationItemTruncateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventInputAudioBufferAppendTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventInputAudioBufferAppendTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventInputAudioBufferClearTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventInputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventInputAudioBufferCommitTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventInputAudioBufferCommitTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventOutputAudioBufferClearTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventOutputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventResponseCancelTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventResponseCancelTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventResponseCreateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventResponseCreateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventSessionUpdateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventSessionUpdateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventTranscriptionSessionUpdateTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventTranscriptionSessionUpdateTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallOutputObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallOutputObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallOutputTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallOutputTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallOutputStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemFunctionCallOutputStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageAssistantContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageSystemContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeFunctionToolTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeFunctionToolTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPApprovalRequestTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPApprovalRequestTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPApprovalResponseTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPApprovalResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPHTTPErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPHTTPErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPListToolsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPListToolsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPProtocolErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPProtocolErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPToolCallTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPToolCallTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPToolExecutionErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeMCPToolExecutionErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusDetailsTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusDetailsTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusDetailsReasonJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseStatusDetailsReasonNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseCreateParamsOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseCreateParamsOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseCreateParamsMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseCreateParamsMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseCreateParamsConversationJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseCreateParamsConversationNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemDeletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemDeletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemRetrievedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemRetrievedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemTruncatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventConversationItemTruncatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventErrorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventErrorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferClearedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferClearedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferCommittedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferCommittedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStartedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStartedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStoppedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStoppedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventMCPListToolsCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventMCPListToolsCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventMCPListToolsFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventMCPListToolsFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventMCPListToolsInProgressTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventMCPListToolsInProgressTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventOutputAudioBufferClearedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventOutputAudioBufferClearedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventOutputAudioBufferStartedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventOutputAudioBufferStartedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventOutputAudioBufferStoppedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventOutputAudioBufferStoppedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventRateLimitsUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventRateLimitsUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventRateLimitsUpdatedRateLimitNameJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventRateLimitsUpdatedRateLimitNameNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioTranscriptDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioTranscriptDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioTranscriptDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseAudioTranscriptDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartAddedPartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartAddedPartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartDonePartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartDonePartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallCompletedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallCompletedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallFailedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallFailedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallInProgressTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseMCPCallInProgressTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseOutputItemAddedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseOutputItemAddedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseOutputItemDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseOutputItemDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseTextDeltaTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseTextDeltaTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseTextDoneTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseTextDoneTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventSessionCreatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventSessionCreatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventSessionUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventSessionUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventTranscriptionSessionUpdatedTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventTranscriptionSessionUpdatedTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGATypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGATypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAModelJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAModelNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGATracingEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGATracingEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTruncationEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTruncationEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTruncationEnumTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTruncationEnumTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ToolChoiceFunctionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ToolChoiceMCPTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ToolChoiceMCPTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ToolChoiceOptionsJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ToolChoiceOptionsNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.TranscriptTextUsageDurationTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.TranscriptTextUsageDurationTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.TranscriptTextUsageTokensTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.TranscriptTextUsageTokensTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.VoiceIdsSharedEnumJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeClientEventJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTruncationJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.VoiceIdsSharedJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.Realtime.AudioTranscriptionModel?>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.Realtime.MCPToolFilter>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum2?>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeMCPProtocolError, global::tryAGI.OpenAI.Realtime.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.Realtime.RealtimeMCPHTTPError>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.Realtime.RealtimeResponseMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsConversation?>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokens, global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDuration>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel?>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens?>),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.Realtime.InputTextContent, global::tryAGI.OpenAI.Realtime.InputImageContent, global::tryAGI.OpenAI.Realtime.InputFileContent>),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.AudioTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.AudioTranscriptionModel?>), TypeInfoPropertyName = "AnyOfStringAudioTranscriptionModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.AudioTranscriptionModel), TypeInfoPropertyName = "AudioTranscriptionModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.FileInputDetail), TypeInfoPropertyName = "FileInputDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ImageDetail), TypeInfoPropertyName = "ImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputFileContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputFileContentType), TypeInfoPropertyName = "InputFileContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputImageContentType), TypeInfoPropertyName = "InputImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputTextContentType), TypeInfoPropertyName = "InputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.LogProbProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.MCPListToolsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.MCPToolType), TypeInfoPropertyName = "MCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.MCPToolConnectorId), TypeInfoPropertyName = "MCPToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.Realtime.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.MCPToolFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum2), TypeInfoPropertyName = "MCPToolRequireApprovalVariant1Enum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.NoiseReductionType), TypeInfoPropertyName = "NoiseReductionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.PromptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats), TypeInfoPropertyName = "RealtimeAudioFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormatType), TypeInfoPropertyName = "RealtimeAudioFormatsPcmAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormatType), TypeInfoPropertyName = "RealtimeAudioFormatsPcmuAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormatType), TypeInfoPropertyName = "RealtimeAudioFormatsPcmaAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEvent), TypeInfoPropertyName = "RealtimeClientEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreateType), TypeInfoPropertyName = "RealtimeClientEventConversationItemCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItem), TypeInfoPropertyName = "RealtimeConversationItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDeleteType), TypeInfoPropertyName = "RealtimeClientEventConversationItemDeleteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieveType), TypeInfoPropertyName = "RealtimeClientEventConversationItemRetrieveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncateType), TypeInfoPropertyName = "RealtimeClientEventConversationItemTruncateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppendType), TypeInfoPropertyName = "RealtimeClientEventInputAudioBufferAppendType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClearType), TypeInfoPropertyName = "RealtimeClientEventInputAudioBufferClearType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommitType), TypeInfoPropertyName = "RealtimeClientEventInputAudioBufferCommitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClearType), TypeInfoPropertyName = "RealtimeClientEventOutputAudioBufferClearType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancelType), TypeInfoPropertyName = "RealtimeClientEventResponseCancelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreateType), TypeInfoPropertyName = "RealtimeClientEventResponseCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdateType), TypeInfoPropertyName = "RealtimeClientEventSessionUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA>), TypeInfoPropertyName = "OneOfRealtimeSessionCreateRequestGARealtimeTranscriptionSessionCreateRequestGA2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventTranscriptionSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventTranscriptionSessionUpdateType), TypeInfoPropertyName = "RealtimeClientEventTranscriptionSessionUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallObject), TypeInfoPropertyName = "RealtimeConversationItemFunctionCallObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallType), TypeInfoPropertyName = "RealtimeConversationItemFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallStatus), TypeInfoPropertyName = "RealtimeConversationItemFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutputObject), TypeInfoPropertyName = "RealtimeConversationItemFunctionCallOutputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutputType), TypeInfoPropertyName = "RealtimeConversationItemFunctionCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutputStatus), TypeInfoPropertyName = "RealtimeConversationItemFunctionCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantObject), TypeInfoPropertyName = "RealtimeConversationItemMessageAssistantObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantType), TypeInfoPropertyName = "RealtimeConversationItemMessageAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantStatus), TypeInfoPropertyName = "RealtimeConversationItemMessageAssistantStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantRole), TypeInfoPropertyName = "RealtimeConversationItemMessageAssistantRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItemType), TypeInfoPropertyName = "RealtimeConversationItemMessageAssistantContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemObject), TypeInfoPropertyName = "RealtimeConversationItemMessageSystemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemType), TypeInfoPropertyName = "RealtimeConversationItemMessageSystemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemStatus), TypeInfoPropertyName = "RealtimeConversationItemMessageSystemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemRole), TypeInfoPropertyName = "RealtimeConversationItemMessageSystemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItemType), TypeInfoPropertyName = "RealtimeConversationItemMessageSystemContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserObject), TypeInfoPropertyName = "RealtimeConversationItemMessageUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserType), TypeInfoPropertyName = "RealtimeConversationItemMessageUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserStatus), TypeInfoPropertyName = "RealtimeConversationItemMessageUserStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserRole), TypeInfoPropertyName = "RealtimeConversationItemMessageUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemType), TypeInfoPropertyName = "RealtimeConversationItemMessageUserContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail), TypeInfoPropertyName = "RealtimeConversationItemMessageUserContentItemDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeFunctionToolType), TypeInfoPropertyName = "RealtimeFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequestType), TypeInfoPropertyName = "RealtimeMCPApprovalRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponseType), TypeInfoPropertyName = "RealtimeMCPApprovalResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPHTTPError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPHTTPErrorType), TypeInfoPropertyName = "RealtimeMCPHTTPErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPListToolsType), TypeInfoPropertyName = "RealtimeMCPListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.MCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPProtocolError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPProtocolErrorType), TypeInfoPropertyName = "RealtimeMCPProtocolErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCallType), TypeInfoPropertyName = "RealtimeMCPToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeMCPProtocolError, global::tryAGI.OpenAI.Realtime.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.Realtime.RealtimeMCPHTTPError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPToolExecutionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPToolExecutionErrorType), TypeInfoPropertyName = "RealtimeMCPToolExecutionErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseObject), TypeInfoPropertyName = "RealtimeResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseStatus), TypeInfoPropertyName = "RealtimeResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsType), TypeInfoPropertyName = "RealtimeResponseStatusDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsReason), TypeInfoPropertyName = "RealtimeResponseStatusDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.VoiceIdsShared), TypeInfoPropertyName = "VoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageInputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageOutputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseOutputModalitie), TypeInfoPropertyName = "RealtimeResponseOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeResponseMaxOutputTokens?>), TypeInfoPropertyName = "OneOfInt32RealtimeResponseMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseMaxOutputTokens), TypeInfoPropertyName = "RealtimeResponseMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsOutputModalitie), TypeInfoPropertyName = "RealtimeResponseCreateParamsOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoice), TypeInfoPropertyName = "VoiceIdsOrCustomVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>), TypeInfoPropertyName = "OneOfRealtimeFunctionToolMCPTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>), TypeInfoPropertyName = "OneOfToolChoiceOptionsToolChoiceFunctionToolChoiceMCP2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ToolChoiceOptions), TypeInfoPropertyName = "ToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ToolChoiceMCP))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsMaxOutputTokens?>), TypeInfoPropertyName = "OneOfInt32RealtimeResponseCreateParamsMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsMaxOutputTokens), TypeInfoPropertyName = "RealtimeResponseCreateParamsMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<string, global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsConversation?>), TypeInfoPropertyName = "OneOfStringRealtimeResponseCreateParamsConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsConversation), TypeInfoPropertyName = "RealtimeResponseCreateParamsConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEvent), TypeInfoPropertyName = "RealtimeServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreatedType), TypeInfoPropertyName = "RealtimeServerEventConversationCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreatedConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAddedType), TypeInfoPropertyName = "RealtimeServerEventConversationItemAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreatedType), TypeInfoPropertyName = "RealtimeServerEventConversationItemCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeletedType), TypeInfoPropertyName = "RealtimeServerEventConversationItemDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDoneType), TypeInfoPropertyName = "RealtimeServerEventConversationItemDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType), TypeInfoPropertyName = "RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.LogProbProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokens, global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDuration>), TypeInfoPropertyName = "OneOfTranscriptTextUsageTokensTranscriptTextUsageDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType), TypeInfoPropertyName = "RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType), TypeInfoPropertyName = "RealtimeServerEventConversationItemInputAudioTranscriptionFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType), TypeInfoPropertyName = "RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrievedType), TypeInfoPropertyName = "RealtimeServerEventConversationItemRetrievedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncatedType), TypeInfoPropertyName = "RealtimeServerEventConversationItemTruncatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventErrorType), TypeInfoPropertyName = "RealtimeServerEventErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferClearedType), TypeInfoPropertyName = "RealtimeServerEventInputAudioBufferClearedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommittedType), TypeInfoPropertyName = "RealtimeServerEventInputAudioBufferCommittedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceivedType), TypeInfoPropertyName = "RealtimeServerEventInputAudioBufferDtmfEventReceivedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStartedType), TypeInfoPropertyName = "RealtimeServerEventInputAudioBufferSpeechStartedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStoppedType), TypeInfoPropertyName = "RealtimeServerEventInputAudioBufferSpeechStoppedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggeredType), TypeInfoPropertyName = "RealtimeServerEventInputAudioBufferTimeoutTriggeredType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompletedType), TypeInfoPropertyName = "RealtimeServerEventMCPListToolsCompletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailedType), TypeInfoPropertyName = "RealtimeServerEventMCPListToolsFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgressType), TypeInfoPropertyName = "RealtimeServerEventMCPListToolsInProgressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferClearedType), TypeInfoPropertyName = "RealtimeServerEventOutputAudioBufferClearedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStartedType), TypeInfoPropertyName = "RealtimeServerEventOutputAudioBufferStartedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStoppedType), TypeInfoPropertyName = "RealtimeServerEventOutputAudioBufferStoppedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedType), TypeInfoPropertyName = "RealtimeServerEventRateLimitsUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimitName), TypeInfoPropertyName = "RealtimeServerEventRateLimitsUpdatedRateLimitName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDeltaType), TypeInfoPropertyName = "RealtimeServerEventResponseAudioDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseAudioDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDeltaType), TypeInfoPropertyName = "RealtimeServerEventResponseAudioTranscriptDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseAudioTranscriptDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedType), TypeInfoPropertyName = "RealtimeServerEventResponseContentPartAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedPartType), TypeInfoPropertyName = "RealtimeServerEventResponseContentPartAddedPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseContentPartDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDonePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDonePartType), TypeInfoPropertyName = "RealtimeServerEventResponseContentPartDonePartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreatedType), TypeInfoPropertyName = "RealtimeServerEventResponseCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDeltaType), TypeInfoPropertyName = "RealtimeServerEventResponseFunctionCallArgumentsDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseFunctionCallArgumentsDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDeltaType), TypeInfoPropertyName = "RealtimeServerEventResponseMCPCallArgumentsDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseMCPCallArgumentsDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompletedType), TypeInfoPropertyName = "RealtimeServerEventResponseMCPCallCompletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailedType), TypeInfoPropertyName = "RealtimeServerEventResponseMCPCallFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgressType), TypeInfoPropertyName = "RealtimeServerEventResponseMCPCallInProgressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAddedType), TypeInfoPropertyName = "RealtimeServerEventResponseOutputItemAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseOutputItemDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDeltaType), TypeInfoPropertyName = "RealtimeServerEventResponseTextDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDoneType), TypeInfoPropertyName = "RealtimeServerEventResponseTextDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreatedType), TypeInfoPropertyName = "RealtimeServerEventSessionCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdatedType), TypeInfoPropertyName = "RealtimeServerEventSessionUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdatedType), TypeInfoPropertyName = "RealtimeServerEventTranscriptionSessionUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAType), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel?>), TypeInfoPropertyName = "AnyOfStringRealtimeSessionCreateRequestGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2>), TypeInfoPropertyName = "OneOfRealtimeSessionCreateRequestGATracingEnumRealtimeSessionCreateRequestGATracingEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum), TypeInfoPropertyName = "RealtimeSessionCreateRequestGATracingEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens?>), TypeInfoPropertyName = "OneOfInt32RealtimeSessionCreateRequestGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTruncation), TypeInfoPropertyName = "RealtimeTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetectionType), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioFormat), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAType), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseClientSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateResponseModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnum), TypeInfoPropertyName = "RealtimeTruncationEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnumType), TypeInfoPropertyName = "RealtimeTruncationEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnumTokenLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness), TypeInfoPropertyName = "RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<string, global::tryAGI.OpenAI.Realtime.InputTextContent, global::tryAGI.OpenAI.Realtime.InputImageContent, global::tryAGI.OpenAI.Realtime.InputFileContent>), TypeInfoPropertyName = "OneOfStringInputTextContentInputImageContentInputFileContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ToolChoiceFunctionType), TypeInfoPropertyName = "ToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ToolChoiceMCPType), TypeInfoPropertyName = "ToolChoiceMCPType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDurationType), TypeInfoPropertyName = "TranscriptTextUsageDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokensType), TypeInfoPropertyName = "TranscriptTextUsageTokensType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokensInputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.VoiceIdsSharedEnum), TypeInfoPropertyName = "VoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.Realtime.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.MCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeResponseOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.LogProbProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}