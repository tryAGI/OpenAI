
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSourceGenerationContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AudioTranscription? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.AudioTranscriptionModel?>? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AudioTranscriptionModel? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AudioTranscriptionDelay? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponse? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponseModel?>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponseModel? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.CallableToolAllowedCaller? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.FileInputDetail? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ImageDetail? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.InputFileContent? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.InputFileContentType? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.PromptCacheBreakpointConfig? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.InputImageContent? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.InputImageContentType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.InputTextContent? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.InputTextContentType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.LogProbProperties? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.MCPListToolsTool? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.MCPTool? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.MCPToolType? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.MCPToolConnectorId? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.Realtime.MCPToolFilter>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.MCPToolFilter? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.CallableToolAllowedCaller>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum2?>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.MCPToolRequireApprovalVariant1Enum2? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.NoiseReductionType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.PromptVariant1? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.PromptCacheBreakpointConfigMode? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.PromptCacheBreakpointConfigTtl? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormatType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormatType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormatType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreateType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItem? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDeleteType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieveType? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncateType? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppendType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClearType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommitType? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClearType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancelType? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreateType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParams? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdateType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventTranscriptionSessionUpdate? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeClientEventTranscriptionSessionUpdateType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemDiscriminator? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemDiscriminatorType? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallObject? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallStatus? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutputObject? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutputType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutputStatus? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantObject? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantStatus? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantRole? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItem>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItem? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItemType? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemObject? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemStatus? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemRole? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItem>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItem? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItemType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserObject? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserStatus? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserRole? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItem>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItem? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeFunctionToolType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequestType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponseType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPHTTPError? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPHTTPErrorType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPListToolsType? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.MCPListToolsTool>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPProtocolError? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPProtocolErrorType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCallType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeMCPProtocolError, global::tryAGI.OpenAI.Realtime.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.Realtime.RealtimeMCPHTTPError>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPToolExecutionError? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPToolExecutionErrorType? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeReasoning? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeReasoningEffort? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseObject? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatus? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetails? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsReason? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseStatusDetailsError? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeConversationItem>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseAudio? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseAudioOutput? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.VoiceIdsShared? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseUsage? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageInputTokenDetails? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageOutputTokenDetails? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseOutputModalitie>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseOutputModalitie? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeResponseMaxOutputTokens?>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseMaxOutputTokens? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsOutputModalitie>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsOutputModalitie? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsAudio? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsAudioOutput? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoice? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ToolChoiceOptions? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ToolChoiceFunction? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ToolChoiceMCP? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsMaxOutputTokens?>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsMaxOutputTokens? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<string, global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsConversation?>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsConversation? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreatedType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreatedConversation? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAddedType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreatedType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeletedType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDoneType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.TranscriptionLanguage>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptionLanguage? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.LogProbProperties>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokens, global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDuration>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokens? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDuration? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrievedType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncatedType? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventErrorType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventErrorError? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferClearedType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommittedType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceivedType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStartedType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStoppedType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggeredType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompletedType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailedType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgressType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferClearedType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStartedType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStoppedType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimitName? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDeltaType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDoneType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDeltaType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDoneType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedPart? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedPartType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDoneType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDonePart? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDonePartType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreatedType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDoneType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDeltaType? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDoneType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDeltaType? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDoneType? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompletedType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailedType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgressType? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAddedType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDoneType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDeltaType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDoneType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreatedType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGA>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGA? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGA? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdatedType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdatedType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel?>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudio? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInput? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioOutput? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens?>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncation? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAObject? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAOutputModalitie>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAOutputModalitie? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAModel?>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAModel? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudio? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudioInput? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudioInputNoiseReduction? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudioOutput? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAIncludeItem>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAIncludeItem? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens?>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetection? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetectionType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudio? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseClientSecret? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseTurnDetection? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAType? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAIncludeItem? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudio? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnum? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnum2? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnumType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnumTokenLimits? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<string, global::tryAGI.OpenAI.Realtime.InputTextContent, global::tryAGI.OpenAI.Realtime.InputImageContent, global::tryAGI.OpenAI.Realtime.InputFileContent>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ToolChoiceFunctionType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ToolChoiceMCPType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDurationType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokensType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokensInputTokenDetails? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.VoiceIdsSharedEnum? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ServerEvent? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ServerEventDiscriminator? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType? Type357 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.Realtime.MCPToolFilter>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.CallableToolAllowedCaller>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistantContentItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystemContentItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItem>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.MCPListToolsTool>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeConversationItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeResponseOutputModalitie>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeResponseCreateParamsOutputModalitie>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.TranscriptionLanguage>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.LogProbProperties>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAOutputModalitie>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAIncludeItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? ListType22 { get; set; }
    }
}