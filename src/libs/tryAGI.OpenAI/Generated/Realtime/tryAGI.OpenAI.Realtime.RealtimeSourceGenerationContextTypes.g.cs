
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
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItem>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItem? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudioType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallStatus? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutputType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutputStatus? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImageType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImageDetail? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminatorType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystem? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloper? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUser? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistant? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDiscriminator? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDiscriminatorRole? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2Role? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2ContentItem>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2ContentItem? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2ContentItemType? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2Role? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFieldsType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFieldsStatus? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2Role? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUserVariant2? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUserVariant2Role? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.ContentItem>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ContentItem? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputTextType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReferenceType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreatedType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreatedConversation? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAddedType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreatedType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeletedType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDoneType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.TranscriptionLanguage>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptionLanguage? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.LogProbProperties>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokens, global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDuration>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokens? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDuration? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrievedType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncatedType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventErrorType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventErrorError? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferClearedType? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommittedType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceivedType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStartedType? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStoppedType? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggeredType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompletedType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailedType? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgressType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferClearedType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStartedType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStoppedType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimitName? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDeltaType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDoneType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDeltaType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDoneType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedPart? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAddedPartType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDoneType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDonePart? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDonePartType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreatedType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDoneType? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDeltaType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDoneType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDeltaType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDoneType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompletedType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailedType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgressType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAddedType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDoneType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDeltaType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDoneType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreatedType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGA>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGA? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGA? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdatedType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdatedType? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel?>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudio? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInput? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioOutput? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens?>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncation? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAObject? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAOutputModalitie>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAOutputModalitie? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAModel?>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAModel? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudio? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudioInput? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudioInputNoiseReduction? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAAudioOutput? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAIncludeItem>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAIncludeItem? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens?>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetection? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetectionType? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAType? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudio? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseClientSecret? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseTurnDetection? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAType? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAIncludeItem? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudio? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnum? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnum2? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnumType? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncationEnumTokenLimits? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.OneOf<string, global::tryAGI.OpenAI.Realtime.InputTextContent, global::tryAGI.OpenAI.Realtime.InputImageContent, global::tryAGI.OpenAI.Realtime.InputFileContent>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ToolChoiceFunctionType? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ToolChoiceMCPType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageDurationType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokensType? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.TranscriptTextUsageTokensInputTokenDetails? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.VoiceIdsSharedEnum? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ServerEvent? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ServerEventDiscriminator? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType? Type404 { get; set; }

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
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2ContentItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.ContentItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.TranscriptionLanguage>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.LogProbProperties>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdatedRateLimit>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAOutputModalitie>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAIncludeItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseModalitie>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? ListType26 { get; set; }
    }
}