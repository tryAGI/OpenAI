
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode), TypeInfoPropertyName = "ChatCompletionAllowedToolsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType), TypeInfoPropertyName = "ChatCompletionAllowedToolsChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionDeletedObject), TypeInfoPropertyName = "ChatCompletionDeletedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionFunctionCallOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionFunctions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionListObject), TypeInfoPropertyName = "ChatCompletionListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType), TypeInfoPropertyName = "ChatCompletionMessageCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject), TypeInfoPropertyName = "ChatCompletionMessageListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>), TypeInfoPropertyName = "AllOfChatCompletionResponseMessageChatCompletionMessageListDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>), TypeInfoPropertyName = "OneOfChatCompletionRequestMessageContentPartTextChatCompletionRequestMessageContentPartImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType), TypeInfoPropertyName = "ChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType), TypeInfoPropertyName = "ChatCompletionMessageToolCallChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem), TypeInfoPropertyName = "ChatCompletionMessageToolCallsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType), TypeInfoPropertyName = "ChatCompletionMessageToolCallDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Input), TypeInfoPropertyName = "Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType), TypeInfoPropertyName = "ChatCompletionModerationInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Output), TypeInfoPropertyName = "Output2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType), TypeInfoPropertyName = "ChatCompletionModerationOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType), TypeInfoPropertyName = "ChatCompletionModerationErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType), TypeInfoPropertyName = "ChatCompletionModerationResultsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationResultBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationResultBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType), TypeInfoPropertyName = "ChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType), TypeInfoPropertyName = "ChatCompletionNamedToolChoiceCustomType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestAssistantMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole), TypeInfoPropertyName = "ChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType), TypeInfoPropertyName = "ChatCompletionRequestAssistantMessageContentPartDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestMessageContentPartText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole), TypeInfoPropertyName = "ChatCompletionRequestDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole), TypeInfoPropertyName = "ChatCompletionRequestFunctionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessage), TypeInfoPropertyName = "ChatCompletionRequestMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole), TypeInfoPropertyName = "ChatCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartAudioInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartRefusalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType), TypeInfoPropertyName = "ChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestSystemMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestSystemMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole), TypeInfoPropertyName = "ChatCompletionRequestSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole), TypeInfoPropertyName = "ChatCompletionRequestToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestToolMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestToolMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>), TypeInfoPropertyName = "OneOfStringIListChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart), TypeInfoPropertyName = "ChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole), TypeInfoPropertyName = "ChatCompletionRequestUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType), TypeInfoPropertyName = "ChatCompletionResponseMessageAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole), TypeInfoPropertyName = "ChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamOptionsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole), TypeInfoPropertyName = "ChatCompletionStreamResponseDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolType), TypeInfoPropertyName = "ChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOption), TypeInfoPropertyName = "ChatCompletionToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum), TypeInfoPropertyName = "ChatCompletionToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequest), TypeInfoPropertyName = "CreateChatCompletionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponseProperties), TypeInfoPropertyName = "CreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsShared), TypeInfoPropertyName = "ModelIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierEnum), TypeInfoPropertyName = "ServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityEnum), TypeInfoPropertyName = "VerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType), TypeInfoPropertyName = "CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchContextSize), TypeInfoPropertyName = "WebSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType), TypeInfoPropertyName = "CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2Audio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice), TypeInfoPropertyName = "VoiceIdsOrCustomVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat), TypeInfoPropertyName = "CreateChatCompletionRequestVariant2AudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StopConfiguration), TypeInfoPropertyName = "StopConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PredictionContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>), TypeInfoPropertyName = "OneOfChatCompletionToolCustomToolChatCompletions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>), TypeInfoPropertyName = "OneOfCreateChatCompletionRequestVariant2FunctionCallChatCompletionFunctionCallOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall), TypeInfoPropertyName = "CreateChatCompletionRequestVariant2FunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject), TypeInfoPropertyName = "CreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason), TypeInfoPropertyName = "CreateChatCompletionStreamResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject), TypeInfoPropertyName = "CreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheOptionsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsShared), TypeInfoPropertyName = "VoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType), TypeInfoPropertyName = "CustomToolChatCompletionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>), TypeInfoPropertyName = "OneOfCustomToolChatCompletionsCustomFormatTextFormatCustomToolChatCompletionsCustomFormatGrammarFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType), TypeInfoPropertyName = "CustomToolChatCompletionsCustomFormatTextFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType), TypeInfoPropertyName = "CustomToolChatCompletionsCustomFormatGrammarFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax), TypeInfoPropertyName = "CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum), TypeInfoPropertyName = "ModelIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention), TypeInfoPropertyName = "ModelResponsePropertiesPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PredictionContentType), TypeInfoPropertyName = "PredictionContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType), TypeInfoPropertyName = "ResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item), TypeInfoPropertyName = "ResponseModalitiesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum), TypeInfoPropertyName = "VoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationInputType), TypeInfoPropertyName = "ModerationInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationResultBodyType), TypeInfoPropertyName = "ModerationResultBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum), TypeInfoPropertyName = "PromptCacheTTLEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheModeEnum), TypeInfoPropertyName = "PromptCacheModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode), TypeInfoPropertyName = "PromptCacheBreakpointParamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationMode), TypeInfoPropertyName = "ModerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationPolicyParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder), TypeInfoPropertyName = "ListChatCompletionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder), TypeInfoPropertyName = "GetChatCompletionMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode?), TypeInfoPropertyName = "NullableChatCompletionAllowedToolsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType?), TypeInfoPropertyName = "NullableChatCompletionAllowedToolsChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionDeletedObject?), TypeInfoPropertyName = "NullableChatCompletionDeletedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionListObject?), TypeInfoPropertyName = "NullableChatCompletionListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject?), TypeInfoPropertyName = "NullableChatCompletionMessageListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>?), TypeInfoPropertyName = "NullableAllOfChatCompletionResponseMessageChatCompletionMessageListDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>?), TypeInfoPropertyName = "NullableOneOfChatCompletionRequestMessageContentPartTextChatCompletionRequestMessageContentPartImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Input?), TypeInfoPropertyName = "NullableInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType?), TypeInfoPropertyName = "NullableChatCompletionModerationInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Output?), TypeInfoPropertyName = "NullableOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType?), TypeInfoPropertyName = "NullableChatCompletionModerationOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType?), TypeInfoPropertyName = "NullableChatCompletionModerationErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType?), TypeInfoPropertyName = "NullableChatCompletionModerationResultsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType?), TypeInfoPropertyName = "NullableChatCompletionNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType?), TypeInfoPropertyName = "NullableChatCompletionNamedToolChoiceCustomType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart?), TypeInfoPropertyName = "NullableChatCompletionRequestAssistantMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?), TypeInfoPropertyName = "NullableChatCompletionRequestAssistantMessageContentPartDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionRequestMessageContentPartText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestFunctionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessage?), TypeInfoPropertyName = "NullableChatCompletionRequestMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartAudioInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartRefusalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionRequestSystemMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart?), TypeInfoPropertyName = "NullableChatCompletionRequestSystemMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionRequestToolMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart?), TypeInfoPropertyName = "NullableChatCompletionRequestToolMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>?), TypeInfoPropertyName = "NullableOneOfStringIListChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart?), TypeInfoPropertyName = "NullableChatCompletionRequestUserMessageContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole?), TypeInfoPropertyName = "NullableChatCompletionRequestUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType?), TypeInfoPropertyName = "NullableChatCompletionResponseMessageAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole?), TypeInfoPropertyName = "NullableChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole?), TypeInfoPropertyName = "NullableChatCompletionStreamResponseDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolType?), TypeInfoPropertyName = "NullableChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOption?), TypeInfoPropertyName = "NullableChatCompletionToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?), TypeInfoPropertyName = "NullableChatCompletionToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?), TypeInfoPropertyName = "NullableReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequest?), TypeInfoPropertyName = "NullableCreateChatCompletionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponseProperties?), TypeInfoPropertyName = "NullableCreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsShared?), TypeInfoPropertyName = "NullableModelIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierEnum?), TypeInfoPropertyName = "NullableServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityEnum?), TypeInfoPropertyName = "NullableVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchContextSize?), TypeInfoPropertyName = "NullableWebSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormat?), TypeInfoPropertyName = "NullableResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice?), TypeInfoPropertyName = "NullableVoiceIdsOrCustomVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestVariant2AudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StopConfiguration?), TypeInfoPropertyName = "NullableStopConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>?), TypeInfoPropertyName = "NullableOneOfChatCompletionToolCustomToolChatCompletions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>?), TypeInfoPropertyName = "NullableOneOfCreateChatCompletionRequestVariant2FunctionCallChatCompletionFunctionCallOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?), TypeInfoPropertyName = "NullableCreateChatCompletionRequestVariant2FunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason?), TypeInfoPropertyName = "NullableCreateChatCompletionStreamResponseChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsShared?), TypeInfoPropertyName = "NullableVoiceIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType?), TypeInfoPropertyName = "NullableCustomToolChatCompletionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>?), TypeInfoPropertyName = "NullableOneOfCustomToolChatCompletionsCustomFormatTextFormatCustomToolChatCompletionsCustomFormatGrammarFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType?), TypeInfoPropertyName = "NullableCustomToolChatCompletionsCustomFormatTextFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType?), TypeInfoPropertyName = "NullableCustomToolChatCompletionsCustomFormatGrammarFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax?), TypeInfoPropertyName = "NullableCustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?), TypeInfoPropertyName = "NullableModelIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?), TypeInfoPropertyName = "NullableModelResponsePropertiesPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PredictionContentType?), TypeInfoPropertyName = "NullablePredictionContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item?), TypeInfoPropertyName = "NullableResponseModalitiesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?), TypeInfoPropertyName = "NullableVoiceIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationInputType?), TypeInfoPropertyName = "NullableModerationInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationResultBodyType?), TypeInfoPropertyName = "NullableModerationResultBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?), TypeInfoPropertyName = "NullablePromptCacheTTLEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?), TypeInfoPropertyName = "NullablePromptCacheModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?), TypeInfoPropertyName = "NullablePromptCacheBreakpointParamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationMode?), TypeInfoPropertyName = "NullableModerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder?), TypeInfoPropertyName = "NullableListChatCompletionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder?), TypeInfoPropertyName = "NullableGetChatCompletionMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationResultBody>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>))]
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.StopConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ChatCompletionResponseMessage, global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText, global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionDeletedObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionDeletedObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionDeletedObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionDeletedObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionDeletedObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionDeletedObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationResultsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationResultsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceCustomTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioInputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2FunctionCallJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2FunctionCallNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatTextFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatTextFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PredictionContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PredictionContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseModalitiesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseModalitiesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListChatCompletionsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListChatCompletionsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetChatCompletionMessagesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetChatCompletionMessagesOrderNullableJsonConverter();
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
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}