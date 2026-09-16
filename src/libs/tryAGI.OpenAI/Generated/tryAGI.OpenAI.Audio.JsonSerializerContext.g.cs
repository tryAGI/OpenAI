
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>?), TypeInfoPropertyName = "CreateTranscriptionResponseVerboseJson_c58e2cb76dff9634")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioResponseFormat), TypeInfoPropertyName = "AudioResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice), TypeInfoPropertyName = "VoiceIdsOrCustomVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestModel), TypeInfoPropertyName = "CreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat), TypeInfoPropertyName = "CreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat), TypeInfoPropertyName = "CreateSpeechRequestStreamFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent), TypeInfoPropertyName = "CreateSpeechResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType), TypeInfoPropertyName = "CreateSpeechResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel), TypeInfoPropertyName = "CreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionInclude), TypeInfoPropertyName = "TranscriptionInclude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "CreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1), TypeInfoPropertyName = "CreateTranscriptionRequestChunkingStrategyVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VadConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask), TypeInfoPropertyName = "CreateTranscriptionResponseDiarizedJsonTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage), TypeInfoPropertyName = "CreateTranscriptionResponseDiarizedJsonUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType), TypeInfoPropertyName = "CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>), TypeInfoPropertyName = "OneOfTranscriptTextUsageTokensTranscriptTextUsageDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent), TypeInfoPropertyName = "CreateTranscriptionResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType), TypeInfoPropertyName = "CreateTranscriptionResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequestModel), TypeInfoPropertyName = "CreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat), TypeInfoPropertyName = "CreateTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVoiceConsentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsShared), TypeInfoPropertyName = "VoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEventType), TypeInfoPropertyName = "SpeechAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventType), TypeInfoPropertyName = "SpeechAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType), TypeInfoPropertyName = "TranscriptTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType), TypeInfoPropertyName = "TranscriptTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType), TypeInfoPropertyName = "TranscriptTextSegmentEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType), TypeInfoPropertyName = "TranscriptTextUsageDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType), TypeInfoPropertyName = "TranscriptTextUsageTokensType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType), TypeInfoPropertyName = "TranscriptionDiarizedSegmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateVoiceConsentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VadConfigType), TypeInfoPropertyName = "VadConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject), TypeInfoPropertyName = "VoiceConsentDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentListResourceObject), TypeInfoPropertyName = "VoiceConsentListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VoiceConsentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentResourceObject), TypeInfoPropertyName = "VoiceConsentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum), TypeInfoPropertyName = "VoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceResourceObject), TypeInfoPropertyName = "VoiceResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>), TypeInfoPropertyName = "OneOfCreateTranscriptionResponseJsonCreateTranscriptionResponseDiarizedJsonCreateTranscriptionResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>), TypeInfoPropertyName = "OneOfCreateTranslationResponseJsonCreateTranslationResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioResponseFormat?), TypeInfoPropertyName = "NullableAudioResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice?), TypeInfoPropertyName = "NullableVoiceIdsOrCustomVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestModel?), TypeInfoPropertyName = "NullableCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat?), TypeInfoPropertyName = "NullableCreateSpeechRequestStreamFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent?), TypeInfoPropertyName = "NullableCreateSpeechResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableCreateSpeechResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionInclude?), TypeInfoPropertyName = "NullableTranscriptionInclude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestChunkingStrategyVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask?), TypeInfoPropertyName = "NullableCreateTranscriptionResponseDiarizedJsonTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage?), TypeInfoPropertyName = "NullableCreateTranscriptionResponseDiarizedJsonUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType?), TypeInfoPropertyName = "NullableCreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>?), TypeInfoPropertyName = "NullableOneOfTranscriptTextUsageTokensTranscriptTextUsageDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent?), TypeInfoPropertyName = "NullableCreateTranscriptionResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableCreateTranscriptionResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequestModel?), TypeInfoPropertyName = "NullableCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsShared?), TypeInfoPropertyName = "NullableVoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEventType?), TypeInfoPropertyName = "NullableSpeechAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventType?), TypeInfoPropertyName = "NullableSpeechAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType?), TypeInfoPropertyName = "NullableTranscriptTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType?), TypeInfoPropertyName = "NullableTranscriptTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType?), TypeInfoPropertyName = "NullableTranscriptTextSegmentEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?), TypeInfoPropertyName = "NullableTranscriptTextUsageDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?), TypeInfoPropertyName = "NullableTranscriptTextUsageTokensType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType?), TypeInfoPropertyName = "NullableTranscriptionDiarizedSegmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VadConfigType?), TypeInfoPropertyName = "NullableVadConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject?), TypeInfoPropertyName = "NullableVoiceConsentDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentListResourceObject?), TypeInfoPropertyName = "NullableVoiceConsentListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceConsentResourceObject?), TypeInfoPropertyName = "NullableVoiceConsentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?), TypeInfoPropertyName = "NullableVoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceResourceObject?), TypeInfoPropertyName = "NullableVoiceResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>?), TypeInfoPropertyName = "NullableOneOfCreateTranslationResponseJsonCreateTranslationResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionInclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VoiceConsentResource>))]
    internal sealed partial class AudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateSpeechResponseStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestStreamFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechRequestStreamFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpeechResponseStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestChunkingStrategyVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestChunkingStrategyVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonTaskJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonTaskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranslationRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpeechAudioDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpeechAudioDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpeechAudioDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpeechAudioDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpeechAudioDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextSegmentEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextSegmentEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionDiarizedSegmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionDiarizedSegmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionIncludeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionIncludeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VadConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VadConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceConsentDeletedResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceConsentDeletedResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceConsentListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceConsentListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceConsentResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceConsentResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceConsentResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceResourceObjectNullableJsonConverter();
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
                    0 => new AudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}