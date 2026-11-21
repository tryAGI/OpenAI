
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
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeyOwner? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeyCreateResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApiKeyList? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AdminApiKey>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssignedRoleDetails? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObject? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectObject? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsCode? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearch? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFunction? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResources? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResourcesCodeInterpreter? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResourcesFileSearch? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantStreamEvent? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEvent? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEvent? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEvent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEvent? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorEvent? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEvent? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantSupportedModels? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsCodeType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchRankingOptions? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFunctionType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionObject? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatText? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonObject? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchema? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOption? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoice? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoiceType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioResponseFormat? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscription? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionModel? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionDelay? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionResponseModel? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLog? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogEventType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProject? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActor? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyCreated? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyCreatedData? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdated? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdatedChangesRequested? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyDeleted? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalKeyRegistered? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalKeyRemoved? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRegistered? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRegisteredData? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRemoved? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupCreated? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupCreatedData? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupUpdated? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupDeleted? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogScimEnabled? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogScimDisabled? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteSent? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteSentData? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteAccepted? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteDeleted? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistCreated? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogLoginFailed? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogLogoutFailed? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogOrganizationUpdated? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogOrganizationUpdatedChangesRequested? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectCreated? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectCreatedData? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectUpdated? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectUpdatedChangesRequested? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectArchived? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectDeleted? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdated? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitDeleted? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleCreated? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUpdated? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUpdatedChangesRequested? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleDeleted? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleBoundToResource? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUnboundFromResource? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreated? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdatedChangesRequested? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderCreated? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderUpdated? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderDeleted? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingCreated? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingUpdated? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingDeleted? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserAdded? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserAddedData? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserUpdated? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserUpdatedChangesRequested? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserDeleted? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateCreated? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateUpdated? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateDeleted? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesActivated? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesDeactivated? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorSession? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorApiKey? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorApiKeyType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorUser? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorServiceAccount? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Batch? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchErrors? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BatchError>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchError? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchStatus? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchRequestCounts? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsage? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsageInputTokensDetails? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsageOutputTokensDetails? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchFileExpirationAfter? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Certificate? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CertificateObject? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CertificateCertificateDetails? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedTools? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionDeleted? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionFunctionCallOption? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionFunctions? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionParameters? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionList? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageList? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItem? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemImageUrl? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemFile? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCall? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallFunction? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminator? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModeration? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input5? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationResults? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationError? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminator? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output6? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminator? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationResultBody>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBody? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminator? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessage? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminator? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParam? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessage? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageFunctionCall? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRole? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamOptionsVariant1? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDelta? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaAudio? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaFunctionCall? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprob? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTool? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParam? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminator? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutput? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutputType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CodeInterpreterFileOutputFile>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutputFile? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTextOutput? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTextOutputType? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTool? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParam? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CallableToolAllowedCaller? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallStatus? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilter? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilterType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompleteUploadRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsage? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilter? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerAction? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParam? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickAction? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParam? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressAction? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParam? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParam? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParam? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParam? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParam? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminator? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminatorType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerAction>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotImage? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCall? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallSafetyCheckParam? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallStatus? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutput? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputStatus? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputStatus? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResource? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResourceObject? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerFileResource>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileResource? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResource? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResourceObject? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerResource>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResource? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfter? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfterAnchor? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceMemoryLimit? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicy? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicyType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Content? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContent? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContent? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItem? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Message? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResource? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCall? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCall? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCall? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCall? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutput? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalTools? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdate? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItem? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Program? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutput? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBody? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCall? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCall? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutput? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCall? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutput? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListTools? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalRequest? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCall? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCall? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutput? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminator? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminatorType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemList? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam2? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResult? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultApiSource? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultObject? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultAmount? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultQuantityUnit? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortEnum? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResources? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesCodeInterpreter? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearch? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequest? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestEndpoint? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestCompletionWindow? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequest? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponseProperties? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsParam? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsShared? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityEnum? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptions? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocation? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSize? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormat? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminator? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2Audio? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationParam? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StopConfiguration? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContent? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletions? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoice? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceLogprobs? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponse? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequest? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequestModel? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponse? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoice? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBody? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem2? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParam? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParam? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminator? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy2? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminator? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerFileBody? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateEmbeddingRequestModel?>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestModel? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestEncodingFormat? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Embedding>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Embedding? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponseUsage? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessage? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItem? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceSamplingParams? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsSource? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItem? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItemSimpleInputMessage? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLabelModelGrader? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLabelModelGraderType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateEvalItem>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfigType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRequest? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig, global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig, global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderStringCheck? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarity? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPython? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModel? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplate? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReference? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParams? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Tool? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParamsText? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfiguration? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalResponsesSource>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSource? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRunRequest? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequest? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequestPurpose? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileExpirationAfter? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningCheckpointPermissionRequest? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequest? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestModel? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparameters? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, int?>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationWandb? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethod? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupBody? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupUserBody? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequest? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Complexity? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestBackground? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestModel? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestSize? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesApiOutputFormat? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgParam? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFidelity? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestQuality? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequest? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Svg? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModel? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestQuality? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestResponseFormat? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestSize? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModeration? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestBackground? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestStyle? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequest? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestSize? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequest? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestRole? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObject? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponseProperties? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequest? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestModel? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponse? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResult? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategories? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryScores? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponse? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseProperties? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsParam? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageOptionsParam? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResponsesEnum? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3Truncation? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Reasoning? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputParam? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.IncludeEnum? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BackgroundOptionsParam? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContextManagementParam? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunRequest? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObject? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestModel? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsShared? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice2? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminator? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBody? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyInterval? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendAlertNotificationChannel? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequest? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequest? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestModel? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesFileSearch? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResources? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequest? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestModel? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionInclude? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.VadConfig>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfig? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegment? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJson? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionLanguage? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEvent? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEvent? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEvent? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionWord>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionWord? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionSegment? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequest? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranslationRequestModel?>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequestModel? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseJson? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequest? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequestPurpose? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileRequest? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreRequest? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreExpirationAfter? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceConsentRequest? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequest? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequestType? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequestModel? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequest? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminator? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallType? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCaller? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputType? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParam? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResource? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputStatusEnum? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResource? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResourceVariant2? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatus? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustom? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteAssistantResponse? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteAssistantResponseObject? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteCertificateResponse? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFileResponse? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteMessageResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteMessageResponseObject? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteModelResponse? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteThreadResponse? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteThreadResponseObject? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreFileResponse? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversation? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResource? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedRoleAssignmentResource? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEventEvent? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEventData? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessageRole? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessageType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParam? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModel? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamQuality? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamSize? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModeration? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamBackground? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<float>, string>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorDetailsResource? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorEventEvent? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Eval? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalObject? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfig? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfig? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderLabelModel? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalApiError? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfigType? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModel? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPython? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPythonVariant2? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModel? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheck? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarity? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarityVariant2? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemRole? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContent? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemType? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentItem? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContent? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentOutputText? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemInputImage? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudio? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentOutputTextType? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemInputImageType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceType? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileIdSourceType? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalList? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalListObject? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Eval>? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfigType? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSourceType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRun? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunObject? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunResultCounts? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerModelUsageItem? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunList? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunListObject? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRun>? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItem? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemObject? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemResult>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemResult? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSample? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleUsage? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemList? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemListObject? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItem>? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsSourceType? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileExpirationAfterAnchor? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FilePath? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FilePathType? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchRanker? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallType? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallStatus? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparameters? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOMethod? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethodType? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedMethod? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementMethod? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMulti? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparameters? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningCheckpointPermission? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegration? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegrationWandb? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJob? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuningJobErrorVariant1, object>? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobErrorVariant1? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparameters? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobStatus? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpoint? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEvent? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventLevel? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventType? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContent? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContent? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminator? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCall? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallStatus? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutput? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputStatus? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResourceVariant2? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModelType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiType? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Graders? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminator? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPythonType? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModelType? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModelSamplingParams? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheckType? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheckOperation? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarityType? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Group? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupObject? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupDeletedResource? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupDeletedResourceObject? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupListResource? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupListResourceObject? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupResponse>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUser? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUserUserType? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResourceWithSuccess? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponseGroupType? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupRoleAssignment? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupRoleAssignmentObject? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Role? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUser? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserAssignment? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserAssignmentObject? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserDeletedResource? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserDeletedResourceObject? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermission? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Image? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditCompletedEventSize?>? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventSize? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventQuality? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventBackground? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsage? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditPartialImageEventSize?>? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventSize? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventQuality? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventBackground? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEvent? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminator? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventSize? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventQuality? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventBackground? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventSize? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventQuality? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventBackground? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEvent? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminator? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenTool? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolType? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModel? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolComplexity? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolQuality? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolSize? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolOutputFormat? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModeration? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolBackground? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolInputImageMask? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenActionEnum? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponse? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseBackground? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImagesResponseSize?>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseSize? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseQuality? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenUsage? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgUsage? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsageInputTokensDetails? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1Format? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminator? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminatorType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItem? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Item? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParam? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParam? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParam? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParam? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminator? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminatorType? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessage? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageRole? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageStatus? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResourceVariant2? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Invite? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRole? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteStatus? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProject? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectRole? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteDeleteResponse? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteListResponse? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite>? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectGroupBody? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequest? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestRole? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteRequestProject>? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProject? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProjectRole? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessage? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParam? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParam? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParam? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParam? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParam? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParam? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponse? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminator? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminatorType? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResource? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminator? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminatorType? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsResponse? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantObject>? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsResponse? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLog>? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListBatchesResponse? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Batch>? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListCertificatesResponse? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationCertificate>? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificate? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesResponse? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OpenAIFile>? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFile? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningCheckpointPermission>? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponse? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint>? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobEventsResponse? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobEvent>? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesResponse? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObject>? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObject? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListModelsResponse? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Model>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Model? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponse? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJob>? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesResponse? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationProjectCertificate>? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificate? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsResponse? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepObject>? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObject? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsResponse? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunObject>? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObject? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesResponse? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileObject>? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObject? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresResponse? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreObject>? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObject? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptRequest? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptSession? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLive? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionAudioParam? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallReferRequest? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallRejectRequest? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEvent? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEvent? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParam? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParam? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCreateParam? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParam? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParam? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParam? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminator? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminatorType? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveConnectParams? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateRequest? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionCreateParams? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransport? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponse? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponseSession? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEvent? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminator? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkPathParams? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkRequest? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionForkParams? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParam? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientConfigParam? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpeechWakePolicyParam? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransport? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunk? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuth? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuthType? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEventDiscriminator? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequest? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminator? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminatorType? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponse? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport2? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminator? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminatorType? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEvent? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParam? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandConnectParams? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandPathParams? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEvent? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRinging? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnswered? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailed? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSent? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStarted? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdated? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResumed? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionPaused? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuted? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppended? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppended? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppended? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreated? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEvent? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreated? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleted? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEvent? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosed? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEvent? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEvent? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallType? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecAction? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallStatus? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputType? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputStatus? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProbProperties? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsTool? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPTool? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolConnectorId? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolFilter? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallError? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallStatus? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolError? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionError? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPError? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminator? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectType? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectType? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObject? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObjectType? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObject? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectType? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectText? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObject? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectType? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectText? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObject? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectObject? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDelta? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectObject? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectStatus? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetails? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectRole? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObjectType? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1Event? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2Event? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3Event? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4Event? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5Event? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIds? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponses? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsCompaction? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLiveEnum? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponsesEnum? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsSharedEnum? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequest? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResources? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyCertificateRequest? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyMessageRequest? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyRunRequest? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequest? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResources? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesCodeInterpreter? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesFileSearch? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NoiseReductionType? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFilePurpose? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileStatus? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponse? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponse? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetention? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionType? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponse? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlert? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertCurrency? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertInterval? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResource? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResource? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert>? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudio? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContent? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContent? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContent? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminator? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminatorType? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItem? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminator? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminatorType? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContent? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageStatus? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminator? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PermissionErrorResponse? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContentType? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Project? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicProjectResidency? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKey? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwner? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerType? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerUser? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerServiceAccount? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponse? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectApiKey>? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectCreateRequest? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetention? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroup? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupGroupType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResource? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResource? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup>? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissions? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponse? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Project>? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissions? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsMode? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponse? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimit? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponse? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectRateLimit>? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccount? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountRole? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKey? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponse? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponse? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectServiceAccount>? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlert? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertCurrency? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertInterval? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResource? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectSpendAlert>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUpdateRequest? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUser? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserCreateRequest? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponse? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserListResponse? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectUser>? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserUpdateRequest? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptVariant1? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateOrganizationRoleBody? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResource? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResourceObject? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreate? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItem? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDelete? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieve? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncate? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppend? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClear? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommit? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClear? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancel? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreate? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParams? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdate? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequest? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdate? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponse? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatus? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetails? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsage? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetails? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageOutputTokenDetails? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseModalitie? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, string>? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceOptions? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunction? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCP? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreated? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeleted? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailed? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedError? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrieved? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncated? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventError? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCleared? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommitted? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStarted? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStopped? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompleted? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailed? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgress? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdated? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDelta? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDone? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDelta? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDone? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAdded? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPart? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPartType? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDone? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePart? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePartType? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreated? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDone? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDelta? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDone? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDelta? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDone? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompleted? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailed? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgress? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAdded? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDone? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDelta? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDone? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreated? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSession? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdated? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreated? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdated? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallCreateRequest? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallReferRequest? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallRejectRequest? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEvent? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminator? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParams? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdate? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConnectDocumentationParams? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConnectDocumentationParamsIntent? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConnectParams? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUser? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponse? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListTools? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCall? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequest? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminator? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReference? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItemType? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session5? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionTool? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPError? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolError? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoning? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoningEffort? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponse? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatus? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetails? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsError? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudio? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudioOutput? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsage? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetails? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageOutputTokenDetails? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseOutputModalitie? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseInputItem>? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputItem? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputAudio? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputAudioType? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallType? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallStatus? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutputType? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutputStatus? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputImage? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputImageType? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputImageDetail? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessage? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseItemReference? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputItemDiscriminator? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputItemDiscriminatorType? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageType? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageSystem? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDeveloper? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUser? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistant? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDiscriminator? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDiscriminatorRole? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2Role? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2ContentItem>? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2ContentItem? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2ContentItemType? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDeveloperVariant2? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDeveloperVariant2Role? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseInputText>? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputText? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsType? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsStatus? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageSystemVariant2? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageSystemVariant2Role? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2Role? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7>? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem7? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputTextType? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEvent? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventError? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDone? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminator? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorError? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPart? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePart? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdated? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionObject? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModalitie? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModel? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfiguration>? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfiguration? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracing>? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracing? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncation? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracing>? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracing? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponse? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracing>? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracing? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfiguration>? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfiguration? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEvent? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequest? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSession? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationConnectParams? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEvent? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminator? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudio? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInput? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioOutput? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputTranscription? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputNoiseReduction? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudio? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInput? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputTranscription? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputNoiseReduction? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioOutput? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum2? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnum? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummary? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningContext? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningGenerateSummary? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemType? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContent? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemStatus? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Response? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResolvedImageOptions? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Truncation? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Status? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsBody? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorVariant1? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningInputTransformation>? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningInputTransformation? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsage? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseToolUsage? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptions? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnostics? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Moderation? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConversation? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingEvent? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEvent? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateText? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format4? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchema? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateTextFormatDiscriminator? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateTextFormatDiscriminatorType? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamText? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format6? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamTextFormatDiscriminator? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEvent? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorCode? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEvent? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEvent? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammar? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPython? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEvent? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemList? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemResource>? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProb? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProbTopLogprob? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseModalitiesVariant1Item? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Annotation? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextParam? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceParam? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEvent? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCode? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEvent? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInput? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventSteer? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventError? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItem? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParam? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminator? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventSteer? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReason? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInput? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEvent? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminator? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageInputTokensDetails? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CacheWriteTokensDetails? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsError? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorPayload? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEvent? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminator? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEvent? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminator? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEvent? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEventVariant2? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleObject? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResource? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResourceObject? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResource? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResourceObject? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetails>? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunCompletionUsageVariant1? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderRequest? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponse? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadata? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataErrors? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataTokenUsage? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectObject? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectStatus? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredAction? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionType? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObject? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastError? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastErrorCode? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetails? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepCompletionUsageVariant1? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObject? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectObject? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectDelta? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectObject? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectType? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectStatus? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastError? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastErrorCode? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1Event? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2Event? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3Event? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4Event? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5Event? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6Event? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7Event? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1Event? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2Event? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3Event? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4Event? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5Event? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6Event? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7Event? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8Event? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9Event? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10Event? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectType? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectFunction? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventUsage? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategy? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequest? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfigurationDiscriminator? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfigurationDiscriminatorType? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObject? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectObject? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResources? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1Event? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToggleCertificatesRequest? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionTool? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchTool? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerTool? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewTool? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchTool? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParam? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParam? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParam? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParam? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParam? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParam? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewTool? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParam? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminator? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminatorType? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowed? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedType? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedMode? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustom? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustomType? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunctionType? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCPType? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypes? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParam? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParam? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypesType? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputTool? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParam? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminator? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventType? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventType? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEventType? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDurationType? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensType? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategy? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObjectType? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateGroupBody? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBody? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBodyRetentionType? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBody? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBodyRetentionType? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBody? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreRequest? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVoiceConsentRequest? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Upload? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadStatus? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadCertificateRequest? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPart? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResultObject? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResult? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultApiSource? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultObject? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResultObject? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResultObject? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResult? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResultObject? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResult? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResultObject? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponse? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponseObject? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucket? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketObject? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem>? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResult? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminator? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResultObject? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultObject? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.User? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserObject? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1Object? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjects? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsObject? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UserProjectsDataItem>? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsDataItem? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponse? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponseObject? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResource? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResourceObject? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser>? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponse? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponseObject? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.User>? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignment? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignmentObject? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleUpdateRequest? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfigType? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderRequest? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderResponse? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?>? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObject? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectFileCounts? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponse? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectStatus? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastError? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectFileCounts? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectStatus? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequest? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObject? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultItem? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPage? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResource? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResourceObject? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResource? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResourceObject? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VoiceConsentResource>? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResource? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResourceObject? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceDeletedResource? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceDeletedResourceObject? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsSharedEnum? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResource? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceObject? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceType? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFind? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearch? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSource? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolType? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolFilters? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolSearchContextSize? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallStatus? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallAction? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpired? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentEvent? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailed? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReady? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspended? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequired? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreated? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailed? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdle? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgress? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelled? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledData? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompleted? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedData? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpired? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredData? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailed? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedData? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceled? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledData? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailed? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedData? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceeded? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededData? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelled? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailed? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedData? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceeded? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncoming? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingData? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportConnected? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportConnectedData? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportConnectedDataType? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncoming? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingData? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncoming? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingData? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelled? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledData? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompleted? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedData? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailed? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedData? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncomplete? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteData? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreated? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedData? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssued? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedData? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreated? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedData? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssued? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedData? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorType? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentSteer? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputType? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBodyType? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTTLEnum? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheModeEnum? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamMode? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamTtl? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationMode? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationConfigParam? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationPolicyParam? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParamType? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParam? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamType? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamMediaType? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParamType? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStatus? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRole? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfig? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigTtl? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentType? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBody? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBodyType? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBody? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBodyType? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBody? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBodyType? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminator? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminatorType? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TopLogProb? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProb? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContentType? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContent? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContentType? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContentType? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContentType? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContentType? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetail? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentType? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContent? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContentType? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileInputDetail? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentType? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase2? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageType? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem9>? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem9? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminator? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminatorType? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCaller? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerType? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCaller? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerType? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminator? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParam? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParamType? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParamType? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminator? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallModerationDetails? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallError? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageBackground? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageOutputFormat? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallType? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallStatus? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallQuality? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickButtonType? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParamType? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickActionType? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CoordParam? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParamType? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressActionType? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParamType? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParamType? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParamType? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParamType? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParamType? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallType? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolType? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankerVersionType? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HybridSearchOptions? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankingOptions? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Filters? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolType? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolType? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerEnvironment? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewToolType? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerMemoryLimit? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy4? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParamType? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgReasoningParam? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParamType? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParam? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamType? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalSkillParam? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParam? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParamType? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParam? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParamType? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamType? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant13? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParam? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParamType? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GrammarSyntax1? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParam? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParamType? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamType? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmptyModelParam? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParam? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParamType? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamType? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem4>? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem4? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParamType? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocation? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocationType? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContextSize? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContentType? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewToolType? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParamType? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputType? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsType? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramType? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputStatus? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputType? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBodyType? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogsType? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImageType? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecActionType? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellAction? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallStatus? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResource? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResourceType? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResource? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResourceType? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallType? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant1? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContent? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputType? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatus? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallType? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatus? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputType? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolErrorType? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionErrorType? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPErrorType? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DetailEnum? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemStatus? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParamType? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParam? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParamType? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParam? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParamType? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileDetailEnum? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParam? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParamType? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamType? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParam? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParamType? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParam? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParamType? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParam? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParamType? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParamType? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParam? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem15? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminator? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParamType? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolSearchOutputTool>? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamType? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamRole? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParamType? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellActionParam? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemStatus? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamType? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant15? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentParam? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatusParam? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParam? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParamType? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParamType? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParamType? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemStatus? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParamType? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResource? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResourceObject? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenOutputTokensDetails? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenInputUsageDetails? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgReasoning? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomVoiceParam? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParam? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParamType? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesServiceTier? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningEffort? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningSummary? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationReasoningInputParam? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTextVerbosity? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationTextInputParam? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParamType? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParamType? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParamType? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerMemoryLimit? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParam? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParamType? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParam? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamType? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParam? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParamType? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyVariant1? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1Discriminator? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsVariant1Item>? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsVariant1Item? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminator? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParam? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParamType? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalSkillParam? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParam? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParamType? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveLocalSkillParam>? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamType? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant16? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1Discriminator? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolFilterParam? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPRequireApprovalFilterParam? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPRequireApprovalApiEnum? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallableToolAllowedCaller? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParam? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParamType? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.LiveMCPToolFilterParam>? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveMCPRequireApprovalFilterParam, global::tryAGI.OpenAI.LiveMCPRequireApprovalApiEnum?>? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveCallableToolAllowedCaller>? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParam? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParamType? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParam? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParamType? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParam? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParamType? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParam? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParamType? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceEnum? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParamType? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParam? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParamType? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParam? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParamType? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParam? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParamType? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParam? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParamType? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParam? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParamType? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceValueEnum? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem11>? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem11? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminator? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem17>? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem17? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminator? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant2?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant2? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2Discriminator? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParamType? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputTextParam? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputTextParamType? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDetailEnum? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputImageParam? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputImageParamType? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionJsonObject? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParam? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParamType? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionJsonObject, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionJsonObject>>? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionJsonObject>? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceParam? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, bool?>? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item2>>? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item2>? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InstructionsVariant2Item2? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminator? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionChoiceParam>? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item3>>? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item3>? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InstructionsVariant2Item3? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminator? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreLevelParam? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item>>? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item>? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InstructionsVariant2Item? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminator? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionScoreLevelParam>? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestion? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminator? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminatorType? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionQuestion>? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParamType? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1Discriminator? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParam? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParamEventType? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialMessageStatus? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParamType? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem8>? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem8? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminator? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItem? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminator? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedServerEventParam? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParam? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpeechWakePolicyParamType? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem18>? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem18? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant22?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant22? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2Discriminator? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMCategoryFlags? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMCategoryScores? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMCategoryAppliedInputTypes? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMModerationResult? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCSAMModerationResponse? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CSAMModerationResult>? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponse? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponseType? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminator? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminatorType? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectApiKeyBody? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParamType? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParamType? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CyberAccessProgramEnum? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageContextCompression? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsePromptCacheOptionsParamTtl? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BackgroundCompletionWindowEnum? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResolvedImageContextCompressionEnum? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputRemovalReason? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningInputTransformationType? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningInputTransformationAction? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CachedUsageDetails? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolUsage? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchUsage? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsTtl? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CacheMissReasonTypeEnum? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBody? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBodyType? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminator? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminatorType? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminator? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminatorType? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ShellCallOutputDelta? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationBody? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateConversationBody? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResourceObject? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNoticeType? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNotice? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResource? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResourceObject? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertErrorType? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResource? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResourceObject? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrderEnum? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalKeyPurpose? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalKeyResource? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListExternalKeysResource? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListExternalKeysResourceObject? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalKeyResource>? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalKeyParams? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalKeyParamsType? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalKeyParams? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalKeyParamsType? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalKeyParams? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalKeyParamsType? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalKeyParams? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalKeyParamsType? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequest? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequestDiscriminator? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequestDiscriminatorType? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateExternalKeyResource? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerification? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerificationType? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerification? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerificationType? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transformation? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProvider? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderObject? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderType? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerification, global::tryAGI.OpenAI.UploadedJwksVerification>? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Transformation>? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderListResource? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderListResourceObject? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PlatformProvider>? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerificationParam? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerificationParamType? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerificationParam? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerificationParamType? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TransformationParam? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBody? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TransformationParam>? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdatePlatformWorkloadIdentityProviderBody? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderDeletedResource? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderDeletedResourceObject? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissions? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissionsType? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissions? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissionsType? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRule? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleObject? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, bool?, global::tryAGI.OpenAI.AnyOf<int?, double?>?>? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<int?, double?>? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissions, global::tryAGI.OpenAI.RestrictedPermissions>? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleListResource? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleListResourceObject? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PlatformFederationRule>? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissionsParam? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissionsParamType? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissionsParam? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissionsParamType? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityFederationRuleBody? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissionsParam, global::tryAGI.OpenAI.RestrictedPermissionsParam>? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdatePlatformWorkloadIdentityFederationRuleBody? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleDeletedResource? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleDeletedResourceObject? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketWidth? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageGroupBy? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageApiSource? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResult? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResultObject? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucket? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketObject? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageResult>? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResource? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageBucket>? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorDetails? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorResponse? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsagePermissionErrorResponse? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageOrder? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageStatus? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponse? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseObject? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResource? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResourceObject? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalStorageResponse>? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParams? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParamsType? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBody? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider2? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResource? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResourceObject? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrency? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitInterval? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatus? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcement? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmailNotificationChannel? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmailNotificationChannelType? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResource? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParams? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBody? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyCurrency? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyInterval? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResource? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResource? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResourceObject? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBody? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResource? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDefaultServiceTier? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectOptionalServiceTier? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceTierSettingsResource? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceObject? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBody? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBodyEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBodyEnabledTiers? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateProjectServiceAccountApiKeyBody? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBody? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContentProvenanceBody? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceCheckObject? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceDetectionResultApi? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAValidationStateApi? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResult? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResultType? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResult? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResultType? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResource? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2>? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem2? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminator? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModel? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModelEnum? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoStatus? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSize? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error2? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResource? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResourceObject? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResource? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResourceObject? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam2? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSeconds? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoMultipartBody? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoJsonBody? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoCharacterBody? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoCharacterResource? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoReferenceInputParam? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditMultipartBody? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditJsonBody? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendMultipartBody? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendJsonBody? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResource? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResourceObject? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoContentVariant? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoRemixBody? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationEnum? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnum? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnumEnum? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsBody? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResource? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResourceObject? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheRetentionEnum? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResponseMethodPublicBody? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemField? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminator? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminatorType? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResource? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResourceObject? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField>? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResource? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResourceObject? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResource? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResourceObject? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillResource>? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillBody? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetDefaultSkillVersionBody? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResource? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResourceObject? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResource? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResourceObject? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResource? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResourceObject? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillVersionResource>? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillVersionBody? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResource? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResourceObject? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflowTracing? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflow? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, int?, bool?, double?>? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionRateLimits? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionStatus? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionFileUpload? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionHistory? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionChatkitConfiguration? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResource? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResourceObject? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowTracingParam? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowParam? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, int?, bool?, double?>? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParam? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParamAnchor? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RateLimitsParam? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomaticThreadTitlingParam? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileUploadParam? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HistoryParam? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitConfigurationParam? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatSessionBody? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputText? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputTextType? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedText? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedTextType? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AttachmentType? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Attachment? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoice? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InferenceOptions? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItem? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemObject? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemType? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem3? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminator? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment>? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSource? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSourceType? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotation? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationType? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSource? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSourceType? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotation? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationType? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputText? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextType? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem>? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminator? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItem? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemObject? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemType? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText>? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItem? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemObject? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemType? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallStatus? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItem? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemObject? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemType? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskType? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItem? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemObject? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemType? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupTask? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItem? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemObject? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemType? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask>? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItem? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminator? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminatorType? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResource? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResourceObject? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadItem>? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatus? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatusType? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatus? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatusType? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatus? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatusType? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResource? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceObject? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Status? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminator? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResource? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResourceObject? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResource? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResourceObject? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource>? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputText? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextType? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpoint? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetailParam? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImage? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpoint? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImageType? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputJson? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputJsonType? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<object, global::System.Collections.Generic.IList<object>>? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartsItem? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminator? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContent? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputUserMessage? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputUserMessageRole? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputUserMessageType? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperContent? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessage? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessageRole? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessageType? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputSystemMessage? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputSystemMessageRole? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputSystemMessageType? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputOutputText? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputOutputTextType? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputRefusal? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputRefusalType? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContentPartDiscriminator? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContentPartDiscriminatorType? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContent? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseParam? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantMessage? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantMessageRole? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantMessageType? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessage? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageDiscriminator? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusParam? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCall? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallType? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminator? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContent? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCall? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallType? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInput? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2Item? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminator? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputText? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputTextType? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputImage? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputImageType? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputPart? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputPartDiscriminator? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputPartDiscriminatorType? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicate? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicateType? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionQuestionInputPart>>? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionQuestionInputPart>? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueParam? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceOptionParam? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoice? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoiceType? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceOptionParam>? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreLevelParam? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScore? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScoreType? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreLevelParam>? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParam? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminator? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminatorType? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequest? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicate? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicateType? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueResource? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceProbabilityResource? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoice? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoiceType? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceProbabilityResource>? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreProbabilityResource? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScore? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScoreType? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreProbabilityResource>? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusal? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusalType? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResource? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminator? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminatorType? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageResource? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionResponse? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnswerResource>? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrderParam? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortResource? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryResource? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningResource? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceText? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceTextType? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResource? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminator? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityResource? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResource? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResource? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunction? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunctionType? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttp? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttpType? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdio? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdioType? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResource? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminator? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginResource? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcp? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcpType? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeResource? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeResource? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationResource? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearchType? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUseType? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceAutomations? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceAutomationsType? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResource? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminator? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigResource? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionResource? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExperimentalConfigResource? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationAgentConfigResource? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource>? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNoneType? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeResource? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesResource? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessResource? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyResource? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopResource? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResource? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminator? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInline? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInlineType? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResource? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminator? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResource? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminator? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHostedType? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHostedType? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResource? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminator? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminatorType? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputText? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputTextType? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImage? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImageType? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResource? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminator? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminatorType? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource2? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource2Type? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource2Role? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSession? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSessionType? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageResource2>? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSessionType? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResource? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceDiscriminator? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceDiscriminatorType? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloperType? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgentType? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResource? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDiscriminator? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDiscriminatorType? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PeriodicAutomationStatusResource? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodic? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodicType? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodicObject? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodicPauseReason? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OnceAutomationStatusResource? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOnce? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOnceType? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOnceObject? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOncePauseReason? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResource? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceDiscriminator? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceDiscriminatorType? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorBodyResource? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse2? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExperimentalConfigOverridesParam? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortParam? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryParam? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningParam? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamText? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamTextType? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchemaType? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParam? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminator? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminatorType? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityParam? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextParam? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierParam? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionParam? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunctionType? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttpType? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdioType? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParam? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminator? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginParam? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcpType? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeParam? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeParam? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationParam? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUse? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamAutomations? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamAutomationsType? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParam? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminator? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentConfigParam? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolConfigParam>? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNone? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNoneType? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesParam? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetupCommandParam? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessParam? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyParam? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopParam? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParam? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminator? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInline? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInlineType? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParam? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminator? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInline? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInlineType? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParam? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminator? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParam? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeParam? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHostedType? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParam? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminator? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputText? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputTextType? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImage? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImageType? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParam? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminator? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminatorType? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParam? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamType? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamRole? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamNewSession? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamNewSessionType? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSession? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSessionType? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParam? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamDiscriminator? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamDiscriminatorType? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodicType? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsOnce? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsOnceType? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParams? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsDiscriminator? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsDiscriminatorType? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAutomationParams? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAutomationResource? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAutomationResourceObject? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManualType? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomationType? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResource? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceDiscriminator? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceDiscriminatorType? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationStatusResource? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationErrorResource? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationResource? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationResourceObject? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationResourceSkipReason? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeParam? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeResource? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentStatusResource? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResource? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInline? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInlineType? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResource? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminator? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResource? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResourceObject? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResource? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResourceObject? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PublicEnvironmentResource>? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHostedType? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParam? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminator? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminatorType? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentEnvironmentParams? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFilePageObjectResource? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResource? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResourceObject? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileListResource? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource>? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentObjectResource? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResource? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResourceType? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResource? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResourceType? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResource? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminator? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentStatusResource? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentResource? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionMessageRoleResource? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputText? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputTextType? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImage? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImageType? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputText? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputTextType? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResource? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminator? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemStatusResource? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseResource? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResource? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResourceType? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource>? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResource? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResourceType? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResource? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResourceType? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource>? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusResource? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResource? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResourceType? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputResource? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResourceType? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResource? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResourceType? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResource? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResourceType? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResource? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResourceType? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResource? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResourceType? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldResource? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationOptionResource? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResource? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminator? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminator? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResource? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearchType? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOther? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOtherType? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResource? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminator? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResource? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResourceType? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResource? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResourceType? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResourceType? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResourceType? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResource? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminator? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResource? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResourceObject? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnItemResource>? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTtlResource? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsResource? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnObjectResource? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnStatusResource? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorCodeResource? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorResource? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource2? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource2? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenUsageResource? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnResource? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResource? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResourceObject? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TurnResource>? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResource? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminator? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUse? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceAutomations? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceAutomationsType? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResource? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminator? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResource? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResourceObject? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolResource>? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResource? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResourceObject? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentResource>? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExperimentalConfigParam? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParam? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUse? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomations? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomationsType? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParam? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentParams? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentParams? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResource? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResourceObject? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResource? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResourceObject? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResource? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentTemplateResource>? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentTemplateParams? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResource? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionReviewResource? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionBudgetControlResource? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionStatusResource? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCallType? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResource? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminator? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminatorType? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequest? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequestType? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequest? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResource? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminator? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentResource? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNone? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNoneType? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResource? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminator? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResource? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResourceObject? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource>? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResource? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResourceObject? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource>? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionReviewParam? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionBudgetControlParams? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionInputParam? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTtlParam? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsParam2? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionStreamOptionsParam? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentSessionParams? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionErrorResource? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventError? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventErrorType? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStatusResource? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentErrorResource? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStateResource? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspended? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspendedType? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpired? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpiredType? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdleType? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReached? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReachedType? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailedType? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResource? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceType? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceRole? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource>? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResource? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEvent? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminator? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminatorType? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionReasoningParam? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionAgentParam? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentSessionParams? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResource? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResourceObject? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResource? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResourceObject? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResource? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResourceObject? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionArtifactResource>? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResource? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalDecisionParam? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCallType? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParam? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamDiscriminator? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamDiscriminatorType? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResult? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResultType? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParam? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResult? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? Type4091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType? Type4092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? Type4093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType? Type4094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputParam? Type4095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? Type4096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType? Type4097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParam? Type4098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminator? Type4099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminatorType? Type4100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionEventsParams? Type4101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>? Type4102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResource? Type4103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResourceObject? Type4104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResource? Type4105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResourceObject? Type4106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnTraceResource>? Type4107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusParam? Type4108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusFilterParam? Type4109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? Type4110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResource? Type4111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResourceObject? Type4112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResource? Type4113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResourceObject? Type4114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultResource>? Type4115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultParams? Type4116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVaultParams? Type4117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResource? Type4118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResourceObject? Type4119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? Type4120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType? Type4121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? Type4122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType? Type4123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? Type4124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType? Type4125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource? Type4126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator? Type4127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType? Type4128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthRefreshResource? Type4129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? Type4130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType? Type4131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? Type4132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType? Type4133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? Type4134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType? Type4135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? Type4136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType? Type4137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResource? Type4138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator? Type4139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType? Type4140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? Type4141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType? Type4142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResource? Type4143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator? Type4144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType? Type4145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResource? Type4146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResourceObject? Type4147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResource? Type4148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResourceObject? Type4149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultCredentialResource>? Type4150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? Type4151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType? Type4152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam? Type4157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator? Type4158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthRefreshParam? Type4160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? Type4161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType? Type4162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? Type4163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType? Type4164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? Type4165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType? Type4166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? Type4167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType? Type4168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParam? Type4169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator? Type4170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType? Type4171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? Type4172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType? Type4173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParam? Type4174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator? Type4175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType? Type4176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialParams? Type4177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam? Type4182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator? Type4183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthRefreshParam? Type4185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? Type4186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType? Type4187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? Type4188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType? Type4189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? Type4190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType? Type4191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParam? Type4192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator? Type4193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType? Type4194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialParams? Type4195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResource? Type4196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject? Type4197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBody? Type4198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResource? Type4199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookEndpointBody>? Type4200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectEventTypeEnum? Type4201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateEndpointBody? Type4202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? Type4203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResource? Type4204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateEndpointBody? Type4205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResource? Type4206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRotateSecretBody? Type4207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicTestEndpointBody? Type4208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResource? Type4209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResource? Type4210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource? Type4211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource? Type4212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionConnectPayloadResource? Type4213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragPoint? Type4214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? Type4215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType? Type4216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? Type4217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType? Type4218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? Type4219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType? Type4220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormat? Type4221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminator? Type4222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminatorType? Type4223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioParam? Type4224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParams? Type4225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant12? Type4226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1Discriminator? Type4227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1DiscriminatorType? Type4228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEventType? Type4229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsSettingsUpdateParam? Type4230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParam? Type4231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType? Type4232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParams? Type4233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant13? Type4234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1Discriminator? Type4235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? Type4236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamType? Type4237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEventType? Type4238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParamType? Type4239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType? Type4240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType? Type4241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParamType? Type4242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParamType? Type4243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParamType? Type4244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCreateParamType? Type4245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? Type4246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParamType? Type4247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? Type4248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParamType? Type4249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParam? Type4250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamType? Type4251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamRole? Type4252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>>? Type4253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>? Type4254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item? Type4255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamContentVariant2ItemDiscriminator? Type4256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType? Type4257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionDeveloperMessageParam? Type4258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionDeveloperMessageParamType? Type4259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionDeveloperMessageParamRole? Type4260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>>? Type4261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>? Type4262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParam? Type4263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParamType? Type4264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParamRole? Type4265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParam? Type4266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParamType? Type4267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionRefusalParam? Type4268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionRefusalParamType? Type4269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMessagePhase? Type4270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParam? Type4271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamType? Type4272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamRole? Type4273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>>? Type4274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>? Type4275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item2? Type4276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminator? Type4277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType? Type4278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionCallItemStatus? Type4279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? Type4280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallParamType? Type4281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? Type4282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParamType? Type4283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item3>>? Type4284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item3>? Type4285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item3? Type4286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminator? Type4287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? Type4288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? Type4289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallParamType? Type4290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? Type4291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParamType? Type4292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item4>>? Type4293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item4>? Type4294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item4? Type4295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParamOutputVariant2ItemDiscriminator? Type4296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType? Type4297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParam? Type4298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? Type4299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1Type? Type4300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamDiscriminator? Type4301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamDiscriminatorType? Type4302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParamType? Type4303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType? Type4304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParamType? Type4305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParamType? Type4306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParamType? Type4307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkAudioParam? Type4308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionConfigParam? Type4309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEventType? Type4310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParam? Type4311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant14? Type4312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1Discriminator? Type4313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1DiscriminatorType? Type4314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamStatus? Type4315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartedType? Type4316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdatedType? Type4317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResumedType? Type4318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionPausedType? Type4319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMutedType? Type4320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmutedType? Type4321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType? Type4322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType? Type4323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendedType? Type4324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendedType? Type4325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendedType? Type4326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppend? Type4327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendType? Type4328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDelta? Type4329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDeltaType? Type4330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDeltaType? Type4331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType? Type4332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItem? Type4333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemType? Type4334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant3?>? Type4335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1? Type4336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2? Type4337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant3? Type4338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreatedType? Type4339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCompleted? Type4340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCompletedType? Type4341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventType? Type4342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1?, global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2?>? Type4343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1? Type4344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2? Type4345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParam? Type4346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamType? Type4347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamRole? Type4348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item3>>? Type4349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item3>? Type4350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item3? Type4351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminator? Type4352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType? Type4353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParam? Type4354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamType? Type4355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamRole? Type4356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredSystemMessageParam? Type4357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredSystemMessageParamType? Type4358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredSystemMessageParamRole? Type4359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParam? Type4360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamType? Type4361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamRole? Type4362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item4>>? Type4363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item4>? Type4364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item4? Type4365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminator? Type4366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType? Type4367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? Type4368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParamType? Type4369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? Type4370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamType? Type4371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item5>>? Type4372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item5>? Type4373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item5? Type4374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminator? Type4375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? Type4376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? Type4377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParamType? Type4378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? Type4379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParamType? Type4380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item6>>? Type4381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item6>? Type4382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item6? Type4383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminator? Type4384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType? Type4385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam? Type4386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? Type4387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1Type? Type4388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminator? Type4389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType? Type4390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreatedType? Type4391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeletedType? Type4392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEventType? Type4393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsage? Type4394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContextWindowUsage? Type4395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdatedType? Type4396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedType? Type4397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1? Type4398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2? Type4399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3? Type4400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4? Type4401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5? Type4402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLiveError? Type4403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEventType? Type4404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEventType? Type4405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceivedType? Type4406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSentType? Type4407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRingingType? Type4408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnsweredType? Type4409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallError? Type4410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallErrorType? Type4411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailedType? Type4412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2Discriminator? Type4413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType? Type4414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParamType? Type4415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamType? Type4416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamRole? Type4417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>? Type4418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>? Type4419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item? Type4420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminator? Type4421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType? Type4422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResource? Type4423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResourceObject? Type4424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsBody? Type4425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? Type4426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>? Type4427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItem? Type4428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? Type4429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTool? Type4430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextParam? Type4431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoning? Type4432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTruncationEnum? Type4433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnum? Type4434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam? Type4435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceParam? Type4436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceOptions? Type4437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed? Type4438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypes? Type4439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunction? Type4440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCP? Type4441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustom? Type4442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? Type4443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? Type4444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? Type4445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType? Type4446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType? Type4447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType? Type4448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustomType? Type4449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCPType? Type4450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunctionType? Type4451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypesType? Type4452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedType? Type4453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedMode? Type4454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam2? Type4455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum? Type4456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnum? Type4457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningEffortEnum? Type4458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningSummary? Type4459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningContext? Type4460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningGenerateSummary? Type4461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? Type4462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration? Type4463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaVerbosityEnum? Type4464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatText? Type4465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? Type4466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject? Type4467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminator? Type4468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminatorType? Type4469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType? Type4470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema? Type4471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionTool? Type4472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchTool? Type4473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerTool? Type4474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool? Type4475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchTool? Type4476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPTool? Type4477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool? Type4478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? Type4479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenTool? Type4480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParam? Type4481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam? Type4482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParam? Type4483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParam? Type4484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParam? Type4485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool? Type4486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam? Type4487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminator? Type4488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminatorType? Type4489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParamType? Type4490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? Type4491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCallableToolAllowedCaller? Type4492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewToolType? Type4493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocation? Type4494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContextSize? Type4495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>? Type4496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContentType? Type4497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocationType? Type4498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParamType? Type4499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Type4500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEmptyModelParam? Type4501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamType? Type4502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem6>? Type4503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem6? Type4504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParam? Type4505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator? Type4506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType? Type4507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamType? Type4508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format2? Type4509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam? Type4510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? Type4511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator? Type4512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType? Type4513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType? Type4514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGrammarSyntax1? Type4515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParamType? Type4516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParamType? Type4517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamType? Type4518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant14? Type4519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParam? Type4520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam? Type4521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParam? Type4522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator? Type4523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type4524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParamType? Type4525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParamType? Type4526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>? Type4527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalSkillParam? Type4528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamType? Type4529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerMemoryLimit? Type4530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy3? Type4531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? Type4532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? Type4533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator? Type4534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType? Type4535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>? Type4536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem3? Type4537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParam? Type4538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParam? Type4539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator? Type4540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType? Type4541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParamType? Type4542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParam? Type4543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamType? Type4544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType? Type4545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParamType? Type4546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType? Type4547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? Type4548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam? Type4549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType? Type4550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParamType? Type4551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolType? Type4552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>? Type4553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModel? Type4554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolComplexity? Type4555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolQuality? Type4556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>? Type4557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolSize? Type4558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolOutputFormat? Type4559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSvgParam? Type4560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModeration? Type4561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolBackground? Type4562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFidelity? Type4563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolInputImageMask? Type4564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenActionEnum? Type4565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSvgReasoningParam? Type4566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType? Type4567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolType? Type4568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>? Type4569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam? Type4570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType? Type4571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy5? Type4572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type4573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type4574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolConnectorId? Type4575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? Type4576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolFilter? Type4577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>? Type4578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum? Type4579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2? Type4580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolType? Type4581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolFilters? Type4582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation? Type4583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize? Type4584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewToolType? Type4585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerEnvironment? Type4586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolType? Type4587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolType? Type4588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankingOptions? Type4589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilters? Type4590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilter? Type4591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilter? Type4592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterType? Type4593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>? Type4594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem2? Type4595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator? Type4596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilterType? Type4597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankerVersionType? Type4598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHybridSearchOptions? Type4599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolType? Type4600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessage? Type4601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItem? Type4602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParam? Type4603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParam? Type4604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParam? Type4605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParam? Type4606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminator? Type4607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminatorType? Type4608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTagParam? Type4609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParamType? Type4610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemStatus? Type4611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParamType? Type4612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParamType? Type4613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType? Type4614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessage? Type4615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessage? Type4616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCall? Type4617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCall? Type4618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? Type4619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCall? Type4620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCall? Type4621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? Type4622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam? Type4623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? Type4624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? Type4625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam? Type4626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? Type4627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? Type4628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParam? Type4629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItem? Type4630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? Type4631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCall? Type4632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? Type4633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCall? Type4634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? Type4635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? Type4636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? Type4637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? Type4638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? Type4639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListTools? Type4640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest? Type4641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse? Type4642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCall? Type4643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? Type4644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCall? Type4645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminator? Type4646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminatorType? Type4647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTag? Type4648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallType? Type4649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCaller? Type4650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller? Type4651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller? Type4652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminator? Type4653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType? Type4654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerType? Type4655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerType? Type4656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputType? Type4657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParam? Type4658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? Type4659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? Type4660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput? Type4661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContent? Type4662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContent? Type4663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContent? Type4664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminator? Type4665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType? Type4666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentType? Type4667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? Type4668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileInputDetail? Type4669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode? Type4670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigTtl? Type4671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentType? Type4672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageDetail? Type4673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentType? Type4674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? Type4675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? Type4676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminator? Type4677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType? Type4678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType? Type4679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType? Type4680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallError? Type4681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallStatus? Type4682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolError? Type4683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError? Type4684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPError? Type4685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator? Type4686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType? Type4687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPErrorType? Type4688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType? Type4689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolErrorType? Type4690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaMCPListToolsTool>? Type4691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsTool? Type4692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType? Type4693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam? Type4694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType? Type4695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam? Type4696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParam? Type4697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? Type4698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? Type4699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? Type4700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminator? Type4701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType? Type4702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType? Type4703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType? Type4704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType? Type4705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType? Type4706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? Type4707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam? Type4708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus? Type4709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam? Type4710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParam? Type4711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParam? Type4712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminator? Type4713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType? Type4714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType? Type4715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType? Type4716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType? Type4717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellActionParam? Type4718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant17? Type4719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator? Type4720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type4721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType? Type4722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus? Type4723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallType? Type4724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecAction? Type4725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallStatus? Type4726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecActionType? Type4727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType? Type4728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus? Type4729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>? Type4730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item2? Type4731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? Type4732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? Type4733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type4734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type4735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType? Type4736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType? Type4737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallType? Type4738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallStatus? Type4739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallError? Type4740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>? Type4741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1? Type4742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallQuality? Type4743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageBackground? Type4744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageOutputFormat? Type4745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSvgUsage? Type4746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetails? Type4747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage? Type4748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType? Type4749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemType? Type4750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent>? Type4751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContent? Type4752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>? Type4753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContent? Type4754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemStatus? Type4755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContentType? Type4756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContentType? Type4757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning? Type4758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamText? Type4759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format7? Type4760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamTextFormatDiscriminator? Type4761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? Type4762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType? Type4763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole? Type4764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType? Type4765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaToolSearchOutputTool>? Type4766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputTool? Type4767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallItemStatus? Type4768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParam? Type4769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminator? Type4770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType? Type4771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType? Type4772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem16>? Type4773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem16? Type4774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParam? Type4775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminator? Type4776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type4777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType? Type4778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParamType? Type4779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType? Type4780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction1? Type4781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam>? Type4782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParam? Type4783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamType? Type4784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3>? Type4785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem3? Type4786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParam? Type4787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParam? Type4788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam? Type4789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator? Type4790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType? Type4791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParamType? Type4792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParamType? Type4793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParamType? Type4794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType? Type4795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamType? Type4796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6>? Type4797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem6? Type4798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParam? Type4799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? Type4800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParam? Type4801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminator? Type4802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType? Type4803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParamType? Type4804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType? Type4805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDetailEnum? Type4806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam? Type4807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode? Type4808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamTtl? Type4809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParamType? Type4810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType? Type4811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>? Type4812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>? Type4813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item2? Type4814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParam? Type4815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type4816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type4817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParamType? Type4818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileDetailEnum? Type4819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallStatus? Type4820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchCallStatus? Type4821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallAction? Type4822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch? Type4823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? Type4824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFind? Type4825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminator? Type4826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType? Type4827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? Type4828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSource? Type4829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType? Type4830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImage? Type4831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? Type4832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam? Type4833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallType? Type4834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerAction? Type4835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>? Type4836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallStatus? Type4837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParam? Type4838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickAction? Type4839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParam? Type4840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressAction? Type4841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParam? Type4842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParam? Type4843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParam? Type4844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParam? Type4845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParam? Type4846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminator? Type4847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType? Type4848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParamType? Type4849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParamType? Type4850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParamType? Type4851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParamType? Type4852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParamType? Type4853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressActionType? Type4854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParamType? Type4855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam>? Type4856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCoordParam? Type4857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickActionType? Type4858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParamType? Type4859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickButtonType? Type4860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallType? Type4861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallStatus? Type4862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? Type4863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item? Type4864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputMessageContent>? Type4865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContent? Type4866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase? Type4867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageStatus? Type4868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContent? Type4869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContent? Type4870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminator? Type4871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType? Type4872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContentType? Type4873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentType? Type4874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>? Type4875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotation? Type4876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>? Type4877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLogProb? Type4878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>? Type4879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTopLogProb? Type4880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBody? Type4881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBody? Type4882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody? Type4883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePath? Type4884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminator? Type4885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType? Type4886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePathType? Type4887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBodyType? Type4888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBodyType? Type4889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBodyType? Type4890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageRole? Type4891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageStatus? Type4892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>? Type4893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContent? Type4894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminator? Type4895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminatorType? Type4896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageRole? Type4897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>? Type4898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageType? Type4899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResponseMethodPublicBody? Type4900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsCompaction? Type4901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageOptionsParam? Type4902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum? Type4903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsParam? Type4904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierEnum? Type4905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheTTLEnum? Type4906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheModeEnum? Type4907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageContextCompression? Type4908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Type4909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsShared? Type4910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? Type4911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum? Type4912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorResponse? Type4913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaError? Type4914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorDetailsResource? Type4915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorType? Type4916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentSteer? Type4917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? Type4918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemList? Type4919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemResource>? Type4920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResource? Type4921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResource? Type4922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? Type4923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResource? Type4924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource? Type4925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessage? Type4926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCall? Type4927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput? Type4928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCall? Type4929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutput? Type4930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalTools? Type4931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdate? Type4932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgram? Type4933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutput? Type4934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBody? Type4935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCall? Type4936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput? Type4937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall? Type4938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? Type4939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? Type4940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResource? Type4941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResource? Type4942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminator? Type4943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType? Type4944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? Type4945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum? Type4946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? Type4947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallStatus? Type4948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType? Type4949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus? Type4950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallType? Type4951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatus? Type4952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation2? Type4953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? Type4954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? Type4955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? Type4956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminator? Type4957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType? Type4958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType? Type4959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType? Type4960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType? Type4961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputType? Type4962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum? Type4963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? Type4964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent? Type4965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome2? Type4966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? Type4967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? Type4968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminator? Type4969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? Type4970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType? Type4971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType? Type4972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallType? Type4973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellAction? Type4974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallStatus? Type4975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant12? Type4976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource? Type4977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResource? Type4978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1Discriminator? Type4979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? Type4980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResourceType? Type4981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType? Type4982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBodyType? Type4983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputType? Type4984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputStatus? Type4985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramType? Type4986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning? Type4987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateText? Type4988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format5? Type4989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateTextFormatDiscriminator? Type4990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateTextFormatDiscriminatorType? Type4991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsType? Type4992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageRole? Type4993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputType? Type4994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallType? Type4995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputType? Type4996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction? Type4997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent>? Type4998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallType? Type4999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageType? Type5000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4>? Type5001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem4? Type5002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContent? Type5003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent? Type5004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContent? Type5005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminator? Type5006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType? Type5007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentType? Type5008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContentType? Type5009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContentType? Type5010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? Type5011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? Type5012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus? Type5013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? Type5014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput? Type5015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? Type5016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputStatus? Type5017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus? Type5018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? Type5019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResource? Type5020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResolvedImageOptions? Type5021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResourceObject? Type5022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemField>? Type5023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemField? Type5024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsage? Type5025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails? Type5026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCacheWriteTokensDetails? Type5027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails? Type5028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessage? Type5029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminator? Type5030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType? Type5031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageType? Type5032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageStatus? Type5033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem>? Type5034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem? Type5035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminator? Type5036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType? Type5037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase2? Type5038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResolvedImageContextCompressionEnum? Type5039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? Type5040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? Type5041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent? Type5042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponse? Type5043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponseProperties? Type5044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseProperties? Type5045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3? Type5046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierResponsesEnum? Type5047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Truncation? Type5048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Status? Type5049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsBody? Type5050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorVariant1? Type5051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetails? Type5052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason? Type5053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningInputTransformation>? Type5054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningInputTransformation? Type5055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputItem>? Type5056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItem? Type5057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseToolUsage? Type5058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptions? Type5059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnostics? Type5060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModeration? Type5061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConversation? Type5062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input2? Type5063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBody? Type5064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBody? Type5065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminator? Type5066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType? Type5067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output2? Type5068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminator? Type5069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType? Type5070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBodyType? Type5071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBodyType? Type5072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>>? Type5073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>? Type5074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputType? Type5075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? Type5076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? Type5077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? Type5078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? Type5079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator? Type5080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType? Type5081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType? Type5082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type5083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType? Type5084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType? Type5085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum? Type5086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsTtl? Type5087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolUsage? Type5088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchUsage? Type5089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenOutputTokensDetails? Type5090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenInputUsageDetails? Type5091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCachedUsageDetails? Type5092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminator? Type5093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType? Type5094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningInputTransformationType? Type5095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningInputTransformationAction? Type5096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputRemovalReason? Type5097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorCode? Type5098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCyberAccessProgramEnum? Type5099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptVariant1? Type5100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>? Type5101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention? Type5102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? Type5103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? Type5104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? Type5105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? Type5106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? Type5107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? Type5108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? Type5109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? Type5110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? Type5111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? Type5112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? Type5113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? Type5114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? Type5115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? Type5116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? Type5117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? Type5118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? Type5119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? Type5120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus? Type5121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPart? Type5122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? Type5123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPart? Type5124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent? Type5125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProb>? Type5126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProb? Type5127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? Type5128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob? Type5129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? Type5130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? Type5131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? Type5132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? Type5133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? Type5134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent? Type5135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent? Type5136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType? Type5137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent? Type5138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType? Type5139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaShellCallOutputDelta? Type5140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent? Type5141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType? Type5142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent? Type5143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType? Type5144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent? Type5145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType? Type5146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? Type5147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? Type5148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? Type5149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? Type5150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? Type5151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEvent? Type5152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent? Type5153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? Type5154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContent? Type5155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminator? Type5156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType? Type5157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? Type5158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent? Type5159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent? Type5160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType? Type5161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? Type5162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? Type5163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? Type5164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? Type5165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? Type5166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? Type5167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? Type5168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? Type5169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? Type5170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent? Type5171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEvent? Type5172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? Type5173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? Type5174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? Type5175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? Type5176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer? Type5177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInput? Type5178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventError? Type5179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCode? Type5180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? Type5181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? Type5182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItem? Type5183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParam? Type5184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminator? Type5185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType? Type5186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamType? Type5187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamRole? Type5188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? Type5189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>? Type5190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item2? Type5191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminator? Type5192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType? Type5193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? Type5194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventSteer? Type5195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReason? Type5196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? Type5197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInput? Type5198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type5199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? Type5200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? Type5201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? Type5202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type5203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? Type5204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? Type5205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator? Type5206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType? Type5207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? Type5208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? Type5209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventSteer? Type5210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEvent? Type5211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudio? Type5212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudio? Type5213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudio? Type5214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudioFormat? Type5215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputParam? Type5216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContent? Type5217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaIncludeEnum? Type5218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEvent? Type5219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? Type5220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2? Type5221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? Type5222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2? Type5223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? Type5224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2? Type5225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? Type5226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2? Type5227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2? Type5228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2? Type5229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2? Type5230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2? Type5231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2? Type5232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? Type5233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2? Type5234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? Type5235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2? Type5236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? Type5237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2? Type5238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? Type5239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2? Type5240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? Type5241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2? Type5242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? Type5243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2? Type5244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? Type5245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2? Type5246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? Type5247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2? Type5248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2? Type5249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? Type5250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2? Type5251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? Type5252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2? Type5253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? Type5254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2? Type5255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? Type5256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2? Type5257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2? Type5258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2? Type5259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? Type5260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2? Type5261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? Type5262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2? Type5263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? Type5264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2? Type5265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? Type5266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2? Type5267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? Type5268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2? Type5269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? Type5270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2? Type5271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? Type5272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2? Type5273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? Type5274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2? Type5275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? Type5276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2? Type5277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? Type5278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2? Type5279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? Type5280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2? Type5281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? Type5282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2? Type5283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? Type5284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2? Type5285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? Type5286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2? Type5287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? Type5288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2? Type5289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? Type5290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2? Type5291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? Type5292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2? Type5293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? Type5294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2? Type5295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? Type5296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2? Type5297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? Type5298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2? Type5299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? Type5300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2? Type5301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? Type5302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2? Type5303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? Type5304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2? Type5305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? Type5306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2? Type5307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? Type5308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2? Type5309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? Type5310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2? Type5311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? Type5312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2? Type5313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? Type5314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2? Type5315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? Type5316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2? Type5317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? Type5318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2? Type5319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? Type5320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2? Type5321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? Type5322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2? Type5323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? Type5324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2? Type5325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? Type5326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2? Type5327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsError? Type5328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? Type5329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? Type5330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminator? Type5331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType? Type5332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventError? Type5333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode? Type5334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorPayload? Type5335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEvent? Type5336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEventVariant2? Type5337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEvent? Type5338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? Type5339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEvent? Type5340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminator? Type5341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType? Type5342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? Type5343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponse? Type5344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties? Type5345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3? Type5346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsParam? Type5347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParam? Type5348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation? Type5349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? Type5350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationParam? Type5351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaBackgroundOptionsParam? Type5352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1? Type5353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>? Type5354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContextManagementParam? Type5355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentParam? Type5356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaBackgroundCompletionWindowEnum? Type5357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationPolicyParam? Type5358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationConfigParam? Type5359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationMode? Type5360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParamTtl? Type5361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? Type5362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEvent? Type5363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminator? Type5364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType? Type5365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateChatCompletionRequest? Type5366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationItemsRequest? Type5367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEvalRequest? Type5368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysCreateRequest? Type5369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsOrder? Type5370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListChatCompletionsOrder? Type5371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetChatCompletionMessagesOrder? Type5372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainersOrder? Type5373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainerFilesOrder? Type5374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListConversationItemsOrder? Type5375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrder? Type5376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrderBy? Type5377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsOrder? Type5378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsStatus? Type5379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? Type5380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? Type5381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesOrder? Type5382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? Type5383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysListOrder? Type5384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsEffectiveAt? Type5385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>? Type5386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationCertificatesOrder? Type5387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>? Type5388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetCertificateIncludeItem? Type5389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsBucketWidth? Type5390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? Type5391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsGroupByItem? Type5392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupsOrder? Type5393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder? Type5394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupUsersOrder? Type5395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess? Type5396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesOrder? Type5397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupsOrder? Type5398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RetrieveProjectGroupGroupType? Type5399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? Type5400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRolesOrder? Type5401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder? Type5402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth? Type5403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? Type5404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem? Type5405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth? Type5406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? Type5407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem? Type5408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth? Type5409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? Type5410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem? Type5411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsBucketWidth? Type5412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? Type5413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsGroupByItem? Type5414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth? Type5415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? Type5416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem? Type5417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth? Type5418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? Type5419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem? Type5420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesBucketWidth? Type5421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSource>? Type5422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSource? Type5423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSize>? Type5424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSize? Type5425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesGroupByItem>? Type5426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesGroupByItem? Type5427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsBucketWidth? Type5428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? Type5429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsGroupByItem? Type5430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresBucketWidth? Type5431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? Type5432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresGroupByItem? Type5433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth? Type5434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? Type5435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel? Type5436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? Type5437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem? Type5438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder? Type5439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupRoleAssignmentsOrder? Type5440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectRolesOrder? Type5441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder? Type5442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListInputItemsOrder? Type5443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesOrder? Type5444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsOrder? Type5445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? Type5446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunIncludeItem? Type5447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsOrder? Type5448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? Type5449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsIncludeItem? Type5450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>? Type5451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetRunStepIncludeItem? Type5452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresOrder? Type5453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? Type5454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? Type5455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesOrder? Type5456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesFilter? Type5457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2?>? Type5458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1? Type5459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2? Type5460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant1? Type5461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant2? Type5462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? Type5463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? Type5464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem? Type5465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? Type5466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem? Type5467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? Type5468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem? Type5469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? Type5470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem? Type5471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? Type5472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem? Type5473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOrder? Type5474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? Type5475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem? Type5476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? Type5477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem? Type5478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateTranslationResponseJson, global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson>? Type5479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponse? Type5480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerResponseObject? Type5481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponse? Type5482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteContainerFileResponseObject? Type5483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalResponse? Type5484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteEvalRunResponse? Type5485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationResponse, global::tryAGI.OpenAI.CreateCSAMModerationResponse>? Type5486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponse? Type5487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponse? Type5488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteResponseResponseObject? Type5489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentAutomationsResponse? Type5490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentAutomationsResponseObject? Type5491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AutomationResource>? Type5492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentAutomationInvocationsResponse? Type5493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentAutomationInvocationsResponseObject? Type5494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AutomationInvocationResource>? Type5495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponse? Type5496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject? Type5497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubagentResource>? Type5498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponse? Type5499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponseObject? Type5500 { get; set; }

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
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem2>? ListType55 { get; set; }
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
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.IncludeEnum>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContextManagementParam>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequest>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionInclude>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionLanguage>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionWord>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionSegment>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ImageRefParam>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.List<float>, string>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItemContentItem>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Eval>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRun>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemResult>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalRunOutputItem>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningIntegration>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItem>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GroupResponse>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Image>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InviteProject>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Invite>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InviteRequestProject>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssistantObject>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLog>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Batch>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationCertificate>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OpenAIFile>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningCheckpointPermission>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobCheckpoint>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJobEvent>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObject>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Model>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FineTuningJob>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationProjectCertificate>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepObject>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunObject>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileObject>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreObject>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialItem>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MCPListToolsTool>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationSpendAlert>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputMessageContent>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectApiKey>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectGroup>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Project>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectRateLimit>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectServiceAccount>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectSpendAlert>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectUser>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Role>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItem>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProbProperties>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseInputItem>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2ContentItem>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseInputText>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem7>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionModalitie>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeFunctionTool>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextContent>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ReasoningTextContent>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ReasoningInputTransformation>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputItem>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemResource>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerInputItem>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProb>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssignedRoleDetails>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunToolCallObject>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageTimeBucket>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UserProjectsDataItem>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GroupUser>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.User>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VoiceConsentResource>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebSearchActionSearchSource>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TopLogProb>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Annotation>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProb>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem9>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CoordParam>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LocalSkillParam>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem4>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SearchContentType>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem15>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolSearchOutputTool>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsVariant1Item>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveLocalSkillParam>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.LiveMCPToolFilterParam>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveCallableToolAllowedCaller>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem11>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem17>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionJsonObject, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionJsonObject>>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionJsonObject>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InstructionsVariant2Item2>>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InstructionsVariant2Item2>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionChoiceParam>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InstructionsVariant2Item3>>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InstructionsVariant2Item3>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InstructionsVariant2Item>>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InstructionsVariant2Item>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionScoreLevelParam>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionQuestion>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem8>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.List<string>>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem18>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CSAMModerationResult>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ExternalKeyResource>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Transformation>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PlatformProvider>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TransformationParam>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PlatformFederationRule>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageResult>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageBucket>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ExternalStorageResponse>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectOptionalServiceTier>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBodyEnabledTiers?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem2>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VideoResource>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemField>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillResource>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillVersionResource>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem3>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.Attachment>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseOutputText>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TaskGroupTask>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadItem>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadResource>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<object, global::System.Collections.Generic.List<object>>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputText>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputVariant2Item>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionQuestionInputPart>>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionQuestionInputPart>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceOptionParam>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreLevelParam>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.QuestionParam>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceProbabilityResource>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreProbabilityResource>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnswerResource>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolResource>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateSkillResource>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateFileResource>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentResource>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageResource2>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolConfigParam>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SetupCommandParam>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillParam>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginParam>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentParam>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageParam>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillResource>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PublicEnvironmentResource>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentFileResource>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentContentResource>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageContentResource>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextResource>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnItemResource>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.TurnResource>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolResource>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentResource>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentTemplateResource>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionRequiredActionResource>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionResource>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputTextResource>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionArtifactResource>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionInputParam>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnTraceResource>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultStatusParam>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultResource>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultCredentialResource>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebhookEndpointBody>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectEventTypeEnum>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item>>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionInputTextParam>>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveDecisionInputTextParam>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item2>>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item2>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item3>>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item3>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item4>>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item4>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item3>>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item3>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item4>>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant2Item4>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item5>>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item5>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item6>>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item6>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>, string>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTool>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSearchContentType>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem6>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLocalSkillParam>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem3>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaMCPListToolsTool>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item2>? ListType369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSummaryTextContent>? ListType370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaReasoningTextContent>? ListType371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaToolSearchOutputTool>? ListType372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem16>? ListType373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContentParam>? ListType374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem3>? ListType375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem6>? ListType376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>>? ListType377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>? ListType378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? ListType379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? ListType380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerAction>? ListType381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCoordParam>? ListType382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? ListType383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputMessageContent>? ListType384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaAnnotation>? ListType385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLogProb>? ListType386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTopLogProb>? ListType387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>? ListType388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>>? ListType389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemResource>? ListType390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? ListType391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContent>? ListType392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem4>? ListType393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemField>? ListType394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem>? ListType395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaReasoningInputTransformation>? ListType396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputItem>? ListType397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>>? ListType398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>? ListType399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProb>? ListType400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? ListType401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? ListType402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? ListType403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>? ListType404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? ListType405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaIncludeEnum>? ListType406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContextManagementParam>? ListType407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogEventType>? ListType408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetCertificateIncludeItem>? ListType409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCostsGroupByItem>? ListType410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? ListType411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? ListType412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? ListType413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? ListType414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? ListType415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? ListType416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSource>? ListType417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSize>? ListType418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesGroupByItem>? ListType419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? ListType420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? ListType421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? ListType422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? ListType423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateRunIncludeItem>? ListType424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? ListType425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetRunStepIncludeItem>? ListType426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? ListType427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>? ListType428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? ListType429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>? ListType430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>? ListType431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>? ListType432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>? ListType433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? ListType434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AutomationResource>? ListType435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.AutomationInvocationResource>? ListType436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubagentResource>? ListType437 { get; set; }
    }
}