
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_0ffeca8e0fd10c1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_fc9fff4902f1d3b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_88d857ee171edc8e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy_4cfbf8c2a0aac51c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>?), TypeInfoPropertyName = "MessageContentRefusalObject_76182275c0945058")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>?), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObject_13a1058b9149fee5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectObject), TypeInfoPropertyName = "AssistantObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>), TypeInfoPropertyName = "OneOfAssistantToolsCodeAssistantToolsFileSearchAssistantToolsFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantSupportedModels), TypeInfoPropertyName = "AssistantSupportedModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsCodeType), TypeInfoPropertyName = "AssistantToolsCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType), TypeInfoPropertyName = "AssistantToolsFileSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType), TypeInfoPropertyName = "AssistantToolsFileSearchTypeOnlyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType), TypeInfoPropertyName = "AssistantToolsFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum), TypeInfoPropertyName = "AssistantsApiResponseFormatOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOption), TypeInfoPropertyName = "AssistantsApiToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum), TypeInfoPropertyName = "AssistantsApiToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType), TypeInfoPropertyName = "AssistantsNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>), TypeInfoPropertyName = "AnyOfStringAssistantSupportedModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType), TypeInfoPropertyName = "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMessageRequestRole), TypeInfoPropertyName = "CreateMessageRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>), TypeInfoPropertyName = "OneOfStringIListOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>), TypeInfoPropertyName = "OneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRequestContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>), TypeInfoPropertyName = "OneOfAssistantToolsCodeAssistantToolsFileSearchTypeOnly2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>), TypeInfoPropertyName = "AllOfTruncationObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>), TypeInfoPropertyName = "AllOfAssistantsApiToolChoiceOptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestModel), TypeInfoPropertyName = "CreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType), TypeInfoPropertyName = "CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteAssistantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteAssistantResponseObject), TypeInfoPropertyName = "DeleteAssistantResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteMessageResponseObject), TypeInfoPropertyName = "DeleteMessageResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteThreadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteThreadResponseObject), TypeInfoPropertyName = "DeleteThreadResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchRanker), TypeInfoPropertyName = "FileSearchRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAssistantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType), TypeInfoPropertyName = "MessageContentImageFileObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail), TypeInfoPropertyName = "MessageContentImageFileObjectImageFileDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType), TypeInfoPropertyName = "MessageContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail), TypeInfoPropertyName = "MessageContentImageUrlObjectImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentRefusalObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType), TypeInfoPropertyName = "MessageContentRefusalObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType), TypeInfoPropertyName = "MessageContentTextAnnotationsFileCitationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType), TypeInfoPropertyName = "MessageContentTextAnnotationsFilePathObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextObjectType), TypeInfoPropertyName = "MessageContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextObjectText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>), TypeInfoPropertyName = "OneOfMessageContentTextAnnotationsFileCitationObjectMessageContentTextAnnotationsFilePathObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectObject), TypeInfoPropertyName = "MessageObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectStatus), TypeInfoPropertyName = "MessageObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason), TypeInfoPropertyName = "MessageObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectRole), TypeInfoPropertyName = "MessageObjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>), TypeInfoPropertyName = "OneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageContentTextObjectMessageContentRefusalObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType), TypeInfoPropertyName = "MessageRequestContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequestToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType), TypeInfoPropertyName = "ResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunCompletionUsageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectObject), TypeInfoPropertyName = "RunObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectStatus), TypeInfoPropertyName = "RunObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectRequiredAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType), TypeInfoPropertyName = "RunObjectRequiredActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunToolCallObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode), TypeInfoPropertyName = "RunObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason), TypeInfoPropertyName = "RunObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepCompletionUsageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType), TypeInfoPropertyName = "RunStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>), TypeInfoPropertyName = "OneOfRunStepDetailsToolCallsCodeOutputLogsObjectRunStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType), TypeInfoPropertyName = "RunStepDetailsToolCallsFileSearchResultObjectContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType), TypeInfoPropertyName = "RunStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>), TypeInfoPropertyName = "OneOfRunStepDetailsToolCallsCodeObjectRunStepDetailsToolCallsFileSearchObjectRunStepDetailsToolCallsFunctionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectObject), TypeInfoPropertyName = "RunStepObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectType), TypeInfoPropertyName = "RunStepObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectStatus), TypeInfoPropertyName = "RunStepObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>), TypeInfoPropertyName = "OneOfRunStepDetailsMessageCreationObjectRunStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode), TypeInfoPropertyName = "RunStepObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunToolCallObjectType), TypeInfoPropertyName = "RunToolCallObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunToolCallObjectFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubmitToolOutputsRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectObject), TypeInfoPropertyName = "ThreadObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectToolResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationObjectType), TypeInfoPropertyName = "TruncationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAssistantsOrder), TypeInfoPropertyName = "ListAssistantsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListMessagesOrder), TypeInfoPropertyName = "ListMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunsOrder), TypeInfoPropertyName = "ListRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateRunIncludeItem), TypeInfoPropertyName = "CreateRunIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsOrder), TypeInfoPropertyName = "ListRunStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ListRunStepsIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsIncludeItem), TypeInfoPropertyName = "ListRunStepsIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetRunStepIncludeItem), TypeInfoPropertyName = "GetRunStepIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantObjectObject?), TypeInfoPropertyName = "NullableAssistantObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>?), TypeInfoPropertyName = "NullableOneOfAssistantToolsCodeAssistantToolsFileSearchAssistantToolsFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantSupportedModels?), TypeInfoPropertyName = "NullableAssistantSupportedModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?), TypeInfoPropertyName = "NullableAssistantToolsCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?), TypeInfoPropertyName = "NullableAssistantToolsFileSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?), TypeInfoPropertyName = "NullableAssistantToolsFileSearchTypeOnlyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?), TypeInfoPropertyName = "NullableAssistantToolsFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?), TypeInfoPropertyName = "NullableAssistantsApiResponseFormatOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?), TypeInfoPropertyName = "NullableAssistantsApiToolChoiceOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?), TypeInfoPropertyName = "NullableAssistantsApiToolChoiceOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?), TypeInfoPropertyName = "NullableAssistantsNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>?), TypeInfoPropertyName = "NullableAnyOfStringAssistantSupportedModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?), TypeInfoPropertyName = "NullableReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?), TypeInfoPropertyName = "NullableCreateMessageRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>?), TypeInfoPropertyName = "NullableOneOfStringIListOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>?), TypeInfoPropertyName = "NullableOneOfMessageContentImageFileObjectMessageContentImageUrlObjectMessageRequestContentTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>?), TypeInfoPropertyName = "NullableOneOfAssistantToolsCodeAssistantToolsFileSearchTypeOnly2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>?), TypeInfoPropertyName = "NullableAllOfTruncationObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>?), TypeInfoPropertyName = "NullableAllOfAssistantsApiToolChoiceOptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?), TypeInfoPropertyName = "NullableCreateThreadAndRunRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?), TypeInfoPropertyName = "NullableCreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteAssistantResponseObject?), TypeInfoPropertyName = "NullableDeleteAssistantResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteMessageResponseObject?), TypeInfoPropertyName = "NullableDeleteMessageResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteThreadResponseObject?), TypeInfoPropertyName = "NullableDeleteThreadResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchRanker?), TypeInfoPropertyName = "NullableFileSearchRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?), TypeInfoPropertyName = "NullableMessageContentImageFileObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?), TypeInfoPropertyName = "NullableMessageContentImageFileObjectImageFileDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?), TypeInfoPropertyName = "NullableMessageContentImageUrlObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?), TypeInfoPropertyName = "NullableMessageContentImageUrlObjectImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?), TypeInfoPropertyName = "NullableMessageContentRefusalObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?), TypeInfoPropertyName = "NullableMessageContentTextAnnotationsFileCitationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?), TypeInfoPropertyName = "NullableMessageContentTextAnnotationsFilePathObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?), TypeInfoPropertyName = "NullableMessageContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>?), TypeInfoPropertyName = "NullableOneOfMessageContentTextAnnotationsFileCitationObjectMessageContentTextAnnotationsFilePathObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectObject?), TypeInfoPropertyName = "NullableMessageObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectStatus?), TypeInfoPropertyName = "NullableMessageObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?), TypeInfoPropertyName = "NullableMessageObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageObjectRole?), TypeInfoPropertyName = "NullableMessageObjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType?), TypeInfoPropertyName = "NullableMessageRequestContentTextObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectObject?), TypeInfoPropertyName = "NullableRunObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectStatus?), TypeInfoPropertyName = "NullableRunObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType?), TypeInfoPropertyName = "NullableRunObjectRequiredActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode?), TypeInfoPropertyName = "NullableRunObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason?), TypeInfoPropertyName = "NullableRunObjectIncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsMessageCreationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDetailsToolCallsCodeOutputLogsObjectRunStepDetailsToolCallsCodeOutputImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeOutputImageObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsCodeOutputLogsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsFileSearchObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsFileSearchResultObjectContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsFunctionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?), TypeInfoPropertyName = "NullableRunStepDetailsToolCallsObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectObject?), TypeInfoPropertyName = "NullableRunStepObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectType?), TypeInfoPropertyName = "NullableRunStepObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectStatus?), TypeInfoPropertyName = "NullableRunStepObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>?), TypeInfoPropertyName = "NullableOneOfRunStepDetailsMessageCreationObjectRunStepDetailsToolCallsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?), TypeInfoPropertyName = "NullableRunStepObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RunToolCallObjectType?), TypeInfoPropertyName = "NullableRunToolCallObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ThreadObjectObject?), TypeInfoPropertyName = "NullableThreadObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationObjectType?), TypeInfoPropertyName = "NullableTruncationObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAssistantsOrder?), TypeInfoPropertyName = "NullableListAssistantsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListMessagesOrder?), TypeInfoPropertyName = "NullableListMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunsOrder?), TypeInfoPropertyName = "NullableListRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateRunIncludeItem?), TypeInfoPropertyName = "NullableCreateRunIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsOrder?), TypeInfoPropertyName = "NullableListRunStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListRunStepsIncludeItem?), TypeInfoPropertyName = "NullableListRunStepsIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetRunStepIncludeItem?), TypeInfoPropertyName = "NullableGetRunStepIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssistantObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunToolCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateRunIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ListRunStepsIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetRunStepIncludeItem>))]
    internal sealed partial class AssistantsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AssistantsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AssistantsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AssistantObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteAssistantResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteAssistantResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteMessageResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteMessageResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteThreadResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteThreadResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListAssistantsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListAssistantsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetRunStepIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetRunStepIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantSupportedModelsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantSupportedModelsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateThreadAndRunRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteAssistantResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteAssistantResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteAssistantResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteMessageResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteMessageResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteMessageResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteThreadResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteThreadResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteThreadResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectRequiredActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListAssistantsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListAssistantsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListAssistantsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListAssistantsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListMessagesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListMessagesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateRunIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateRunIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunStepsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunStepsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunStepsIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunStepsIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunStepsIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetRunStepIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetRunStepIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetRunStepIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetRunStepIncludeItemNullableJsonConverter();
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
                    0 => new AssistantsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}