
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
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
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AddUploadPartRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKey? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeyObject? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeyOwner? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeyCreateResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApiKeyList? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApiKeyListObject? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AdminApiKey>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssignedRoleDetails? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObject? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectObject? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsCode? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearch? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFunction? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResources? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResourcesCodeInterpreter? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResourcesFileSearch? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantStreamEvent? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEvent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEvent? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEvent? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEvent? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorEvent? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEvent? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantSupportedModels? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsCodeType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchRankingOptions? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFunctionType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionObject? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatText? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonObject? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchema? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOption? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoice? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoiceType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioResponseFormat? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscription? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionModel? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionDelay? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionResponse? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionResponseModel? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLog? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogEventType? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProject? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActor? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyCreated? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyCreatedData? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdated? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdatedChangesRequested? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyDeleted? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalKeyRegistered? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalKeyRemoved? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRegistered? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRegisteredData? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRemoved? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupCreated? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupCreatedData? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupUpdated? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupDeleted? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogScimEnabled? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogScimDisabled? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteSent? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteSentData? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteAccepted? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteDeleted? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistCreated? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogLoginFailed? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogLogoutFailed? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogOrganizationUpdated? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogOrganizationUpdatedChangesRequested? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectCreated? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectCreatedData? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectUpdated? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectUpdatedChangesRequested? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectArchived? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectDeleted? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdated? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitDeleted? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleCreated? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUpdated? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUpdatedChangesRequested? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleDeleted? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleBoundToResource? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUnboundFromResource? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreated? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdatedChangesRequested? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderCreated? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderUpdated? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderDeleted? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingCreated? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingUpdated? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingDeleted? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserAdded? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserAddedData? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserUpdated? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserUpdatedChangesRequested? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserDeleted? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateCreated? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateUpdated? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateDeleted? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesActivated? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesDeactivated? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorSession? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorApiKey? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorApiKeyType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorUser? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorServiceAccount? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Batch? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchObject? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchErrors? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BatchError>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchError? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchStatus? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchRequestCounts? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsage? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsageInputTokensDetails? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsageOutputTokensDetails? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchFileExpirationAfter? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchFileExpirationAfterAnchor? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Certificate? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CertificateObject? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CertificateCertificateDetails? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedTools? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionDeleted? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionDeletedObject? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionFunctionCallOption? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionFunctions? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionParameters? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionList? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionListObject? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponse? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageList? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListObject? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItem? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemImageUrl? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemFile? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCall? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallFunction? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminator? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModeration? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationResults? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationError? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminator? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminator? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationErrorType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationResultsType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationResultBody>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBody? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminator? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessage? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminator? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParam? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessage? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageRole? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageFunctionCall? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRole? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamOptionsVariant1? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDelta? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaAudio? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaFunctionCall? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprob? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTool? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParam? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminator? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutput? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutputType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CodeInterpreterFileOutputFile>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutputFile? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTextOutput? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTextOutputType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTool? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParam? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CallableToolAllowedCaller? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallStatus? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilter? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilterType? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompleteUploadRequest? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsage? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilter? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerAction? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParam? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickAction? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParam? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressAction? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParam? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParam? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParam? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParam? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParam? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminator? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminatorType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerAction>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotImage? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotImageType? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCall? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallType? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallSafetyCheckParam? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallStatus? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutput? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputStatus? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputStatus? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResource? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResourceObject? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerFileResource>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileResource? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResource? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResourceObject? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerResource>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResource? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfter? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfterAnchor? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceMemoryLimit? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicy? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicyType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Content5? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContent? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContent? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItem? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Message? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResource? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCall? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCall? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCall? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCall? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutput? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalTools? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdate? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItem? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Program? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutput? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBody? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCall? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCall? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutput? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCall? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutput? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListTools? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalRequest? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCall? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCall? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutput? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminator? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminatorType? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemList? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemListObject? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam2? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResult? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultApiSource? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultObject? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultAmount? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultQuantityUnit? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequest? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortEnum? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResources? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesCodeInterpreter? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearch? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequest? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestEndpoint? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestCompletionWindow? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequest? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponseProperties? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsShared? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityEnum? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptions? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocation? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSize? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormat? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminator? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2Audio? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationParam? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StopConfiguration? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContent? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletions? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoice? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceLogprobs? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseObject? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponse? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequest? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequestModel? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponse? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoice? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseObject? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBody? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParam? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParam? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminator? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminator? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerFileBody? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateEmbeddingRequestModel?>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestModel? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestEncodingFormat? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponse? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Embedding>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Embedding? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponseObject? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponseUsage? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessage? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItem? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceSamplingParams? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsSource? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItem? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItemSimpleInputMessage? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLabelModelGrader? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLabelModelGraderType? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateEvalItem>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfigType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRequest? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig, global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig, global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderStringCheck? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarity? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPython? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModel? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceType? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplate? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReference? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParams? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Tool? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParamsText? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfiguration? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalResponsesSource>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSource? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRunRequest? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequest? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequestPurpose? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileExpirationAfter? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningCheckpointPermissionRequest? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequest? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestModel? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparameters? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationWandb? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethod? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupBody? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupUserBody? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequest? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestBackground? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestModel? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestSize? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFidelity? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestQuality? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequest? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModel? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestQuality? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestResponseFormat? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestOutputFormat? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestSize? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModeration? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestBackground? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestStyle? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequest? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestModel? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestSize? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequest? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestRole? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObject? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponseProperties? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsParam? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequest? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestModel? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponse? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResult? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategories? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryScores? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponse? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseProperties? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsParam? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResponsesEnum? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3Truncation? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Reasoning? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputParam? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.IncludeEnum? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContextManagementParam? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunRequest? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObject? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequest? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestModel? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsShared? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice2? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminator? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBody? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyInterval? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendAlertNotificationChannel? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequest? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequest? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestModel? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesFileSearch? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResources? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequest? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestModel? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionInclude? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfig? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegment? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJson? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionLanguage? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEvent? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEvent? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEvent? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionWord>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionWord? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionSegment? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequestModel? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseJson? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequest? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequestPurpose? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileRequest? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreRequest? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreExpirationAfter? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceConsentRequest? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequest? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminator? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallType? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCaller? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputType? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParam? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResource? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputStatusEnum? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResource? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResourceVariant2? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatus? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsType? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustom? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteAssistantResponse? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteAssistantResponseObject? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteCertificateResponse? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteCertificateResponseObject? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFileResponse? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFileResponseObject? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteMessageResponse? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteMessageResponseObject? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteModelResponse? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteThreadResponse? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteThreadResponseObject? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreFileResponse? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreResponseObject? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversation? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResource? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedRoleAssignmentResource? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEventEvent? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEventData? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessageRole? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessageType? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParam? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?>? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModel? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam>? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamQuality? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?>? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamSize? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModeration? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamBackground? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<float>, string>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmbeddingObject? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorDetailsResource? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorEventEvent? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Eval? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalObject? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig>? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfig? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfig? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderLabelModel? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalApiError? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfigType? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModel? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPython? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPythonVariant2? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModel? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheck? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarity? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarityVariant2? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemRole? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContent? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentItem? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContent? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentOutputText? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemInputImage? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudio? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentOutputTextType? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemInputImageType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceType? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileIdSourceType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalList? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalListObject? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Eval>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfigType? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSourceType? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRun? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunObject? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunResultCounts? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerModelUsageItem? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunList? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunListObject? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRun>? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItem? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemObject? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemResult>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemResult? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSample? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleUsage? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemList? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemListObject? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItem>? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsSourceType? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileExpirationAfterAnchor? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FilePath? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FilePathType? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchRanker? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallType? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallStatus? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparameters? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOMethod? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethodType? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedMethod? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementMethod? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMulti? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparameters? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningCheckpointPermission? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegration? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegrationType? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegrationWandb? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJob? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuningJobErrorVariant1, object>? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobErrorVariant1? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparameters? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobObject? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobStatus? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpoint? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpointObject? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEvent? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventObject? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventLevel? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventType? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContent? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContent? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminator? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCall? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallType? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallStatus? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutput? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputType? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputStatus? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResourceVariant2? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModelType? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiType? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Graders? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminator? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPythonType? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModelType? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModelSamplingParams? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheckType? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheckOperation? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarityType? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Group? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupObject? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupDeletedResource? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupDeletedResourceObject? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupListResource? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupListResourceObject? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupResponse>? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponse? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUser? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUserUserType? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResourceWithSuccess? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponseGroupType? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupRoleAssignment? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupRoleAssignmentObject? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Role? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUser? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserAssignment? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserAssignmentObject? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserDeletedResource? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserDeletedResourceObject? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermission? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Image2? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventType? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditCompletedEventSize?>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventSize? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventQuality? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventBackground? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsage? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditPartialImageEventSize?>? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventSize? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventQuality? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventBackground? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEvent? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminator? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventType? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventSize? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventQuality? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventBackground? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventType? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventSize? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventQuality? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventBackground? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEvent? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminator? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenTool? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolType? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModel? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolQuality? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolSize? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolOutputFormat? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModeration? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolBackground? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolInputImageMask? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenActionEnum? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponse? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image2>? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseBackground? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseOutputFormat? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImagesResponseSize?>? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseSize? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseQuality? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenUsage? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsageInputTokensDetails? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioType? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1Format? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminator? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminatorType? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItem? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Item? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParam? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParam? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParam? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParam? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminator? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminatorType? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessage? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageType? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageRole? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageStatus? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResourceVariant2? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Invite? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteObject? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRole? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteStatus? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProject? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectRole? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteDeleteResponse? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteDeleteResponseObject? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteListResponse? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteListResponseObject? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectGroupBody? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequest? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestRole? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteRequestProject>? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProject? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProjectRole? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessage? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParam? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParam? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParam? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParam? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParam? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParam? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponse? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminator? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminatorType? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResource? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminator? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminatorType? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsResponse? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantObject>? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsResponse? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsResponseObject? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLog>? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListBatchesResponse? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Batch>? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListBatchesResponseObject? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListCertificatesResponse? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationCertificate>? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificate? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListCertificatesResponseObject? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesResponse? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OpenAIFile>? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFile? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningCheckpointPermission>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponse? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint>? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobEventsResponse? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobEvent>? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesResponse? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObject>? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObject? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListModelsResponse? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListModelsResponseObject? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Model18>? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Model18? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponse? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJob>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesResponse? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationProjectCertificate>? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificate? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesResponseObject? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsResponse? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepObject>? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObject? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsResponse? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunObject>? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObject? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesResponse? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileObject>? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObject? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresResponse? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreObject>? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObject? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptRequest? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptSession? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLive? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionAudioParam? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptSessionType? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallReferRequest? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallRejectRequest? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEvent? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEvent? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParam? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParam? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParam? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParam? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminator? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminatorType? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveConnectParams? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateRequest? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionCreateParams? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransport? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponse? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponseSession? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEvent? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminator? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkPathParams? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkRequest? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionForkParams? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParam? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientConfigParam? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransport? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransportType? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunk? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuth? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuthType? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEventDiscriminator? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequest? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminator? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminatorType? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponse? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session5? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport2? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2Type? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminator? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminatorType? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEvent? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandConnectParams? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandPathParams? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEvent? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRinging? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnswered? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailed? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStarted? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdated? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuted? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppended? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppended? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppended? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreated? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEvent? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosed? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEvent? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEvent? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransportType? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallType? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecAction? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallStatus? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputType? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputStatus? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProbProperties? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalRequestType? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseType? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseResourceType? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsType? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsTool? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPTool? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolType? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolConnectorId? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolFilter? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallType? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallError? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallStatus? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolError? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionError? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPError? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminator? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectType? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectType? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObject? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObjectType? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObject? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectType? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectText? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObject? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectText? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObject? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectObject? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDelta? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectObject? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectStatus? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetails? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectRole? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObjectType? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1Event? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2Event? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3Event? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4Event? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5Event? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelObject? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIds? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponses? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsCompaction? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLiveEnum? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponsesEnum? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsSharedEnum? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequest? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResources? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyCertificateRequest? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyMessageRequest? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyRunRequest? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequest? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResources? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesCodeInterpreter? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesFileSearch? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NoiseReductionType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileObject? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFilePurpose? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileStatus? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateObject? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponse? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponse? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetention? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionObject? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionType? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateObject? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponse? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponse? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlert? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertObject? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertCurrency? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertInterval? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResource? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResource? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert>? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudio? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudioType? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContent? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContent? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContent? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminator? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminatorType? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItem? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminator? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminatorType? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageRole? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContent? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageStatus? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminator? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PermissionErrorResponse? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContentType? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Project? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectObject? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicProjectResidency? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKey? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyObject? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwner? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerType? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerUser? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerServiceAccount? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponse? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponseObject? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectApiKey>? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectCreateRequest? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetention? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionObject? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionType? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroup? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupObject? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupGroupType? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResource? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResource? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResourceObject? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup>? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissions? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponse? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponseObject? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Project>? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissions? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsObject? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsMode? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponse? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimit? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitObject? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponse? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponseObject? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectRateLimit>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccount? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountObject? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountRole? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKey? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponse? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponse? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectServiceAccount>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlert? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertObject? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertCurrency? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertInterval? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResource? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectSpendAlert>? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUpdateRequest? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUser? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserObject? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserCreateRequest? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponse? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponseObject? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserListResponse? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectUser>? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserUpdateRequest? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptVariant1? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateOrganizationRoleBody? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResource? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResourceObject? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreate? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItem? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDelete? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDeleteType? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieve? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieveType? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncate? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncateType? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppend? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppendType? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClear? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClearType? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommit? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommitType? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClear? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClearType? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancel? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancelType? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreate? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParams? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdate? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdateType? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequest? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdate? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdateType? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponse? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseObject? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatus? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetails? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsage? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetails? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageOutputTokenDetails? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseModalitie? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceOptions? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunction? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCP? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreated? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeleted? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeletedType? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailed? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedError? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrieved? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncated? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncatedType? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventError? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorType? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCleared? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferClearedType? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommitted? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommittedType? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStarted? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStartedType? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStopped? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStoppedType? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompleted? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompletedType? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailed? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailedType? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgress? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgressType? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdated? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedType? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDelta? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDeltaType? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDone? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDoneType? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDelta? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDeltaType? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDone? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDoneType? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAdded? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedType? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPart? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPartType? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDone? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDoneType? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePart? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePartType? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreated? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDone? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDelta? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDone? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDelta? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDone? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDoneType? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompleted? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompletedType? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailed? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailedType? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgress? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgressType? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAdded? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDone? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDelta? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDeltaType? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDone? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDoneType? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreated? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSession? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdated? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreated? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreatedType? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdated? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdatedType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallCreateRequest? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallReferRequest? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallRejectRequest? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEvent? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminator? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParams? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdate? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdateType? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUser? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponse? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListTools? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCall? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequest? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminator? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReference? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceObject? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItemType? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session2? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionTool? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionToolType? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPError? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListToolsType? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolError? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCallType? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoning? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoningEffort? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponse? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseObject? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatus? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetails? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsError? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudio? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudioOutput? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsage? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetails? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageOutputTokenDetails? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseOutputModalitie? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEvent? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventError? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDone? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminator? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorType? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorError? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPart? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePart? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdated? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionObject? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModalitie? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModel? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncation? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponse? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEvent? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppendType? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionCloseType? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdateType? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequest? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSession? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEvent? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminator? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionType? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudio? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInput? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioOutput? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputTranscription? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputNoiseReduction? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudio? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInput? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputTranscription? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputNoiseReduction? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioOutput? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum2? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumType? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnum? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummary? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningContext? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningGenerateSummary? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemType? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContent? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemStatus? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Response? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Truncation? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Object? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Status? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsBody? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorVariant1? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsage? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptions? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnostics? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Moderation? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConversation? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEventType? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEventType? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingEvent? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEvent? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEventType? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateType? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEventType? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEventType? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEvent? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEventType? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorCode? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEvent? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEventType? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEvent? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEventType? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonObjectType? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaType? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextType? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammar? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammarType? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPython? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPythonType? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEvent? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEventType? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEventType? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemList? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemListObject? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemResource>? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProb? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProbTopLogprob? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEventType? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseModalitiesVariant1Item? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEventType? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEventType? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Annotation? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextParam? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceParam? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEvent? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEventType? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEventType? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEventType? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventType? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCode? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEvent? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEventType? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInput? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventType? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventSteer? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventError? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItem? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParam? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminator? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventType? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventSteer? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReason? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInput? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEvent? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminator? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEventType? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEventType? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageInputTokensDetails? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsError? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsErrorType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorPayload? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEvent? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminator? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEvent? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminator? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEvent? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEventVariant2? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleObject? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResource? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResourceObject? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResource? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResourceObject? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetails>? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunCompletionUsageVariant1? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderRequest? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponse? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadata? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataErrors? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataTokenUsage? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectObject? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectStatus? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredAction? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionType? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObject? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastError? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastErrorCode? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetails? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepCompletionUsageVariant1? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObject? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectObject? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectDelta? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectObject? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectType? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectStatus? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastError? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastErrorCode? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1Event? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2Event? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3Event? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4Event? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5Event? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6Event? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7Event? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1Event? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2Event? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3Event? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4Event? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5Event? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6Event? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7Event? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8Event? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9Event? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10Event? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectType? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectFunction? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDeltaEventType? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventType? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventUsage? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendAlertNotificationChannelType? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategy? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequest? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchema? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObject? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectObject? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResources? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1Event? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToggleCertificatesRequest? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionTool? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchTool? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerTool? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewTool? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchTool? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParam? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParam? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParam? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParam? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParam? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParam? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewTool? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParam? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminator? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminatorType? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowed? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedType? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedMode? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustom? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustomType? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunctionType? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCPType? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypes? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParam? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParam? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypesType? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputTool? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParam? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminator? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventType? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventType? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEventType? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDurationType? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensType? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategy? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategyEnum? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObjectType? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateGroupBody? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBody? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBodyRetentionType? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBody? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBodyRetentionType? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBody? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreRequest? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVoiceConsentRequest? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Upload? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadStatus? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadObject? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadCertificateRequest? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPart? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPartObject? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResultObject? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResult? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultApiSource? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultObject? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResultObject? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResultObject? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResult? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResultObject? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResult? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResultObject? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponse? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponseObject? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucket? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketObject? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem>? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResult? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminator? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResultObject? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultObject? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.User? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserObject? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1Object? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjects? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsObject? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UserProjectsDataItem>? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsDataItem? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponse? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponseObject? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResource? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResourceObject? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser>? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponse? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponseObject? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.User>? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignment? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignmentObject? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleUpdateRequest? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfigType? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderRequest? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderResponse? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?>? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObject? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectFileCounts? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponse? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseObject? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectObject? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectStatus? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastError? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectObject? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectFileCounts? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectStatus? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequest? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObject? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultItem? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPage? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResource? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResource? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResourceObject? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VoiceConsentResource>? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResource? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResourceObject? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsSharedEnum? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResource? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceObject? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceType? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFind? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFindType? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPageType? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearch? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchType? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSource? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSourceType? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolType? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolFilters? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolSearchContextSize? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallType? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallStatus? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallAction? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpired? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentEvent? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailed? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReady? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspended? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequired? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreated? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailed? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdle? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgress? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelled? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledData? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledObject? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledType? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompleted? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedData? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedObject? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedType? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpired? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredData? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredObject? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredType? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailed? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedData? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedObject? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedType? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceled? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledData? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledObject? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledType? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailed? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedData? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedObject? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedType? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceeded? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededData? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededObject? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededType? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelled? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledObject? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledType? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailed? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedData? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedObject? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedType? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceeded? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededObject? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededType? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncoming? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingData? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingObject? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingType? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncoming? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingData? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataType? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingObject? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingType? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncoming? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingData? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingObject? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingType? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelled? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledData? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledObject? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledType? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompleted? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedData? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedObject? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedType? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailed? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedData? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedObject? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedType? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncomplete? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteData? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteObject? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteType? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreated? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedObject? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedType? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedData? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssued? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedObject? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedType? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedData? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreated? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedObject? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedType? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedData? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssued? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedObject? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedType? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedData? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorType? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentSteer? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputType? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBodyType? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTTLEnum? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheModeEnum? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamMode? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationMode? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationConfigParam? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationPolicyParam? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParamType? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParam? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamType? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamMediaType? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParamType? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStatus? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRole? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfig? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentType? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBody? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBodyType? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBody? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBodyType? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBody? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBodyType? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminator? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminatorType? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TopLogProb? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProb? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContentType? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContent? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContentType? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContentType? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContentType? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContentType? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetail? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentType? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContent? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContentType? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileInputDetail? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentType? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase2? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageType? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem3? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminator? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminatorType? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCaller? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerType? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCaller? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerType? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminator? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParam? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParamType? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParamType? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminator? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageBackground? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageOutputFormat? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallType? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallStatus? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallQuality? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickButtonType? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParamType? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickActionType? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CoordParam? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParamType? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressActionType? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParamType? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParamType? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParamType? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParamType? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParamType? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallType? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolType? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankerVersionType? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HybridSearchOptions? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankingOptions? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Filters2? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolType? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolType? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerEnvironment? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewToolType? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerMemoryLimit? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy2? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParamType? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParamType? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParam? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamType? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy3? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem2? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalSkillParam? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParam? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParamType? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParam? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParamType? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamType? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant1? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParam? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParamType? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GrammarSyntax1? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParam? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParamType? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamType? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format2? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmptyModelParam? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParam? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParamType? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamType? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem13? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParamType? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocation? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocationType? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContextSize? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContentType? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewToolType? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParamType? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputType? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsType? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramType? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputStatus? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputType? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBodyType? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogsType? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImageType? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecActionType? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellAction? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallStatus? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResource? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResourceType? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResource? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResourceType? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallType? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant12? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContent? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputType? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatus? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallType? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatus? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputType? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolErrorType? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionErrorType? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPErrorType? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DetailEnum? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemStatus? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParamType? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParam? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParamType? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParam? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParamType? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileDetailEnum? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParam? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParamType? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamType? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParam? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParamType? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParam? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParamType? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParam? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParamType? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParamType? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParam? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem14>? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem14? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminator? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParamType? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolSearchOutputTool>? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamType? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamRole? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParamType? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellActionParam? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemStatus? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamType? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant13? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentParam? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatusParam? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParam? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParamType? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParamType? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParamType? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemStatus? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParamType? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResource? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResourceObject? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenOutputTokensDetails? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenInputUsageDetails? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomVoiceParam? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParam? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParamType? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesServiceTier? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningEffort? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningSummary? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationReasoningInputParam? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTextVerbosity? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationTextInputParam? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParamType? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParamType? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParamType? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerMemoryLimit? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParam? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParamType? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParam? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamType? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParam? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParamType? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyVariant1? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1Discriminator? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsVariant1Item>? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsVariant1Item? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminator? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParam? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParamType? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalSkillParam? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParam? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParamType? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveLocalSkillParam>? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamType? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant14? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1Discriminator? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParam? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParamType? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParam? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParamType? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParam? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParamType? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParam? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParamType? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParam? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParamType? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceEnum? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParamType? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParam? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParamType? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParam? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParamType? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParam? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParamType? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParam? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParamType? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParam? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParamType? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceValueEnum? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem15? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminator? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem16>? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem16? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminator? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant2?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant2? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2Discriminator? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParamType? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1Discriminator? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialMessageStatus? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParamType? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4>? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem4? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminator? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItem? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminator? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedServerEventParam? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParam? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem17>? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem17? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant22?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant22? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2Discriminator? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponse? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponseType? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminator? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminatorType? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParamType? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParamType? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CyberAccessProgramEnum? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CacheMissReasonTypeEnum? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBody? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBodyType? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input4? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminator? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminatorType? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output5? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminator? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminatorType? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ShellCallOutputDelta? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationBody? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateConversationBody? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResourceObject? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNoticeType? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNotice? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResource? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResourceObject? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertErrorType? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResource? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResourceObject? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketWidth? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageGroupBy? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageApiSource? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResult? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResultObject? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucket? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketObject? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageResult>? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResource? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageBucket>? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorDetails? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorResponse? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsagePermissionErrorResponse? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageOrder? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageStatus? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponse? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseObject? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider2? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResource? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResourceObject? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalStorageResponse>? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParams? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParamsType? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBody? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider3? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResource? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResourceObject? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrency? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitInterval? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatus? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcement? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResource? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBody? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyCurrency? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyInterval? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResource? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResource? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResourceObject? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBody? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResource? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateProjectServiceAccountApiKeyBody? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBody? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContentProvenanceBody? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceCheckObject? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceDetectionResultApi? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAValidationStateApi? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResult? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResultType? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResult? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResultType? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResource? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2>? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem2? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminator? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrderEnum? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModel? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModelEnum? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoStatus? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSize? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error22? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResource? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResourceObject? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResource? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResourceObject? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam2? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSeconds? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoMultipartBody? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoJsonBody? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoCharacterBody? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoCharacterResource? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoReferenceInputParam? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditMultipartBody? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditJsonBody? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendMultipartBody? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendJsonBody? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResource? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResourceObject? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoContentVariant? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoRemixBody? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationEnum? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnum? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnumEnum? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsBody? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResource? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResourceObject? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheRetentionEnum? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum2? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResponseMethodPublicBody? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemField? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminator? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminatorType? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResource? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResourceObject? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField>? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResource? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResourceObject? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResource? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResourceObject? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillResource>? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillBody? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetDefaultSkillVersionBody? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResource? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResourceObject? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResource? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResourceObject? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResource? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResourceObject? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillVersionResource>? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillVersionBody? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResource? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResourceObject? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflowTracing? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflow? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, int?, bool?, double?>? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionRateLimits? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionStatus? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionFileUpload? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionHistory? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionChatkitConfiguration? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResource? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResourceObject? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowTracingParam? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowParam? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, int?, bool?, double?>? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParam? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParamAnchor? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RateLimitsParam? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomaticThreadTitlingParam? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileUploadParam? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HistoryParam? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitConfigurationParam? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatSessionBody? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputText? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputTextType? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedText? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedTextType? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AttachmentType? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Attachment? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoice9? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InferenceOptions? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItem? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemObject? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemType? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem5>? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem5? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminator? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment>? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSource? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSourceType? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotation? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationType? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSource? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSourceType? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotation? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationType? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputText? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextType? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3>? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem3? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminator? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItem? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemObject? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemType? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText>? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItem? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemObject? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemType? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallStatus? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItem? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemObject? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemType? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskType? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItem? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemObject? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemType? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupTask? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItem? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemObject? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemType? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask>? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItem? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminator? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminatorType? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResource? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResourceObject? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadItem>? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatus? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatusType? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatus? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatusType? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatus? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatusType? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResource? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceObject? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Status? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminator? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResource? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResourceObject? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResource? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResourceObject? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource>? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputText? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextType? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetailParam? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImage? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImageType? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartsItem? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminator? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContent? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessage? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageRole? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageType? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInput? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2Item? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminator? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicate? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicateType? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueParam? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceOptionParam? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoice? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoiceType? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceOptionParam>? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreLevelParam? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScore? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScoreType? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreLevelParam>? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParam? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminator? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminatorType? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequest? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicate? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicateType? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueResource? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceProbabilityResource? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoice? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoiceType? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceProbabilityResource>? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreProbabilityResource? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScore? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScoreType? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreProbabilityResource>? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusal? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusalType? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResource? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminator? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminatorType? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageResource? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionResponse? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnswerResource>? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrderParam? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeParam? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeResource? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentStatusResource? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResource? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInline? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInlineType? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResource? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminator? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInline? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInlineType? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResource? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminator? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResource? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResourceObject? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResource? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResourceObject? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PublicEnvironmentResource>? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorBodyResource? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse2? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesParam? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetupCommandParam? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessParam? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyParam? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopParam? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParam? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminator? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInline? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInlineType? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParam? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminator? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInline? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInlineType? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParam? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminator? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParam? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHostedType? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParam? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminator? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminatorType? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentEnvironmentParams? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFilePageObjectResource? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResource? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResourceObject? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileListResource? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource>? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentObjectResource? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResource? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResourceType? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResource? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResourceType? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResource? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminator? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentStatusResource? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentResource? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionMessageRoleResource? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputText? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputTextType? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImage? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImageType? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputText? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputTextType? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResource? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminator? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemStatusResource? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseResource? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResource? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResourceType? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource>? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResource? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResourceType? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResource? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResourceType? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource>? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusResource? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResource? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResourceType? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputText? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputTextType? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImage? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImageType? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResource? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminator? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminatorType? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputResource? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResourceType? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResource? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResourceType? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResource? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResourceType? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResource? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResourceType? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResource? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResourceType? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldResource? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationOptionResource? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResource? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminator? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminator? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResource? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearchType? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOther? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOtherType? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResource? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminator? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResource? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResourceType? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResource? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResourceType? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResourceType? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResourceType? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResource? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminator? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResource? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResourceObject? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnItemResource>? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnObjectResource? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnStatusResource? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorCodeResource? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorResource? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource2? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource2? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenUsageResource? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnResource? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResource? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResourceObject? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TurnResource>? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortResource? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryResource? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningResource? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceText? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceTextType? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResource? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminator? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityResource? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResource? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResource? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResource? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminator? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginResource? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeResource? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeResource? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationResource? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUse? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResource? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminator? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigResource? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResource? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResourceObject? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolResource>? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResource? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResourceObject? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentResource>? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortParam? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryParam? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningParam? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamText? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamTextType? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchemaType? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParam? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminator? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminatorType? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityParam? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextParam? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierParam? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParam? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginParam? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeParam? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeParam? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationParam? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUse? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParam? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentParams? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentParams? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResource? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResourceObject? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesResource? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessResource? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyResource? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopResource? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResource? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminator? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResource? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminator? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResource? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResourceObject? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResource? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentTemplateResource>? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentTemplateParams? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResource? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionSpendControlResource? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionStatusResource? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequest? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResource? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminator? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunction? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunctionType? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttp? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttpType? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdio? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdioType? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResource? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminator? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcp? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcpType? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearchType? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUseType? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResource? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminator? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentResource? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource>? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNone? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNoneType? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeResource? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResource? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminator? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResource? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResourceObject? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource>? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResource? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResourceObject? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource>? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionSpendControlParam? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunctionType? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttpType? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdioType? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParam? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminator? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcpType? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUse? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParam? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminator? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentConfigParam? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolConfigParam>? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNone? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNoneType? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeParam? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHostedType? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParam? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminator? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputText? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputTextType? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImage? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImageType? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParam? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminator? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminatorType? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParam? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamType? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamRole? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionInputParam? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentSessionParams? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionErrorResource? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventError? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventErrorType? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStatusResource? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentErrorResource? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStateResource? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspended? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspendedType? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpired? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpiredType? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? Type4091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType? Type4092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? Type4093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType? Type4094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? Type4095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType? Type4096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? Type4097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType? Type4098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? Type4099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType? Type4100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? Type4101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType? Type4102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle? Type4103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdleType? Type4104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? Type4105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType? Type4106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? Type4107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType? Type4108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed? Type4109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailedType? Type4110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? Type4111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType? Type4112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? Type4113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType? Type4114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? Type4115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType? Type4116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? Type4117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType? Type4118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? Type4119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType? Type4120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? Type4121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType? Type4122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? Type4123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType? Type4124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResource? Type4125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceType? Type4126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceRole? Type4127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource>? Type4128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResource? Type4129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator? Type4130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType? Type4131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? Type4132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType? Type4133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? Type4134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType? Type4135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? Type4136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType? Type4137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? Type4138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType? Type4139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? Type4140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType? Type4141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? Type4142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType? Type4143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? Type4144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType? Type4145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? Type4146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? Type4147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType? Type4148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEvent? Type4149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminator? Type4150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminatorType? Type4151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionReasoningParam? Type4152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionAgentParam? Type4153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentSessionParams? Type4154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResource? Type4155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResourceObject? Type4156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResource? Type4157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResourceObject? Type4158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResource? Type4159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResourceObject? Type4160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionArtifactResource>? Type4161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResource? Type4162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject? Type4163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam? Type4164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam? Type4165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType? Type4166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction? Type4167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? Type4168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam? Type4169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType? Type4170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction? Type4171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? Type4172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType? Type4173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator? Type4174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? Type4175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam? Type4176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? Type4177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType? Type4178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParam? Type4179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator? Type4180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType? Type4181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResult? Type4182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType? Type4183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? Type4184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType? Type4185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? Type4186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType? Type4187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputParam? Type4188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? Type4189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType? Type4190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParam? Type4191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminator? Type4192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminatorType? Type4193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionEventsParams? Type4194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>? Type4195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResource? Type4196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResourceObject? Type4197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResource? Type4198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResourceObject? Type4199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnTraceResource>? Type4200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusParam? Type4201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusFilterParam? Type4202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? Type4203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResource? Type4204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResourceObject? Type4205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResource? Type4206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResourceObject? Type4207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultResource>? Type4208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultParams? Type4209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVaultParams? Type4210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResource? Type4211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResourceObject? Type4212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? Type4213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType? Type4214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? Type4215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType? Type4216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? Type4217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType? Type4218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource? Type4219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator? Type4220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType? Type4221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthRefreshResource? Type4222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? Type4223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType? Type4224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? Type4225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType? Type4226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? Type4227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType? Type4228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? Type4229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType? Type4230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResource? Type4231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator? Type4232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType? Type4233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? Type4234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType? Type4235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResource? Type4236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator? Type4237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType? Type4238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResource? Type4239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResourceObject? Type4240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResource? Type4241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResourceObject? Type4242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultCredentialResource>? Type4243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? Type4244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType? Type4245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam? Type4250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator? Type4251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthRefreshParam? Type4253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? Type4254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType? Type4255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? Type4256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType? Type4257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? Type4258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType? Type4259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? Type4260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType? Type4261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParam? Type4262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator? Type4263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType? Type4264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? Type4265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType? Type4266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParam? Type4267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator? Type4268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType? Type4269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialParams? Type4270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam? Type4275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator? Type4276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthRefreshParam? Type4278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? Type4279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType? Type4280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? Type4281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType? Type4282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? Type4283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType? Type4284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParam? Type4285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator? Type4286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType? Type4287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialParams? Type4288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResource? Type4289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject? Type4290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBody? Type4291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBodyObject? Type4292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResource? Type4293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResourceObject? Type4294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookEndpointBody>? Type4295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectEventTypeEnum? Type4296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateEndpointBody? Type4297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? Type4298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResource? Type4299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject? Type4300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateEndpointBody? Type4301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResource? Type4302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject? Type4303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRotateSecretBody? Type4304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicTestEndpointBody? Type4305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResource? Type4306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResourceObject? Type4307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResource? Type4308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResourceObject? Type4309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource? Type4310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource? Type4311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionConnectPayloadResource? Type4312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragPoint? Type4313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? Type4314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType? Type4315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? Type4316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType? Type4317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? Type4318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType? Type4319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormat? Type4320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminator? Type4321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminatorType? Type4322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioParam? Type4323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParams? Type4324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant12? Type4325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1Discriminator? Type4326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1DiscriminatorType? Type4327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEventType? Type4328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParams? Type4329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant13? Type4330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1Discriminator? Type4331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? Type4332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamType? Type4333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEventType? Type4334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParamType? Type4335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType? Type4336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParamType? Type4337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParamType? Type4338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParamType? Type4339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParamType? Type4340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParamType? Type4341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParamType? Type4342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkAudioParam? Type4343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionConfigParam? Type4344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEventType? Type4345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParam? Type4346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant14? Type4347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1Discriminator? Type4348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1DiscriminatorType? Type4349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamStatus? Type4350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartedType? Type4351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdatedType? Type4352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMutedType? Type4353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmutedType? Type4354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendedType? Type4355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendedType? Type4356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendedType? Type4357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppend? Type4358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendType? Type4359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDelta? Type4360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDeltaType? Type4361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDeltaType? Type4362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType? Type4363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItem? Type4364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemType? Type4365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?>? Type4366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1? Type4367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2? Type4368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreatedType? Type4369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEventType? Type4370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsage? Type4371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContextWindowUsage? Type4372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdatedType? Type4373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedType? Type4374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1? Type4375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2? Type4376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3? Type4377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4? Type4378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5? Type4379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLiveError? Type4380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEventType? Type4381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEventType? Type4382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived? Type4383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceivedType? Type4384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSend? Type4385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendType? Type4386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRingingType? Type4387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnsweredType? Type4388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallError? Type4389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallErrorType? Type4390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailedType? Type4391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2Discriminator? Type4392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType? Type4393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamType? Type4394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamRole? Type4395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>? Type4396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>? Type4397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item? Type4398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminator? Type4399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType? Type4400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResource? Type4401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResourceObject? Type4402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsBody? Type4403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? Type4404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>? Type4405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItem? Type4406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? Type4407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTool? Type4408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextParam? Type4409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoning? Type4410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTruncationEnum? Type4411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnum? Type4412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam? Type4413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceParam? Type4414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceOptions? Type4415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed? Type4416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypes? Type4417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunction? Type4418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCP? Type4419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustom? Type4420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? Type4421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? Type4422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? Type4423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType? Type4424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType? Type4425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType? Type4426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustomType? Type4427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCPType? Type4428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunctionType? Type4429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypesType? Type4430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedType? Type4431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedMode? Type4432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam2? Type4433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum? Type4434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnum? Type4435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningEffortEnum? Type4436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningSummary? Type4437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningContext? Type4438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningGenerateSummary? Type4439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? Type4440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration? Type4441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaVerbosityEnum? Type4442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatText? Type4443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? Type4444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject? Type4445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType? Type4446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType? Type4447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema? Type4448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatTextType? Type4449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionTool? Type4450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchTool? Type4451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerTool? Type4452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool? Type4453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchTool? Type4454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPTool? Type4455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool? Type4456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? Type4457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenTool? Type4458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParam? Type4459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam? Type4460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParam? Type4461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParam? Type4462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParam? Type4463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool? Type4464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam? Type4465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminator? Type4466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminatorType? Type4467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParamType? Type4468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? Type4469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCallableToolAllowedCaller? Type4470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewToolType? Type4471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocation? Type4472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContextSize? Type4473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>? Type4474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContentType? Type4475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocationType? Type4476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParamType? Type4477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Type4478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEmptyModelParam? Type4479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamType? Type4480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem18>? Type4481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem18? Type4482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParam? Type4483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator? Type4484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType? Type4485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamType? Type4486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format3? Type4487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam? Type4488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? Type4489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator? Type4490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType? Type4491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType? Type4492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGrammarSyntax1? Type4493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParamType? Type4494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParamType? Type4495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamType? Type4496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant15? Type4497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParam? Type4498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam? Type4499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParam? Type4500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator? Type4501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type4502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParamType? Type4503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParamType? Type4504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>? Type4505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalSkillParam? Type4506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamType? Type4507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerMemoryLimit? Type4508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy4? Type4509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? Type4510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? Type4511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator? Type4512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType? Type4513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>? Type4514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem3? Type4515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParam? Type4516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParam? Type4517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator? Type4518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType? Type4519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParamType? Type4520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParam? Type4521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamType? Type4522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType? Type4523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParamType? Type4524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType? Type4525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? Type4526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam? Type4527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType? Type4528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParamType? Type4529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolType? Type4530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>? Type4531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModel? Type4532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolQuality? Type4533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>? Type4534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolSize? Type4535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolOutputFormat? Type4536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModeration? Type4537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolBackground? Type4538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFidelity? Type4539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolInputImageMask? Type4540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenActionEnum? Type4541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType? Type4542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolType? Type4543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>? Type4544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam? Type4545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType? Type4546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy5? Type4547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type4548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type4549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolType? Type4550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolConnectorId? Type4551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? Type4552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolFilter? Type4553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>? Type4554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum? Type4555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2? Type4556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolType? Type4557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolFilters? Type4558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation? Type4559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize? Type4560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType? Type4561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewToolType? Type4562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerEnvironment? Type4563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolType? Type4564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolType? Type4565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankingOptions? Type4566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilters? Type4567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilter? Type4568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilter? Type4569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterType? Type4570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>? Type4571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem2? Type4572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator? Type4573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilterType? Type4574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankerVersionType? Type4575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHybridSearchOptions? Type4576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolType? Type4577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessage? Type4578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItem? Type4579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParam? Type4580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParam? Type4581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParam? Type4582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParam? Type4583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminator? Type4584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminatorType? Type4585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTagParam? Type4586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParamType? Type4587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemStatus? Type4588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParamType? Type4589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParamType? Type4590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType? Type4591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessage? Type4592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessage? Type4593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCall? Type4594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCall? Type4595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? Type4596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCall? Type4597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCall? Type4598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? Type4599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam? Type4600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? Type4601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? Type4602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam? Type4603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? Type4604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? Type4605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParam? Type4606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItem? Type4607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? Type4608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCall? Type4609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? Type4610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCall? Type4611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? Type4612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? Type4613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? Type4614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? Type4615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? Type4616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListTools? Type4617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest? Type4618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse? Type4619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCall? Type4620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? Type4621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCall? Type4622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminator? Type4623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminatorType? Type4624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTag? Type4625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallType? Type4626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCaller? Type4627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller? Type4628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller? Type4629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminator? Type4630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType? Type4631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerType? Type4632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerType? Type4633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputType? Type4634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParam? Type4635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? Type4636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? Type4637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput? Type4638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContent? Type4639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContent? Type4640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContent? Type4641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminator? Type4642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType? Type4643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentType? Type4644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? Type4645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileInputDetail? Type4646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode? Type4647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentType? Type4648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageDetail? Type4649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentType? Type4650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? Type4651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? Type4652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminator? Type4653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType? Type4654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType? Type4655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType? Type4656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallType? Type4657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallError? Type4658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallStatus? Type4659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolError? Type4660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError? Type4661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPError? Type4662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator? Type4663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType? Type4664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPErrorType? Type4665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType? Type4666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolErrorType? Type4667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseType? Type4668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequestType? Type4669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsType? Type4670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaMCPListToolsTool>? Type4671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsTool? Type4672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType? Type4673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam? Type4674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType? Type4675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam? Type4676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParam? Type4677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? Type4678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? Type4679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? Type4680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminator? Type4681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType? Type4682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType? Type4683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType? Type4684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType? Type4685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType? Type4686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? Type4687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam? Type4688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus? Type4689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam? Type4690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParam? Type4691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParam? Type4692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminator? Type4693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType? Type4694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType? Type4695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType? Type4696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType? Type4697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellActionParam? Type4698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant16? Type4699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator? Type4700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type4701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType? Type4702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus? Type4703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallType? Type4704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecAction? Type4705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallStatus? Type4706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecActionType? Type4707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType? Type4708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus? Type4709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>? Type4710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item2? Type4711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? Type4712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? Type4713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type4714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type4715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType? Type4716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType? Type4717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallType? Type4718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallStatus? Type4719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>? Type4720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1? Type4721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallQuality? Type4722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageBackground? Type4723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageOutputFormat? Type4724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType? Type4725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemType? Type4726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent>? Type4727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContent? Type4728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>? Type4729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContent? Type4730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemStatus? Type4731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContentType? Type4732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContentType? Type4733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType? Type4734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning? Type4735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType? Type4736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole? Type4737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType? Type4738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaToolSearchOutputTool>? Type4739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputTool? Type4740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallItemStatus? Type4741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParam? Type4742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminator? Type4743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType? Type4744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType? Type4745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem19>? Type4746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem19? Type4747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParam? Type4748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminator? Type4749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type4750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType? Type4751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParamType? Type4752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType? Type4753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction1? Type4754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam>? Type4755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParam? Type4756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamType? Type4757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem4>? Type4758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem4? Type4759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParam? Type4760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParam? Type4761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam? Type4762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator? Type4763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType? Type4764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParamType? Type4765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParamType? Type4766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParamType? Type4767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType? Type4768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamType? Type4769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6>? Type4770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem6? Type4771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParam? Type4772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? Type4773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParam? Type4774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminator? Type4775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType? Type4776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParamType? Type4777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType? Type4778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDetailEnum? Type4779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam? Type4780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode? Type4781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParamType? Type4782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType? Type4783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>? Type4784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>? Type4785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item2? Type4786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParam? Type4787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type4788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type4789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParamType? Type4790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileDetailEnum? Type4791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallType? Type4792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallStatus? Type4793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallType? Type4794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchCallStatus? Type4795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallAction? Type4796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch? Type4797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? Type4798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFind? Type4799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminator? Type4800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType? Type4801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFindType? Type4802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType? Type4803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchType? Type4804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? Type4805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSource? Type4806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType? Type4807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType? Type4808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImage? Type4809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? Type4810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam? Type4811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImageType? Type4812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallType? Type4813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerAction? Type4814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>? Type4815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallStatus? Type4816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParam? Type4817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickAction? Type4818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParam? Type4819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressAction? Type4820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParam? Type4821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParam? Type4822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParam? Type4823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParam? Type4824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParam? Type4825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminator? Type4826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType? Type4827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParamType? Type4828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParamType? Type4829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParamType? Type4830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParamType? Type4831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParamType? Type4832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressActionType? Type4833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParamType? Type4834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam>? Type4835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCoordParam? Type4836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickActionType? Type4837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParamType? Type4838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickButtonType? Type4839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallType? Type4840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallStatus? Type4841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? Type4842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item? Type4843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageType? Type4844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageRole? Type4845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputMessageContent>? Type4846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContent? Type4847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase? Type4848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageStatus? Type4849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContent? Type4850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContent? Type4851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminator? Type4852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType? Type4853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContentType? Type4854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentType? Type4855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>? Type4856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotation? Type4857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>? Type4858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLogProb? Type4859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>? Type4860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTopLogProb? Type4861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBody? Type4862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBody? Type4863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody? Type4864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePath? Type4865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminator? Type4866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType? Type4867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePathType? Type4868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBodyType? Type4869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBodyType? Type4870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBodyType? Type4871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageType? Type4872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageRole? Type4873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageStatus? Type4874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>? Type4875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContent? Type4876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminator? Type4877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminatorType? Type4878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageRole? Type4879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>? Type4880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageType? Type4881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResponseMethodPublicBody? Type4882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsCompaction? Type4883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum? Type4884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsParam? Type4885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierEnum? Type4886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheTTLEnum? Type4887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheModeEnum? Type4888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Type4889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsShared? Type4890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? Type4891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum? Type4892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorResponse? Type4893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaError? Type4894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorDetailsResource? Type4895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorType? Type4896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentSteer? Type4897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? Type4898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemList? Type4899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemListObject? Type4900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemResource>? Type4901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResource? Type4902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResource? Type4903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? Type4904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResource? Type4905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource? Type4906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessage? Type4907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCall? Type4908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput? Type4909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCall? Type4910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutput? Type4911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalTools? Type4912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdate? Type4913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgram? Type4914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutput? Type4915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBody? Type4916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCall? Type4917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput? Type4918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall? Type4919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? Type4920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? Type4921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResource? Type4922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResource? Type4923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminator? Type4924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType? Type4925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? Type4926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum? Type4927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? Type4928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallStatus? Type4929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType? Type4930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType? Type4931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus? Type4932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallType? Type4933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatus? Type4934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation2? Type4935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? Type4936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? Type4937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? Type4938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminator? Type4939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType? Type4940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType? Type4941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType? Type4942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType? Type4943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputType? Type4944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum? Type4945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? Type4946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent? Type4947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome2? Type4948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? Type4949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? Type4950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminator? Type4951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? Type4952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType? Type4953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType? Type4954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallType? Type4955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellAction? Type4956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallStatus? Type4957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant17? Type4958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource? Type4959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResource? Type4960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1Discriminator? Type4961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? Type4962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResourceType? Type4963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType? Type4964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBodyType? Type4965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputType? Type4966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputStatus? Type4967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramType? Type4968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType? Type4969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning? Type4970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsType? Type4971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageRole? Type4972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputType? Type4973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallType? Type4974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputType? Type4975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction? Type4976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent>? Type4977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallType? Type4978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageType? Type4979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7>? Type4980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem7? Type4981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContent? Type4982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent? Type4983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContent? Type4984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminator? Type4985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType? Type4986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentType? Type4987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContentType? Type4988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContentType? Type4989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? Type4990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? Type4991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputType? Type4992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus? Type4993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? Type4994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput? Type4995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? Type4996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputStatus? Type4997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputType? Type4998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus? Type4999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? Type5000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResource? Type5001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResourceObject? Type5002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemField>? Type5003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemField? Type5004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsage? Type5005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails? Type5006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails? Type5007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessage? Type5008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminator? Type5009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType? Type5010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageType? Type5011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageStatus? Type5012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem8>? Type5013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem8? Type5014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminator? Type5015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType? Type5016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase2? Type5017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? Type5018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType? Type5019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? Type5020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType? Type5021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent? Type5022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEventType? Type5023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponse? Type5024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponseProperties? Type5025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseProperties? Type5026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3? Type5027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierResponsesEnum? Type5028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Truncation? Type5029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Object? Type5030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Status? Type5031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsBody? Type5032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorVariant1? Type5033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetails? Type5034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason? Type5035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputItem>? Type5036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItem? Type5037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptions? Type5038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnostics? Type5039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModeration? Type5040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConversation? Type5041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input5? Type5042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBody? Type5043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBody? Type5044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminator? Type5045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType? Type5046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output9? Type5047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminator? Type5048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType? Type5049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBodyType? Type5050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBodyType? Type5051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>>? Type5052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>? Type5053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputType? Type5054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? Type5055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? Type5056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? Type5057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? Type5058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator? Type5059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType? Type5060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType? Type5061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type5062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType? Type5063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType? Type5064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum? Type5065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminator? Type5066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType? Type5067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorCode? Type5068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCyberAccessProgramEnum? Type5069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptVariant1? Type5070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>? Type5071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention? Type5072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? Type5073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType? Type5074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? Type5075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType? Type5076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? Type5077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType? Type5078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? Type5079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType? Type5080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? Type5081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType? Type5082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? Type5083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType? Type5084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? Type5085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType? Type5086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? Type5087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType? Type5088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? Type5089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType? Type5090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? Type5091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType? Type5092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? Type5093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType? Type5094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? Type5095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType? Type5096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? Type5097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType? Type5098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? Type5099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType? Type5100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? Type5101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType? Type5102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? Type5103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType? Type5104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? Type5105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType? Type5106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? Type5107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType? Type5108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus? Type5109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPart? Type5110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType? Type5111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? Type5112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType? Type5113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPart? Type5114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType? Type5115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent? Type5116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEventType? Type5117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProb>? Type5118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProb? Type5119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? Type5120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob? Type5121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? Type5122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEventType? Type5123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? Type5124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType? Type5125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? Type5126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType? Type5127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? Type5128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType? Type5129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? Type5130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType? Type5131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent? Type5132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEventType? Type5133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent? Type5134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType? Type5135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent? Type5136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType? Type5137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaShellCallOutputDelta? Type5138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent? Type5139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType? Type5140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent? Type5141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType? Type5142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent? Type5143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType? Type5144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? Type5145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType? Type5146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? Type5147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType? Type5148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? Type5149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType? Type5150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? Type5151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType? Type5152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? Type5153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType? Type5154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEvent? Type5155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEventType? Type5156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent? Type5157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEventType? Type5158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? Type5159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType? Type5160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContent? Type5161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminator? Type5162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType? Type5163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? Type5164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType? Type5165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent? Type5166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEventType? Type5167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent? Type5168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType? Type5169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? Type5170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType? Type5171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? Type5172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType? Type5173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? Type5174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType? Type5175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? Type5176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType? Type5177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? Type5178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType? Type5179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? Type5180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType? Type5181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? Type5182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType? Type5183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? Type5184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEventType? Type5185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? Type5186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType? Type5187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent? Type5188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEventType? Type5189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEvent? Type5190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEventType? Type5191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? Type5192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType? Type5193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? Type5194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType? Type5195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? Type5196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType? Type5197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? Type5198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventType? Type5199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer? Type5200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInput? Type5201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventError? Type5202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType? Type5203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCode? Type5204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? Type5205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? Type5206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItem? Type5207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParam? Type5208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminator? Type5209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType? Type5210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamType? Type5211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamRole? Type5212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? Type5213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>? Type5214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item2? Type5215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminator? Type5216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType? Type5217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? Type5218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventType? Type5219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventSteer? Type5220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReason? Type5221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? Type5222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInput? Type5223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type5224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType? Type5225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? Type5226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType? Type5227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? Type5228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType? Type5229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? Type5230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType? Type5231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type5232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? Type5233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? Type5234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType? Type5235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution? Type5236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? Type5237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType? Type5238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator? Type5239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType? Type5240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? Type5241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? Type5242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType? Type5243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventSteer? Type5244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEvent? Type5245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEventType? Type5246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudio? Type5247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudioType? Type5248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudio? Type5249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioType? Type5250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudio? Type5251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudioFormat? Type5252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputParam? Type5253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContent? Type5254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaIncludeEnum? Type5255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEvent? Type5256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? Type5257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2? Type5258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? Type5259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2? Type5260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? Type5261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2? Type5262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? Type5263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2? Type5264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2? Type5265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2? Type5266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2? Type5267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2? Type5268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2? Type5269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? Type5270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2? Type5271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? Type5272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2? Type5273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? Type5274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2? Type5275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? Type5276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2? Type5277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? Type5278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2? Type5279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? Type5280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2? Type5281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? Type5282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2? Type5283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? Type5284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2? Type5285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2? Type5286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? Type5287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2? Type5288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? Type5289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2? Type5290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? Type5291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2? Type5292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? Type5293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2? Type5294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2? Type5295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2? Type5296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? Type5297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2? Type5298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? Type5299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2? Type5300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? Type5301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2? Type5302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? Type5303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2? Type5304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? Type5305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2? Type5306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? Type5307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2? Type5308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? Type5309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2? Type5310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? Type5311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2? Type5312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? Type5313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2? Type5314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? Type5315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2? Type5316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? Type5317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2? Type5318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? Type5319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2? Type5320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? Type5321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2? Type5322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? Type5323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2? Type5324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? Type5325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2? Type5326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? Type5327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2? Type5328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? Type5329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2? Type5330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? Type5331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2? Type5332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? Type5333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2? Type5334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? Type5335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2? Type5336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? Type5337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2? Type5338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? Type5339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2? Type5340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? Type5341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2? Type5342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? Type5343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2? Type5344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? Type5345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2? Type5346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? Type5347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2? Type5348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? Type5349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2? Type5350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? Type5351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2? Type5352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? Type5353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2? Type5354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? Type5355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2? Type5356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? Type5357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2? Type5358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? Type5359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2? Type5360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? Type5361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2? Type5362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? Type5363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2? Type5364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsError? Type5365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? Type5366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? Type5367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminator? Type5368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType? Type5369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventType? Type5370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventError? Type5371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode? Type5372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType? Type5373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsErrorType? Type5374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorPayload? Type5375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEvent? Type5376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEventVariant2? Type5377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEvent? Type5378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? Type5379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEvent? Type5380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminator? Type5381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType? Type5382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEventType? Type5383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? Type5384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type? Type5385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponse? Type5386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties? Type5387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3? Type5388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsParam? Type5389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParam? Type5390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation? Type5391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? Type5392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationParam? Type5393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1? Type5394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>? Type5395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContextManagementParam? Type5396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentParam? Type5397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationPolicyParam? Type5398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationConfigParam? Type5399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationMode? Type5400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? Type5401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEvent? Type5402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminator? Type5403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType? Type5404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateChatCompletionRequest? Type5405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationItemsRequest? Type5406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEvalRequest? Type5407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysCreateRequest? Type5408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsOrder? Type5409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListChatCompletionsOrder? Type5410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetChatCompletionMessagesOrder? Type5411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainersOrder? Type5412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainerFilesOrder? Type5413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListConversationItemsOrder? Type5414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrder? Type5415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrderBy? Type5416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsOrder? Type5417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsStatus? Type5418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? Type5419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? Type5420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesOrder? Type5421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? Type5422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysListOrder? Type5423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsEffectiveAt? Type5424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>? Type5425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationCertificatesOrder? Type5426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>? Type5427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetCertificateIncludeItem? Type5428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsBucketWidth? Type5429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? Type5430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsGroupByItem? Type5431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupsOrder? Type5432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder? Type5433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupUsersOrder? Type5434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess? Type5435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesOrder? Type5436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupsOrder? Type5437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RetrieveProjectGroupGroupType? Type5438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? Type5439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRolesOrder? Type5440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder? Type5441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth? Type5442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? Type5443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem? Type5444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth? Type5445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? Type5446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem? Type5447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth? Type5448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? Type5449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem? Type5450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsBucketWidth? Type5451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? Type5452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsGroupByItem? Type5453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth? Type5454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? Type5455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem? Type5456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth? Type5457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? Type5458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem? Type5459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesBucketWidth? Type5460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSource>? Type5461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSource? Type5462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSize>? Type5463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSize? Type5464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesGroupByItem>? Type5465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesGroupByItem? Type5466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsBucketWidth? Type5467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? Type5468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsGroupByItem? Type5469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresBucketWidth? Type5470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? Type5471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresGroupByItem? Type5472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth? Type5473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? Type5474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel? Type5475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? Type5476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem? Type5477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder? Type5478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupRoleAssignmentsOrder? Type5479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectRolesOrder? Type5480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder? Type5481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListInputItemsOrder? Type5482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesOrder? Type5483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsOrder? Type5484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? Type5485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunIncludeItem? Type5486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsOrder? Type5487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? Type5488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsIncludeItem? Type5489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>? Type5490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetRunStepIncludeItem? Type5491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresOrder? Type5492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? Type5493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? Type5494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesOrder? Type5495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesFilter? Type5496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? Type5497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? Type5498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem? Type5499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? Type5500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem? Type5501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? Type5502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem? Type5503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? Type5504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem? Type5505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? Type5506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem? Type5507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOrder? Type5508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? Type5509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem? Type5510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? Type5511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem? Type5512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>? Type5513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponse? Type5514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponseObject? Type5515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponse? Type5516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponseObject? Type5517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalResponse? Type5518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalRunResponse? Type5519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponse? Type5520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponseObject? Type5521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponse? Type5522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponseObject? Type5523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponse? Type5524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject? Type5525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubagentResource>? Type5526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponse? Type5527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponseObject? Type5528 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AdminApiKey>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BatchError>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponse>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationResultBody>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CodeInterpreterFileOutputFile>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerAction>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerFileResource>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerResource>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ConversationItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessage>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionFunctions>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateCompletionResponseChoice>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Embedding>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTool>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateEvalItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Tool>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.List<byte[]>>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResult>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.IncludeEnum>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContextManagementParam>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequest>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionInclude>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionLanguage>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionWord>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionSegment>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ImageRefParam>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.List<float>, string>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItemContentItem>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Eval>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRun>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemResult>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItem>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningIntegration>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItem>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GroupResponse>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Image2>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InviteProject>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Invite>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InviteRequestProject>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssistantObject>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLog>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Batch>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationCertificate>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OpenAIFile>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningCheckpointPermission>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobCheckpoint>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobEvent>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObject>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Model18>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJob>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationProjectCertificate>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepObject>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunObject>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileObject>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreObject>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialItem>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MCPListToolsTool>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationSpendAlert>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputMessageContent>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectApiKey>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectGroup>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Project>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectRateLimit>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectServiceAccount>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectSpendAlert>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectUser>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Role>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItem>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProbProperties>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionModalitie>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeFunctionTool>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextContent>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ReasoningTextContent>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputItem>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemResource>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerInputItem>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProb>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssignedRoleDetails>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunToolCallObject>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageTimeBucket>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UserProjectsDataItem>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GroupUser>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.User>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VoiceConsentResource>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebSearchActionSearchSource>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TopLogProb>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Annotation>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProb>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem3>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CoordParam>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem2>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LocalSkillParam>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem13>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SearchContentType>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem14>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolSearchOutputTool>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsVariant1Item>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveLocalSkillParam>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem15>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem16>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem4>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.List<string>>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem17>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageResult>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageBucket>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ExternalStorageResponse>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem2>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VideoResource>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemField>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillResource>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillVersionResource>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem5>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Attachment>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem3>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseOutputText>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TaskGroupTask>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadItem>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadResource>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputVariant2Item>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceOptionParam>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreLevelParam>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.QuestionParam>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceProbabilityResource>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreProbabilityResource>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnswerResource>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillResource>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PublicEnvironmentResource>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SetupCommandParam>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillParam>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginParam>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentFileResource>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentContentResource>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageContentResource>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextResource>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentResource>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnItemResource>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TurnResource>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolResource>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentResource>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateSkillResource>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateFileResource>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentTemplateResource>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolResource>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionRequiredActionResource>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionResource>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolConfigParam>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentParam>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageParam>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputTextResource>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionArtifactResource>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionInputParam>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnTraceResource>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultStatusParam>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultResource>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultCredentialResource>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookEndpointBody>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectEventTypeEnum>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>, string>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTool>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSearchContentType>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem18>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLocalSkillParam>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem3>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaMCPListToolsTool>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item2>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSummaryTextContent>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaReasoningTextContent>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaToolSearchOutputTool>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem19>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContentParam>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem4>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem6>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerAction>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCoordParam>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputMessageContent>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaAnnotation>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLogProb>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTopLogProb>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemResource>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContent>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem7>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemField>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem8>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputItem>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProb>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaIncludeEnum>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContextManagementParam>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogEventType>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetCertificateIncludeItem>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCostsGroupByItem>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? ListType369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSource>? ListType370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSize>? ListType371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesGroupByItem>? ListType372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? ListType373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? ListType374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? ListType375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? ListType376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateRunIncludeItem>? ListType377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? ListType378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetRunStepIncludeItem>? ListType379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? ListType380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? ListType381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? ListType382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? ListType383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? ListType384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? ListType385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? ListType386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? ListType387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubagentResource>? ListType388 { get; set; }
    }
}