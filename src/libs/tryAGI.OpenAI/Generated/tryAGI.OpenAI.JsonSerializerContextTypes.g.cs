
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
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptSessionType? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallReferRequest? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallRejectRequest? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEvent? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEvent? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParam? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParam? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCreateParam? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParam? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParam? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParam? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminator? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminatorType? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveConnectParams? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateRequest? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionCreateParams? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransport? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponse? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponseSession? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEvent? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminator? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkPathParams? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkRequest? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionForkParams? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParam? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientConfigParam? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransport? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransportType? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunk? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuth? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuthType? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEventDiscriminator? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequest? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminator? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminatorType? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponse? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session5? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport2? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2Type? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminator? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminatorType? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEvent? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandConnectParams? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandPathParams? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEvent? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRinging? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnswered? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailed? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStarted? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdated? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuted? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppended? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppended? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppended? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreated? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEvent? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreated? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleted? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEvent? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosed? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEvent? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEvent? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransportType? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallType? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecAction? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallStatus? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputType? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputStatus? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProbProperties? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalRequestType? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseType? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseResourceType? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsType? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsTool? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPTool? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolType? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolConnectorId? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolFilter? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallType? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallError? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallStatus? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolError? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionError? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPError? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminator? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectType? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectType? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObject? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObjectType? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObject? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectType? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectText? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObject? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectType? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectText? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObject? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectObject? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDelta? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectObject? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectStatus? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetails? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectRole? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObjectType? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1Event? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2Event? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3Event? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4Event? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5Event? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelObject? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIds? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponses? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsCompaction? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLiveEnum? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponsesEnum? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsSharedEnum? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequest? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResources? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyCertificateRequest? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyMessageRequest? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyRunRequest? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequest? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResources? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesCodeInterpreter? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesFileSearch? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NoiseReductionType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileObject? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFilePurpose? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileStatus? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateObject? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponse? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponse? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetention? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionObject? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateObject? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponse? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponse? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlert? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertObject? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertCurrency? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertInterval? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResource? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResource? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert>? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudio? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudioType? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContent? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContent? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContent? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminator? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminatorType? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItem? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminator? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminatorType? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageType? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageRole? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContent? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageStatus? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminator? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PermissionErrorResponse? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContentType? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Project? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectObject? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicProjectResidency? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKey? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyObject? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwner? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerType? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerUser? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerServiceAccount? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponse? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponseObject? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectApiKey>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectCreateRequest? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetention? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionObject? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionType? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroup? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupObject? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupGroupType? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResource? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResource? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResourceObject? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup>? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissions? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponse? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponseObject? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Project>? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissions? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsObject? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsMode? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponse? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimit? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitObject? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponse? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponseObject? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectRateLimit>? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccount? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountObject? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountRole? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKey? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponse? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponse? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectServiceAccount>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlert? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertObject? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertCurrency? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertInterval? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResource? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectSpendAlert>? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUpdateRequest? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUser? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserObject? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserCreateRequest? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponse? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponseObject? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserListResponse? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectUser>? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserUpdateRequest? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptVariant1? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateOrganizationRoleBody? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResource? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResourceObject? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role>? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreate? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItem? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDelete? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDeleteType? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieve? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieveType? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncate? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncateType? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppend? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppendType? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClear? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClearType? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommit? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommitType? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClear? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClearType? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancel? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancelType? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreate? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParams? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdate? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdateType? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequest? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdate? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdateType? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponse? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseObject? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatus? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetails? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsage? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetails? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageOutputTokenDetails? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseModalitie? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceOptions? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunction? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCP? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreated? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeleted? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeletedType? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailed? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedError? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrieved? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncated? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncatedType? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventError? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorType? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCleared? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferClearedType? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommitted? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommittedType? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStarted? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStartedType? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStopped? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStoppedType? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompleted? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompletedType? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailed? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailedType? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgress? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgressType? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdated? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedType? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDelta? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDeltaType? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDone? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDoneType? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDelta? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDeltaType? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDone? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDoneType? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAdded? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedType? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPart? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPartType? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDone? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDoneType? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePart? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePartType? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreated? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDone? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDelta? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDone? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDelta? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDone? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDoneType? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompleted? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompletedType? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailed? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailedType? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgress? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgressType? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAdded? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDone? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDelta? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDeltaType? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDone? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDoneType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreated? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSession? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdated? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreated? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreatedType? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdated? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdatedType? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallCreateRequest? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallReferRequest? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallRejectRequest? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEvent? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminator? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParams? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdate? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdateType? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUser? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponse? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListTools? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCall? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequest? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminator? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReference? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceObject? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItemType? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session2? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionTool? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionToolType? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPError? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListToolsType? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolError? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCallType? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoning? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoningEffort? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponse? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseObject? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatus? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetails? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsError? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudio? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudioOutput? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsage? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetails? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageOutputTokenDetails? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseOutputModalitie? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEvent? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventError? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDone? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminator? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorType? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorError? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPart? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePart? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdated? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionObject? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModalitie? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModel? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncation? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponse? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEvent? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppendType? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionCloseType? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdateType? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequest? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfterAnchor? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSession? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEvent? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminator? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionType? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudio? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInput? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioOutput? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputTranscription? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputNoiseReduction? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudio? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInput? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputTranscription? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputNoiseReduction? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioOutput? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum2? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumType? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnum? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummary? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningContext? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningGenerateSummary? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemType? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContent? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemStatus? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Response? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Truncation? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Object? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Status? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsBody? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorVariant1? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsage? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptions? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnostics? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Moderation? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConversation? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEventType? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEventType? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingEvent? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEvent? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEventType? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateType? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEventType? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEventType? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEvent? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEventType? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorCode? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEvent? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEventType? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEvent? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEventType? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonObjectType? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaType? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextType? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammar? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammarType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPython? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPythonType? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEvent? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEventType? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEventType? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemList? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemListObject? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemResource>? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProb? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProbTopLogprob? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEventType? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseModalitiesVariant1Item? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEventType? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEventType? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Annotation? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextParam? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceParam? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEvent? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEventType? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEventType? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEventType? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventType? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCode? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEvent? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEventType? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInput? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventType? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventSteer? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventError? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItem? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParam? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminator? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventType? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventSteer? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReason? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInput? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEvent? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminator? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEventType? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEventType? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageInputTokensDetails? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsError? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsErrorType? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorPayload? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEvent? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminator? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEvent? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminator? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEvent? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEventVariant2? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleObject? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResource? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResourceObject? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResource? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResourceObject? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetails>? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunCompletionUsageVariant1? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderRequest? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponse? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadata? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataErrors? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataTokenUsage? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectObject? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectStatus? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredAction? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionType? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObject? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastError? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastErrorCode? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetails? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepCompletionUsageVariant1? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObject? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectObject? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectDelta? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectObject? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectType? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectStatus? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastError? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastErrorCode? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1Event? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2Event? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3Event? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4Event? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5Event? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6Event? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7Event? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1Event? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2Event? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3Event? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4Event? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5Event? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6Event? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7Event? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8Event? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9Event? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10Event? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectType? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectFunction? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDeltaEventType? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventType? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventUsage? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendAlertNotificationChannelType? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategy? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequest? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchema? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObject? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectObject? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResources? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1Event? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToggleCertificatesRequest? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionTool? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchTool? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerTool? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewTool? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchTool? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParam? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParam? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParam? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParam? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParam? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParam? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewTool? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParam? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminator? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminatorType? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowed? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedType? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedMode? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustom? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustomType? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunctionType? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCPType? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypes? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParam? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParam? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypesType? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputTool? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParam? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminator? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventType? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventType? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEventType? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDurationType? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensType? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategy? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategyEnum? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObjectType? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateGroupBody? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBody? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBodyRetentionType? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBody? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBodyRetentionType? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBody? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreRequest? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVoiceConsentRequest? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Upload? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadStatus? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadObject? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadCertificateRequest? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPart? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPartObject? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResultObject? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResult? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultApiSource? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultObject? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResultObject? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResultObject? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResult? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResultObject? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResult? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResultObject? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponse? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponseObject? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucket? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketObject? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem>? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResult? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminator? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResultObject? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultObject? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.User? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserObject? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1Object? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjects? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsObject? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UserProjectsDataItem>? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsDataItem? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponse? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponseObject? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResource? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResourceObject? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser>? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponse? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponseObject? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.User>? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignment? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignmentObject? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleUpdateRequest? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfigType? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderRequest? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderResponse? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?>? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObject? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectFileCounts? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponse? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseObject? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectObject? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectStatus? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastError? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectObject? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectFileCounts? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectStatus? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequest? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObject? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultItem? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPage? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResource? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResource? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResourceObject? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VoiceConsentResource>? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResource? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResourceObject? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsSharedEnum? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResource? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceObject? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceType? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFind? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFindType? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPageType? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearch? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchType? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSource? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSourceType? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolType? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolFilters? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolSearchContextSize? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallType? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallStatus? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallAction? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpired? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentEvent? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailed? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReady? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspended? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequired? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreated? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailed? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdle? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgress? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelled? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledData? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledObject? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledType? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompleted? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedData? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedObject? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedType? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpired? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredData? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredObject? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredType? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailed? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedData? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedObject? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedType? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceled? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledData? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledObject? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledType? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailed? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedData? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedObject? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedType? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceeded? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededData? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededObject? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededType? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelled? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledObject? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledType? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailed? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedData? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedObject? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedType? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceeded? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededObject? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededType? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncoming? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingData? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingObject? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingType? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncoming? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingData? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataType? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingObject? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingType? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncoming? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingData? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingObject? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingType? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelled? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledData? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledObject? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledType? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompleted? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedData? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedObject? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedType? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailed? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedData? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedObject? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedType? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncomplete? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteData? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteObject? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteType? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreated? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedObject? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedType? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedData? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssued? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedObject? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedType? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedData? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreated? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedObject? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedType? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedData? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssued? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedObject? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedType? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedData? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorType? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentSteer? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputType? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBodyType? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTTLEnum? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheModeEnum? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamMode? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationMode? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationConfigParam? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationPolicyParam? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParamType? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParam? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamType? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamMediaType? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParamType? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStatus? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRole? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfig? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentType? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBody? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBodyType? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBody? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBodyType? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBody? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBodyType? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminator? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminatorType? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TopLogProb? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProb? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContentType? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContent? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContentType? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContentType? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContentType? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContentType? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetail? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentType? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContent? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContentType? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileInputDetail? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentType? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase2? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageType? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem3? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminator? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminatorType? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCaller? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerType? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCaller? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerType? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminator? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParam? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParamType? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParamType? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminator? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallModerationDetails? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallError? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageBackground? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageOutputFormat? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallType? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallStatus? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallQuality? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickButtonType? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParamType? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickActionType? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CoordParam? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParamType? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressActionType? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParamType? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParamType? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParamType? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParamType? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParamType? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallType? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolType? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankerVersionType? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HybridSearchOptions? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankingOptions? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Filters2? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolType? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolType? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerEnvironment? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewToolType? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerMemoryLimit? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy2? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParamType? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParamType? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParam? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamType? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy3? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem2? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalSkillParam? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParam? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParamType? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParam? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParamType? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamType? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant1? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParam? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParamType? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GrammarSyntax1? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParam? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParamType? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamType? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format2? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmptyModelParam? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParam? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParamType? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamType? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem13? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParamType? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocation? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocationType? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContextSize? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContentType? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewToolType? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParamType? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputType? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsType? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramType? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputStatus? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputType? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBodyType? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogsType? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImageType? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecActionType? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellAction? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallStatus? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResource? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResourceType? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResource? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResourceType? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallType? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant12? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContent? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputType? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatus? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallType? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatus? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputType? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolErrorType? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionErrorType? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPErrorType? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DetailEnum? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemStatus? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParamType? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParam? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParamType? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParam? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParamType? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileDetailEnum? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParam? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParamType? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamType? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParam? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParamType? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParam? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParamType? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParam? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParamType? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParamType? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParam? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem14>? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem14? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminator? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParamType? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolSearchOutputTool>? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamType? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamRole? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParamType? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellActionParam? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemStatus? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamType? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant13? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentParam? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatusParam? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParam? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParamType? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParamType? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParamType? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemStatus? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParamType? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResource? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResourceObject? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenOutputTokensDetails? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenInputUsageDetails? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomVoiceParam? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParam? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParamType? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesServiceTier? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningEffort? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningSummary? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationReasoningInputParam? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTextVerbosity? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationTextInputParam? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParamType? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParamType? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParamType? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerMemoryLimit? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParam? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParamType? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParam? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamType? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParam? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParamType? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyVariant1? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1Discriminator? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsVariant1Item>? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsVariant1Item? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminator? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParam? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParamType? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalSkillParam? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParam? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParamType? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveLocalSkillParam>? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamType? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant14? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1Discriminator? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParam? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParamType? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParam? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParamType? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParam? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParamType? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParam? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParamType? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParam? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParamType? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceEnum? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParamType? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParam? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParamType? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParam? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParamType? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParam? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParamType? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParam? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParamType? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParam? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParamType? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceValueEnum? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem15? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminator? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem16>? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem16? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminator? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant2?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant2? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2Discriminator? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParamType? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceParam? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, bool?>? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionChoiceParam>? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreLevelParam? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionScoreLevelParam>? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestion? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminator? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminatorType? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionQuestion>? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParamType? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1Discriminator? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParam? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParamEventType? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialMessageStatus? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParamType? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4>? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem4? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminator? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItem? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminator? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedServerEventParam? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParam? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem17>? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem17? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant22?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant22? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2Discriminator? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponse? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponseType? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminator? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminatorType? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectApiKeyBody? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParamType? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParamType? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CyberAccessProgramEnum? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CacheMissReasonTypeEnum? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBody? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBodyType? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input4? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminator? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminatorType? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output5? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminator? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminatorType? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ShellCallOutputDelta? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationBody? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateConversationBody? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResourceObject? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNoticeType? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNotice? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResource? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResourceObject? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertErrorType? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResource? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResourceObject? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketWidth? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageGroupBy? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageApiSource? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResult? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResultObject? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucket? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketObject? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageResult>? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResource? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageBucket>? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorDetails? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorResponse? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsagePermissionErrorResponse? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageOrder? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageStatus? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponse? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseObject? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider2? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResource? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResourceObject? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalStorageResponse>? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParams? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParamsType? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBody? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider3? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResource? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResourceObject? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrency? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitInterval? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatus? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcement? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResource? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBody? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyCurrency? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyInterval? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResource? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResource? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResourceObject? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBody? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResource? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateProjectServiceAccountApiKeyBody? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBody? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContentProvenanceBody? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceCheckObject? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceDetectionResultApi? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAValidationStateApi? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResult? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResultType? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResult? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResultType? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResource? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2>? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem2? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminator? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrderEnum? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModel? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModelEnum? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoStatus? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSize? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error22? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResource? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResourceObject? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResource? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResourceObject? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam2? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSeconds? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoMultipartBody? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoJsonBody? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoCharacterBody? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoCharacterResource? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoReferenceInputParam? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditMultipartBody? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditJsonBody? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendMultipartBody? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendJsonBody? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResource? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResourceObject? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoContentVariant? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoRemixBody? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationEnum? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnum? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnumEnum? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsBody? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResource? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResourceObject? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheRetentionEnum? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum2? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResponseMethodPublicBody? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemField? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminator? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminatorType? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResource? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResourceObject? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField>? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResource? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResourceObject? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResource? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResourceObject? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillResource>? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillBody? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetDefaultSkillVersionBody? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResource? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResourceObject? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResource? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResourceObject? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResource? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResourceObject? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillVersionResource>? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillVersionBody? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResource? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResourceObject? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflowTracing? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflow? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, int?, bool?, double?>? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionRateLimits? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionStatus? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionFileUpload? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionHistory? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionChatkitConfiguration? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResource? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResourceObject? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowTracingParam? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowParam? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, int?, bool?, double?>? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParam? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParamAnchor? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RateLimitsParam? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomaticThreadTitlingParam? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileUploadParam? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HistoryParam? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitConfigurationParam? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatSessionBody? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputText? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputTextType? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedText? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedTextType? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AttachmentType? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Attachment? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoice9? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InferenceOptions? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItem? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemObject? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemType? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem5>? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem5? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminator? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment>? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSource? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSourceType? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotation? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationType? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSource? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSourceType? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotation? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationType? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputText? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextType? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3>? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem3? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminator? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItem? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemObject? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemType? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText>? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItem? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemObject? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemType? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallStatus? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItem? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemObject? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemType? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskType? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItem? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemObject? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemType? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupTask? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItem? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemObject? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemType? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask>? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItem? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminator? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminatorType? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResource? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResourceObject? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadItem>? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatus? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatusType? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatus? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatusType? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatus? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatusType? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResource? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceObject? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Status? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminator? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResource? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResourceObject? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResource? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResourceObject? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource>? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputText? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextType? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpoint? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetailParam? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImage? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpoint? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImageType? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputOutputText? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputOutputTextType? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputRefusal? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputRefusalType? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartsItem? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminator? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContent? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseParam? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessage? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageRole? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageType? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusParam? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCall? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallType? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminator? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContent? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCall? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallType? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInput? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2Item? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminator? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicate? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicateType? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueParam? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceOptionParam? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoice? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoiceType? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceOptionParam>? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreLevelParam? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScore? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScoreType? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreLevelParam>? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParam? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminator? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminatorType? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequest? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicate? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicateType? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueResource? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceProbabilityResource? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoice? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoiceType? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceProbabilityResource>? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreProbabilityResource? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScore? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScoreType? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreProbabilityResource>? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusal? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusalType? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResource? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminator? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminatorType? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageResource? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionResponse? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnswerResource>? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrderParam? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeParam? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeResource? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentStatusResource? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResource? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInline? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInlineType? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResource? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminator? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInline? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInlineType? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResource? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminator? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResource? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResourceObject? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResource? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResourceObject? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PublicEnvironmentResource>? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorBodyResource? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse2? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesParam? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetupCommandParam? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessParam? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyParam? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopParam? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParam? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminator? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInline? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInlineType? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParam? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminator? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInline? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInlineType? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParam? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminator? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParam? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHostedType? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParam? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminator? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminatorType? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentEnvironmentParams? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFilePageObjectResource? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResource? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResourceObject? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileListResource? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource>? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentObjectResource? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResource? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResourceType? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResource? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResourceType? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResource? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminator? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentStatusResource? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentResource? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionMessageRoleResource? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputText? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputTextType? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImage? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImageType? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputText? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputTextType? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResource? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminator? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemStatusResource? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseResource? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResource? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResourceType? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource>? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResource? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResourceType? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResource? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResourceType? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource>? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusResource? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResource? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResourceType? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputText? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputTextType? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImage? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImageType? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResource? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminator? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminatorType? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputResource? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResourceType? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResource? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResourceType? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResource? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResourceType? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResource? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResourceType? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResource? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResourceType? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldResource? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationOptionResource? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResource? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminator? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminator? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResource? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearchType? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOther? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOtherType? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResource? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminator? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResource? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResourceType? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResource? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResourceType? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResourceType? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResourceType? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResource? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminator? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResource? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResourceObject? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnItemResource>? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnObjectResource? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnStatusResource? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorCodeResource? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorResource? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource2? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource2? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenUsageResource? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnResource? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResource? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResourceObject? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TurnResource>? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortResource? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryResource? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningResource? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceText? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceTextType? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResource? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminator? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityResource? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResource? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResource? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResource? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminator? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginResource? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeResource? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeResource? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationResource? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUse? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResource? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminator? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigResource? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResource? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResourceObject? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolResource>? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResource? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResourceObject? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentResource>? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortParam? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryParam? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningParam? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamText? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamTextType? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchemaType? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParam? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminator? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminatorType? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityParam? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextParam? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierParam? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParam? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginParam? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeParam? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeParam? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationParam? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUse? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParam? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentParams? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentParams? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResource? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResourceObject? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesResource? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessResource? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyResource? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopResource? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResource? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminator? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResource? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminator? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResource? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResourceObject? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResource? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentTemplateResource>? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentTemplateParams? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResource? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionSpendControlResource? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionStatusResource? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequest? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResource? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminator? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunction? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunctionType? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttp? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttpType? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdio? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdioType? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResource? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminator? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcp? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcpType? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearchType? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUseType? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResource? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminator? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentResource? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource>? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNone? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNoneType? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeResource? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResource? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminator? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResource? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResourceObject? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource>? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResource? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResourceObject? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource>? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionSpendControlParam? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunctionType? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp? Type4091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttpType? Type4092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio? Type4093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdioType? Type4094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParam? Type4095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminator? Type4096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType? Type4097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp? Type4098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcpType? Type4099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? Type4100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType? Type4101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUse? Type4102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType? Type4103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParam? Type4104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminator? Type4105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType? Type4106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentConfigParam? Type4107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolConfigParam>? Type4108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNone? Type4109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNoneType? Type4110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeParam? Type4111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? Type4112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType? Type4113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted? Type4114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHostedType? Type4115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParam? Type4116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminator? Type4117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType? Type4118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputText? Type4119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputTextType? Type4120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImage? Type4121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImageType? Type4122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParam? Type4123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminator? Type4124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminatorType? Type4125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParam? Type4126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamType? Type4127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamRole? Type4128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? Type4129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionInputParam? Type4130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? Type4131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentSessionParams? Type4132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? Type4133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType? Type4134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionErrorResource? Type4135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventError? Type4136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventErrorType? Type4137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStatusResource? Type4138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentErrorResource? Type4139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStateResource? Type4140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? Type4141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType? Type4142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspended? Type4143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspendedType? Type4144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpired? Type4145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpiredType? Type4146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? Type4147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType? Type4148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? Type4149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType? Type4150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated? Type4151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType? Type4152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? Type4153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType? Type4154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? Type4155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType? Type4156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? Type4157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType? Type4158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? Type4159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType? Type4160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? Type4161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType? Type4162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? Type4163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType? Type4164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle? Type4165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdleType? Type4166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? Type4167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType? Type4168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? Type4169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType? Type4170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed? Type4171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailedType? Type4172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? Type4173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType? Type4174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? Type4175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType? Type4176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? Type4177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType? Type4178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? Type4179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType? Type4180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? Type4181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType? Type4182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? Type4183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType? Type4184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? Type4185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType? Type4186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResource? Type4187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceType? Type4188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceRole? Type4189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource>? Type4190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResource? Type4191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator? Type4192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType? Type4193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? Type4194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType? Type4195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? Type4196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType? Type4197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? Type4198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType? Type4199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? Type4200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType? Type4201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? Type4202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType? Type4203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? Type4204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType? Type4205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? Type4206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType? Type4207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? Type4208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? Type4209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType? Type4210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEvent? Type4211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminator? Type4212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminatorType? Type4213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionReasoningParam? Type4214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionAgentParam? Type4215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentSessionParams? Type4216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResource? Type4217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResourceObject? Type4218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResource? Type4219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResourceObject? Type4220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResource? Type4221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResourceObject? Type4222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionArtifactResource>? Type4223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResource? Type4224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject? Type4225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam? Type4226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam? Type4227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType? Type4228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction? Type4229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? Type4230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam? Type4231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType? Type4232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction? Type4233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? Type4234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType? Type4235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator? Type4236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? Type4237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam? Type4238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? Type4239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType? Type4240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParam? Type4241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator? Type4242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType? Type4243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResult? Type4244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType? Type4245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? Type4246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType? Type4247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? Type4248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType? Type4249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputParam? Type4250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? Type4251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType? Type4252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParam? Type4253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminator? Type4254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminatorType? Type4255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionEventsParams? Type4256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>? Type4257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResource? Type4258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResourceObject? Type4259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResource? Type4260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResourceObject? Type4261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnTraceResource>? Type4262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusParam? Type4263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusFilterParam? Type4264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? Type4265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResource? Type4266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResourceObject? Type4267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResource? Type4268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResourceObject? Type4269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultResource>? Type4270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultParams? Type4271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVaultParams? Type4272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResource? Type4273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResourceObject? Type4274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? Type4275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType? Type4276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? Type4277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType? Type4278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? Type4279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType? Type4280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource? Type4281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator? Type4282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType? Type4283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthRefreshResource? Type4284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? Type4285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType? Type4286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? Type4287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType? Type4288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? Type4289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType? Type4290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? Type4291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType? Type4292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResource? Type4293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator? Type4294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType? Type4295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? Type4296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType? Type4297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResource? Type4298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator? Type4299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType? Type4300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResource? Type4301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResourceObject? Type4302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResource? Type4303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResourceObject? Type4304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultCredentialResource>? Type4305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? Type4306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType? Type4307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam? Type4312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator? Type4313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthRefreshParam? Type4315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? Type4316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType? Type4317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? Type4318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType? Type4319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? Type4320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType? Type4321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? Type4322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType? Type4323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParam? Type4324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator? Type4325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType? Type4326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? Type4327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType? Type4328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParam? Type4329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator? Type4330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType? Type4331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialParams? Type4332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam? Type4337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator? Type4338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthRefreshParam? Type4340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? Type4341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType? Type4342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? Type4343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType? Type4344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? Type4345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType? Type4346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParam? Type4347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator? Type4348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType? Type4349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialParams? Type4350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResource? Type4351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject? Type4352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBody? Type4353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBodyObject? Type4354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResource? Type4355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResourceObject? Type4356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookEndpointBody>? Type4357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectEventTypeEnum? Type4358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateEndpointBody? Type4359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? Type4360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResource? Type4361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResourceObject? Type4362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateEndpointBody? Type4363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResource? Type4364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject? Type4365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRotateSecretBody? Type4366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicTestEndpointBody? Type4367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResource? Type4368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResourceObject? Type4369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResource? Type4370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResourceObject? Type4371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource? Type4372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource? Type4373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionConnectPayloadResource? Type4374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragPoint? Type4375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? Type4376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType? Type4377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? Type4378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType? Type4379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? Type4380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType? Type4381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormat? Type4382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminator? Type4383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminatorType? Type4384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioParam? Type4385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam2? Type4386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam2? Type4387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam2Type? Type4388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam2? Type4389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2? Type4390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2Type? Type4391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2EventType? Type4392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParams? Type4393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant12? Type4394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1Discriminator? Type4395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1DiscriminatorType? Type4396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2>? Type4397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEventType? Type4398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsSettingsUpdateParam? Type4399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParam? Type4400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType? Type4401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParams? Type4402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant13? Type4403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1Discriminator? Type4404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? Type4405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamType? Type4406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEventType? Type4407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParamType? Type4408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType? Type4409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType? Type4410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParamType? Type4411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParamType? Type4412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParamType? Type4413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCreateParamType? Type4414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputTextParam? Type4415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputTextParamType? Type4416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDetailEnum? Type4417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputImageParam? Type4418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputImageParamType? Type4419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParam? Type4420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamType? Type4421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamRole? Type4422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>>? Type4423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>? Type4424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item? Type4425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamContentVariant2ItemDiscriminator? Type4426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType? Type4427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParamType? Type4428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType? Type4429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParamType? Type4430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParamType? Type4431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParamType? Type4432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkAudioParam? Type4433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionConfigParam? Type4434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEventType? Type4435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParam? Type4436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant14? Type4437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1Discriminator? Type4438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1DiscriminatorType? Type4439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamStatus? Type4440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartedType? Type4441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdatedType? Type4442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMutedType? Type4443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmutedType? Type4444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType? Type4445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType? Type4446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendedType? Type4447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendedType? Type4448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendedType? Type4449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppend? Type4450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendType? Type4451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDelta? Type4452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDeltaType? Type4453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDeltaType? Type4454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType? Type4455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItem? Type4456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemType? Type4457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant3?>? Type4458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1? Type4459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2? Type4460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant3? Type4461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreatedType? Type4462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCompleted? Type4463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCompletedType? Type4464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventType? Type4465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1?, global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2?>? Type4466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1? Type4467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2? Type4468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam? Type4469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamType? Type4470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamRole? Type4471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>>? Type4472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>? Type4473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item2? Type4474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminator? Type4475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType? Type4476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreatedType? Type4477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeletedType? Type4478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEventType? Type4479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsage? Type4480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContextWindowUsage? Type4481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdatedType? Type4482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedType? Type4483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1? Type4484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2? Type4485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3? Type4486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4? Type4487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5? Type4488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLiveError? Type4489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEventType? Type4490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEventType? Type4491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived? Type4492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceivedType? Type4493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSend? Type4494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendType? Type4495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRingingType? Type4496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnsweredType? Type4497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallError? Type4498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallErrorType? Type4499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailedType? Type4500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2Discriminator? Type4501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType? Type4502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamType? Type4503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamRole? Type4504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>? Type4505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>? Type4506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item? Type4507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminator? Type4508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType? Type4509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResource? Type4510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResourceObject? Type4511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsBody? Type4512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? Type4513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>? Type4514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItem? Type4515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? Type4516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTool? Type4517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextParam? Type4518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoning? Type4519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTruncationEnum? Type4520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnum? Type4521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam? Type4522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceParam? Type4523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceOptions? Type4524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed? Type4525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypes? Type4526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunction? Type4527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCP? Type4528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustom? Type4529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? Type4530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? Type4531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? Type4532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType? Type4533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType? Type4534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType? Type4535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustomType? Type4536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCPType? Type4537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunctionType? Type4538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypesType? Type4539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedType? Type4540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedMode? Type4541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam2? Type4542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum? Type4543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnum? Type4544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningEffortEnum? Type4545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningSummary? Type4546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningContext? Type4547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningGenerateSummary? Type4548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? Type4549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration? Type4550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaVerbosityEnum? Type4551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatText? Type4552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? Type4553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject? Type4554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType? Type4555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType? Type4556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema? Type4557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatTextType? Type4558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionTool? Type4559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchTool? Type4560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerTool? Type4561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool? Type4562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchTool? Type4563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPTool? Type4564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool? Type4565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? Type4566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenTool? Type4567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParam? Type4568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam? Type4569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParam? Type4570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParam? Type4571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParam? Type4572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool? Type4573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam? Type4574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminator? Type4575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminatorType? Type4576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParamType? Type4577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? Type4578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCallableToolAllowedCaller? Type4579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewToolType? Type4580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocation? Type4581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContextSize? Type4582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>? Type4583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContentType? Type4584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocationType? Type4585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParamType? Type4586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Type4587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEmptyModelParam? Type4588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamType? Type4589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem18>? Type4590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem18? Type4591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParam? Type4592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator? Type4593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType? Type4594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamType? Type4595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format3? Type4596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam? Type4597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? Type4598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator? Type4599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType? Type4600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType? Type4601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGrammarSyntax1? Type4602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParamType? Type4603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParamType? Type4604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamType? Type4605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant15? Type4606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParam? Type4607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam? Type4608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParam? Type4609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator? Type4610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type4611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParamType? Type4612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParamType? Type4613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>? Type4614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalSkillParam? Type4615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamType? Type4616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerMemoryLimit? Type4617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy4? Type4618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? Type4619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? Type4620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator? Type4621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType? Type4622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>? Type4623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem3? Type4624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParam? Type4625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParam? Type4626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator? Type4627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType? Type4628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParamType? Type4629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParam? Type4630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamType? Type4631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType? Type4632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParamType? Type4633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType? Type4634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? Type4635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam? Type4636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType? Type4637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParamType? Type4638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolType? Type4639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>? Type4640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModel? Type4641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolQuality? Type4642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>? Type4643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolSize? Type4644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolOutputFormat? Type4645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModeration? Type4646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolBackground? Type4647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFidelity? Type4648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolInputImageMask? Type4649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenActionEnum? Type4650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType? Type4651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolType? Type4652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>? Type4653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam? Type4654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType? Type4655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy5? Type4656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type4657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type4658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolType? Type4659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolConnectorId? Type4660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? Type4661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolFilter? Type4662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>? Type4663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum? Type4664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2? Type4665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolType? Type4666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolFilters? Type4667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation? Type4668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize? Type4669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType? Type4670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewToolType? Type4671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerEnvironment? Type4672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolType? Type4673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolType? Type4674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankingOptions? Type4675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilters? Type4676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilter? Type4677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilter? Type4678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterType? Type4679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>? Type4680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem2? Type4681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator? Type4682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilterType? Type4683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankerVersionType? Type4684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHybridSearchOptions? Type4685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolType? Type4686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessage? Type4687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItem? Type4688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParam? Type4689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParam? Type4690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParam? Type4691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParam? Type4692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminator? Type4693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminatorType? Type4694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTagParam? Type4695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParamType? Type4696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemStatus? Type4697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParamType? Type4698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParamType? Type4699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType? Type4700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessage? Type4701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessage? Type4702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCall? Type4703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCall? Type4704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? Type4705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCall? Type4706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCall? Type4707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? Type4708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam? Type4709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? Type4710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? Type4711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam? Type4712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? Type4713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? Type4714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParam? Type4715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItem? Type4716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? Type4717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCall? Type4718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? Type4719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCall? Type4720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? Type4721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? Type4722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? Type4723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? Type4724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? Type4725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListTools? Type4726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest? Type4727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse? Type4728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCall? Type4729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? Type4730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCall? Type4731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminator? Type4732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminatorType? Type4733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTag? Type4734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallType? Type4735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCaller? Type4736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller? Type4737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller? Type4738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminator? Type4739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType? Type4740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerType? Type4741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerType? Type4742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputType? Type4743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParam? Type4744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? Type4745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? Type4746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput? Type4747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContent? Type4748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContent? Type4749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContent? Type4750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminator? Type4751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType? Type4752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentType? Type4753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? Type4754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileInputDetail? Type4755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode? Type4756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentType? Type4757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageDetail? Type4758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentType? Type4759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? Type4760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? Type4761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminator? Type4762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType? Type4763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType? Type4764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType? Type4765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallType? Type4766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallError? Type4767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallStatus? Type4768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolError? Type4769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError? Type4770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPError? Type4771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator? Type4772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType? Type4773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPErrorType? Type4774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType? Type4775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolErrorType? Type4776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseType? Type4777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequestType? Type4778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsType? Type4779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaMCPListToolsTool>? Type4780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsTool? Type4781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType? Type4782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam? Type4783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType? Type4784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam? Type4785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParam? Type4786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? Type4787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? Type4788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? Type4789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminator? Type4790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType? Type4791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType? Type4792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType? Type4793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType? Type4794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType? Type4795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? Type4796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam? Type4797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus? Type4798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam? Type4799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParam? Type4800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParam? Type4801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminator? Type4802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType? Type4803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType? Type4804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType? Type4805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType? Type4806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellActionParam? Type4807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant16? Type4808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator? Type4809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type4810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType? Type4811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus? Type4812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallType? Type4813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecAction? Type4814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallStatus? Type4815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecActionType? Type4816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType? Type4817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus? Type4818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>? Type4819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item2? Type4820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? Type4821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? Type4822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type4823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type4824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType? Type4825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType? Type4826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallType? Type4827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallStatus? Type4828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallError? Type4829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>? Type4830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1? Type4831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallQuality? Type4832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageBackground? Type4833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageOutputFormat? Type4834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetails? Type4835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage? Type4836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType? Type4837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemType? Type4838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent>? Type4839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContent? Type4840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>? Type4841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContent? Type4842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemStatus? Type4843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContentType? Type4844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContentType? Type4845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType? Type4846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning? Type4847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType? Type4848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole? Type4849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType? Type4850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaToolSearchOutputTool>? Type4851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputTool? Type4852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallItemStatus? Type4853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParam? Type4854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminator? Type4855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType? Type4856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType? Type4857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem19>? Type4858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem19? Type4859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParam? Type4860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminator? Type4861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type4862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType? Type4863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParamType? Type4864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType? Type4865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction1? Type4866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam>? Type4867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParam? Type4868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamType? Type4869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem4>? Type4870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem4? Type4871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParam? Type4872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParam? Type4873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam? Type4874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator? Type4875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType? Type4876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParamType? Type4877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParamType? Type4878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParamType? Type4879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType? Type4880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamType? Type4881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6>? Type4882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem6? Type4883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParam? Type4884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? Type4885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParam? Type4886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminator? Type4887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType? Type4888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParamType? Type4889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType? Type4890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDetailEnum? Type4891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam? Type4892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode? Type4893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParamType? Type4894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType? Type4895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>? Type4896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>? Type4897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item2? Type4898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParam? Type4899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type4900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type4901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParamType? Type4902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileDetailEnum? Type4903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallType? Type4904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallStatus? Type4905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallType? Type4906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchCallStatus? Type4907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallAction? Type4908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch? Type4909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? Type4910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFind? Type4911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminator? Type4912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType? Type4913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFindType? Type4914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType? Type4915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchType? Type4916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? Type4917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSource? Type4918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType? Type4919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType? Type4920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImage? Type4921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? Type4922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam? Type4923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImageType? Type4924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallType? Type4925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerAction? Type4926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>? Type4927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallStatus? Type4928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParam? Type4929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickAction? Type4930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParam? Type4931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressAction? Type4932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParam? Type4933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParam? Type4934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParam? Type4935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParam? Type4936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParam? Type4937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminator? Type4938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType? Type4939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParamType? Type4940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParamType? Type4941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParamType? Type4942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParamType? Type4943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParamType? Type4944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressActionType? Type4945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParamType? Type4946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam>? Type4947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCoordParam? Type4948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickActionType? Type4949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParamType? Type4950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickButtonType? Type4951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallType? Type4952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallStatus? Type4953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? Type4954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item? Type4955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageType? Type4956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageRole? Type4957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputMessageContent>? Type4958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContent? Type4959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase? Type4960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageStatus? Type4961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContent? Type4962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContent? Type4963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminator? Type4964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType? Type4965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContentType? Type4966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentType? Type4967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>? Type4968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotation? Type4969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>? Type4970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLogProb? Type4971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>? Type4972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTopLogProb? Type4973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBody? Type4974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBody? Type4975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody? Type4976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePath? Type4977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminator? Type4978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType? Type4979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePathType? Type4980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBodyType? Type4981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBodyType? Type4982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBodyType? Type4983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageType? Type4984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageRole? Type4985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageStatus? Type4986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>? Type4987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContent? Type4988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminator? Type4989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminatorType? Type4990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageRole? Type4991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>? Type4992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageType? Type4993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResponseMethodPublicBody? Type4994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsCompaction? Type4995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum? Type4996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsParam? Type4997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierEnum? Type4998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheTTLEnum? Type4999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheModeEnum? Type5000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Type5001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsShared? Type5002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? Type5003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum? Type5004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorResponse? Type5005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaError? Type5006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorDetailsResource? Type5007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorType? Type5008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentSteer? Type5009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? Type5010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemList? Type5011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemListObject? Type5012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemResource>? Type5013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResource? Type5014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResource? Type5015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? Type5016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResource? Type5017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource? Type5018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessage? Type5019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCall? Type5020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput? Type5021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCall? Type5022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutput? Type5023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalTools? Type5024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdate? Type5025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgram? Type5026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutput? Type5027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBody? Type5028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCall? Type5029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput? Type5030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall? Type5031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? Type5032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? Type5033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResource? Type5034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResource? Type5035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminator? Type5036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType? Type5037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? Type5038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum? Type5039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? Type5040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallStatus? Type5041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType? Type5042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType? Type5043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus? Type5044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallType? Type5045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatus? Type5046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation2? Type5047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? Type5048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? Type5049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? Type5050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminator? Type5051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType? Type5052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType? Type5053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType? Type5054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType? Type5055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputType? Type5056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum? Type5057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? Type5058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent? Type5059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome2? Type5060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? Type5061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? Type5062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminator? Type5063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? Type5064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType? Type5065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType? Type5066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallType? Type5067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellAction? Type5068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallStatus? Type5069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant17? Type5070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource? Type5071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResource? Type5072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1Discriminator? Type5073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? Type5074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResourceType? Type5075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType? Type5076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBodyType? Type5077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputType? Type5078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputStatus? Type5079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramType? Type5080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType? Type5081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning? Type5082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsType? Type5083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageRole? Type5084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputType? Type5085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallType? Type5086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputType? Type5087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction? Type5088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent>? Type5089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallType? Type5090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageType? Type5091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7>? Type5092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem7? Type5093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContent? Type5094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent? Type5095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContent? Type5096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminator? Type5097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType? Type5098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentType? Type5099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContentType? Type5100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContentType? Type5101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? Type5102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? Type5103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputType? Type5104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus? Type5105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? Type5106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput? Type5107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? Type5108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputStatus? Type5109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputType? Type5110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus? Type5111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? Type5112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResource? Type5113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResourceObject? Type5114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemField>? Type5115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemField? Type5116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsage? Type5117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails? Type5118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails? Type5119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessage? Type5120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminator? Type5121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType? Type5122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageType? Type5123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageStatus? Type5124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem8>? Type5125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem8? Type5126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminator? Type5127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType? Type5128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase2? Type5129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? Type5130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType? Type5131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? Type5132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType? Type5133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent? Type5134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEventType? Type5135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponse? Type5136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponseProperties? Type5137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseProperties? Type5138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3? Type5139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierResponsesEnum? Type5140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Truncation? Type5141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Object? Type5142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Status? Type5143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsBody? Type5144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorVariant1? Type5145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetails? Type5146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason? Type5147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputItem>? Type5148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItem? Type5149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptions? Type5150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnostics? Type5151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModeration? Type5152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConversation? Type5153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input5? Type5154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBody? Type5155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBody? Type5156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminator? Type5157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType? Type5158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output9? Type5159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminator? Type5160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType? Type5161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBodyType? Type5162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBodyType? Type5163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>>? Type5164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>? Type5165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputType? Type5166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? Type5167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? Type5168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? Type5169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? Type5170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator? Type5171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType? Type5172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType? Type5173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type5174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType? Type5175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType? Type5176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum? Type5177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminator? Type5178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType? Type5179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorCode? Type5180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCyberAccessProgramEnum? Type5181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptVariant1? Type5182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>? Type5183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention? Type5184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? Type5185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType? Type5186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? Type5187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType? Type5188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? Type5189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType? Type5190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? Type5191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType? Type5192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? Type5193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType? Type5194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? Type5195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType? Type5196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? Type5197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType? Type5198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? Type5199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType? Type5200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? Type5201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType? Type5202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? Type5203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType? Type5204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? Type5205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType? Type5206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? Type5207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType? Type5208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? Type5209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType? Type5210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? Type5211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType? Type5212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? Type5213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType? Type5214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? Type5215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType? Type5216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? Type5217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType? Type5218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? Type5219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType? Type5220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus? Type5221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPart? Type5222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType? Type5223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? Type5224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType? Type5225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPart? Type5226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType? Type5227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent? Type5228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEventType? Type5229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProb>? Type5230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProb? Type5231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? Type5232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob? Type5233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? Type5234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEventType? Type5235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? Type5236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType? Type5237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? Type5238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType? Type5239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? Type5240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType? Type5241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? Type5242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType? Type5243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent? Type5244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEventType? Type5245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent? Type5246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType? Type5247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent? Type5248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType? Type5249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaShellCallOutputDelta? Type5250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent? Type5251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType? Type5252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent? Type5253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType? Type5254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent? Type5255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType? Type5256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? Type5257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType? Type5258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? Type5259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType? Type5260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? Type5261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType? Type5262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? Type5263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType? Type5264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? Type5265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType? Type5266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEvent? Type5267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEventType? Type5268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent? Type5269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEventType? Type5270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? Type5271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType? Type5272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContent? Type5273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminator? Type5274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType? Type5275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? Type5276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType? Type5277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent? Type5278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEventType? Type5279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent? Type5280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType? Type5281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? Type5282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType? Type5283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? Type5284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType? Type5285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? Type5286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType? Type5287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? Type5288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType? Type5289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? Type5290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType? Type5291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? Type5292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType? Type5293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? Type5294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType? Type5295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? Type5296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEventType? Type5297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? Type5298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType? Type5299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent? Type5300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEventType? Type5301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEvent? Type5302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEventType? Type5303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? Type5304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType? Type5305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? Type5306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType? Type5307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? Type5308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType? Type5309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? Type5310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventType? Type5311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer? Type5312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInput? Type5313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventError? Type5314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType? Type5315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCode? Type5316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? Type5317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? Type5318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItem? Type5319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParam? Type5320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminator? Type5321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType? Type5322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamType? Type5323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamRole? Type5324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? Type5325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>? Type5326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item2? Type5327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminator? Type5328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType? Type5329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? Type5330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventType? Type5331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventSteer? Type5332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReason? Type5333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? Type5334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInput? Type5335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type5336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType? Type5337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? Type5338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType? Type5339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? Type5340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType? Type5341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? Type5342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType? Type5343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type5344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? Type5345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? Type5346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType? Type5347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution? Type5348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? Type5349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType? Type5350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator? Type5351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType? Type5352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? Type5353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? Type5354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType? Type5355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventSteer? Type5356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEvent? Type5357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEventType? Type5358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudio? Type5359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudioType? Type5360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudio? Type5361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioType? Type5362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudio? Type5363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudioFormat? Type5364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputParam? Type5365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContent? Type5366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaIncludeEnum? Type5367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEvent? Type5368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? Type5369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2? Type5370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? Type5371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2? Type5372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? Type5373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2? Type5374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? Type5375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2? Type5376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2? Type5377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2? Type5378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2? Type5379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2? Type5380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2? Type5381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? Type5382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2? Type5383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? Type5384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2? Type5385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? Type5386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2? Type5387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? Type5388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2? Type5389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? Type5390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2? Type5391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? Type5392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2? Type5393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? Type5394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2? Type5395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? Type5396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2? Type5397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2? Type5398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? Type5399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2? Type5400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? Type5401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2? Type5402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? Type5403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2? Type5404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? Type5405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2? Type5406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2? Type5407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2? Type5408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? Type5409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2? Type5410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? Type5411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2? Type5412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? Type5413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2? Type5414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? Type5415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2? Type5416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? Type5417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2? Type5418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? Type5419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2? Type5420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? Type5421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2? Type5422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? Type5423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2? Type5424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? Type5425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2? Type5426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? Type5427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2? Type5428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? Type5429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2? Type5430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? Type5431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2? Type5432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? Type5433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2? Type5434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? Type5435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2? Type5436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? Type5437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2? Type5438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? Type5439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2? Type5440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? Type5441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2? Type5442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? Type5443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2? Type5444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? Type5445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2? Type5446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? Type5447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2? Type5448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? Type5449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2? Type5450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? Type5451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2? Type5452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? Type5453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2? Type5454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? Type5455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2? Type5456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? Type5457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2? Type5458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? Type5459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2? Type5460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? Type5461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2? Type5462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? Type5463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2? Type5464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? Type5465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2? Type5466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? Type5467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2? Type5468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? Type5469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2? Type5470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? Type5471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2? Type5472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? Type5473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2? Type5474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? Type5475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2? Type5476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsError? Type5477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? Type5478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? Type5479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminator? Type5480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType? Type5481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventType? Type5482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventError? Type5483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode? Type5484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType? Type5485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsErrorType? Type5486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorPayload? Type5487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEvent? Type5488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEventVariant2? Type5489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEvent? Type5490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? Type5491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEvent? Type5492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminator? Type5493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType? Type5494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEventType? Type5495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? Type5496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type? Type5497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponse? Type5498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties? Type5499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3? Type5500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsParam? Type5501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParam? Type5502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation? Type5503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? Type5504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationParam? Type5505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1? Type5506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>? Type5507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContextManagementParam? Type5508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentParam? Type5509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationPolicyParam? Type5510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationConfigParam? Type5511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationMode? Type5512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? Type5513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEvent? Type5514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminator? Type5515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType? Type5516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateChatCompletionRequest? Type5517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationItemsRequest? Type5518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEvalRequest? Type5519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysCreateRequest? Type5520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsOrder? Type5521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListChatCompletionsOrder? Type5522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetChatCompletionMessagesOrder? Type5523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainersOrder? Type5524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainerFilesOrder? Type5525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListConversationItemsOrder? Type5526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrder? Type5527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrderBy? Type5528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsOrder? Type5529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsStatus? Type5530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? Type5531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? Type5532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesOrder? Type5533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? Type5534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysListOrder? Type5535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsEffectiveAt? Type5536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>? Type5537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationCertificatesOrder? Type5538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>? Type5539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetCertificateIncludeItem? Type5540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsBucketWidth? Type5541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? Type5542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsGroupByItem? Type5543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupsOrder? Type5544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder? Type5545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupUsersOrder? Type5546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess? Type5547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesOrder? Type5548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupsOrder? Type5549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RetrieveProjectGroupGroupType? Type5550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? Type5551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRolesOrder? Type5552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder? Type5553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth? Type5554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? Type5555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem? Type5556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth? Type5557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? Type5558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem? Type5559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth? Type5560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? Type5561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem? Type5562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsBucketWidth? Type5563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? Type5564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsGroupByItem? Type5565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth? Type5566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? Type5567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem? Type5568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth? Type5569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? Type5570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem? Type5571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesBucketWidth? Type5572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSource>? Type5573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSource? Type5574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSize>? Type5575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSize? Type5576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesGroupByItem>? Type5577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesGroupByItem? Type5578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsBucketWidth? Type5579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? Type5580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsGroupByItem? Type5581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresBucketWidth? Type5582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? Type5583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresGroupByItem? Type5584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth? Type5585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? Type5586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel? Type5587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? Type5588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem? Type5589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder? Type5590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupRoleAssignmentsOrder? Type5591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectRolesOrder? Type5592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder? Type5593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListInputItemsOrder? Type5594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesOrder? Type5595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsOrder? Type5596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? Type5597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunIncludeItem? Type5598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsOrder? Type5599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? Type5600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsIncludeItem? Type5601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>? Type5602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetRunStepIncludeItem? Type5603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresOrder? Type5604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? Type5605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? Type5606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesOrder? Type5607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesFilter? Type5608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? Type5609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? Type5610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem? Type5611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? Type5612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem? Type5613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? Type5614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem? Type5615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? Type5616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem? Type5617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? Type5618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem? Type5619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOrder? Type5620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? Type5621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem? Type5622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? Type5623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem? Type5624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>? Type5625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponse? Type5626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponseObject? Type5627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponse? Type5628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponseObject? Type5629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalResponse? Type5630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalRunResponse? Type5631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponse? Type5632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponseObject? Type5633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponse? Type5634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponseObject? Type5635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponse? Type5636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject? Type5637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubagentResource>? Type5638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponse? Type5639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponseObject? Type5640 { get; set; }

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
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialItem>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MCPListToolsTool>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationSpendAlert>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputMessageContent>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectApiKey>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectGroup>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Project>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectRateLimit>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectServiceAccount>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectSpendAlert>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectUser>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Role>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItem>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProbProperties>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionModalitie>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeFunctionTool>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextContent>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ReasoningTextContent>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputItem>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemResource>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerInputItem>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProb>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssignedRoleDetails>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunToolCallObject>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageTimeBucket>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UserProjectsDataItem>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GroupUser>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.User>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VoiceConsentResource>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebSearchActionSearchSource>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TopLogProb>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Annotation>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProb>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem3>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CoordParam>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem2>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LocalSkillParam>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem13>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SearchContentType>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem14>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolSearchOutputTool>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsVariant1Item>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveLocalSkillParam>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem15>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem16>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionChoiceParam>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionScoreLevelParam>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionQuestion>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem4>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.List<string>>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem17>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageResult>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageBucket>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ExternalStorageResponse>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem2>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VideoResource>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemField>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillResource>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillVersionResource>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem5>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Attachment>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem3>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseOutputText>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TaskGroupTask>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadItem>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadResource>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputVariant2Item>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceOptionParam>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreLevelParam>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.QuestionParam>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceProbabilityResource>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreProbabilityResource>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnswerResource>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillResource>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PublicEnvironmentResource>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SetupCommandParam>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillParam>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginParam>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentFileResource>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentContentResource>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageContentResource>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextResource>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentResource>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnItemResource>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TurnResource>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolResource>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentResource>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateSkillResource>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateFileResource>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentTemplateResource>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolResource>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionRequiredActionResource>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionResource>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolConfigParam>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentParam>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageParam>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputTextResource>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionArtifactResource>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionInputParam>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnTraceResource>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultStatusParam>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultResource>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultCredentialResource>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookEndpointBody>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectEventTypeEnum>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item>>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item2>>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item2>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>, string>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTool>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSearchContentType>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem18>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLocalSkillParam>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem3>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaMCPListToolsTool>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item2>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSummaryTextContent>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaReasoningTextContent>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaToolSearchOutputTool>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem19>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContentParam>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem4>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem6>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerAction>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCoordParam>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputMessageContent>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaAnnotation>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLogProb>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTopLogProb>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemResource>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContent>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem7>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemField>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem8>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputItem>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProb>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaIncludeEnum>? ListType369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContextManagementParam>? ListType370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogEventType>? ListType371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetCertificateIncludeItem>? ListType372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCostsGroupByItem>? ListType373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? ListType374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? ListType375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? ListType376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? ListType377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? ListType378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? ListType379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSource>? ListType380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSize>? ListType381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesGroupByItem>? ListType382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? ListType383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? ListType384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? ListType385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? ListType386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateRunIncludeItem>? ListType387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? ListType388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetRunStepIncludeItem>? ListType389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? ListType390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? ListType391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? ListType392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? ListType393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? ListType394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? ListType395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? ListType396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? ListType397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubagentResource>? ListType398 { get; set; }
    }
}