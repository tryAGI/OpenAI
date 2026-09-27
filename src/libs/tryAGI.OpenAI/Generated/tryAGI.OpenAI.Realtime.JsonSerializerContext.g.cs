
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2>), TypeInfoPropertyName = "RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2_fe3c1cd2e870870e")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>), TypeInfoPropertyName = "AnyOfStringAudioTranscriptionModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionModel), TypeInfoPropertyName = "AudioTranscriptionModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay), TypeInfoPropertyName = "AudioTranscriptionDelay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>), TypeInfoPropertyName = "AnyOfStringAudioTranscriptionResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel), TypeInfoPropertyName = "AudioTranscriptionResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller), TypeInfoPropertyName = "CallableToolAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice), TypeInfoPropertyName = "VoiceIdsOrCustomVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsShared), TypeInfoPropertyName = "VoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolType), TypeInfoPropertyName = "MCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolConnectorId), TypeInfoPropertyName = "MCPToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2), TypeInfoPropertyName = "MCPToolRequireApprovalVariant1Enum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NoiseReductionType), TypeInfoPropertyName = "NoiseReductionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormats), TypeInfoPropertyName = "RealtimeAudioFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType), TypeInfoPropertyName = "RealtimeAudioFormatsPcmAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType), TypeInfoPropertyName = "RealtimeAudioFormatsPcmuAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType), TypeInfoPropertyName = "RealtimeAudioFormatsPcmaAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>), TypeInfoPropertyName = "OneOfToolChoiceOptionsToolChoiceFunctionToolChoiceMCP2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceOptions), TypeInfoPropertyName = "ToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCP))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCallCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCallReferRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCallRejectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>), TypeInfoPropertyName = "OneOfRealtimeSessionCreateRequestGARealtimeTranscriptionSessionCreateRequestGA2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor), TypeInfoPropertyName = "RealtimeCreateClientSecretRequestExpiresAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Session2), TypeInfoPropertyName = "Session22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType), TypeInfoPropertyName = "RealtimeCreateClientSecretResponseSessionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType), TypeInfoPropertyName = "RealtimeFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort), TypeInfoPropertyName = "RealtimeReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>), TypeInfoPropertyName = "OneOfRealtimeFunctionToolMCPTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie), TypeInfoPropertyName = "RealtimeSessionCreateRequestModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>), TypeInfoPropertyName = "OneOfRealtimeSessionCreateRequestTracingEnumRealtimeSessionCreateRequestTracingEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum), TypeInfoPropertyName = "RealtimeSessionCreateRequestTracingEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType), TypeInfoPropertyName = "RealtimeSessionCreateRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>), TypeInfoPropertyName = "OneOfInt32RealtimeSessionCreateRequestMaxResponseOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens), TypeInfoPropertyName = "RealtimeSessionCreateRequestMaxResponseOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncation), TypeInfoPropertyName = "RealtimeTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>), TypeInfoPropertyName = "AnyOfStringRealtimeSessionCreateRequestGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>), TypeInfoPropertyName = "OneOfRealtimeSessionCreateRequestGATracingEnumRealtimeSessionCreateRequestGATracingEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum), TypeInfoPropertyName = "RealtimeSessionCreateRequestGATracingEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>), TypeInfoPropertyName = "OneOfInt32RealtimeSessionCreateRequestGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens), TypeInfoPropertyName = "RealtimeSessionCreateRequestGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem), TypeInfoPropertyName = "RealtimeSessionCreateResponseIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie), TypeInfoPropertyName = "RealtimeSessionCreateResponseOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>), TypeInfoPropertyName = "OneOfRealtimeSessionCreateResponseTracingEnumRealtimeSessionCreateResponseTracingEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum), TypeInfoPropertyName = "RealtimeSessionCreateResponseTracingEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>), TypeInfoPropertyName = "OneOfInt32RealtimeSessionCreateResponseMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens), TypeInfoPropertyName = "RealtimeSessionCreateResponseMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType), TypeInfoPropertyName = "RealtimeSessionCreateResponseGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject), TypeInfoPropertyName = "RealtimeSessionCreateResponseGAObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie), TypeInfoPropertyName = "RealtimeSessionCreateResponseGAOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>), TypeInfoPropertyName = "AnyOfStringRealtimeSessionCreateResponseGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel), TypeInfoPropertyName = "RealtimeSessionCreateResponseGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem), TypeInfoPropertyName = "RealtimeSessionCreateResponseGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum), TypeInfoPropertyName = "RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>), TypeInfoPropertyName = "OneOfInt32RealtimeSessionCreateResponseGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens), TypeInfoPropertyName = "RealtimeSessionCreateResponseGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateRequestGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateResponseModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateResponseGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem), TypeInfoPropertyName = "RealtimeTranscriptionSessionCreateResponseGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor), TypeInfoPropertyName = "RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType), TypeInfoPropertyName = "RealtimeTranslationSessionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum), TypeInfoPropertyName = "RealtimeTruncationEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType), TypeInfoPropertyName = "RealtimeTruncationEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness), TypeInfoPropertyName = "RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType), TypeInfoPropertyName = "RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>), TypeInfoPropertyName = "OneOfStringInputTextContentInputImageContentInputFileContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType), TypeInfoPropertyName = "ToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCPType), TypeInfoPropertyName = "ToolChoiceMCPType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum), TypeInfoPropertyName = "VoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode), TypeInfoPropertyName = "PromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentType), TypeInfoPropertyName = "InputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageDetail), TypeInfoPropertyName = "ImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentType), TypeInfoPropertyName = "InputImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileInputDetail), TypeInfoPropertyName = "FileInputDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentType), TypeInfoPropertyName = "InputFileContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>?), TypeInfoPropertyName = "NullableAnyOfStringAudioTranscriptionModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionModel?), TypeInfoPropertyName = "NullableAudioTranscriptionModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay?), TypeInfoPropertyName = "NullableAudioTranscriptionDelay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>?), TypeInfoPropertyName = "NullableAnyOfStringAudioTranscriptionResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?), TypeInfoPropertyName = "NullableAudioTranscriptionResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?), TypeInfoPropertyName = "NullableCallableToolAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice?), TypeInfoPropertyName = "NullableVoiceIdsOrCustomVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsShared?), TypeInfoPropertyName = "NullableVoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolType?), TypeInfoPropertyName = "NullableMCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolConnectorId?), TypeInfoPropertyName = "NullableMCPToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?), TypeInfoPropertyName = "NullableMCPToolRequireApprovalVariant1Enum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NoiseReductionType?), TypeInfoPropertyName = "NullableNoiseReductionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormats?), TypeInfoPropertyName = "NullableRealtimeAudioFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType?), TypeInfoPropertyName = "NullableRealtimeAudioFormatsPcmAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType?), TypeInfoPropertyName = "NullableRealtimeAudioFormatsPcmuAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType?), TypeInfoPropertyName = "NullableRealtimeAudioFormatsPcmaAudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>?), TypeInfoPropertyName = "NullableOneOfToolChoiceOptionsToolChoiceFunctionToolChoiceMCP2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceOptions?), TypeInfoPropertyName = "NullableToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>?), TypeInfoPropertyName = "NullableOneOfRealtimeSessionCreateRequestGARealtimeTranscriptionSessionCreateRequestGA2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor?), TypeInfoPropertyName = "NullableRealtimeCreateClientSecretRequestExpiresAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Session2?), TypeInfoPropertyName = "NullableSession22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType?), TypeInfoPropertyName = "NullableRealtimeCreateClientSecretResponseSessionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?), TypeInfoPropertyName = "NullableRealtimeFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?), TypeInfoPropertyName = "NullableRealtimeReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>?), TypeInfoPropertyName = "NullableOneOfRealtimeFunctionToolMCPTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>?), TypeInfoPropertyName = "NullableOneOfRealtimeSessionCreateRequestTracingEnumRealtimeSessionCreateRequestTracingEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestTracingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>?), TypeInfoPropertyName = "NullableOneOfInt32RealtimeSessionCreateRequestMaxResponseOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestMaxResponseOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncation?), TypeInfoPropertyName = "NullableRealtimeTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestGAOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>?), TypeInfoPropertyName = "NullableAnyOfStringRealtimeSessionCreateRequestGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>?), TypeInfoPropertyName = "NullableOneOfRealtimeSessionCreateRequestGATracingEnumRealtimeSessionCreateRequestGATracingEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestGATracingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>?), TypeInfoPropertyName = "NullableOneOfInt32RealtimeSessionCreateRequestGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?), TypeInfoPropertyName = "NullableRealtimeSessionCreateRequestGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>?), TypeInfoPropertyName = "NullableOneOfRealtimeSessionCreateResponseTracingEnumRealtimeSessionCreateResponseTracingEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseTracingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>?), TypeInfoPropertyName = "NullableOneOfInt32RealtimeSessionCreateResponseMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseGAObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseGAOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>?), TypeInfoPropertyName = "NullableAnyOfStringRealtimeSessionCreateResponseGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseGAModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseGATracingTracingConfigurationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>?), TypeInfoPropertyName = "NullableOneOfInt32RealtimeSessionCreateResponseGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?), TypeInfoPropertyName = "NullableRealtimeSessionCreateResponseGAMaxOutputTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateRequestTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateRequestInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateRequestIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateRequestGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateRequestGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateResponseModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateResponseGAType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem?), TypeInfoPropertyName = "NullableRealtimeTranscriptionSessionCreateResponseGAIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor?), TypeInfoPropertyName = "NullableRealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType?), TypeInfoPropertyName = "NullableRealtimeTranslationSessionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum?), TypeInfoPropertyName = "NullableRealtimeTruncationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType?), TypeInfoPropertyName = "NullableRealtimeTruncationEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?), TypeInfoPropertyName = "NullableRealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?), TypeInfoPropertyName = "NullableRealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>?), TypeInfoPropertyName = "NullableOneOfStringInputTextContentInputImageContentInputFileContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?), TypeInfoPropertyName = "NullableToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?), TypeInfoPropertyName = "NullableToolChoiceMCPType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?), TypeInfoPropertyName = "NullableVoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?), TypeInfoPropertyName = "NullablePromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentType?), TypeInfoPropertyName = "NullableInputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageDetail?), TypeInfoPropertyName = "NullableImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentType?), TypeInfoPropertyName = "NullableInputImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileInputDetail?), TypeInfoPropertyName = "NullableFileInputDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentType?), TypeInfoPropertyName = "NullableInputFileContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeFunctionTool>))]
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
    internal sealed partial class RealtimeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RealtimeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RealtimeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Session2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionDelayJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionDelayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionResponseModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionResponseModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretRequestExpiresAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretRequestExpiresAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretResponseSessionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretResponseSessionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestTracingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestTracingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestMaxResponseOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestMaxResponseOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATracingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATracingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseTracingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseTracingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATracingTracingConfigurationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATracingTracingConfigurationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGAIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationSessionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationSessionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerNullableJsonConverter();
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
                    0 => new RealtimeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}