
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
            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AudioFormatJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AudioFormatNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionVoiceJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionVoiceNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionTurnDetectionTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionTurnDetectionTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionToolChoiceJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionToolChoiceNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemContentPartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemContentPartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemRoleJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemRoleNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ContentPartTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ContentPartTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseObjectJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseObjectNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseStatusJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseStatusNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RateLimitInfoNameJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RateLimitInfoNameNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseConfigModalitieJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseConfigModalitieNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseConfigVoiceJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseConfigVoiceNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseConfigToolChoiceJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseConfigToolChoiceNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionUpdatePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionUpdatePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferAppendPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferAppendPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferCommitPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferCommitPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferClearPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferClearPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemCreatePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemCreatePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemTruncatePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemTruncatePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemDeletePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemDeletePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseCreatePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseCreatePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseCancelPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseCancelPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ErrorPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ErrorPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionCreatedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionCreatedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionUpdatedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.SessionUpdatedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationCreatedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationCreatedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemCreatedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemCreatedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemInputAudioTranscriptionCompletedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemInputAudioTranscriptionCompletedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemInputAudioTranscriptionFailedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemInputAudioTranscriptionFailedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemTruncatedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemTruncatedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemDeletedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ConversationItemDeletedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferCommittedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferCommittedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferClearedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferClearedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferSpeechStartedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferSpeechStartedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferSpeechStoppedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferSpeechStoppedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseCreatedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseCreatedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseDonePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseDonePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseOutputItemAddedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseOutputItemAddedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseOutputItemDonePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseOutputItemDonePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseContentPartAddedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseContentPartAddedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseContentPartDonePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseContentPartDonePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseTextDeltaPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseTextDeltaPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseTextDonePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseTextDonePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioTranscriptDeltaPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioTranscriptDeltaPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioTranscriptDonePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioTranscriptDonePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioDeltaPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioDeltaPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioDonePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseAudioDonePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseFunctionCallArgumentsDeltaPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseFunctionCallArgumentsDeltaPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseFunctionCallArgumentsDonePayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseFunctionCallArgumentsDonePayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RateLimitsUpdatedPayloadTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RateLimitsUpdatedPayloadTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.AudioFormat), TypeInfoPropertyName = "AudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.Session))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionObject), TypeInfoPropertyName = "SessionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionVoice), TypeInfoPropertyName = "SessionVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionInputAudioTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionTurnDetectionType), TypeInfoPropertyName = "SessionTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionToolChoice), TypeInfoPropertyName = "SessionToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationObject), TypeInfoPropertyName = "ConversationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemContentPartType), TypeInfoPropertyName = "ConversationItemContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemObject), TypeInfoPropertyName = "ConversationItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemType), TypeInfoPropertyName = "ConversationItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemStatus), TypeInfoPropertyName = "ConversationItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemRole), TypeInfoPropertyName = "ConversationItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.ConversationItemContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ContentPartType), TypeInfoPropertyName = "ContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.UsageDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseObject), TypeInfoPropertyName = "ResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseStatus), TypeInfoPropertyName = "ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.ConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RateLimitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RateLimitInfoName), TypeInfoPropertyName = "RateLimitInfoName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.ResponseConfigModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseConfigModalitie), TypeInfoPropertyName = "ResponseConfigModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseConfigVoice), TypeInfoPropertyName = "ResponseConfigVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseConfigToolChoice), TypeInfoPropertyName = "ResponseConfigToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatePayloadType), TypeInfoPropertyName = "SessionUpdatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferAppendPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferAppendPayloadType), TypeInfoPropertyName = "InputAudioBufferAppendPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommitPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommitPayloadType), TypeInfoPropertyName = "InputAudioBufferCommitPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearPayloadType), TypeInfoPropertyName = "InputAudioBufferClearPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatePayloadType), TypeInfoPropertyName = "ConversationItemCreatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatePayloadType), TypeInfoPropertyName = "ConversationItemTruncatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletePayloadType), TypeInfoPropertyName = "ConversationItemDeletePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatePayloadType), TypeInfoPropertyName = "ResponseCreatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseCancelPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseCancelPayloadType), TypeInfoPropertyName = "ResponseCancelPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ErrorPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ErrorPayloadType), TypeInfoPropertyName = "ErrorPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionCreatedPayloadType), TypeInfoPropertyName = "SessionCreatedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayloadType), TypeInfoPropertyName = "SessionUpdatedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayloadType), TypeInfoPropertyName = "ConversationCreatedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayloadType), TypeInfoPropertyName = "ConversationItemCreatedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayloadType), TypeInfoPropertyName = "ConversationItemInputAudioTranscriptionCompletedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadType), TypeInfoPropertyName = "ConversationItemInputAudioTranscriptionFailedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayloadType), TypeInfoPropertyName = "ConversationItemTruncatedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayloadType), TypeInfoPropertyName = "ConversationItemDeletedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayloadType), TypeInfoPropertyName = "InputAudioBufferCommittedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayloadType), TypeInfoPropertyName = "InputAudioBufferClearedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayloadType), TypeInfoPropertyName = "InputAudioBufferSpeechStartedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayloadType), TypeInfoPropertyName = "InputAudioBufferSpeechStoppedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayloadType), TypeInfoPropertyName = "ResponseCreatedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseDonePayloadType), TypeInfoPropertyName = "ResponseDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayloadType), TypeInfoPropertyName = "ResponseOutputItemAddedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayloadType), TypeInfoPropertyName = "ResponseOutputItemDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayloadType), TypeInfoPropertyName = "ResponseContentPartAddedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayloadType), TypeInfoPropertyName = "ResponseContentPartDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayloadType), TypeInfoPropertyName = "ResponseTextDeltaPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayloadType), TypeInfoPropertyName = "ResponseTextDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayloadType), TypeInfoPropertyName = "ResponseAudioTranscriptDeltaPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayloadType), TypeInfoPropertyName = "ResponseAudioTranscriptDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayloadType), TypeInfoPropertyName = "ResponseAudioDeltaPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayloadType), TypeInfoPropertyName = "ResponseAudioDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayloadType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDeltaPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayloadType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayloadType), TypeInfoPropertyName = "RateLimitsUpdatedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RateLimitInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.ConversationItemContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.ConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.ResponseConfigModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RateLimitInfo>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}