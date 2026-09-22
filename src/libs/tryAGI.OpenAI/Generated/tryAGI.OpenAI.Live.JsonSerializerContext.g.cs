
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCallAcceptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCallAcceptSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsLive), TypeInfoPropertyName = "ModelIdsLive2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveMediaSessionAudioParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DelegationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCallAcceptSessionType), TypeInfoPropertyName = "LiveCallAcceptSessionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCallReferRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCallRejectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveMediaSessionCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveWebRTCTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCreateResponseSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveForkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveMediaSessionForkParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveClientConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType), TypeInfoPropertyName = "LiveWebRTCTransportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsLiveEnum), TypeInfoPropertyName = "ModelIdsLiveEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCustomVoiceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>), TypeInfoPropertyName = "OneOfAnyOfStringLiveInitialSessionAudioOutputParamVoiceVariant1LiveCustomVoiceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>), TypeInfoPropertyName = "AnyOfStringLiveInitialSessionAudioOutputParamVoiceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1), TypeInfoPropertyName = "LiveInitialSessionAudioOutputParamVoiceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveClientDelegationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveClientDelegationParamType), TypeInfoPropertyName = "LiveClientDelegationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier), TypeInfoPropertyName = "LiveResponsesServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveReasoningEffort), TypeInfoPropertyName = "LiveReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveReasoningSummary), TypeInfoPropertyName = "LiveReasoningSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveDelegationReasoningInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveTextVerbosity), TypeInfoPropertyName = "LiveTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveDelegationTextInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType), TypeInfoPropertyName = "LiveFunctionToolInputParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType), TypeInfoPropertyName = "LiveWebSearchToolInputParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum), TypeInfoPropertyName = "LiveToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType), TypeInfoPropertyName = "LiveFunctionToolChoiceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType), TypeInfoPropertyName = "LiveMCPToolChoiceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem14>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem14), TypeInfoPropertyName = "ToolsItem142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType), TypeInfoPropertyName = "LiveResponsesDelegationSettingsInputParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>), TypeInfoPropertyName = "OneOfLiveToolChoiceEnumLiveFunctionToolChoiceParamLiveMCPToolChoiceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParamType), TypeInfoPropertyName = "LiveResponsesDelegationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DelegationVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType), TypeInfoPropertyName = "DelegationVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialMessageStatus), TypeInfoPropertyName = "LiveInitialMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType), TypeInfoPropertyName = "LiveInitialInputTextContentPartParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType), TypeInfoPropertyName = "LiveInitialDeveloperMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole), TypeInfoPropertyName = "LiveInitialDeveloperMessageItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType), TypeInfoPropertyName = "LiveInitialUserMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole), TypeInfoPropertyName = "LiveInitialUserMessageItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParamType), TypeInfoPropertyName = "LiveInitialTextContentPartParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType), TypeInfoPropertyName = "LiveInitialOutputTextContentPartParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType), TypeInfoPropertyName = "LiveInitialAssistantMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole), TypeInfoPropertyName = "LiveInitialAssistantMessageItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem4), TypeInfoPropertyName = "ContentItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType), TypeInfoPropertyName = "LiveInitialAssistantMessageItemParamContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialItem), TypeInfoPropertyName = "LiveInitialItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole), TypeInfoPropertyName = "LiveInitialItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveAllowedServerEventParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfLiveDataChannelConfigParamAllowedClientEventsIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents), TypeInfoPropertyName = "LiveDataChannelConfigParamAllowedClientEvents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>), TypeInfoPropertyName = "OneOfLiveDataChannelConfigParamAllowedServerEventsIListLiveAllowedServerEventParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents), TypeInfoPropertyName = "LiveDataChannelConfigParamAllowedServerEvents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem15), TypeInfoPropertyName = "ToolsItem152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType), TypeInfoPropertyName = "LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType), TypeInfoPropertyName = "LiveResponsesDelegationUpdateParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsLive?), TypeInfoPropertyName = "NullableModelIdsLive2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveCallAcceptSessionType?), TypeInfoPropertyName = "NullableLiveCallAcceptSessionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType?), TypeInfoPropertyName = "NullableLiveWebRTCTransportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsLiveEnum?), TypeInfoPropertyName = "NullableModelIdsLiveEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>?), TypeInfoPropertyName = "NullableOneOfAnyOfStringLiveInitialSessionAudioOutputParamVoiceVariant1LiveCustomVoiceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?), TypeInfoPropertyName = "NullableAnyOfStringLiveInitialSessionAudioOutputParamVoiceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?), TypeInfoPropertyName = "NullableLiveInitialSessionAudioOutputParamVoiceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveClientDelegationParamType?), TypeInfoPropertyName = "NullableLiveClientDelegationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier?), TypeInfoPropertyName = "NullableLiveResponsesServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveReasoningEffort?), TypeInfoPropertyName = "NullableLiveReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveReasoningSummary?), TypeInfoPropertyName = "NullableLiveReasoningSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveTextVerbosity?), TypeInfoPropertyName = "NullableLiveTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType?), TypeInfoPropertyName = "NullableLiveFunctionToolInputParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType?), TypeInfoPropertyName = "NullableLiveWebSearchToolInputParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum?), TypeInfoPropertyName = "NullableLiveToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType?), TypeInfoPropertyName = "NullableLiveFunctionToolChoiceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType?), TypeInfoPropertyName = "NullableLiveMCPToolChoiceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem14?), TypeInfoPropertyName = "NullableToolsItem142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType?), TypeInfoPropertyName = "NullableLiveResponsesDelegationSettingsInputParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>?), TypeInfoPropertyName = "NullableOneOfLiveToolChoiceEnumLiveFunctionToolChoiceParamLiveMCPToolChoiceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParamType?), TypeInfoPropertyName = "NullableLiveResponsesDelegationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableDelegationVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialMessageStatus?), TypeInfoPropertyName = "NullableLiveInitialMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType?), TypeInfoPropertyName = "NullableLiveInitialInputTextContentPartParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType?), TypeInfoPropertyName = "NullableLiveInitialDeveloperMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole?), TypeInfoPropertyName = "NullableLiveInitialDeveloperMessageItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType?), TypeInfoPropertyName = "NullableLiveInitialUserMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole?), TypeInfoPropertyName = "NullableLiveInitialUserMessageItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParamType?), TypeInfoPropertyName = "NullableLiveInitialTextContentPartParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType?), TypeInfoPropertyName = "NullableLiveInitialOutputTextContentPartParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType?), TypeInfoPropertyName = "NullableLiveInitialAssistantMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole?), TypeInfoPropertyName = "NullableLiveInitialAssistantMessageItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem4?), TypeInfoPropertyName = "NullableContentItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableLiveInitialAssistantMessageItemParamContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialItem?), TypeInfoPropertyName = "NullableLiveInitialItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole?), TypeInfoPropertyName = "NullableLiveInitialItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfLiveDataChannelConfigParamAllowedClientEventsIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?), TypeInfoPropertyName = "NullableLiveDataChannelConfigParamAllowedClientEvents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>?), TypeInfoPropertyName = "NullableOneOfLiveDataChannelConfigParamAllowedServerEventsIListLiveAllowedServerEventParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?), TypeInfoPropertyName = "NullableLiveDataChannelConfigParamAllowedServerEvents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem15?), TypeInfoPropertyName = "NullableToolsItem152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType?), TypeInfoPropertyName = "NullableLiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType?), TypeInfoPropertyName = "NullableLiveResponsesDelegationUpdateParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem14>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem15>))]
    internal sealed partial class LiveSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LiveSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LiveSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsLiveJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem14JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.DelegationVariant1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.LiveInitialItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem15JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.LiveCallAcceptSessionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveCallAcceptSessionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsLiveEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsLiveEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveClientDelegationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveClientDelegationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveCallAcceptSessionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveCallAcceptSessionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveCallAcceptSessionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveCallAcceptSessionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebRTCTransportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebRTCTransportTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsLiveEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsLiveEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsLiveEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsLiveEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialSessionAudioOutputParamVoiceVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialSessionAudioOutputParamVoiceVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveClientDelegationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveClientDelegationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveClientDelegationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveClientDelegationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveTextVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveTextVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebSearchToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebSearchToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolChoiceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolChoiceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolChoiceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveMCPToolChoiceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveMCPToolChoiceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsInputParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsInputParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DelegationVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DelegationVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialInputTextContentPartParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialInputTextContentPartParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialDeveloperMessageItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialDeveloperMessageItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialDeveloperMessageItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialDeveloperMessageItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialUserMessageItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialUserMessageItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialUserMessageItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialUserMessageItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialTextContentPartParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialTextContentPartParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialOutputTextContentPartParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialOutputTextContentPartParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialAssistantMessageItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialAssistantMessageItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialAssistantMessageItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialAssistantMessageItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialAssistantMessageItemParamContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialAssistantMessageItemParamContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialItemDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInitialItemDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedClientEventsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedClientEventsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedServerEventsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedServerEventsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationUpdateParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationUpdateParamTypeNullableJsonConverter();
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
                    0 => new LiveSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}