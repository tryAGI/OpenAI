
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
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaFunctionCall? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprob? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTool? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParam? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminator? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutput? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutputType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CodeInterpreterFileOutputFile>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutputFile? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTextOutput? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTextOutputType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTool? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParam? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CallableToolAllowedCaller? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallStatus? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilter? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilterType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompleteUploadRequest? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsage? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilter? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerAction? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParam? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickAction? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParam? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressAction? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParam? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParam? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParam? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParam? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParam? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminator? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminatorType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerAction>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotImage? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotImageType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCall? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallSafetyCheckParam? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallStatus? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutput? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputType? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputStatus? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputStatus? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResource? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResourceObject? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerFileResource>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileResource? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResource? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResourceObject? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerResource>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResource? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfter? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfterAnchor? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceMemoryLimit? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicy? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicyType? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Content5? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContent? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContent? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItem? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Message? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResource? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCall? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCall? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCall? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCall? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutput? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalTools? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdate? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItem? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Program? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutput? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBody? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCall? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCall? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutput? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCall? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutput? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListTools? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalRequest? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCall? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCall? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutput? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminator? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminatorType? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemList? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemListObject? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam2? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResult? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultApiSource? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultObject? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultAmount? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?, object>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultQuantityUnit? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequest? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortEnum? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResources? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesCodeInterpreter? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearch? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequest? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestEndpoint? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestCompletionWindow? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequest? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponseProperties? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsShared? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityEnum? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptions? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocation? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSize? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormat? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminator? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2Audio? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationParam? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StopConfiguration? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContent? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletions? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoice? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceLogprobs? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseObject? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponse? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequest? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequestModel? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoice? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseObject? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBody? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParam? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParam? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminator? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminator? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerFileBody? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequest? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateEmbeddingRequestModel?>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestModel? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestEncodingFormat? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponse? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Embedding>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Embedding? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponseObject? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponseUsage? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessage? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItem? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceSamplingParams? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsSource? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItem? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItemSimpleInputMessage? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLabelModelGrader? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLabelModelGraderType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateEvalItem>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfigType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRequest? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig, global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig, global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderStringCheck? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarity? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPython? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModel? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceType? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplate? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReference? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParams? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Tool? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParamsText? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfiguration? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalResponsesSource>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSource? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRunRequest? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequest? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequestPurpose? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileExpirationAfter? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningCheckpointPermissionRequest? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequest? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestModel? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparameters? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersBatchSize? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparametersNEpochs? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationType? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationWandb? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethod? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupBody? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupUserBody? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequest? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestBackground? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestModel? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestSize? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFidelity? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestQuality? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequest? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModel? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestQuality? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestResponseFormat? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestOutputFormat? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestSize? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModeration? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestBackground? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestStyle? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequest? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestModel? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestSize? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequest? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestRole? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObject? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponseProperties? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsParam? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequest? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestModel? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponse? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResult? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategories? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryScores? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponse? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseProperties? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsParam? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResponsesEnum? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3Truncation? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Reasoning? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputParam? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.IncludeEnum? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContextManagementParam? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunRequest? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObject? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequest? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestModel? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsShared? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice2? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminator? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBody? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyInterval? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendAlertNotificationChannel? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequest? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequest? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestModel? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesFileSearch? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResources? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequest? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestModel? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionInclude? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfig? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegment? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJson? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionLanguage? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEvent? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEvent? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEvent? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionWord>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionWord? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionSegment? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequest? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequestModel? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseJson? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequestPurpose? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileRequest? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreRequest? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreExpirationAfter? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceConsentRequest? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequest? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequestType? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequestModel? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequest? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminator? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCaller? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputType? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParam? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResource? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputStatusEnum? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResource? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResourceVariant2? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatus? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsType? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustom? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteAssistantResponse? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteAssistantResponseObject? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteCertificateResponse? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteCertificateResponseObject? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFileResponse? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFileResponseObject? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteMessageResponse? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteMessageResponseObject? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteModelResponse? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteThreadResponse? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteThreadResponseObject? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreFileResponse? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreResponse? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreResponseObject? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversation? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResource? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedRoleAssignmentResource? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEventEvent? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEventData? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessageRole? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessageType? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParam? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModel? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamQuality? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?, object>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamSize? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModeration? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamBackground? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<float>, string>? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmbeddingObject? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorDetailsResource? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorEventEvent? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Eval? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalObject? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfig? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfig? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderLabelModel? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalApiError? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfigType? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModel? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPython? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPythonVariant2? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModel? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheck? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarity? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarityVariant2? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemRole? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContent? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemType? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentItem? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContent? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentOutputText? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemInputImage? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudio? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentOutputTextType? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemInputImageType? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileIdSourceType? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalList? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalListObject? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Eval>? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfigType? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSourceType? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRun? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunObject? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunResultCounts? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerModelUsageItem? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunList? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunListObject? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRun>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItem? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemObject? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemResult>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemResult? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSample? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleUsage? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemList? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemListObject? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItem>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsSourceType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileExpirationAfterAnchor? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FilePath? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FilePathType? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchRanker? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallType? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallStatus? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparameters? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta?, double?>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersBeta? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize?, int?>? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersBatchSize? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersLearningRateMultiplier? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs?, int?>? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparametersNEpochs? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOMethod? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethodType? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedMethod? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementMethod? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize?, int?>? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersBatchSize? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersLearningRateMultiplier? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs?, int?>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersNEpochs? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersComputeMultiplier? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval?, int?>? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalInterval? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples?, int?>? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersEvalSamples? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMulti? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparameters? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize?, int?>? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersBatchSize? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersLearningRateMultiplier? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs?, int?>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparametersNEpochs? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningCheckpointPermission? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegration? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegrationType? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegrationWandb? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJob? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuningJobErrorVariant1, object, object>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobErrorVariant1? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparameters? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1?, int?>? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparametersBatchSizeVariant1? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier?, double?>? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparametersLearningRateMultiplier? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs?, int?>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparametersNEpochs? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobObject? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobStatus? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpoint? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpointObject? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEvent? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventObject? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventLevel? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContent? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContent? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminator? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCall? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallType? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallStatus? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutput? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputType? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputStatus? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResourceVariant2? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModelType? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiType? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Graders? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminator? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPythonType? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModelType? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModelSamplingParams? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheckType? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheckOperation? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarityType? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Group? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupObject? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupDeletedResource? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupDeletedResourceObject? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupListResource? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupListResourceObject? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupResponse>? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponse? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUser? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUserUserType? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResourceWithSuccess? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponseGroupType? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupRoleAssignment? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupRoleAssignmentObject? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Role? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUser? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserAssignment? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserAssignmentObject? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserDeletedResource? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserDeletedResourceObject? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermission? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Image2? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventType? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditCompletedEventSize?>? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventSize? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventQuality? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventBackground? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsage? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditPartialImageEventSize?>? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventSize? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventQuality? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventBackground? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEvent? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminator? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventType? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventSize? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventQuality? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventBackground? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventType? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventSize? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventQuality? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventBackground? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEvent? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminator? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenTool? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolType? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModel? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolQuality? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolSize? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolOutputFormat? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModeration? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolBackground? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolInputImageMask? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenActionEnum? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponse? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image2>? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseBackground? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseOutputFormat? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImagesResponseSize?>? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseSize? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseQuality? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenUsage? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsageInputTokensDetails? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioType? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1Format? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminator? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminatorType? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItem? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Item? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParam? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParam? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParam? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParam? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminator? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminatorType? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessage? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageType? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageRole? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageStatus? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResourceVariant2? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Invite? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteObject? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRole? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteStatus? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProject? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectRole? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteDeleteResponse? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteDeleteResponseObject? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteListResponse? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteListResponseObject? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite>? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectGroupBody? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequest? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestRole? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteRequestProject>? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProject? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProjectRole? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessage? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParam? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParam? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParam? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParam? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParam? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParam? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponse? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminator? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminatorType? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResource? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminator? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminatorType? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsResponse? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantObject>? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsResponse? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsResponseObject? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLog>? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListBatchesResponse? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Batch>? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListBatchesResponseObject? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListCertificatesResponse? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationCertificate>? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificate? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListCertificatesResponseObject? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesResponse? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OpenAIFile>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFile? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningCheckpointPermission>? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponseObject? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponse? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint>? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobEventsResponse? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobEvent>? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobEventsResponseObject? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesResponse? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObject>? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObject? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListModelsResponse? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListModelsResponseObject? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Model19>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Model19? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponse? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJob>? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponseObject? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesResponse? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationProjectCertificate>? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificate? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesResponseObject? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsResponse? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepObject>? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObject? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsResponse? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunObject>? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObject? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesResponse? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileObject>? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObject? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresResponse? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreObject>? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObject? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptRequest? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptSession? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLive? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionAudioParam? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptSessionType? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallReferRequest? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallRejectRequest? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEvent? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEvent? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParam? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParam? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParam? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParam? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminator? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminatorType? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveConnectParams? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateRequest? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionCreateParams? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransport? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponse? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponseSession? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEvent? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminator? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkPathParams? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkRequest? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionForkParams? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParam? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientConfigParam? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransport? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransportType? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunk? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuth? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuthType? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEventDiscriminator? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequest? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminator? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminatorType? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponse? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session5? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport2? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2Type? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminator? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminatorType? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEvent? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandConnectParams? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandPathParams? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEvent? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRinging? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnswered? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailed? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStarted? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdated? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuted? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppended? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppended? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppended? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreated? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEvent? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosed? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEvent? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEvent? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransportType? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallType? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecAction? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallStatus? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputType? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputStatus? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProbProperties? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalRequestType? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseType? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseResourceType? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsType? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsTool? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPTool? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolType? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolConnectorId? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolFilter? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallType? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallError? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallStatus? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolError? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionError? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPError? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminator? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectType? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectType? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObject? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObjectType? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObject? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectText? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObject? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectText? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObject? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectObject? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDelta? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectObject? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectStatus? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetails? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectRole? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObjectType? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1Event? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2Event? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3Event? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4Event? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5Event? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelObject? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIds? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponses? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsCompaction? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLiveEnum? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponsesEnum? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsSharedEnum? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequest? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResources? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyCertificateRequest? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyMessageRequest? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyRunRequest? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequest? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResources? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesCodeInterpreter? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesFileSearch? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NoiseReductionType? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileObject? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFilePurpose? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileStatus? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateObject? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponse? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponse? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetention? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionObject? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionType? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateObject? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponse? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponse? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlert? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertObject? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertCurrency? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertInterval? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResource? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResource? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert>? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudio? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudioType? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContent? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContent? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContent? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminator? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminatorType? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItem? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminator? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminatorType? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageType? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageRole? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContent? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageStatus? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminator? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PermissionErrorResponse? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContentType? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Project? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectObject? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicProjectResidency? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKey? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyObject? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwner? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerType? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerUser? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerServiceAccount? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponse? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponseObject? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectApiKey>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectCreateRequest? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetention? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionObject? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionType? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroup? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupObject? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupGroupType? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResource? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResource? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResourceObject? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup>? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissions? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponse? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponseObject? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Project>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissions? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsObject? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsMode? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponse? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimit? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitObject? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponse? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponseObject? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectRateLimit>? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccount? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountObject? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountRole? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKey? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponse? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponse? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectServiceAccount>? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlert? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertObject? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertCurrency? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertInterval? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResource? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectSpendAlert>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUpdateRequest? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUser? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserObject? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserCreateRequest? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponse? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponseObject? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserListResponse? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectUser>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserUpdateRequest? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptVariant1? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateOrganizationRoleBody? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResource? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResourceObject? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role>? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreate? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItem? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDelete? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDeleteType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieve? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieveType? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncate? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncateType? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppend? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppendType? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClear? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClearType? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommit? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommitType? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClear? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClearType? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancel? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancelType? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreate? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParams? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdate? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdateType? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequest? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdate? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdateType? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponse? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseObject? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatus? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetails? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsage? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetails? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageOutputTokenDetails? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseModalitie? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceOptions? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunction? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCP? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreated? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeleted? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeletedType? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailed? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedError? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrieved? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncated? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncatedType? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventError? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorType? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCleared? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferClearedType? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommitted? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommittedType? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStarted? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStartedType? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStopped? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStoppedType? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompleted? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompletedType? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailed? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailedType? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgress? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgressType? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdated? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedType? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDelta? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDeltaType? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDone? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDoneType? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDelta? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDeltaType? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDone? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDoneType? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAdded? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedType? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPart? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPartType? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDone? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDoneType? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePart? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePartType? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreated? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDone? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDelta? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDone? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDelta? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDone? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDoneType? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompleted? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompletedType? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailed? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailedType? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgress? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgressType? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAdded? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDone? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDelta? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDeltaType? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDone? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDoneType? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreated? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSession? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdated? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreated? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreatedType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdated? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdatedType? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallCreateRequest? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallReferRequest? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallRejectRequest? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEvent? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminator? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParams? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdate? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdateType? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUser? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponse? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListTools? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCall? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequest? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminator? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReference? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceObject? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItemType? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session2? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionTool? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionToolType? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPError? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListToolsType? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolError? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCallType? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoning? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoningEffort? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponse? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseObject? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatus? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetails? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsError? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudio? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudioOutput? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsage? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetails? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageOutputTokenDetails? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseOutputModalitie? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEvent? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventError? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDone? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminator? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorType? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorError? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPart? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePart? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdated? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionObject? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModalitie? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModel? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncation? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponse? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEvent? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppendType? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionCloseType? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdateType? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequest? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSession? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEvent? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminator? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionType? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudio? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInput? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioOutput? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputTranscription? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputNoiseReduction? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudio? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInput? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputTranscription? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputNoiseReduction? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioOutput? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum2? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumType? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnum? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummary? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningContext? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningGenerateSummary? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemType? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContent? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemStatus? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Response? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Truncation? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Object? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Status? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsBody? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorVariant1? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsage? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptions? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnostics? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Moderation? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConversation? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEventType? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEventType? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingEvent? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEvent? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEventType? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateType? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEventType? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEventType? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEvent? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEventType? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorCode? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEvent? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEventType? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEvent? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEventType? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonObjectType? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaType? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextType? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammar? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammarType? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPython? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPythonType? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEvent? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEventType? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEventType? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemList? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemListObject? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemResource>? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProb? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProbTopLogprob? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEventType? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseModalitiesVariant1Item? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEventType? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEventType? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Annotation? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextParam? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceParam? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEvent? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEventType? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEventType? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEventType? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventType? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCode? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEvent? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEventType? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInput? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventType? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventSteer? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventError? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItem? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParam? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminator? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventType? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventSteer? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReason? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInput? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEvent? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminator? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEventType? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEventType? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageInputTokensDetails? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsError? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsErrorType? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorPayload? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEvent? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminator? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEvent? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminator? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEvent? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEventVariant2? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleObject? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResource? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResourceObject? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResource? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResourceObject? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetails>? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunCompletionUsageVariant1? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderRequest? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponse? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadata? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataErrors? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataTokenUsage? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectObject? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectStatus? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredAction? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionType? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObject? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastError? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastErrorCode? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetails? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepCompletionUsageVariant1? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObject? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectObject? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectDelta? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectObject? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectType? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectStatus? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastError? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastErrorCode? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1Event? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2Event? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3Event? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4Event? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5Event? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6Event? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7Event? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1Event? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2Event? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3Event? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4Event? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5Event? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6Event? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7Event? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8Event? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9Event? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10Event? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectType? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectFunction? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDeltaEventType? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventType? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventUsage? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendAlertNotificationChannelType? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategy? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequest? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchema? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObject? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectObject? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResources? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1Event? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToggleCertificatesRequest? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionTool? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchTool? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerTool? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewTool? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchTool? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParam? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParam? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParam? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParam? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParam? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParam? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewTool? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParam? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminator? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminatorType? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowed? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedType? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedMode? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustom? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustomType? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunctionType? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCPType? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypes? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParam? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParam? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypesType? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventType? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventType? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEventType? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDurationType? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensType? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategy? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategyEnum? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObjectType? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateGroupBody? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBody? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBodyRetentionType? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBody? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBodyRetentionType? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBody? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreRequest? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVoiceConsentRequest? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Upload? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadStatus? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadObject? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadCertificateRequest? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPart? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPartObject? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResultObject? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResult? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultApiSource? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultObject? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResultObject? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResultObject? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResult? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResultObject? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResult? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResultObject? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponse? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponseObject? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucket? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketObject? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem>? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResult? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminator? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResultObject? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultObject? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.User? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserObject? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1Object? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjects? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsObject? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UserProjectsDataItem>? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsDataItem? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponse? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponseObject? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResource? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResourceObject? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser>? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponse? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponseObject? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.User>? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignment? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignmentObject? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleUpdateRequest? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfigType? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderRequest? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderResponse? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?>? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObject? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectFileCounts? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponse? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseObject? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectObject? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectStatus? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastError? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectObject? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectFileCounts? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectStatus? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequest? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObject? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultItem? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPage? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResource? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResource? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResourceObject? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VoiceConsentResource>? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResource? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResourceObject? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsSharedEnum? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResource? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceObject? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceType? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFind? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFindType? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPageType? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearch? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchType? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSource? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSourceType? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolType? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolFilters? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolSearchContextSize? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallType? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallStatus? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallAction? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequired? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreated? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailed? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdle? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgress? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelled? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledData? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledObject? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledType? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompleted? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedData? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedObject? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedType? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpired? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredData? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredObject? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredType? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailed? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedData? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedObject? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedType? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceled? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledData? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledObject? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledType? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailed? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedData? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedObject? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedType? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceeded? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededData? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededObject? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededType? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelled? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledObject? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledType? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailed? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedData? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedObject? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedType? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceeded? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededObject? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededType? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncoming? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingData? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingObject? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingType? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncoming? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingData? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataType? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingObject? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingType? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncoming? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingData? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingObject? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingType? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelled? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledData? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledObject? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledType? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompleted? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedData? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedObject? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedType? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailed? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedData? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedObject? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedType? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncomplete? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteData? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteObject? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteType? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreated? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedObject? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedType? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedData? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssued? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedObject? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedType? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedData? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreated? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedObject? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedType? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedData? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssued? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedObject? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedType? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedData? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorType? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentSteer? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputType? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBodyType? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTTLEnum? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheModeEnum? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamMode? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationMode? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationConfigParam? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationPolicyParam? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParamType? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParam? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamType? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamMediaType? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParamType? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStatus? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRole? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfig? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentType? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBody? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBodyType? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBody? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBodyType? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBody? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBodyType? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminator? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminatorType? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TopLogProb? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProb? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContentType? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContent? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContentType? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContentType? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContentType? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContentType? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetail? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentType? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContent? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContentType? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileInputDetail? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentType? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase2? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageType? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem3? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminator? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminatorType? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCaller? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerType? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCaller? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerType? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminator? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParam? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParamType? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParamType? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminator? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageBackground? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageOutputFormat? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallType? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallStatus? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallQuality? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickButtonType? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParamType? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickActionType? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CoordParam? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParamType? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressActionType? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParamType? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParamType? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParamType? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParamType? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParamType? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallType? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolType? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankerVersionType? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HybridSearchOptions? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankingOptions? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Filters2? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolType? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolType? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerEnvironment? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewToolType? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerMemoryLimit? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy2? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParamType? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParamType? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParam? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamType? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy3? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem2? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalSkillParam? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParam? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParamType? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParam? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParamType? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamType? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant1? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParam? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParamType? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GrammarSyntax1? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParam? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParamType? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamType? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format2? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmptyModelParam? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParam? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParamType? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamType? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem13? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParamType? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocation? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocationType? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContextSize? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContentType? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewToolType? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParamType? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputType? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsType? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramType? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputStatus? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputType? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBodyType? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogsType? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImageType? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecActionType? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellAction? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallStatus? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResource? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResourceType? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResource? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResourceType? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallType? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant12? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContent? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputType? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatus? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallType? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatus? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputType? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolErrorType? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionErrorType? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPErrorType? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DetailEnum? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemStatus? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParamType? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParam? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParamType? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParam? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParamType? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileDetailEnum? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParam? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParamType? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamType? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParam? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParamType? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParam? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParamType? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParam? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParamType? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParamType? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParamType? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamType? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamRole? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParamType? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellActionParam? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemStatus? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamType? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant13? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentParam? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatusParam? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParam? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParamType? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParamType? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParamType? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemStatus? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParamType? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResource? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResourceObject? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenOutputTokensDetails? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenInputUsageDetails? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomVoiceParam? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParam? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParamType? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesServiceTier? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningEffort? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningSummary? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationReasoningInputParam? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTextVerbosity? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationTextInputParam? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParamType? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParamType? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceEnum? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParamType? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem14>? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem14? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminator? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, global::tryAGI.OpenAI.LiveMCPToolChoiceParam>? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParamType? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1Discriminator? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialMessageStatus? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParamType? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4>? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem4? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminator? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItem? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminator? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedServerEventParam? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParam? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem15? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminator? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminatorType? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParamType? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParamType? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CyberAccessProgramEnum? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CacheMissReasonTypeEnum? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBody? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBodyType? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input4? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminator? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminatorType? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output5? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminator? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminatorType? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ShellCallOutputDelta? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationBody? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateConversationBody? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResourceObject? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNoticeType? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNotice? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResource? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResourceObject? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertErrorType? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResource? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResourceObject? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageOrder? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageStatus? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponse? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseObject? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider2? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResource? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResourceObject? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalStorageResponse>? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBody? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider3? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResource? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResourceObject? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrency? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitInterval? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatus? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcement? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResource? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBody? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyCurrency? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyInterval? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResource? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResource? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResourceObject? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBody? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResource? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateProjectServiceAccountApiKeyBody? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBody? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContentProvenanceBody? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceCheckObject? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceDetectionResultApi? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAValidationStateApi? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResult? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResultType? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResult? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResultType? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResource? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2>? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem2? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminator? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrderEnum? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModel? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModelEnum? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoStatus? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSize? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error22? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResource? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResourceObject? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResource? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResourceObject? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam2? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSeconds? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoMultipartBody? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoJsonBody? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoCharacterBody? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoCharacterResource? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoReferenceInputParam? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditMultipartBody? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditJsonBody? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendMultipartBody? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendJsonBody? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResource? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResourceObject? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoContentVariant? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoRemixBody? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationEnum? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnum? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnumEnum? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsBody? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResource? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResourceObject? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheRetentionEnum? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum2? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResponseMethodPublicBody? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemField? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminator? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminatorType? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResource? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResourceObject? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField>? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResource? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResourceObject? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResource? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResourceObject? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillResource>? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillBody? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetDefaultSkillVersionBody? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResource? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResourceObject? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResource? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResourceObject? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResource? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResourceObject? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillVersionResource>? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillVersionBody? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResource? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResourceObject? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflowTracing? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflow? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, int?, bool?, double?, object>? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionRateLimits? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionStatus? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionFileUpload? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionHistory? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionChatkitConfiguration? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResource? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResourceObject? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowTracingParam? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowParam? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, int?, bool?, double?>? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParam? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParamAnchor? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RateLimitsParam? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomaticThreadTitlingParam? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileUploadParam? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HistoryParam? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitConfigurationParam? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatSessionBody? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputText? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputTextType? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedText? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedTextType? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AttachmentType? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Attachment? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoice9? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InferenceOptions? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItem? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemObject? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemType? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem5>? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem5? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminator? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment>? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSource? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSourceType? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotation? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationType? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSource? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSourceType? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotation? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationType? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputText? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextType? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3>? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem3? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminator? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItem? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemObject? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemType? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText>? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItem? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemObject? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemType? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallStatus? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItem? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemObject? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemType? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskType? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItem? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemObject? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemType? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupTask? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItem? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemObject? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemType? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask>? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItem? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminator? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminatorType? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResource? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResourceObject? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadItem>? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatus? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatusType? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatus? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatusType? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatus? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatusType? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResource? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceObject? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Status? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminator? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResource? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResourceObject? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResource? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResourceObject? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource>? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeResource? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentStatusResource? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInline? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInlineType? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResource? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminator? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInline? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInlineType? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResource? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminator? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResource? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResource? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResourceObject? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorBodyResource? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse2? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrderParam? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFilePageObjectResource? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResource? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResourceObject? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileListResource? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource>? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParam? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentObjectResource? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResource? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResourceType? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResource? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResourceType? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResource? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminator? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentStatusResource? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentResource? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionMessageRoleResource? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputText? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputTextType? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImage? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImageType? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputText? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputTextType? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResource? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminator? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemStatusResource? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseResource? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResource? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResourceType? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource>? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResource? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResourceType? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResource? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResourceType? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource>? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusResource? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResource? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResourceType? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputText? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputTextType? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImage? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImageType? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResource? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminator? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminatorType? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputResource? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResourceType? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResource? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResourceType? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResource? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResourceType? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResource? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResourceType? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResource? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResourceType? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldResource? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationOptionResource? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResource? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminator? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminator? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResource? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearchType? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOther? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOtherType? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResource? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminator? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResource? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResourceType? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResource? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResourceType? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResourceType? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResourceType? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResource? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminator? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResource? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResourceObject? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnItemResource>? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnObjectResource? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnStatusResource? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorCodeResource? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorResource? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenUsageResource? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnResource? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResource? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResourceObject? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TurnResource>? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortResource? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryResource? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningResource? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceText? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceTextType? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResource? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminator? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityResource? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResource? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResource? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResource? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminator? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginResource? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeResource? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeResource? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationResource? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUse? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResource? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminator? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigResource? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResource? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResourceObject? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolResource>? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResource? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResourceObject? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentResource>? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortParam? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryParam? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningParam? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamText? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamTextType? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchemaType? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParam? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminator? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminatorType? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityParam? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextParam? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierParam? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParam? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginParam? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeParam? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeParam? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationParam? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUse? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParam? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentParams? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentParams? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResource? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResourceObject? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesResource? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessResource? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyResource? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopResource? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResource? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminator? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResource? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminator? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResource? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResourceObject? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResource? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentTemplateResource>? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesParam? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetupCommandParam? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessParam? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyParam? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopParam? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParam? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminator? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInline? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInlineType? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParam? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminator? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInline? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInlineType? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParam? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminator? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentTemplateParams? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResource? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionStatusResource? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequest? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResource? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminator? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunction? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunctionType? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttp? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttpType? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdio? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdioType? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResource? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminator? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcp? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcpType? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearchType? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUseType? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResource? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminator? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentResource? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource>? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNone? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNoneType? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeResource? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResource? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminator? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResource? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResourceObject? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource>? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResource? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResourceObject? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource>? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunctionType? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttpType? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdioType? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParam? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminator? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcpType? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUse? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParam? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminator? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentConfigParam? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolConfigParam>? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNone? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNoneType? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeParam? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHostedType? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParam? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminator? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputText? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputTextType? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImage? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImageType? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParam? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminator? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminatorType? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParam? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamType? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamRole? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionInputParam? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentSessionParams? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionErrorResource? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventError? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventErrorType? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStatusResource? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentErrorResource? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStateResource? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdleType? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailedType? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResource? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceType? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceRole? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource>? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResource? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEvent? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminator? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminatorType? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionReasoningParam? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionAgentParam? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentSessionParams? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResource? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResourceObject? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResource? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResourceObject? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResource? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResourceObject? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionArtifactResource>? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResource? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParam? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResult? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputParam? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParam? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminator? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminatorType? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionEventsParams? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResource? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResourceObject? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResource? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResourceObject? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnTraceResource>? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusParam? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusFilterParam? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResource? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResourceObject? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResource? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResourceObject? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultResource>? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultParams? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResource? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResourceObject? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthRefreshResource? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResource? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResource? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResource? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResourceObject? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResource? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResourceObject? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultCredentialResource>? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthRefreshParam? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParam? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParam? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialParams? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthRefreshParam? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParam? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialParams? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResource? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject? Type4091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBody? Type4092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBodyObject? Type4093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResource? Type4094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResourceObject? Type4095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookEndpointBody>? Type4096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectEventTypeEnum? Type4097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateEndpointBody? Type4098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? Type4099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResource? Type4100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject? Type4101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateEndpointBody? Type4102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResource? Type4103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject? Type4104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRotateSecretBody? Type4105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicTestEndpointBody? Type4106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResource? Type4107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResourceObject? Type4108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResource? Type4109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResourceObject? Type4110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource? Type4111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource? Type4112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionConnectPayloadResource? Type4113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragPoint? Type4114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? Type4115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType? Type4116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? Type4117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType? Type4118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? Type4119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType? Type4120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormat? Type4121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminator? Type4122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminatorType? Type4123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioParam? Type4124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParams? Type4125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant12? Type4126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1Discriminator? Type4127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1DiscriminatorType? Type4128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEventType? Type4129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParams? Type4130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant13? Type4131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1Discriminator? Type4132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? Type4133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamType? Type4134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEventType? Type4135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParamType? Type4136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType? Type4137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParamType? Type4138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParamType? Type4139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParamType? Type4140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParamType? Type4141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParamType? Type4142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParamType? Type4143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkAudioParam? Type4144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionConfigParam? Type4145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEventType? Type4146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParam? Type4147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant14? Type4148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1Discriminator? Type4149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1DiscriminatorType? Type4150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamStatus? Type4151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartedType? Type4152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdatedType? Type4153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMutedType? Type4154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmutedType? Type4155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendedType? Type4156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendedType? Type4157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendedType? Type4158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppend? Type4159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendType? Type4160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDelta? Type4161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDeltaType? Type4162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDeltaType? Type4163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType? Type4164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItem? Type4165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemType? Type4166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?>? Type4167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1? Type4168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2? Type4169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreatedType? Type4170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEventType? Type4171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsage? Type4172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContextWindowUsage? Type4173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdatedType? Type4174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedType? Type4175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1? Type4176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2? Type4177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3? Type4178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4? Type4179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5? Type4180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLiveError? Type4181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEventType? Type4182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEventType? Type4183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived? Type4184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceivedType? Type4185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSend? Type4186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendType? Type4187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRingingType? Type4188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnsweredType? Type4189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallError? Type4190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallErrorType? Type4191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailedType? Type4192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2Discriminator? Type4193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType? Type4194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamType? Type4195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamRole? Type4196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>? Type4197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>? Type4198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item? Type4199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminator? Type4200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType? Type4201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResource? Type4202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResourceObject? Type4203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsBody? Type4204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? Type4205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>? Type4206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItem? Type4207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? Type4208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTool? Type4209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextParam? Type4210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoning? Type4211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTruncationEnum? Type4212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnum? Type4213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam? Type4214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceParam? Type4215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceOptions? Type4216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed? Type4217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypes? Type4218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunction? Type4219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCP? Type4220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustom? Type4221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? Type4222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? Type4223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? Type4224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType? Type4225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType? Type4226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType? Type4227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustomType? Type4228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCPType? Type4229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunctionType? Type4230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypesType? Type4231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedType? Type4232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedMode? Type4233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam2? Type4234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum? Type4235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnum? Type4236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningEffortEnum? Type4237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningSummary? Type4238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningContext? Type4239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningGenerateSummary? Type4240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? Type4241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration? Type4242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaVerbosityEnum? Type4243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatText? Type4244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? Type4245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject? Type4246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType? Type4247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType? Type4248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema? Type4249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatTextType? Type4250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionTool? Type4251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchTool? Type4252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerTool? Type4253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool? Type4254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchTool? Type4255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPTool? Type4256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool? Type4257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? Type4258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenTool? Type4259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParam? Type4260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam? Type4261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParam? Type4262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParam? Type4263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParam? Type4264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool? Type4265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam? Type4266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminator? Type4267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminatorType? Type4268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParamType? Type4269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? Type4270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCallableToolAllowedCaller? Type4271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewToolType? Type4272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocation? Type4273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContextSize? Type4274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>? Type4275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContentType? Type4276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocationType? Type4277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParamType? Type4278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Type4279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEmptyModelParam? Type4280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamType? Type4281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem16>? Type4282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem16? Type4283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParam? Type4284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator? Type4285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType? Type4286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamType? Type4287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format3? Type4288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam? Type4289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? Type4290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator? Type4291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType? Type4292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType? Type4293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGrammarSyntax1? Type4294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParamType? Type4295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParamType? Type4296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamType? Type4297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant14? Type4298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParam? Type4299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam? Type4300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParam? Type4301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator? Type4302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type4303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParamType? Type4304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParamType? Type4305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>? Type4306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalSkillParam? Type4307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamType? Type4308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerMemoryLimit? Type4309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy4? Type4310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? Type4311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? Type4312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator? Type4313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType? Type4314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>? Type4315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem3? Type4316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParam? Type4317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParam? Type4318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator? Type4319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType? Type4320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParamType? Type4321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParam? Type4322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamType? Type4323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType? Type4324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParamType? Type4325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType? Type4326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? Type4327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam? Type4328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType? Type4329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParamType? Type4330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolType? Type4331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>? Type4332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModel? Type4333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolQuality? Type4334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>? Type4335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolSize? Type4336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolOutputFormat? Type4337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModeration? Type4338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolBackground? Type4339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFidelity? Type4340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolInputImageMask? Type4341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenActionEnum? Type4342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType? Type4343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolType? Type4344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>? Type4345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam? Type4346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType? Type4347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy5? Type4348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type4349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type4350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolType? Type4351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolConnectorId? Type4352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? Type4353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolFilter? Type4354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>? Type4355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum? Type4356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2? Type4357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolType? Type4358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolFilters? Type4359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation? Type4360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize? Type4361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType? Type4362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewToolType? Type4363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerEnvironment? Type4364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolType? Type4365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolType? Type4366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankingOptions? Type4367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilters? Type4368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilter? Type4369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilter? Type4370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterType? Type4371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>? Type4372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem2? Type4373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator? Type4374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilterType? Type4375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankerVersionType? Type4376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHybridSearchOptions? Type4377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolType? Type4378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessage? Type4379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItem? Type4380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParam? Type4381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParam? Type4382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParam? Type4383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParam? Type4384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminator? Type4385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminatorType? Type4386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTagParam? Type4387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParamType? Type4388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemStatus? Type4389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParamType? Type4390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParamType? Type4391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType? Type4392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessage? Type4393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessage? Type4394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCall? Type4395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCall? Type4396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? Type4397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCall? Type4398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCall? Type4399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? Type4400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam? Type4401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? Type4402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? Type4403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam? Type4404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? Type4405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? Type4406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParam? Type4407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItem? Type4408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? Type4409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCall? Type4410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? Type4411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCall? Type4412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? Type4413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? Type4414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? Type4415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? Type4416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? Type4417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListTools? Type4418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest? Type4419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse? Type4420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCall? Type4421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? Type4422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCall? Type4423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminator? Type4424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminatorType? Type4425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTag? Type4426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallType? Type4427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCaller? Type4428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller? Type4429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller? Type4430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminator? Type4431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType? Type4432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerType? Type4433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerType? Type4434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputType? Type4435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParam? Type4436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? Type4437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? Type4438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput? Type4439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContent? Type4440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContent? Type4441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContent? Type4442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminator? Type4443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType? Type4444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentType? Type4445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? Type4446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileInputDetail? Type4447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode? Type4448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentType? Type4449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageDetail? Type4450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentType? Type4451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? Type4452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? Type4453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminator? Type4454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType? Type4455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType? Type4456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType? Type4457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallType? Type4458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallError? Type4459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallStatus? Type4460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolError? Type4461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError? Type4462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPError? Type4463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator? Type4464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType? Type4465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPErrorType? Type4466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType? Type4467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolErrorType? Type4468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseType? Type4469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequestType? Type4470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsType? Type4471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaMCPListToolsTool>? Type4472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsTool? Type4473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType? Type4474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam? Type4475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType? Type4476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam? Type4477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParam? Type4478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? Type4479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? Type4480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? Type4481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminator? Type4482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType? Type4483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType? Type4484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType? Type4485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType? Type4486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType? Type4487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? Type4488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam? Type4489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus? Type4490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam? Type4491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParam? Type4492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParam? Type4493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminator? Type4494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType? Type4495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType? Type4496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType? Type4497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType? Type4498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellActionParam? Type4499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant15? Type4500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator? Type4501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type4502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType? Type4503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus? Type4504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallType? Type4505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecAction? Type4506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallStatus? Type4507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecActionType? Type4508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType? Type4509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus? Type4510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>? Type4511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item2? Type4512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? Type4513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? Type4514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type4515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type4516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType? Type4517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType? Type4518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallType? Type4519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallStatus? Type4520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>? Type4521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1? Type4522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallQuality? Type4523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageBackground? Type4524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageOutputFormat? Type4525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType? Type4526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemType? Type4527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent>? Type4528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContent? Type4529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>? Type4530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContent? Type4531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemStatus? Type4532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContentType? Type4533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContentType? Type4534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType? Type4535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning? Type4536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType? Type4537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole? Type4538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType? Type4539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallItemStatus? Type4540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParamType? Type4541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType? Type4542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction1? Type4543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam>? Type4544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParam? Type4545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamType? Type4546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem4>? Type4547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem4? Type4548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParam? Type4549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParam? Type4550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam? Type4551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator? Type4552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType? Type4553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParamType? Type4554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParamType? Type4555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParamType? Type4556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType? Type4557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamType? Type4558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6>? Type4559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem6? Type4560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParam? Type4561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? Type4562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParam? Type4563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminator? Type4564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType? Type4565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParamType? Type4566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType? Type4567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDetailEnum? Type4568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam? Type4569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode? Type4570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParamType? Type4571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType? Type4572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>? Type4573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>? Type4574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item2? Type4575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParam? Type4576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type4577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type4578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParamType? Type4579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileDetailEnum? Type4580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallType? Type4581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallStatus? Type4582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallType? Type4583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchCallStatus? Type4584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallAction? Type4585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch? Type4586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? Type4587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFind? Type4588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminator? Type4589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType? Type4590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFindType? Type4591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType? Type4592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchType? Type4593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? Type4594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSource? Type4595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType? Type4596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType? Type4597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImage? Type4598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? Type4599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam? Type4600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImageType? Type4601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallType? Type4602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerAction? Type4603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>? Type4604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallStatus? Type4605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParam? Type4606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickAction? Type4607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParam? Type4608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressAction? Type4609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParam? Type4610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParam? Type4611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParam? Type4612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParam? Type4613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParam? Type4614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminator? Type4615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType? Type4616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParamType? Type4617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParamType? Type4618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParamType? Type4619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParamType? Type4620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParamType? Type4621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressActionType? Type4622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParamType? Type4623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam>? Type4624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCoordParam? Type4625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickActionType? Type4626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParamType? Type4627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickButtonType? Type4628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallType? Type4629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallStatus? Type4630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? Type4631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item? Type4632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageType? Type4633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageRole? Type4634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputMessageContent>? Type4635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContent? Type4636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase? Type4637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageStatus? Type4638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContent? Type4639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContent? Type4640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminator? Type4641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType? Type4642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContentType? Type4643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentType? Type4644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>? Type4645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotation? Type4646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>? Type4647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLogProb? Type4648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>? Type4649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTopLogProb? Type4650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBody? Type4651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBody? Type4652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody? Type4653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePath? Type4654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminator? Type4655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType? Type4656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePathType? Type4657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBodyType? Type4658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBodyType? Type4659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBodyType? Type4660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageType? Type4661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageRole? Type4662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageStatus? Type4663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>? Type4664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContent? Type4665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminator? Type4666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminatorType? Type4667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageRole? Type4668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>? Type4669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageType? Type4670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResponseMethodPublicBody? Type4671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsCompaction? Type4672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum? Type4673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsParam? Type4674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierEnum? Type4675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheTTLEnum? Type4676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheModeEnum? Type4677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Type4678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsShared? Type4679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? Type4680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum? Type4681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorResponse? Type4682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaError? Type4683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorDetailsResource? Type4684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorType? Type4685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentSteer? Type4686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? Type4687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemList? Type4688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemListObject? Type4689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemResource>? Type4690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResource? Type4691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResource? Type4692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? Type4693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResource? Type4694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource? Type4695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessage? Type4696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCall? Type4697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput? Type4698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCall? Type4699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutput? Type4700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalTools? Type4701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdate? Type4702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgram? Type4703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutput? Type4704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBody? Type4705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCall? Type4706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput? Type4707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall? Type4708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? Type4709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? Type4710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResource? Type4711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResource? Type4712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminator? Type4713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType? Type4714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? Type4715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum? Type4716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? Type4717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallStatus? Type4718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType? Type4719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType? Type4720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus? Type4721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallType? Type4722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatus? Type4723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation2? Type4724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? Type4725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? Type4726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? Type4727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminator? Type4728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType? Type4729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType? Type4730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType? Type4731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType? Type4732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputType? Type4733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum? Type4734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? Type4735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent? Type4736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome2? Type4737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? Type4738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? Type4739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminator? Type4740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? Type4741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType? Type4742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType? Type4743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallType? Type4744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellAction? Type4745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallStatus? Type4746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant16? Type4747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource? Type4748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResource? Type4749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1Discriminator? Type4750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? Type4751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResourceType? Type4752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType? Type4753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBodyType? Type4754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputType? Type4755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputStatus? Type4756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramType? Type4757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType? Type4758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning? Type4759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsType? Type4760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageRole? Type4761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputType? Type4762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallType? Type4763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputType? Type4764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction? Type4765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent>? Type4766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallType? Type4767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageType? Type4768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7>? Type4769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem7? Type4770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContent? Type4771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent? Type4772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContent? Type4773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminator? Type4774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType? Type4775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentType? Type4776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContentType? Type4777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContentType? Type4778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? Type4779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? Type4780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputType? Type4781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus? Type4782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? Type4783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput? Type4784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? Type4785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputStatus? Type4786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputType? Type4787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus? Type4788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? Type4789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResource? Type4790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResourceObject? Type4791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemField>? Type4792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemField? Type4793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsage? Type4794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails? Type4795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails? Type4796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessage? Type4797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminator? Type4798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType? Type4799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageType? Type4800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageStatus? Type4801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem8>? Type4802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem8? Type4803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminator? Type4804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType? Type4805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase2? Type4806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? Type4807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType? Type4808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? Type4809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType? Type4810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent? Type4811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEventType? Type4812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponse? Type4813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponseProperties? Type4814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseProperties? Type4815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3? Type4816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierResponsesEnum? Type4817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Truncation? Type4818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Object? Type4819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Status? Type4820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsBody? Type4821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorVariant1? Type4822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetails? Type4823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason? Type4824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputItem>? Type4825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItem? Type4826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptions? Type4827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnostics? Type4828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModeration? Type4829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConversation? Type4830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input5? Type4831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBody? Type4832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBody? Type4833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminator? Type4834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType? Type4835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output9? Type4836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminator? Type4837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType? Type4838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBodyType? Type4839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBodyType? Type4840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>>? Type4841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>? Type4842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputType? Type4843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? Type4844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? Type4845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? Type4846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? Type4847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator? Type4848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType? Type4849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType? Type4850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type4851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType? Type4852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType? Type4853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum? Type4854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminator? Type4855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType? Type4856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorCode? Type4857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCyberAccessProgramEnum? Type4858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptVariant1? Type4859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>? Type4860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention? Type4861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? Type4862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType? Type4863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? Type4864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType? Type4865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? Type4866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType? Type4867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? Type4868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType? Type4869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? Type4870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType? Type4871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? Type4872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType? Type4873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? Type4874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType? Type4875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? Type4876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType? Type4877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? Type4878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType? Type4879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? Type4880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType? Type4881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? Type4882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType? Type4883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? Type4884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType? Type4885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? Type4886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType? Type4887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? Type4888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType? Type4889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? Type4890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType? Type4891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? Type4892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType? Type4893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? Type4894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType? Type4895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? Type4896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType? Type4897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus? Type4898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPart? Type4899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType? Type4900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? Type4901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType? Type4902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPart? Type4903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType? Type4904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent? Type4905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEventType? Type4906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProb>? Type4907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProb? Type4908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? Type4909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob? Type4910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? Type4911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEventType? Type4912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? Type4913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType? Type4914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? Type4915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType? Type4916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? Type4917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType? Type4918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? Type4919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType? Type4920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent? Type4921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEventType? Type4922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent? Type4923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType? Type4924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent? Type4925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType? Type4926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaShellCallOutputDelta? Type4927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent? Type4928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType? Type4929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent? Type4930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType? Type4931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent? Type4932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType? Type4933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? Type4934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType? Type4935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? Type4936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType? Type4937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? Type4938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType? Type4939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? Type4940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType? Type4941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? Type4942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType? Type4943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEvent? Type4944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEventType? Type4945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent? Type4946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEventType? Type4947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? Type4948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType? Type4949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContent? Type4950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminator? Type4951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType? Type4952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? Type4953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType? Type4954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent? Type4955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEventType? Type4956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent? Type4957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType? Type4958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? Type4959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType? Type4960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? Type4961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType? Type4962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? Type4963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType? Type4964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? Type4965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType? Type4966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? Type4967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType? Type4968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? Type4969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType? Type4970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? Type4971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType? Type4972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? Type4973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEventType? Type4974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? Type4975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType? Type4976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent? Type4977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEventType? Type4978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEvent? Type4979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEventType? Type4980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? Type4981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType? Type4982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? Type4983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType? Type4984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? Type4985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType? Type4986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? Type4987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventType? Type4988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer? Type4989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInput? Type4990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventError? Type4991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType? Type4992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCode? Type4993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? Type4994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? Type4995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItem? Type4996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParam? Type4997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminator? Type4998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType? Type4999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamType? Type5000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamRole? Type5001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? Type5002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>? Type5003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item2? Type5004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminator? Type5005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType? Type5006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? Type5007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventType? Type5008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventSteer? Type5009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReason? Type5010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? Type5011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInput? Type5012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type5013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType? Type5014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? Type5015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType? Type5016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? Type5017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType? Type5018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? Type5019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType? Type5020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type5021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? Type5022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? Type5023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType? Type5024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution? Type5025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? Type5026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType? Type5027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator? Type5028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType? Type5029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? Type5030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? Type5031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType? Type5032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventSteer? Type5033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEvent? Type5034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEventType? Type5035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudio? Type5036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudioType? Type5037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudio? Type5038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioType? Type5039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudio? Type5040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudioFormat? Type5041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputParam? Type5042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContent? Type5043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaIncludeEnum? Type5044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEvent? Type5045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? Type5046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2? Type5047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? Type5048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2? Type5049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? Type5050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2? Type5051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? Type5052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2? Type5053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2? Type5054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2? Type5055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2? Type5056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2? Type5057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2? Type5058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? Type5059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2? Type5060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? Type5061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2? Type5062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? Type5063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2? Type5064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? Type5065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2? Type5066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? Type5067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2? Type5068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? Type5069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2? Type5070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? Type5071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2? Type5072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? Type5073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2? Type5074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2? Type5075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? Type5076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2? Type5077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? Type5078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2? Type5079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? Type5080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2? Type5081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? Type5082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2? Type5083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2? Type5084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2? Type5085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? Type5086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2? Type5087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? Type5088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2? Type5089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? Type5090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2? Type5091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? Type5092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2? Type5093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? Type5094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2? Type5095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? Type5096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2? Type5097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? Type5098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2? Type5099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? Type5100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2? Type5101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? Type5102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2? Type5103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? Type5104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2? Type5105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? Type5106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2? Type5107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? Type5108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2? Type5109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? Type5110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2? Type5111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? Type5112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2? Type5113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? Type5114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2? Type5115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? Type5116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2? Type5117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? Type5118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2? Type5119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? Type5120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2? Type5121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? Type5122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2? Type5123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? Type5124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2? Type5125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? Type5126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2? Type5127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? Type5128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2? Type5129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? Type5130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2? Type5131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? Type5132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2? Type5133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? Type5134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2? Type5135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? Type5136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2? Type5137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? Type5138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2? Type5139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? Type5140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2? Type5141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? Type5142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2? Type5143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? Type5144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2? Type5145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? Type5146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2? Type5147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? Type5148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2? Type5149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? Type5150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2? Type5151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? Type5152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2? Type5153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsError? Type5154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? Type5155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? Type5156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminator? Type5157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType? Type5158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventType? Type5159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventError? Type5160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode? Type5161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType? Type5162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsErrorType? Type5163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorPayload? Type5164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEvent? Type5165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEventVariant2? Type5166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEvent? Type5167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? Type5168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEvent? Type5169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminator? Type5170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType? Type5171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEventType? Type5172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? Type5173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type? Type5174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponse? Type5175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties? Type5176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3? Type5177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsParam? Type5178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParam? Type5179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation? Type5180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? Type5181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationParam? Type5182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1? Type5183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>? Type5184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContextManagementParam? Type5185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentParam? Type5186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationPolicyParam? Type5187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationConfigParam? Type5188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationMode? Type5189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? Type5190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEvent? Type5191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminator? Type5192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType? Type5193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateChatCompletionRequest? Type5194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationItemsRequest? Type5195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEvalRequest? Type5196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysCreateRequest? Type5197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsOrder? Type5198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListChatCompletionsOrder? Type5199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetChatCompletionMessagesOrder? Type5200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainersOrder? Type5201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainerFilesOrder? Type5202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListConversationItemsOrder? Type5203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrder? Type5204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrderBy? Type5205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsOrder? Type5206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsStatus? Type5207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? Type5208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? Type5209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesOrder? Type5210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? Type5211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysListOrder? Type5212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsEffectiveAt? Type5213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>? Type5214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationCertificatesOrder? Type5215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>? Type5216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetCertificateIncludeItem? Type5217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsBucketWidth? Type5218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? Type5219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsGroupByItem? Type5220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupsOrder? Type5221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder? Type5222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupUsersOrder? Type5223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess? Type5224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesOrder? Type5225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupsOrder? Type5226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RetrieveProjectGroupGroupType? Type5227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? Type5228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRolesOrder? Type5229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder? Type5230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth? Type5231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? Type5232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem? Type5233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth? Type5234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? Type5235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem? Type5236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth? Type5237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? Type5238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem? Type5239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsBucketWidth? Type5240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? Type5241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsGroupByItem? Type5242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth? Type5243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? Type5244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem? Type5245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth? Type5246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? Type5247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem? Type5248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesBucketWidth? Type5249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSource>? Type5250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSource? Type5251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSize>? Type5252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSize? Type5253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesGroupByItem>? Type5254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesGroupByItem? Type5255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsBucketWidth? Type5256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? Type5257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsGroupByItem? Type5258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresBucketWidth? Type5259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? Type5260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresGroupByItem? Type5261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth? Type5262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? Type5263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel? Type5264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? Type5265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem? Type5266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder? Type5267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupRoleAssignmentsOrder? Type5268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectRolesOrder? Type5269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder? Type5270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListInputItemsOrder? Type5271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesOrder? Type5272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsOrder? Type5273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? Type5274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunIncludeItem? Type5275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsOrder? Type5276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? Type5277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsIncludeItem? Type5278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>? Type5279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetRunStepIncludeItem? Type5280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresOrder? Type5281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? Type5282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? Type5283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesOrder? Type5284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesFilter? Type5285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? Type5286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem? Type5287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? Type5288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem? Type5289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? Type5290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem? Type5291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? Type5292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem? Type5293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? Type5294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem? Type5295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOrder? Type5296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? Type5297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem? Type5298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? Type5299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem? Type5300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>? Type5301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponse? Type5302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponseObject? Type5303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponse? Type5304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponseObject? Type5305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalResponse? Type5306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalRunResponse? Type5307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponse? Type5308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponseObject? Type5309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponse? Type5310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponseObject? Type5311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponse? Type5312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject? Type5313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubagentResource>? Type5314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponse? Type5315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponseObject? Type5316 { get; set; }

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
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Model19>? ListType132 { get; set; }
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
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem14>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem4>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.List<string>>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem15>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ExternalStorageResponse>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem2>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VideoResource>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemField>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillResource>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillVersionResource>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem5>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Attachment>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem3>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseOutputText>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TaskGroupTask>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadItem>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadResource>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillResource>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentFileResource>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentContentResource>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageContentResource>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextResource>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentResource>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnItemResource>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TurnResource>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolResource>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentResource>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateSkillResource>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateFileResource>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentTemplateResource>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SetupCommandParam>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillParam>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginParam>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolResource>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionRequiredActionResource>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionResource>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolConfigParam>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentParam>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageParam>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputTextResource>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionArtifactResource>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionInputParam>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnTraceResource>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultStatusParam>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultResource>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultCredentialResource>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookEndpointBody>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectEventTypeEnum>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>, string>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTool>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSearchContentType>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem16>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLocalSkillParam>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem3>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaMCPListToolsTool>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item2>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSummaryTextContent>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaReasoningTextContent>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContentParam>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem4>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem6>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerAction>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCoordParam>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputMessageContent>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaAnnotation>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLogProb>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTopLogProb>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemResource>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContent>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem7>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemField>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem8>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputItem>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProb>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaIncludeEnum>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContextManagementParam>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogEventType>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetCertificateIncludeItem>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCostsGroupByItem>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSource>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSize>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesGroupByItem>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateRunIncludeItem>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetRunStepIncludeItem>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubagentResource>? ListType369 { get; set; }
    }
}