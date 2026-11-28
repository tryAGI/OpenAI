
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
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsCode? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearch? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFunction? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResources? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResourcesCodeInterpreter? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantObjectToolResourcesFileSearch? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantStreamEvent? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEvent? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEvent? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEvent? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEvent? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorEvent? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoneEvent? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantSupportedModels? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchRankingOptions? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionObject? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatText? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonObject? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchema? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOption? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoice? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoiceType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioResponseFormat? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscription? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionModel? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionDelay? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionResponse? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AudioTranscriptionResponseModel? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLog? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogEventType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProject? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActor? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyCreated? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyCreatedData? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdated? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdatedChangesRequested? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogApiKeyDeleted? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalKeyRegistered? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalKeyRemoved? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRegistered? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRegisteredData? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogExternalStorageRemoved? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupCreated? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupCreatedData? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupUpdated? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogGroupDeleted? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogScimEnabled? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogScimDisabled? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteSent? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteSentData? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteAccepted? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogInviteDeleted? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistCreated? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogLoginFailed? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogLogoutFailed? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogOrganizationUpdated? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogOrganizationUpdatedChangesRequested? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectCreated? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectCreatedData? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectUpdated? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectUpdatedChangesRequested? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectArchived? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogProjectDeleted? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdated? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRateLimitDeleted? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleCreated? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUpdated? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUpdatedChangesRequested? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleDeleted? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleBoundToResource? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUnboundFromResource? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreated? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdatedChangesRequested? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderCreated? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderUpdated? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderDeleted? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingCreated? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingUpdated? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingDeleted? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserAdded? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserAddedData? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserUpdated? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserUpdatedChangesRequested? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogUserDeleted? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateCreated? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateUpdated? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificateDeleted? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesActivated? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesDeactivated? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorSession? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorApiKey? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorApiKeyType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorUser? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AuditLogActorServiceAccount? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Batch? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchErrors? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BatchError>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchError? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchStatus? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchRequestCounts? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsage? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsageInputTokensDetails? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchUsageOutputTokensDetails? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BatchFileExpirationAfter? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Certificate? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CertificateObject? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CertificateCertificateDetails? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedTools? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionDeleted? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionFunctionCallOption? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionFunctions? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionParameters? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionList? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageList? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItem? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemImageUrl? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemFile? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCall? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallFunction? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminator? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModalitiesVariant1Item? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModeration? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input5? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationResults? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationError? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminator? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output6? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminator? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationResultBody>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBody? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminator? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessage? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminator? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParam? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessage? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageFunctionCall? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRole? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamOptionsVariant1? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDelta? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaAudio? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaFunctionCall? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunk>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprob? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionTool? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParam? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminator? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutput? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CodeInterpreterFileOutputFile>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterFileOutputFile? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTextOutput? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterTool? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParam? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CallableToolAllowedCaller? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallStatus? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilter? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilterType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompleteUploadRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsage? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilter? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerAction? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParam? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickAction? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParam? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressAction? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParam? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParam? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParam? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParam? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParam? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminator? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminatorType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerAction>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotImage? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCall? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallSafetyCheckParam? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallStatus? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutput? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputStatus? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputStatus? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResource? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileListResourceObject? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerFileResource>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileResource? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResource? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerListResourceObject? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerResource>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResource? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfter? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfterAnchor? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceMemoryLimit? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicy? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicyType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Content? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContent? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContent? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItem? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Message? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResource? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCall? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCall? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCall? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCall? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutput? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalTools? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdate? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItem? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Program? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutput? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBody? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCall? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCall? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutput? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCall? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutput? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListTools? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalRequest? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCall? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCall? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutput? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminator? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemDiscriminatorType? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationItemList? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationParam2? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResult? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultApiSource? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultAmount? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CostsResultQuantityUnit? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortEnum? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResources? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesCodeInterpreter? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearch? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestEndpoint? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateBatchRequestCompletionWindow? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequest? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponseProperties? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsParam? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsShared? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum2? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityEnum? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptions? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocation? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSize? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormat? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminator? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2Audio? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationParam? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StopConfiguration? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PredictionContent? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletions? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoice? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceLogprobs? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequest? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionRequestModel? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponse? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoice? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBody? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem2? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParam? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParam? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminator? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy2? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminator? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContainerFileBody? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequest? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateEmbeddingRequestModel?>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestModel? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingRequestEncodingFormat? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponse? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Embedding>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Embedding? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEmbeddingResponseUsage? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceType? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessages? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EasyInputMessage, global::tryAGI.OpenAI.EvalItem>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessage? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItem? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessages? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSourceSamplingParams? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalStoredCompletionsSource>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsSource? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItem? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalItemSimpleInputMessage? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLabelModelGrader? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateEvalItem>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRequest? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig, global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig, global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderStringCheck? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarity? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPython? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModel? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplate? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem, global::tryAGI.OpenAI.EvalItem>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTemplateItem? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReference? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParams? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Tool? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSourceSamplingParamsText? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfiguration? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalJsonlFileContentSource, global::tryAGI.OpenAI.EvalJsonlFileIdSource, global::tryAGI.OpenAI.EvalResponsesSource>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSource? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEvalRunRequest? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequest? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFileRequestPurpose? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileExpirationAfter? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningCheckpointPermissionRequest? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequest? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestModel? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestHyperparameters? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, int?>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegrationWandb? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethod? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupBody? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateGroupUserBody? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequest? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Complexity? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestBackground? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestModel? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestSize? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesApiOutputFormat? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgParam? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFidelity? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageEditRequestQuality? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequest? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Svg? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModel? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestQuality? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestResponseFormat? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestSize? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestModeration? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestBackground? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageRequestStyle? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequest? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateImageVariationRequestSize? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequest? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestRole? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObject? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponseProperties? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequest? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationRequestModel? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponse? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResult? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategories? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryScores? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponse? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseProperties? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsParam? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageOptionsParam? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResponsesEnum? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateResponseVariant3Truncation? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Reasoning? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputParam? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.IncludeEnum? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BackgroundOptionsParam? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContextManagementParam? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunRequest? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObject? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequest? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestModel? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsShared? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestVoice2? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminator? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpeechResponseStreamEventDiscriminatorType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBody? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSpendAlertBodyInterval? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendAlertNotificationChannel? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequest? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequest? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestModel? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResourcesFileSearch? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResources? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesCodeInterpreter? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearch? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStore? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequest? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestModel? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionInclude? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.VadConfig>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfig? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionDiarizedSegment? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJson? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionLanguage? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextSegmentEvent? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEvent? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEvent? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionWord>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionWord? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionSegment? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequest? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationRequestResponseFormat? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseJson? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateTranslationResponseVerboseJson? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequest? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateUploadRequestPurpose? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreFileRequest? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVectorStoreRequest? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreExpirationAfter? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceConsentRequest? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequest? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequestType? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequestModel? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequest? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminator? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCaller? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParam? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResource? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputStatusEnum? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResource? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolCallResourceVariant2? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatus? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustom? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteAssistantResponse? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteCertificateResponse? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFileResponse? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteMessageResponse? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteModelResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteThreadResponse? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreFileResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeleteVectorStoreResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversation? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResource? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedRoleAssignmentResource? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EasyInputMessageRole? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParam? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModel? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamQuality? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamSize? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModeration? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EditImageBodyJsonParamBackground? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<float>, string>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorDetailsResource? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Eval? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalCustomDataSourceConfig, global::tryAGI.OpenAI.EvalLogsDataSourceConfig, global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfig? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfig? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.EvalGraderLabelModel?, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderLabelModel? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalApiError? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModel? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPython? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderPythonVariant2? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModel? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheck? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarity? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalGraderTextSimilarityVariant2? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemRole? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContent? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentItem? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContent? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemContentOutputText? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalItemInputImage? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudio? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalList? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Eval>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalResponsesSourceType? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRun? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunResultCounts? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerModelUsageItem>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerModelUsageItem? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunPerTestingCriteriaResult? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunList? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRun>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItem? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemResult>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemResult? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSample? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemSampleUsage? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EvalRunOutputItemList? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItem>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FilePath? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchRanker? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallStatus? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOHyperparameters? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneDPOMethod? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneMethodType? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedMethod? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementMethod? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneReinforcementHyperparametersReasoningEffort? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMulti? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuneSupervisedHyperparameters? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningCheckpointPermission? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegration? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningIntegrationWandb? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJob? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.FineTuningJobErrorVariant1, object>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobErrorVariant1? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobHyperparameters? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobStatus? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningIntegration>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpoint? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobCheckpointMetrics? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEvent? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventLevel? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FineTuningJobEventType? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContent? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContent? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminator? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCall? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallStatus? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutput? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputStatus? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolCallResourceVariant2? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Graders? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminator? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModelSamplingParams? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheckOperation? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Group? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupDeletedResource? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupListResource? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupResponse>? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponse? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUser? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupMemberUserUserType? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResourceWithSuccess? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupResponseGroupType? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupRoleAssignment? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Role? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUser? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserAssignment? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GroupUserDeletedResource? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermission? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Image? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditCompletedEventSize?>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventSize? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventQuality? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventBackground? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsage? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditPartialImageEventSize?>? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventSize? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventQuality? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventBackground? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEvent? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminator? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventSize? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventQuality? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventBackground? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventSize? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventQuality? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventBackground? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEvent? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminator? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenTool? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModel? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolComplexity? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolQuality? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolSize? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolOutputFormat? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolModeration? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolBackground? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolInputImageMask? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenActionEnum? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponse? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image>? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseBackground? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImagesResponseSize?>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseSize? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesResponseQuality? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenUsage? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgUsage? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImagesUsageInputTokensDetails? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputAudioInputAudio1Format? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminator? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminatorType? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItem? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Item? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParam? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParam? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParam? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParam? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminator? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputItemDiscriminatorType? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessage? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageRole? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageStatus? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResourceVariant2? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Invite? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRole? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteStatus? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProject? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectRole? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteDeleteResponse? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteListResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteProjectGroupBody? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequest? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestRole? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteRequestProject>? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProject? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InviteRequestProjectRole? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessage? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParam? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParam? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParam? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParam? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParam? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParam? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPApprovalResponse? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminator? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemDiscriminatorType? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResource? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminator? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemResourceDiscriminatorType? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsResponse? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantObject>? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsResponse? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLog>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListBatchesResponse? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Batch>? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListCertificatesResponse? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationCertificate>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificate? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesResponse? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OpenAIFile>? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFile? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningCheckpointPermission>? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponse? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint>? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningJobEventsResponse? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobEvent>? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesResponse? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObject>? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObject? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListModelsResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Model>? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Model? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPaginatedFineTuningJobsResponse? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJob>? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesResponse? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationProjectCertificate>? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificate? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsResponse? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepObject>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObject? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsResponse? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunObject>? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObject? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesResponse? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileObject>? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObject? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresResponse? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreObject>? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObject? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptRequest? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallAcceptSession? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLive? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionAudioParam? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallReferRequest? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallRejectRequest? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEvent? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEvent? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParam? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParam? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCreateParam? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParam? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParam? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParam? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminator? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientEventDiscriminatorType? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveConnectParams? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateRequest? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionCreateParams? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransport? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponse? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCreateResponseSession? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEvent? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminator? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkPathParams? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkRequest? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMediaSessionForkParams? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParam? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientConfigParam? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpeechWakePolicyParam? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTransport? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunk? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuth? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSIPTrunkAuthType? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEventDiscriminator? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequest? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminator? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateRequestTransportDiscriminatorType? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponse? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transport2? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminator? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminatorType? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEvent? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParam? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandConnectParams? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandPathParams? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEvent? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRinging? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnswered? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailed? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSent? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStarted? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdated? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResumed? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionPaused? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuted? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppended? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppended? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppended? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreated? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEvent? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreated? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleted? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEvent? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosed? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEvent? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEvent? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecAction? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallStatus? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolCallOutputStatus? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProbProperties? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPListToolsTool? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPTool? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolConnectorId? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolFilter? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallError? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallStatus? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolError? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionError? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPError? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminator? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentRefusalObject? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObject? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectText? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObject? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectText? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObject? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDelta? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectStatus? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetails? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectRole? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant1? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant2? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant3? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant4? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStreamEventVariant5? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIds? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponses? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsCompaction? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLiveEnum? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsResponsesEnum? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsSharedEnum? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequest? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResources? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyCertificateRequest? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyMessageRequest? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyRunRequest? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequest? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResources? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesCodeInterpreter? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModifyThreadRequestToolResourcesFileSearch? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NoiseReductionType? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFilePurpose? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OpenAIFileStatus? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateActivationResponse? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponse? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetention? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationDataRetentionType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponse? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponse? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlert? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertCurrency? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertInterval? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResource? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResource? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert>? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputAudio? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContent? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContent? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContent? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminator? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputContentDiscriminatorType? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItem? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminator? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemDiscriminatorType? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContent? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageStatus? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminator? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PermissionErrorResponse? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Project? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicProjectResidency? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKey? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwner? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerType? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerUser? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyOwnerServiceAccount? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectApiKeyListResponse? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectApiKey>? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectCreateRequest? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetention? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDataRetentionType? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroup? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupGroupType? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupDeletedResource? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectGroupListResource? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup>? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissions? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectListResponse? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Project>? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissions? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsMode? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponse? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimit? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitListResponse? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectRateLimit>? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccount? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountRole? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKey? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponse? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceAccountListResponse? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectServiceAccount>? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlert? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertCurrency? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertInterval? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendAlertListResource? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectSpendAlert>? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUpdateRequest? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUser? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserCreateRequest? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserDeleteResponse? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserListResponse? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectUser>? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectUserUpdateRequest? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptVariant1? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateOrganizationRoleBody? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRoleListResource? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role>? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreate? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItem? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemDelete? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemRetrieve? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemTruncate? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferAppend? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferClear? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventInputAudioBufferCommit? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClear? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCancel? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreate? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParams? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventSessionUpdate? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequest? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdate? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponse? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatus? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetails? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsage? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetails? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageOutputTokenDetails? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseModalitie? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<int?, string>? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceOptions? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceFunction? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceMCP? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreated? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemDeleted? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailed? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedError? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegment? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrieved? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemTruncated? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventError? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCleared? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferCommitted? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStarted? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventInputAudioBufferSpeechStopped? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsCompleted? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsFailed? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventMCPListToolsInProgress? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdated? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit>? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimit? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDelta? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioDone? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDelta? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseAudioTranscriptDone? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAdded? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPart? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartAddedPartType? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDone? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePart? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseContentPartDonePartType? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreated? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDone? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDelta? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseFunctionCallArgumentsDone? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDelta? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDone? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallCompleted? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallFailed? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallInProgress? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAdded? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDone? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDelta? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseTextDone? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreated? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSession? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdated? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionCreated? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeBetaServerEventTranscriptionSessionUpdated? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallCreateRequest? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallReferRequest? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCallRejectRequest? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEvent? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminator? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParams? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeClientEventTranscriptionSessionUpdate? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConnectDocumentationParams? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConnectDocumentationParamsIntent? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConnectParams? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUser? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalResponse? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPListTools? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolCall? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPApprovalRequest? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminator? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReference? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceType? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceStatus? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceRole? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItem? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeConversationItemWithReferenceContentItemType? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Session5? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeFunctionTool? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPHTTPError? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPProtocolError? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoning? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeReasoningEffort? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponse? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatus? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetails? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseStatusDetailsError? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudio? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseAudioOutput? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsage? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetails? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseUsageOutputTokenDetails? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseOutputModalitie? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseInputItem>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputItem? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputAudio? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputAudioType? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallType? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallStatus? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutputType? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutputStatus? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputImage? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputImageType? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputImageDetail? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessage? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseItemReference? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputItemDiscriminator? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputItemDiscriminatorType? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageType? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageSystem? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDeveloper? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUser? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistant? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDiscriminator? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDiscriminatorRole? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2Role? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2ContentItem>? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2ContentItem? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageAssistantVariant2ContentItemType? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDeveloperVariant2? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageDeveloperVariant2Role? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseInputText>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputText? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsType? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsStatus? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageSystemVariant2? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageSystemVariant2Role? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2Role? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem7? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputTextType? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEvent? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventError? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDone? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminator? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventErrorError? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPart? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePart? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdated? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionObject? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModalitie? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionModel? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfiguration>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfiguration? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracing>? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracing? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncation? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracing>? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracing? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponse? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracing>? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracing? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfiguration>? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfiguration? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetectionType? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEvent? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequest? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSession? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationConnectParams? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEvent? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminator? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudio? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInput? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioOutput? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputTranscription? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInputNoiseReduction? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudio? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInput? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputTranscription? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputNoiseReduction? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioOutput? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnum2? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnum? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummary? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningContext? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningGenerateSummary? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContent? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemStatus? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Response? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResolvedImageOptions? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Truncation? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3Status? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsBody? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorVariant1? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningInputTransformation>? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningInputTransformation? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsage? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseToolUsage? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptions? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnostics? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Moderation? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConversation? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingEvent? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEvent? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateText? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format4? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatJsonSchema? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateTextFormatDiscriminator? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateTextFormatDiscriminatorType? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamText? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format6? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamTextFormatDiscriminator? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEvent? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorCode? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEvent? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEvent? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextGrammar? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFormatTextPython? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEvent? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseItemList? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemResource>? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProb? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseLogProbTopLogprob? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseModalitiesVariant1Item? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Annotation? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextParam? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceParam? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEvent? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCode? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEvent? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInput? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventSteer? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEventError? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItem? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParam? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminator? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEventSteer? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReason? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput>? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInput? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEvent? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminator? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageInputTokensDetails? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CacheWriteTokensDetails? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsError? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorPayload? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEvent? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminator? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEvent? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminator? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEvent? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesWebSocketStreamEventVariant2? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleDeletedResource? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RoleListResource? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetails>? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunCompletionUsageVariant1? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderRequest? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponse? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadata? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataErrors? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunGraderResponseMetadataTokenUsage? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectStatus? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredAction? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObject? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastError? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectLastErrorCode? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetails? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepCompletionUsageVariant1? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObject? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaObjectDelta? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectType? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectStatus? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastError? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectLastErrorCode? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant1? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant2? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant4? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant5? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant6? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStepStreamEventVariant7? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant1? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant2? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant3? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant4? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant5? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant6? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant7? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant8? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant9? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunStreamEventVariant10? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RunToolCallObjectFunction? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpeechAudioDoneEventUsage? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategy? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequest? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput>? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubmitToolOutputsRunRequestToolOutput? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfigurationDiscriminator? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResponseFormatConfigurationDiscriminatorType? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObject? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResources? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToggleCertificatesRequest? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionTool? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchTool? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerTool? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewTool? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchTool? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParam? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParam? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParam? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParam? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParam? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParam? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewTool? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParam? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminator? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolDiscriminatorType? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowed? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceAllowedMode? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceCustom? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypes? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParam? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParam? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceTypesType? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputTool? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParam? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminator? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TranscriptionChunkingStrategy? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationObjectType? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateGroupBody? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBody? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationDataRetentionBodyRetentionType? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBody? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectDataRetentionBodyRetentionType? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBody? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVectorStoreRequest? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVoiceConsentRequest? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Upload? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadStatus? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadCertificateRequest? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadPart? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResult? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResultApiSource? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResult? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResult? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageResponse? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucket? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem>? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResult? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminator? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.User? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserUser1? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjects? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UserProjectsDataItem>? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserProjectsDataItem? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserDeleteResponse? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResource? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser>? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserListResponse? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.User>? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleAssignment? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserRoleUpdateRequest? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfigType? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderRequest? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateGraderResponse? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, double?, bool?>? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObject? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileBatchObjectFileCounts? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponse? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectStatus? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastError? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectFileCounts? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreObjectStatus? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequest? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObject? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultItem? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreSearchResultsPage? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentDeletedResource? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentListResource? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VoiceConsentResource>? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceConsentResource? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceDeletedResource? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceIdsSharedEnum? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResource? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VoiceResourceType? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionFind? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearch? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionSearchSource? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolType? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolFilters? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolSearchContextSize? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallStatus? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallAction? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpired? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentEvent? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailed? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReady? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspended? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequired? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreated? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailed? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdle? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgress? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelled? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCancelledData? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompleted? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchCompletedData? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpired? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchExpiredData? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailed? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookBatchFailedData? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceled? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunCanceledData? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailed? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunFailedData? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceeded? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEvalRunSucceededData? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelled? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobCancelledData? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailed? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobFailedData? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceeded? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookFineTuningJobSucceededData? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncoming? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingData? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportConnected? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportConnectedData? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportConnectedDataType? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncoming? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingData? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader>? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncoming? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingData? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader>? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelled? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCancelledData? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompleted? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseCompletedData? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailed? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseFailedData? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncomplete? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookResponseIncompleteData? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreated? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyAlertCreatedData? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssued? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyDeactivationIssuedData? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreated? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyOrgAlertCreatedData? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssued? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookSafetyWarningIssuedData? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorType? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentSteer? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputType? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBodyType? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTTLEnum? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheModeEnum? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamMode? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamTtl? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationMode? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationConfigParam? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationPolicyParam? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillReferenceParamType? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParam? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamType? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillSourceParamMediaType? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineSkillParamType? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageStatus? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageRole? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfig? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigTtl? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentType? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBody? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationBodyType? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBody? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationBodyType? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBody? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationBodyType? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminator? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationDiscriminatorType? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TopLogProb? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LogProb? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContentType? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContent? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextContentType? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContentType? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContentType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContentType? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetail? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentType? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContent? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContentType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileInputDetail? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentType? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhase2? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageType? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem9>? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem9? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminator? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminatorType? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCaller? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerType? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCaller? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerType? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminator? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParam? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParamType? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParamType? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminator? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallModerationDetails? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallError? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageBackground? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageOutputFormat? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallType? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallStatus? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolCallQuality? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickButtonType? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClickParamType? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickActionType? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CoordParam? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragParamType? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressActionType? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MoveParamType? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParamType? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParamType? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TypeParamType? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitParamType? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchExecutionType? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallType? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolType? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankerVersionType? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HybridSearchOptions? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RankingOptions? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Filters? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileSearchToolType? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerToolType? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerEnvironment? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUsePreviewToolType? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerMemoryLimit? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy4? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParamType? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgReasoningParam? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellToolParamType? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParam? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamType? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalSkillParam? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParam? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParamType? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParam? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParamType? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamType? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant13? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParam? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParamType? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GrammarSyntax1? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParam? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParamType? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamType? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmptyModelParam? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParam? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParamType? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamType? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem4>? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem4? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchToolParamType? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocation? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApproximateLocationType? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContextSize? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SearchContentType? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchPreviewToolType? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolParamType? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputType? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsType? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramType? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputStatus? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputType? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionBodyType? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogsType? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImageType? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalShellExecActionType? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellAction? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallStatus? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResource? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentResourceType? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResource? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceResourceType? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallType? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant1? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContent? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputType? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatus? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallType? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatus? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputType? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolErrorType? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionErrorType? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPErrorType? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DetailEnum? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemStatus? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerCallOutputItemParamType? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParam? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContentParamType? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParam? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContentParamAutoParamType? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileDetailEnum? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParam? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContentParamType? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamType? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParam? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileCitationParamType? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParam? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlCitationParamType? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParam? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerFileCitationParamType? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchCallItemParamType? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParam? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem15? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminator? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolSearchOutputItemParamType? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolSearchOutputTool>? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamType? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdditionalToolsItemParamRole? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionSummaryItemParamType? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellActionParam? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemStatus? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamType? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant15? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputContentParam? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallStatusParam? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParam? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionTriggerItemParamType? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemReferenceParamType? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramItemParamType? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemStatus? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramOutputItemParamType? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResource? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ConversationResourceObject? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenOutputTokensDetails? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenInputUsageDetails? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SvgReasoning? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomVoiceParam? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>?, global::tryAGI.OpenAI.LiveCustomVoiceParam>? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1?>? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioOutputParamVoiceVariant1? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParam? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParamType? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesServiceTier? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningEffort? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveReasoningSummary? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationReasoningInputParam? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTextVerbosity? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationTextInputParam? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParamType? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParamType? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParamType? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerMemoryLimit? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParam? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParamType? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParam? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamType? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParam? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParamType? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyVariant1? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1Discriminator? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsVariant1Item>? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsVariant1Item? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminator? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParam? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParamType? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalSkillParam? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParam? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParamType? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveLocalSkillParam>? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamType? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant16? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1Discriminator? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolFilterParam? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPRequireApprovalFilterParam? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPRequireApprovalApiEnum? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCallableToolAllowedCaller? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParam? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParamType? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.LiveMCPToolFilterParam>? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveMCPRequireApprovalFilterParam, global::tryAGI.OpenAI.LiveMCPRequireApprovalApiEnum?>? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveCallableToolAllowedCaller>? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParam? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParamType? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParam? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParamType? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParam? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParamType? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParam? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParamType? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceEnum? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParamType? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParam? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParamType? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParam? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParamType? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParam? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParamType? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParam? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParamType? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParam? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParamType? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolChoiceValueEnum? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem11>? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem11? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminator? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem17>? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem17? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminator? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant2?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant2? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2Discriminator? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParamType? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputTextParam? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputTextParamType? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDetailEnum? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputImageParam? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputImageParamType? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionJsonObject? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParam? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParamType? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionJsonObject, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionJsonObject>>? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionJsonObject>? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceParam? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, bool?>? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamType? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item2>>? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item2>? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InstructionsVariant2Item2? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminator? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionChoiceParam>? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamType? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item3>>? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item3>? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InstructionsVariant2Item3? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminator? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreLevelParam? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item>>? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item>? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InstructionsVariant2Item? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminator? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionScoreLevelParam>? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestion? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminator? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminatorType? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionQuestion>? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParamType? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1Discriminator? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant1DiscriminatorType? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParam? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParamEventType? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialMessageStatus? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialInputTextContentPartParamType? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam>? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamType? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParamRole? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParamType? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamType? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamRole? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem8>? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem8? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminator? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItem? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminator? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAllowedServerEventParam? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParam? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpeechWakePolicyParamType? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem18>? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem18? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant22?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoiceVariant22? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2Discriminator? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMCategoryFlags? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMCategoryScores? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMCategoryAppliedInputTypes? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CSAMModerationResult? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateCSAMModerationResponse? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CSAMModerationResult>? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponse? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponseType? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminator? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminatorType? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectApiKeyBody? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificApplyPatchParamType? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpecificFunctionShellParamType? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CyberAccessProgramEnum? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageContextCompression? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsePromptCacheOptionsParamTtl? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BackgroundCompletionWindowEnum? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResolvedImageContextCompressionEnum? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputRemovalReason? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningInputTransformationType? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningInputTransformationAction? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CachedUsageDetails? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageGenToolUsage? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchUsage? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsTtl? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CacheMissReasonTypeEnum? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBody? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBodyType? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminator? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminatorType? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminator? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModerationOutputDiscriminatorType? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ShellCallOutputDelta? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationBody? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateConversationBody? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedConversationResourceObject? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNoticeType? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseNotice? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResource? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyCaseResourceObject? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertErrorType? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResource? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SafetyAlertResourceObject? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrderEnum? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalKeyPurpose? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalKeyResource? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListExternalKeysResource? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListExternalKeysResourceObject? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalKeyResource>? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalKeyParams? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalKeyParamsType? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalKeyParams? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalKeyParamsType? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalKeyParams? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalKeyParamsType? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalKeyParams? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalKeyParamsType? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequest? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequestDiscriminator? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequestDiscriminatorType? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ValidateExternalKeyResource? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerification? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerificationType? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerification? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerificationType? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Transformation? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProvider? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderObject? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderType? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerification, global::tryAGI.OpenAI.UploadedJwksVerification>? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Transformation>? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderListResource? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderListResourceObject? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PlatformProvider>? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerificationParam? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DiscoveryVerificationParamType? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerificationParam? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UploadedJwksVerificationParamType? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TransformationParam? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBody? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TransformationParam>? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdatePlatformWorkloadIdentityProviderBody? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderDeletedResource? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformProviderDeletedResourceObject? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissions? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissionsType? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissions? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissionsType? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRule? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleObject? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, bool?, global::tryAGI.OpenAI.AnyOf<int?, double?>?>? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<int?, double?>? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissions, global::tryAGI.OpenAI.RestrictedPermissions>? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleListResource? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleListResourceObject? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PlatformFederationRule>? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissionsParam? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DefaultPermissionsParamType? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissionsParam? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RestrictedPermissionsParamType? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityFederationRuleBody? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissionsParam, global::tryAGI.OpenAI.RestrictedPermissionsParam>? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdatePlatformWorkloadIdentityFederationRuleBody? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleDeletedResource? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PlatformFederationRuleDeletedResourceObject? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketWidth? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageGroupBy? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageApiSource? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResult? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageResultObject? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucket? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageBucketObject? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageResult>? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResource? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageBucket>? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorDetails? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsageErrorResponse? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionsUsagePermissionErrorResponse? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageOrder? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageStatus? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponse? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseObject? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResource? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageListResourceObject? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalStorageResponse>? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParams? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParamsType? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBody? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Provider2? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResource? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageDeletedResourceObject? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrency? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitInterval? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatus? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcement? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmailNotificationChannel? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EmailNotificationChannelType? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResource? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParams? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBody? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyCurrency? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyInterval? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResource? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResource? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitResourceObject? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBody? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResource? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectDefaultServiceTier? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectOptionalServiceTier? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceTierSettingsResource? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceObject? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBody? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBodyEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBodyEnabledTiers? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateProjectServiceAccountApiKeyBody? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBody? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateContentProvenanceBody? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceCheckObject? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceDetectionResultApi? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAValidationStateApi? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResult? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResultType? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResult? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResultType? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResource? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2>? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResultsItem2? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminator? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModel? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoModelEnum? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoStatus? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSize? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Error2? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResource? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoResourceObject? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResource? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoListResourceObject? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageRefParam2? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoSeconds? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoMultipartBody? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoJsonBody? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoCharacterBody? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoCharacterResource? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoReferenceInputParam? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditMultipartBody? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoEditJsonBody? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendMultipartBody? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoExtendJsonBody? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResource? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVideoResourceObject? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VideoContentVariant? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVideoRemixBody? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TruncationEnum? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnum? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnumEnum? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsBody? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResource? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenCountsResourceObject? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheRetentionEnum? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierEnum? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResponseMethodPublicBody? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemField? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminator? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ItemFieldDiscriminatorType? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResource? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactResourceObject? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField>? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResource? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillResourceObject? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResource? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillListResourceObject? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillResource>? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillBody? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetDefaultSkillVersionBody? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResource? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillResourceObject? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResource? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionResourceObject? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResource? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillVersionListResourceObject? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillVersionResource>? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSkillVersionBody? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResource? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSkillVersionResourceObject? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflowTracing? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitWorkflow? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, int?, bool?, double?>? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionRateLimits? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionStatus? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionFileUpload? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionHistory? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionChatkitConfiguration? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResource? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatSessionResourceObject? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowTracingParam? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WorkflowParam? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, int?, bool?, double?>? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParam? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExpiresAfterParamAnchor? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RateLimitsParam? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomaticThreadTitlingParam? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileUploadParam? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HistoryParam? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChatkitConfigurationParam? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatSessionBody? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputText? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageInputTextType? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedText? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageQuotedTextType? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AttachmentType? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Attachment? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolChoice? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InferenceOptions? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItem? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemObject? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemType? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem3? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminator? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment>? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSource? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationSourceType? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotation? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FileAnnotationType? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSource? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationSourceType? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotation? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UrlAnnotationType? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputText? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextType? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem>? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminator? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItem? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemObject? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemType? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText>? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItem? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemObject? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WidgetMessageItemType? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallStatus? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItem? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemObject? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClientToolCallItemType? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskType? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItem? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemObject? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskItemType? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupTask? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItem? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemObject? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TaskGroupItemType? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask>? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItem? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminator? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemDiscriminatorType? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResource? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadItemListResourceObject? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadItem>? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatus? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ActiveStatusType? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatus? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LockedStatusType? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatus? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ClosedStatusType? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResource? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceObject? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Status? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminator? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResource? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedThreadResourceObject? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResource? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ThreadListResourceObject? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource>? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputText? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextType? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpoint? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ImageDetailParam? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImage? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpoint? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImageType? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputJson? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputJsonType? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<object, global::System.Collections.Generic.IList<object>>? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartsItem? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminator? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContent? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputUserMessage? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputUserMessageRole? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputUserMessageType? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperContent? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessage? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessageRole? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessageType? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputSystemMessage? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputSystemMessageRole? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputSystemMessageType? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputOutputText? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputOutputTextType? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputRefusal? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputRefusalType? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContentPartDiscriminator? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContentPartDiscriminatorType? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContent? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseParam? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantMessage? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantMessageRole? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantMessageType? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessage? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageDiscriminator? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusParam? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCall? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallType? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminator? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputToolOutputContent? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCall? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallType? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInput? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2Item? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminator? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputText? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputTextType? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputImage? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputImageType? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputPart? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputPartDiscriminator? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionQuestionInputPartDiscriminatorType? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicate? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicateType? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionQuestionInputPart>>? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionQuestionInputPart>? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueParam? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceOptionParam? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoice? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoiceType? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceOptionParam>? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreLevelParam? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScore? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScoreType? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreLevelParam>? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParam? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminator? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminatorType? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequest? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicate? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicateType? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceValueResource? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ChoiceProbabilityResource? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoice? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoiceType? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceProbabilityResource>? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ScoreProbabilityResource? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScore? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScoreType? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreProbabilityResource>? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusal? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusalType? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResource? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminator? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminatorType? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseUsageResource? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionResponse? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnswerResource>? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrderParam? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortResource? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryResource? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningResource? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceText? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceTextType? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResource? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminator? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityResource? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextResource? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierResource? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunction? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunctionType? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttp? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttpType? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdio? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdioType? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResource? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminator? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginResource? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcp? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcpType? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeResource? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeResource? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationResource? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearchType? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUseType? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceAutomations? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceAutomationsType? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResource? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminator? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigResource? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionResource? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExperimentalConfigResource? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationAgentConfigResource? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource>? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNoneType? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeResource? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesResource? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessResource? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyResource? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopResource? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResource? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminator? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInline? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceInlineType? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResource? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminator? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResource? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminator? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHostedType? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHostedType? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResource? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminator? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminatorType? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputText? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputTextType? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImage? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImageType? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResource? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminator? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminatorType? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource2? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource2Type? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageResource2Role? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSession? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSessionType? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageResource2>? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSessionType? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResource? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceDiscriminator? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceDiscriminatorType? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloperType? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgentType? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResource? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDiscriminator? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDiscriminatorType? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PeriodicAutomationStatusResource? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodic? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodicType? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodicObject? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodicPauseReason? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OnceAutomationStatusResource? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOnce? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOnceType? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOnceObject? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOncePauseReason? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResource? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceDiscriminator? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceDiscriminatorType? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorBodyResource? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ErrorResponse2? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExperimentalConfigOverridesParam? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningEffortParam? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningSummaryParam? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningParam? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamText? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamTextType? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchemaType? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParam? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminator? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminatorType? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VerbosityParam? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextParam? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ServiceTierParam? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompactionParam? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunctionType? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttpType? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdioType? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParam? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminator? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpConnectionOriginParam? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcpType? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchModeParam? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchContextSizeParam? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchLocationParam? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUse? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamAutomations? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamAutomationsType? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParam? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminator? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentConfigParam? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolConfigParam>? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNone? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNoneType? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentPackagesParam? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SetupCommandParam? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkAccessParam? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicyParam? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DesktopParam? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParam? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminator? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInline? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInlineType? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParam? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminator? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInline? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInlineType? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParam? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminator? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParam? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerSizeParam? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHostedType? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParam? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminator? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputText? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputTextType? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImage? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImageType? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParam? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminator? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminatorType? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParam? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamType? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputMessageParamRole? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamNewSession? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamNewSessionType? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSession? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSessionType? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParam? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamDiscriminator? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamDiscriminatorType? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodicType? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsOnce? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsOnceType? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParams? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsDiscriminator? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsDiscriminatorType? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAutomationParams? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAutomationResource? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAutomationResourceObject? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManualType? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomationType? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResource? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceDiscriminator? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceDiscriminatorType? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationStatusResource? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationErrorResource? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationResource? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationResourceObject? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationResourceSkipReason? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeParam? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTypeResource? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentStatusResource? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResource? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInline? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInlineType? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResource? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminator? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResource? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicEnvironmentResourceObject? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResource? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentEnvironmentListResourceObject? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PublicEnvironmentResource>? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHostedType? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParam? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminator? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminatorType? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentEnvironmentParams? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFilePageObjectResource? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResource? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileResourceObject? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentFileListResource? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource>? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentObjectResource? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResource? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResourceType? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResource? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResourceType? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResource? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminator? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentStatusResource? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SubagentResource? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionMessageRoleResource? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputText? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputTextType? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImage? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImageType? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputText? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputTextType? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResource? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminator? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputItemStatusResource? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessagePhaseResource? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResource? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResourceType? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource>? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResource? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextResourceType? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResource? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResourceType? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource>? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallStatusResource? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResource? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResourceType? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputResource? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResourceType? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResource? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResourceType? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResource? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResourceType? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResource? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotResourceType? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResource? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseCallItemResourceType? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldResource? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationOptionResource? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResource? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminator? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminator? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResource? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearchType? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOther? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOtherType? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResource? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminator? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResource? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResourceType? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResource? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResourceType? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResourceType? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResourceType? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResource? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminator? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResource? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionItemListResourceObject? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnItemResource>? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTtlResource? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsResource? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnObjectResource? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnStatusResource? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorCodeResource? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnErrorResource? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputTokensDetailsResource2? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTokensDetailsResource2? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TokenUsageResource? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TurnResource? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResource? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnListResourceObject? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TurnResource>? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResource? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminator? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUse? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceAutomations? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceAutomationsType? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResource? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminator? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResource? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentResourceObject? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolResource>? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResource? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentListResourceObject? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentResource>? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExperimentalConfigParam? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParam? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUse? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomations? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomationsType? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParam? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentParams? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentParams? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResource? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedAgentResourceObject? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResource? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateResourceObject? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResource? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentTemplateResource>? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentTemplateParams? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResource? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CyberAccessProgramResource? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsResource? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionReviewResource? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionBudgetControlResource? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionStatusResource? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCallType? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResource? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminator? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminatorType? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequest? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceMcpApprovalRequestType? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequest? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResource? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminator? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionAgentResource? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNone? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNoneType? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResource? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminator? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResource? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionResourceObject? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource>? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResource? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionListResourceObject? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource>? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionReviewParam? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionBudgetControlParams? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionInputParam? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CyberAccessProgramParam? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsParam2? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheTtlParam? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheOptionsParam2? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionStreamOptionsParam? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAgentSessionParams? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionErrorResource? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventError? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventErrorType? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStatusResource? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentErrorResource? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEnvironmentStateResource? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspended? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentSuspendedType? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpired? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentExpiredType? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdleType? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReached? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReachedType? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailedType? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResource? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceType? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AssistantMessageItemResourceRole? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource>? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResource? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEvent? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminator? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminatorType? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AccessProgramsUpdateParam? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionReasoningParam? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateSessionAgentParam? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateAgentSessionParams? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResource? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionResourceObject? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResource? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactResourceObject? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResource? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionArtifactListResourceObject? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionArtifactResource>? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResource? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalDecisionParam? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCallType? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParam? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamDiscriminator? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamDiscriminatorType? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResult? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMcpApprovalRequestResultType? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParam? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResult? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputParam? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParam? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminator? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminatorType? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSessionEventsParams? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResource? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnTraceResourceObject? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResource? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTraceListResourceObject? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnTraceResource>? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusParam? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusFilterParam? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResource? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultResourceObject? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResource? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultListResourceObject? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultResource>? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultParams? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateVaultParams? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResource? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultResourceObject? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthRefreshResource? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResource? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResource? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResource? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialResourceObject? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResource? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialListResourceObject? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultCredentialResource>? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthRefreshParam? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParam? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParam? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialParams? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthRefreshParam? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParam? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialParams? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResource? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointBody? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointListResource? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookEndpointBody>? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProjectEventTypeEnum? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicCreateEndpointBody? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointWithSecretResource? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicUpdateEndpointBody? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResource? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicRotateSecretBody? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PublicTestEndpointBody? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEndpointTestResultResource? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookEventTypeListResource? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentSessionConnectPayloadResource? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DragPoint? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormat? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminator? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminatorType? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialSessionAudioParam? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParams? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant12? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1Discriminator? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1DiscriminatorType? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartEventType? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsSettingsUpdateParam? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParam? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParams? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant13? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1Discriminator? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamType? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEventType? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParamType? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParamType? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParamType? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParamType? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCreateParamType? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParamType? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParamType? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParam? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamType? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamRole? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>>? Type4091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>? Type4092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item? Type4093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamContentVariant2ItemDiscriminator? Type4094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType? Type4095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionDeveloperMessageParam? Type4096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionDeveloperMessageParamType? Type4097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionDeveloperMessageParamRole? Type4098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>>? Type4099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>? Type4100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParam? Type4101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParamType? Type4102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParamRole? Type4103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParam? Type4104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParamType? Type4105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionRefusalParam? Type4106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionRefusalParamType? Type4107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMessagePhase? Type4108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParam? Type4109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamType? Type4110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamRole? Type4111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>>? Type4112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>? Type4113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item2? Type4114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminator? Type4115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType? Type4116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionCallItemStatus? Type4117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? Type4118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallParamType? Type4119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? Type4120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParamType? Type4121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item3>>? Type4122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item3>? Type4123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item3? Type4124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminator? Type4125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? Type4126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? Type4127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallParamType? Type4128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? Type4129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParamType? Type4130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item4>>? Type4131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item4>? Type4132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item4? Type4133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParamOutputVariant2ItemDiscriminator? Type4134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType? Type4135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParam? Type4136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? Type4137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1Type? Type4138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamDiscriminator? Type4139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamDiscriminatorType? Type4140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParamType? Type4141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType? Type4142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParamType? Type4143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParamType? Type4144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParamType? Type4145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkAudioParam? Type4146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionConfigParam? Type4147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEventType? Type4148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParam? Type4149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DelegationVariant14? Type4150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1Discriminator? Type4151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamDelegationVariant1DiscriminatorType? Type4152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResourceParamStatus? Type4153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStartedType? Type4154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdatedType? Type4155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionResumedType? Type4156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionPausedType? Type4157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMutedType? Type4158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmutedType? Type4159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType? Type4160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType? Type4161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendedType? Type4162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendedType? Type4163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendedType? Type4164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppend? Type4165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendType? Type4166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDelta? Type4167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDeltaType? Type4168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDeltaType? Type4169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDeltaType? Type4170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItem? Type4171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemType? Type4172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant3?>? Type4173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1? Type4174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2? Type4175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationItemTargetVariant3? Type4176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreatedType? Type4177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCompleted? Type4178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCompletedType? Type4179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventType? Type4180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1?, global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2?>? Type4181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1? Type4182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2? Type4183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParam? Type4184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamType? Type4185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamRole? Type4186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item3>>? Type4187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item3>? Type4188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item3? Type4189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminator? Type4190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType? Type4191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParam? Type4192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamType? Type4193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamRole? Type4194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredSystemMessageParam? Type4195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredSystemMessageParamType? Type4196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredSystemMessageParamRole? Type4197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParam? Type4198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamType? Type4199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamRole? Type4200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item4>>? Type4201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item4>? Type4202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant2Item4? Type4203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminator? Type4204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType? Type4205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? Type4206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParamType? Type4207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? Type4208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamType? Type4209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item5>>? Type4210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item5>? Type4211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item5? Type4212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminator? Type4213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? Type4214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? Type4215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParamType? Type4216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? Type4217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParamType? Type4218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item6>>? Type4219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item6>? Type4220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item6? Type4221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminator? Type4222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType? Type4223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam? Type4224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? Type4225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1Type? Type4226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminator? Type4227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType? Type4228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreatedType? Type4229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeletedType? Type4230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEventType? Type4231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsage? Type4232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContextWindowUsage? Type4233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdatedType? Type4234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedType? Type4235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1? Type4236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2? Type4237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3? Type4238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4? Type4239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5? Type4240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLiveError? Type4241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEventType? Type4242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEventType? Type4243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceivedType? Type4244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSentType? Type4245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRingingType? Type4246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnsweredType? Type4247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallError? Type4248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportCallErrorType? Type4249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailedType? Type4250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2Discriminator? Type4251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType? Type4252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParamType? Type4253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamType? Type4254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamRole? Type4255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>? Type4256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>? Type4257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item? Type4258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminator? Type4259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType? Type4260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResource? Type4261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsResourceObject? Type4262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTokenCountsBody? Type4263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? Type4264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>? Type4265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItem? Type4266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? Type4267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTool? Type4268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextParam? Type4269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoning? Type4270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTruncationEnum? Type4271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnum? Type4272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam? Type4273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceParam? Type4274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceOptions? Type4275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed? Type4276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypes? Type4277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunction? Type4278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCP? Type4279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustom? Type4280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? Type4281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? Type4282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? Type4283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType? Type4284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType? Type4285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType? Type4286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypesType? Type4287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowedMode? Type4288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaConversationParam2? Type4289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum? Type4290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnum? Type4291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningEffortEnum? Type4292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningSummary? Type4293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningContext? Type4294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningGenerateSummary? Type4295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? Type4296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration? Type4297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaVerbosityEnum? Type4298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatText? Type4299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? Type4300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject? Type4301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminator? Type4302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminatorType? Type4303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema? Type4304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionTool? Type4305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchTool? Type4306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerTool? Type4307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool? Type4308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchTool? Type4309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPTool? Type4310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool? Type4311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? Type4312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenTool? Type4313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParam? Type4314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam? Type4315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParam? Type4316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParam? Type4317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParam? Type4318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool? Type4319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam? Type4320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminator? Type4321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolDiscriminatorType? Type4322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParamType? Type4323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? Type4324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCallableToolAllowedCaller? Type4325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewToolType? Type4326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocation? Type4327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContextSize? Type4328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>? Type4329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSearchContentType? Type4330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApproximateLocationType? Type4331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParamType? Type4332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchExecutionType? Type4333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEmptyModelParam? Type4334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamType? Type4335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem6>? Type4336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem6? Type4337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParam? Type4338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator? Type4339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType? Type4340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamType? Type4341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format2? Type4342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam? Type4343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? Type4344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator? Type4345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType? Type4346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType? Type4347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaGrammarSyntax1? Type4348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParamType? Type4349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParamType? Type4350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamType? Type4351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant14? Type4352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParam? Type4353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam? Type4354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParam? Type4355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator? Type4356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type4357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParamType? Type4358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParamType? Type4359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>? Type4360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalSkillParam? Type4361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamType? Type4362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerMemoryLimit? Type4363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy3? Type4364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? Type4365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? Type4366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator? Type4367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType? Type4368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>? Type4369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SkillsItem3? Type4370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParam? Type4371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParam? Type4372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator? Type4373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType? Type4374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParamType? Type4375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParam? Type4376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamType? Type4377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType? Type4378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParamType? Type4379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType? Type4380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? Type4381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam? Type4382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType? Type4383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParamType? Type4384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>? Type4385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModel? Type4386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolComplexity? Type4387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolQuality? Type4388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>? Type4389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolSize? Type4390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolOutputFormat? Type4391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSvgParam? Type4392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolModeration? Type4393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolBackground? Type4394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFidelity? Type4395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolInputImageMask? Type4396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenActionEnum? Type4397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSvgReasoningParam? Type4398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType? Type4399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>? Type4400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam? Type4401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType? Type4402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NetworkPolicy5? Type4403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator? Type4404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? Type4405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolConnectorId? Type4406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>? Type4407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolFilter? Type4408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>? Type4409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum? Type4410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2? Type4411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolType? Type4412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolFilters? Type4413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation? Type4414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize? Type4415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewToolType? Type4416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerEnvironment? Type4417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolType? Type4418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolType? Type4419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankingOptions? Type4420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilters? Type4421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilter? Type4422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilter? Type4423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterType? Type4424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>? Type4425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FiltersItem2? Type4426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator? Type4427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilterType? Type4428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRankerVersionType? Type4429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHybridSearchOptions? Type4430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolType? Type4431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessage? Type4432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItem? Type4433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParam? Type4434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParam? Type4435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParam? Type4436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParam? Type4437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminator? Type4438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputItemDiscriminatorType? Type4439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTagParam? Type4440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemParamType? Type4441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputItemStatus? Type4442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramItemParamType? Type4443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemReferenceParamType? Type4444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType? Type4445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessage? Type4446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessage? Type4447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCall? Type4448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCall? Type4449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? Type4450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCall? Type4451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCall? Type4452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? Type4453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam? Type4454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? Type4455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? Type4456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam? Type4457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? Type4458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? Type4459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParam? Type4460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItem? Type4461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? Type4462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCall? Type4463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? Type4464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCall? Type4465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? Type4466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? Type4467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? Type4468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? Type4469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? Type4470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListTools? Type4471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest? Type4472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse? Type4473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCall? Type4474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? Type4475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCall? Type4476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminator? Type4477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminatorType? Type4478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentTag? Type4479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCaller? Type4480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller? Type4481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller? Type4482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminator? Type4483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType? Type4484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerType? Type4485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerType? Type4486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParam? Type4487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>? Type4488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>? Type4489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput? Type4490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContent? Type4491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContent? Type4492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContent? Type4493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminator? Type4494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType? Type4495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentType? Type4496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? Type4497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileInputDetail? Type4498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode? Type4499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigTtl? Type4500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentType? Type4501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageDetail? Type4502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentType? Type4503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? Type4504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? Type4505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminator? Type4506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType? Type4507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType? Type4508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType? Type4509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallError? Type4510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallStatus? Type4511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolError? Type4512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError? Type4513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPError? Type4514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator? Type4515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType? Type4516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPErrorType? Type4517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType? Type4518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolErrorType? Type4519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaMCPListToolsTool>? Type4520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListToolsTool? Type4521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType? Type4522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam? Type4523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType? Type4524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam? Type4525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParam? Type4526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? Type4527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? Type4528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? Type4529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminator? Type4530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType? Type4531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType? Type4532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType? Type4533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType? Type4534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType? Type4535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>? Type4536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam? Type4537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus? Type4538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam? Type4539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParam? Type4540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParam? Type4541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminator? Type4542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType? Type4543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType? Type4544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType? Type4545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType? Type4546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellActionParam? Type4547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant17? Type4548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator? Type4549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type4550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus? Type4551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecAction? Type4552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallStatus? Type4553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellExecActionType? Type4554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus? Type4555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>? Type4556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputsVariant1Item2? Type4557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? Type4558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? Type4559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator? Type4560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type4561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType? Type4562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType? Type4563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallType? Type4564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallStatus? Type4565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallError? Type4566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>? Type4567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1? Type4568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallQuality? Type4569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageBackground? Type4570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageOutputFormat? Type4571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSvgUsage? Type4572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetails? Type4573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage? Type4574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType? Type4575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent>? Type4576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContent? Type4577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>? Type4578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContent? Type4579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItemStatus? Type4580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContentType? Type4581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContentType? Type4582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning? Type4583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamText? Type4584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format7? Type4585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamTextFormatDiscriminator? Type4586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? Type4587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType? Type4588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole? Type4589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType? Type4590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaToolSearchOutputTool>? Type4591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputTool? Type4592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallItemStatus? Type4593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParam? Type4594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminator? Type4595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType? Type4596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType? Type4597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem16>? Type4598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolsItem16? Type4599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParam? Type4600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminator? Type4601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType? Type4602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType? Type4603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParamType? Type4604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType? Type4605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction1? Type4606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam>? Type4607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParam? Type4608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamType? Type4609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3>? Type4610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnnotationsItem3? Type4611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParam? Type4612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParam? Type4613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam? Type4614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator? Type4615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType? Type4616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParamType? Type4617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParamType? Type4618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParamType? Type4619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType? Type4620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamType? Type4621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6>? Type4622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem6? Type4623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParam? Type4624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? Type4625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParam? Type4626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminator? Type4627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType? Type4628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParamType? Type4629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType? Type4630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDetailEnum? Type4631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam? Type4632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode? Type4633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamTtl? Type4634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParamType? Type4635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType? Type4636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>? Type4637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>? Type4638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputVariant2Item2? Type4639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParam? Type4640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator? Type4641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type4642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParamType? Type4643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileDetailEnum? Type4644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallStatus? Type4645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchCallStatus? Type4646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallAction? Type4647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch? Type4648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? Type4649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFind? Type4650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminator? Type4651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType? Type4652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>? Type4653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearchSource? Type4654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType? Type4655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotImage? Type4656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? Type4657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam? Type4658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallType? Type4659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerAction? Type4660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>? Type4661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallStatus? Type4662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParam? Type4663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickAction? Type4664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParam? Type4665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressAction? Type4666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParam? Type4667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParam? Type4668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParam? Type4669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParam? Type4670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParam? Type4671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminator? Type4672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType? Type4673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParamType? Type4674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParamType? Type4675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParamType? Type4676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParamType? Type4677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParamType? Type4678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressActionType? Type4679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParamType? Type4680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam>? Type4681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCoordParam? Type4682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickActionType? Type4683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParamType? Type4684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickButtonType? Type4685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallStatus? Type4686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? Type4687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item? Type4688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputMessageContent>? Type4689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContent? Type4690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase? Type4691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageStatus? Type4692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContent? Type4693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContent? Type4694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminator? Type4695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType? Type4696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContentType? Type4697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentType? Type4698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>? Type4699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotation? Type4700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>? Type4701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLogProb? Type4702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>? Type4703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTopLogProb? Type4704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBody? Type4705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBody? Type4706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody? Type4707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePath? Type4708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminator? Type4709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType? Type4710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBodyType? Type4711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBodyType? Type4712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBodyType? Type4713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageRole? Type4714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageStatus? Type4715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>? Type4716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContent? Type4717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminator? Type4718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminatorType? Type4719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEasyInputMessageRole? Type4720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>? Type4721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResponseMethodPublicBody? Type4722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsCompaction? Type4723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageOptionsParam? Type4724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum? Type4725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsParam? Type4726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierEnum? Type4727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheTTLEnum? Type4728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheModeEnum? Type4729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageContextCompression? Type4730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Type4731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsShared? Type4732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? Type4733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum? Type4734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorResponse? Type4735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaError? Type4736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorDetailsResource? Type4737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorType? Type4738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentSteer? Type4739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? Type4740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseItemList? Type4741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemResource>? Type4742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResource? Type4743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResource? Type4744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? Type4745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResource? Type4746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource? Type4747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessage? Type4748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCall? Type4749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput? Type4750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCall? Type4751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutput? Type4752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalTools? Type4753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdate? Type4754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgram? Type4755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutput? Type4756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBody? Type4757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCall? Type4758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput? Type4759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall? Type4760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? Type4761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? Type4762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResource? Type4763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResource? Type4764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminator? Type4765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType? Type4766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? Type4767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum? Type4768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? Type4769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallStatus? Type4770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType? Type4771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus? Type4772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallType? Type4773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCallStatus? Type4774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Operation2? Type4775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? Type4776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? Type4777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? Type4778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminator? Type4779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType? Type4780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType? Type4781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType? Type4782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType? Type4783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputType? Type4784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum? Type4785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>? Type4786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent? Type4787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Outcome2? Type4788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? Type4789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? Type4790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminator? Type4791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? Type4792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType? Type4793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType? Type4794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallType? Type4795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellAction? Type4796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallStatus? Type4797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentVariant12? Type4798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource? Type4799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResource? Type4800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1Discriminator? Type4801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? Type4802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResourceType? Type4803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType? Type4804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBodyType? Type4805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputType? Type4806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutputStatus? Type4807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramType? Type4808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning? Type4809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateText? Type4810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Format5? Type4811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateTextFormatDiscriminator? Type4812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateTextFormatDiscriminatorType? Type4813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsType? Type4814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageRole? Type4815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputType? Type4816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallType? Type4817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputType? Type4818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentAction? Type4819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent>? Type4820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallType? Type4821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageType? Type4822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem4>? Type4823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem4? Type4824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContent? Type4825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent? Type4826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContent? Type4827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminator? Type4828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType? Type4829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentType? Type4830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContentType? Type4831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContentType? Type4832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? Type4833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? Type4834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus? Type4835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? Type4836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput? Type4837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? Type4838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputStatus? Type4839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus? Type4840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? Type4841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResource? Type4842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResolvedImageOptions? Type4843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactResourceObject? Type4844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemField>? Type4845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemField? Type4846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsage? Type4847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails? Type4848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCacheWriteTokensDetails? Type4849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails? Type4850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessage? Type4851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminator? Type4852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType? Type4853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageType? Type4854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageStatus? Type4855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem>? Type4856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentItem? Type4857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminator? Type4858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType? Type4859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessagePhase2? Type4860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResolvedImageContextCompressionEnum? Type4861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? Type4862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? Type4863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent? Type4864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponse? Type4865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponseProperties? Type4866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseProperties? Type4867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3? Type4868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaServiceTierResponsesEnum? Type4869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Truncation? Type4870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3Status? Type4871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsBody? Type4872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorVariant1? Type4873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetails? Type4874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason? Type4875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningInputTransformation>? Type4876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningInputTransformation? Type4877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputItem>? Type4878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItem? Type4879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseToolUsage? Type4880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptions? Type4881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnostics? Type4882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModeration? Type4883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConversation? Type4884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Input2? Type4885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBody? Type4886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBody? Type4887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminator? Type4888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType? Type4889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Output2? Type4890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminator? Type4891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType? Type4892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBodyType? Type4893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBodyType? Type4894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>>? Type4895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>? Type4896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputType? Type4897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? Type4898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? Type4899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? Type4900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? Type4901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator? Type4902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType? Type4903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType? Type4904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType? Type4905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType? Type4906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType? Type4907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum? Type4908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsTtl? Type4909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolUsage? Type4910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchUsage? Type4911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenOutputTokensDetails? Type4912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenInputUsageDetails? Type4913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCachedUsageDetails? Type4914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminator? Type4915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType? Type4916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningInputTransformationType? Type4917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningInputTransformationAction? Type4918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputRemovalReason? Type4919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorCode? Type4920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCyberAccessProgramEnum? Type4921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptVariant1? Type4922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>? Type4923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention? Type4924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? Type4925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? Type4926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? Type4927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? Type4928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? Type4929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? Type4930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? Type4931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? Type4932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? Type4933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? Type4934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? Type4935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? Type4936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? Type4937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? Type4938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? Type4939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? Type4940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? Type4941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? Type4942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus? Type4943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPart? Type4944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? Type4945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPart? Type4946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent? Type4947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProb>? Type4948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProb? Type4949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>? Type4950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob? Type4951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? Type4952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? Type4953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? Type4954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? Type4955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? Type4956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent? Type4957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent? Type4958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType? Type4959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent? Type4960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType? Type4961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaShellCallOutputDelta? Type4962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent? Type4963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType? Type4964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent? Type4965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType? Type4966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent? Type4967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType? Type4968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? Type4969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? Type4970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? Type4971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? Type4972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? Type4973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEvent? Type4974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent? Type4975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? Type4976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContent? Type4977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminator? Type4978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType? Type4979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? Type4980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent? Type4981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent? Type4982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType? Type4983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? Type4984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? Type4985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? Type4986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? Type4987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? Type4988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? Type4989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? Type4990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? Type4991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? Type4992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent? Type4993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEvent? Type4994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? Type4995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? Type4996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? Type4997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? Type4998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer? Type4999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInput? Type5000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventError? Type5001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCode? Type5002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? Type5003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerInputItem>? Type5004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItem? Type5005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParam? Type5006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminator? Type5007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType? Type5008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamType? Type5009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamRole? Type5010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>? Type5011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>? Type5012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContentVariant1Item2? Type5013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminator? Type5014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType? Type5015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? Type5016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEventSteer? Type5017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReason? Type5018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>? Type5019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInput? Type5020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? Type5021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? Type5022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? Type5023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? Type5024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? Type5025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? Type5026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? Type5027 { get; set; }
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
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventSteer? Type5032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerEvent? Type5033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputAudio? Type5034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudio? Type5035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudio? Type5036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputAudioInputAudioFormat? Type5037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputParam? Type5038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContent? Type5039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaIncludeEnum? Type5040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEvent? Type5041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? Type5042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2? Type5043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? Type5044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2? Type5045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? Type5046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2? Type5047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? Type5048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2? Type5049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2? Type5050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2? Type5051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2? Type5052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2? Type5053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2? Type5054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? Type5055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2? Type5056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? Type5057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2? Type5058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? Type5059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2? Type5060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? Type5061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2? Type5062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? Type5063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2? Type5064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? Type5065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2? Type5066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? Type5067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2? Type5068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? Type5069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2? Type5070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2? Type5071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? Type5072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2? Type5073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? Type5074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2? Type5075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? Type5076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2? Type5077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? Type5078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2? Type5079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2? Type5080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2? Type5081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? Type5082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2? Type5083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? Type5084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2? Type5085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? Type5086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2? Type5087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? Type5088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2? Type5089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? Type5090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2? Type5091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? Type5092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2? Type5093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? Type5094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2? Type5095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? Type5096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2? Type5097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? Type5098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2? Type5099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? Type5100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2? Type5101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? Type5102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2? Type5103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? Type5104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2? Type5105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? Type5106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2? Type5107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? Type5108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2? Type5109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? Type5110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2? Type5111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? Type5112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2? Type5113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? Type5114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2? Type5115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? Type5116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2? Type5117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? Type5118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2? Type5119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? Type5120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2? Type5121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? Type5122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2? Type5123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? Type5124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2? Type5125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? Type5126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2? Type5127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? Type5128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2? Type5129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? Type5130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2? Type5131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? Type5132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2? Type5133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? Type5134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2? Type5135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? Type5136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2? Type5137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? Type5138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2? Type5139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? Type5140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2? Type5141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? Type5142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2? Type5143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? Type5144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2? Type5145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? Type5146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2? Type5147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? Type5148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2? Type5149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsError? Type5150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? Type5151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? Type5152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminator? Type5153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType? Type5154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventError? Type5155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode? Type5156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaErrorPayload? Type5157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEvent? Type5158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesWebSocketStreamEventVariant2? Type5159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEvent? Type5160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? Type5161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEvent? Type5162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminator? Type5163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType? Type5164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? Type5165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponse? Type5166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties? Type5167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3? Type5168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAccessProgramsParam? Type5169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParam? Type5170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation? Type5171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? Type5172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationParam? Type5173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaBackgroundOptionsParam? Type5174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1? Type5175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>? Type5176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContextManagementParam? Type5177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentParam? Type5178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaBackgroundCompletionWindowEnum? Type5179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationPolicyParam? Type5180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationConfigParam? Type5181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationMode? Type5182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParamTtl? Type5183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? Type5184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEvent? Type5185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminator? Type5186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType? Type5187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateChatCompletionRequest? Type5188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateConversationItemsRequest? Type5189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UpdateEvalRequest? Type5190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysCreateRequest? Type5191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAssistantsOrder? Type5192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListChatCompletionsOrder? Type5193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetChatCompletionMessagesOrder? Type5194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainersOrder? Type5195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListContainerFilesOrder? Type5196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListConversationItemsOrder? Type5197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrder? Type5198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListEvalsOrderBy? Type5199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsOrder? Type5200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunsStatus? Type5201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? Type5202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? Type5203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesOrder? Type5204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? Type5205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysListOrder? Type5206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAuditLogsEffectiveAt? Type5207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>? Type5208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationCertificatesOrder? Type5209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>? Type5210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetCertificateIncludeItem? Type5211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsBucketWidth? Type5212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? Type5213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCostsGroupByItem? Type5214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupsOrder? Type5215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder? Type5216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListGroupUsersOrder? Type5217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess? Type5218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectCertificatesOrder? Type5219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupsOrder? Type5220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RetrieveProjectGroupGroupType? Type5221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? Type5222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRolesOrder? Type5223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder? Type5224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth? Type5225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>? Type5226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem? Type5227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth? Type5228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>? Type5229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem? Type5230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth? Type5231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? Type5232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem? Type5233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsBucketWidth? Type5234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>? Type5235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsGroupByItem? Type5236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth? Type5237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>? Type5238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem? Type5239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth? Type5240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>? Type5241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem? Type5242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesBucketWidth? Type5243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSource>? Type5244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSource? Type5245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSize>? Type5246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesSize? Type5247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesGroupByItem>? Type5248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesGroupByItem? Type5249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsBucketWidth? Type5250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageModerationsGroupByItem>? Type5251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsGroupByItem? Type5252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresBucketWidth? Type5253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>? Type5254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresGroupByItem? Type5255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth? Type5256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>? Type5257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel? Type5258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>? Type5259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem? Type5260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder? Type5261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectGroupRoleAssignmentsOrder? Type5262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectRolesOrder? Type5263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder? Type5264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListInputItemsOrder? Type5265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListMessagesOrder? Type5266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunsOrder? Type5267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? Type5268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateRunIncludeItem? Type5269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsOrder? Type5270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ListRunStepsIncludeItem>? Type5271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListRunStepsIncludeItem? Type5272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetRunStepIncludeItem>? Type5273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GetRunStepIncludeItem? Type5274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoresOrder? Type5275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? Type5276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? Type5277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesOrder? Type5278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListVectorStoreFilesFilter? Type5279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2?>? Type5280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1? Type5281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2? Type5282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant1? Type5283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant2? Type5284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? Type5285 { get; set; }
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
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationResponse, global::tryAGI.OpenAI.CreateCSAMModerationResponse>? Type5308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponse? Type5309 { get; set; }
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
        public global::tryAGI.OpenAI.ListAgentAutomationsResponse? Type5312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentAutomationsResponseObject? Type5313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AutomationResource>? Type5314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentAutomationInvocationsResponse? Type5315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentAutomationInvocationsResponseObject? Type5316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AutomationInvocationResource>? Type5317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponse? Type5318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject? Type5319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubagentResource>? Type5320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponse? Type5321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDeleteResponseResponseObject? Type5322 { get; set; }

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