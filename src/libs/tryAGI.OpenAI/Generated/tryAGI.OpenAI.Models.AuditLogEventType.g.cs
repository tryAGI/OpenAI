
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum AuditLogEventType
    {
        /// <summary>
        ///
        /// </summary>
        ApiKeyCreated,
        /// <summary>
        ///
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        ///
        /// </summary>
        ApiKeyUpdated,
        /// <summary>
        ///
        /// </summary>
        CertificateCreated,
        /// <summary>
        ///
        /// </summary>
        CertificateDeleted,
        /// <summary>
        ///
        /// </summary>
        CertificateUpdated,
        /// <summary>
        ///
        /// </summary>
        CertificatesActivated,
        /// <summary>
        ///
        /// </summary>
        CertificatesDeactivated,
        /// <summary>
        ///
        /// </summary>
        CheckpointPermissionCreated,
        /// <summary>
        ///
        /// </summary>
        CheckpointPermissionDeleted,
        /// <summary>
        ///
        /// </summary>
        ExternalKeyRegistered,
        /// <summary>
        ///
        /// </summary>
        ExternalKeyRemoved,
        /// <summary>
        ///
        /// </summary>
        GroupCreated,
        /// <summary>
        ///
        /// </summary>
        GroupDeleted,
        /// <summary>
        ///
        /// </summary>
        GroupUpdated,
        /// <summary>
        ///
        /// </summary>
        InviteAccepted,
        /// <summary>
        ///
        /// </summary>
        InviteDeleted,
        /// <summary>
        ///
        /// </summary>
        InviteSent,
        /// <summary>
        ///
        /// </summary>
        IpAllowlistConfigActivated,
        /// <summary>
        ///
        /// </summary>
        IpAllowlistConfigDeactivated,
        /// <summary>
        ///
        /// </summary>
        IpAllowlistCreated,
        /// <summary>
        ///
        /// </summary>
        IpAllowlistDeleted,
        /// <summary>
        ///
        /// </summary>
        IpAllowlistUpdated,
        /// <summary>
        ///
        /// </summary>
        LoginFailed,
        /// <summary>
        ///
        /// </summary>
        LoginSucceeded,
        /// <summary>
        ///
        /// </summary>
        LogoutFailed,
        /// <summary>
        ///
        /// </summary>
        LogoutSucceeded,
        /// <summary>
        ///
        /// </summary>
        OrganizationUpdated,
        /// <summary>
        ///
        /// </summary>
        ProjectArchived,
        /// <summary>
        ///
        /// </summary>
        ProjectCreated,
        /// <summary>
        ///
        /// </summary>
        ProjectDeleted,
        /// <summary>
        ///
        /// </summary>
        ProjectUpdated,
        /// <summary>
        ///
        /// </summary>
        RateLimitDeleted,
        /// <summary>
        ///
        /// </summary>
        RateLimitUpdated,
        /// <summary>
        ///
        /// </summary>
        ResourceDeleted,
        /// <summary>
        ///
        /// </summary>
        RoleAssignmentCreated,
        /// <summary>
        ///
        /// </summary>
        RoleAssignmentDeleted,
        /// <summary>
        ///
        /// </summary>
        RoleBoundToResource,
        /// <summary>
        ///
        /// </summary>
        RoleCreated,
        /// <summary>
        ///
        /// </summary>
        RoleDeleted,
        /// <summary>
        ///
        /// </summary>
        RoleUnboundFromResource,
        /// <summary>
        ///
        /// </summary>
        RoleUpdated,
        /// <summary>
        ///
        /// </summary>
        ScimDisabled,
        /// <summary>
        ///
        /// </summary>
        ScimEnabled,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountCreated,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountDeleted,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantAdminApiKeyCreated,
        /// <summary>
        ///
        /// </summary>
        TenantAdminApiKeyDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantAdminApiKeyUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantApiOrganizationInviteDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantApiOrganizationInviteUpserted,
        /// <summary>
        ///
        /// </summary>
        TenantBillingAlertsUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantBillingInfoUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantBillingOverageLimitUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantChatgptAccessTokenRevoked,
        /// <summary>
        ///
        /// </summary>
        TenantChatgptWorkspaceInviteUpserted,
        /// <summary>
        ///
        /// </summary>
        TenantCustomRoleCreated,
        /// <summary>
        ///
        /// </summary>
        TenantCustomRoleDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantCustomRoleUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantDomainsMigrated,
        /// <summary>
        ///
        /// </summary>
        TenantGroupCreated,
        /// <summary>
        ///
        /// </summary>
        TenantGroupDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantGroupMemberAdded,
        /// <summary>
        ///
        /// </summary>
        TenantGroupMemberRemoved,
        /// <summary>
        ///
        /// </summary>
        TenantGroupUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantMembershipAccepted,
        /// <summary>
        ///
        /// </summary>
        TenantMembershipDeclined,
        /// <summary>
        ///
        /// </summary>
        TenantMembershipRevoked,
        /// <summary>
        ///
        /// </summary>
        TenantMetadataUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantMicrosoftEntraMappingDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantMicrosoftEntraMappingUpserted,
        /// <summary>
        ///
        /// </summary>
        TenantMigrationCompleted,
        /// <summary>
        ///
        /// </summary>
        TenantMigrationRolloutStatusUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantMigrationRolloutTierUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantPolicyAttached,
        /// <summary>
        ///
        /// </summary>
        TenantPolicyCreated,
        /// <summary>
        ///
        /// </summary>
        TenantPolicyDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantPolicyDetached,
        /// <summary>
        ///
        /// </summary>
        TenantPolicyUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantPrincipalAuthenticationPolicyResolved,
        /// <summary>
        ///
        /// </summary>
        TenantProductAccessPolicyUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantProjectApiKeyCreated,
        /// <summary>
        ///
        /// </summary>
        TenantResourceAccessDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantResourceAccessUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantResourceRoleAssignmentCreated,
        /// <summary>
        ///
        /// </summary>
        TenantResourceRoleAssignmentDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantResourceShareGrantAccepted,
        /// <summary>
        ///
        /// </summary>
        TenantResourceShareGrantCreated,
        /// <summary>
        ///
        /// </summary>
        TenantResourceShareGrantDeclined,
        /// <summary>
        ///
        /// </summary>
        TenantResourceShareGrantDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantResourceShareGrantRevoked,
        /// <summary>
        ///
        /// </summary>
        TenantResourceShareGrantUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantRoleMetadataUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantRoleAssignmentCreated,
        /// <summary>
        ///
        /// </summary>
        TenantRoleAssignmentDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantScimDeletionRequested,
        /// <summary>
        ///
        /// </summary>
        TenantScimDirectoryCreated,
        /// <summary>
        ///
        /// </summary>
        TenantScimSetupStarted,
        /// <summary>
        ///
        /// </summary>
        TenantServiceAccountDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantServiceAccountTokenRevoked,
        /// <summary>
        ///
        /// </summary>
        TenantServiceAccountUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantSessionPolicyCreated,
        /// <summary>
        ///
        /// </summary>
        TenantSessionPolicyDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantSessionPolicyUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantSessionRevocationStarted,
        /// <summary>
        ///
        /// </summary>
        TenantSsoMigrated,
        /// <summary>
        ///
        /// </summary>
        TenantSsoConnectionCreated,
        /// <summary>
        ///
        /// </summary>
        TenantSsoConnectionDeleted,
        /// <summary>
        ///
        /// </summary>
        TenantSsoConnectionSetupStarted,
        /// <summary>
        ///
        /// </summary>
        TenantSsoConnectionUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantThirdPartyAppPolicyUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantUsageLimitGroupUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantUsageLimitIncreaseRequestResolved,
        /// <summary>
        ///
        /// </summary>
        TenantUsageLimitIncreaseRequestUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantUsageLimitUserUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantUsageLimitWorkspaceUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantUserAdded,
        /// <summary>
        ///
        /// </summary>
        TenantUserInvited,
        /// <summary>
        ///
        /// </summary>
        TenantUserLookedUp,
        /// <summary>
        ///
        /// </summary>
        TenantUserRemoved,
        /// <summary>
        ///
        /// </summary>
        TenantUserUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityBindingCreated,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityMappingArchived,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityMappingCreated,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityMappingUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityPrincipalProvisioned,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityProviderArchived,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityProviderCreated,
        /// <summary>
        ///
        /// </summary>
        TenantWorkloadIdentityProviderUpdated,
        /// <summary>
        ///
        /// </summary>
        TenantWorkspaceInviteEmailSettingsUpdated,
        /// <summary>
        ///
        /// </summary>
        TunnelCreated,
        /// <summary>
        ///
        /// </summary>
        TunnelDeleted,
        /// <summary>
        ///
        /// </summary>
        TunnelUpdated,
        /// <summary>
        ///
        /// </summary>
        UserAdded,
        /// <summary>
        ///
        /// </summary>
        UserDeleted,
        /// <summary>
        ///
        /// </summary>
        UserUpdated,
        /// <summary>
        ///
        /// </summary>
        WorkloadIdentityProviderCreated,
        /// <summary>
        ///
        /// </summary>
        WorkloadIdentityProviderDeleted,
        /// <summary>
        ///
        /// </summary>
        WorkloadIdentityProviderUpdated,
        /// <summary>
        ///
        /// </summary>
        WorkloadIdentityProviderMappingCreated,
        /// <summary>
        ///
        /// </summary>
        WorkloadIdentityProviderMappingDeleted,
        /// <summary>
        ///
        /// </summary>
        WorkloadIdentityProviderMappingUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEventType value)
        {
            return value switch
            {
                AuditLogEventType.ApiKeyCreated => "api_key.created",
                AuditLogEventType.ApiKeyDeleted => "api_key.deleted",
                AuditLogEventType.ApiKeyUpdated => "api_key.updated",
                AuditLogEventType.CertificateCreated => "certificate.created",
                AuditLogEventType.CertificateDeleted => "certificate.deleted",
                AuditLogEventType.CertificateUpdated => "certificate.updated",
                AuditLogEventType.CertificatesActivated => "certificates.activated",
                AuditLogEventType.CertificatesDeactivated => "certificates.deactivated",
                AuditLogEventType.CheckpointPermissionCreated => "checkpoint.permission.created",
                AuditLogEventType.CheckpointPermissionDeleted => "checkpoint.permission.deleted",
                AuditLogEventType.ExternalKeyRegistered => "external_key.registered",
                AuditLogEventType.ExternalKeyRemoved => "external_key.removed",
                AuditLogEventType.GroupCreated => "group.created",
                AuditLogEventType.GroupDeleted => "group.deleted",
                AuditLogEventType.GroupUpdated => "group.updated",
                AuditLogEventType.InviteAccepted => "invite.accepted",
                AuditLogEventType.InviteDeleted => "invite.deleted",
                AuditLogEventType.InviteSent => "invite.sent",
                AuditLogEventType.IpAllowlistConfigActivated => "ip_allowlist.config.activated",
                AuditLogEventType.IpAllowlistConfigDeactivated => "ip_allowlist.config.deactivated",
                AuditLogEventType.IpAllowlistCreated => "ip_allowlist.created",
                AuditLogEventType.IpAllowlistDeleted => "ip_allowlist.deleted",
                AuditLogEventType.IpAllowlistUpdated => "ip_allowlist.updated",
                AuditLogEventType.LoginFailed => "login.failed",
                AuditLogEventType.LoginSucceeded => "login.succeeded",
                AuditLogEventType.LogoutFailed => "logout.failed",
                AuditLogEventType.LogoutSucceeded => "logout.succeeded",
                AuditLogEventType.OrganizationUpdated => "organization.updated",
                AuditLogEventType.ProjectArchived => "project.archived",
                AuditLogEventType.ProjectCreated => "project.created",
                AuditLogEventType.ProjectDeleted => "project.deleted",
                AuditLogEventType.ProjectUpdated => "project.updated",
                AuditLogEventType.RateLimitDeleted => "rate_limit.deleted",
                AuditLogEventType.RateLimitUpdated => "rate_limit.updated",
                AuditLogEventType.ResourceDeleted => "resource.deleted",
                AuditLogEventType.RoleAssignmentCreated => "role.assignment.created",
                AuditLogEventType.RoleAssignmentDeleted => "role.assignment.deleted",
                AuditLogEventType.RoleBoundToResource => "role.bound_to_resource",
                AuditLogEventType.RoleCreated => "role.created",
                AuditLogEventType.RoleDeleted => "role.deleted",
                AuditLogEventType.RoleUnboundFromResource => "role.unbound_from_resource",
                AuditLogEventType.RoleUpdated => "role.updated",
                AuditLogEventType.ScimDisabled => "scim.disabled",
                AuditLogEventType.ScimEnabled => "scim.enabled",
                AuditLogEventType.ServiceAccountCreated => "service_account.created",
                AuditLogEventType.ServiceAccountDeleted => "service_account.deleted",
                AuditLogEventType.ServiceAccountUpdated => "service_account.updated",
                AuditLogEventType.TenantAdminApiKeyCreated => "tenant.admin_api_key.created",
                AuditLogEventType.TenantAdminApiKeyDeleted => "tenant.admin_api_key.deleted",
                AuditLogEventType.TenantAdminApiKeyUpdated => "tenant.admin_api_key.updated",
                AuditLogEventType.TenantApiOrganizationInviteDeleted => "tenant.api_organization_invite.deleted",
                AuditLogEventType.TenantApiOrganizationInviteUpserted => "tenant.api_organization_invite.upserted",
                AuditLogEventType.TenantBillingAlertsUpdated => "tenant.billing.alerts.updated",
                AuditLogEventType.TenantBillingInfoUpdated => "tenant.billing.info.updated",
                AuditLogEventType.TenantBillingOverageLimitUpdated => "tenant.billing.overage_limit.updated",
                AuditLogEventType.TenantChatgptAccessTokenRevoked => "tenant.chatgpt_access_token.revoked",
                AuditLogEventType.TenantChatgptWorkspaceInviteUpserted => "tenant.chatgpt_workspace_invite.upserted",
                AuditLogEventType.TenantCustomRoleCreated => "tenant.custom_role.created",
                AuditLogEventType.TenantCustomRoleDeleted => "tenant.custom_role.deleted",
                AuditLogEventType.TenantCustomRoleUpdated => "tenant.custom_role.updated",
                AuditLogEventType.TenantDomainsMigrated => "tenant.domains.migrated",
                AuditLogEventType.TenantGroupCreated => "tenant.group.created",
                AuditLogEventType.TenantGroupDeleted => "tenant.group.deleted",
                AuditLogEventType.TenantGroupMemberAdded => "tenant.group.member.added",
                AuditLogEventType.TenantGroupMemberRemoved => "tenant.group.member.removed",
                AuditLogEventType.TenantGroupUpdated => "tenant.group.updated",
                AuditLogEventType.TenantMembershipAccepted => "tenant.membership.accepted",
                AuditLogEventType.TenantMembershipDeclined => "tenant.membership.declined",
                AuditLogEventType.TenantMembershipRevoked => "tenant.membership.revoked",
                AuditLogEventType.TenantMetadataUpdated => "tenant.metadata.updated",
                AuditLogEventType.TenantMicrosoftEntraMappingDeleted => "tenant.microsoft_entra_mapping.deleted",
                AuditLogEventType.TenantMicrosoftEntraMappingUpserted => "tenant.microsoft_entra_mapping.upserted",
                AuditLogEventType.TenantMigrationCompleted => "tenant.migration.completed",
                AuditLogEventType.TenantMigrationRolloutStatusUpdated => "tenant.migration_rollout.status.updated",
                AuditLogEventType.TenantMigrationRolloutTierUpdated => "tenant.migration_rollout.tier.updated",
                AuditLogEventType.TenantPolicyAttached => "tenant.policy.attached",
                AuditLogEventType.TenantPolicyCreated => "tenant.policy.created",
                AuditLogEventType.TenantPolicyDeleted => "tenant.policy.deleted",
                AuditLogEventType.TenantPolicyDetached => "tenant.policy.detached",
                AuditLogEventType.TenantPolicyUpdated => "tenant.policy.updated",
                AuditLogEventType.TenantPrincipalAuthenticationPolicyResolved => "tenant.principal_authentication_policy.resolved",
                AuditLogEventType.TenantProductAccessPolicyUpdated => "tenant.product_access_policy.updated",
                AuditLogEventType.TenantProjectApiKeyCreated => "tenant.project_api_key.created",
                AuditLogEventType.TenantResourceAccessDeleted => "tenant.resource_access.deleted",
                AuditLogEventType.TenantResourceAccessUpdated => "tenant.resource_access.updated",
                AuditLogEventType.TenantResourceRoleAssignmentCreated => "tenant.resource_role_assignment.created",
                AuditLogEventType.TenantResourceRoleAssignmentDeleted => "tenant.resource_role_assignment.deleted",
                AuditLogEventType.TenantResourceShareGrantAccepted => "tenant.resource_share_grant.accepted",
                AuditLogEventType.TenantResourceShareGrantCreated => "tenant.resource_share_grant.created",
                AuditLogEventType.TenantResourceShareGrantDeclined => "tenant.resource_share_grant.declined",
                AuditLogEventType.TenantResourceShareGrantDeleted => "tenant.resource_share_grant.deleted",
                AuditLogEventType.TenantResourceShareGrantRevoked => "tenant.resource_share_grant.revoked",
                AuditLogEventType.TenantResourceShareGrantUpdated => "tenant.resource_share_grant.updated",
                AuditLogEventType.TenantRoleMetadataUpdated => "tenant.role.metadata.updated",
                AuditLogEventType.TenantRoleAssignmentCreated => "tenant.role_assignment.created",
                AuditLogEventType.TenantRoleAssignmentDeleted => "tenant.role_assignment.deleted",
                AuditLogEventType.TenantScimDeletionRequested => "tenant.scim.deletion.requested",
                AuditLogEventType.TenantScimDirectoryCreated => "tenant.scim.directory.created",
                AuditLogEventType.TenantScimSetupStarted => "tenant.scim.setup.started",
                AuditLogEventType.TenantServiceAccountDeleted => "tenant.service_account.deleted",
                AuditLogEventType.TenantServiceAccountTokenRevoked => "tenant.service_account.token.revoked",
                AuditLogEventType.TenantServiceAccountUpdated => "tenant.service_account.updated",
                AuditLogEventType.TenantSessionPolicyCreated => "tenant.session_policy.created",
                AuditLogEventType.TenantSessionPolicyDeleted => "tenant.session_policy.deleted",
                AuditLogEventType.TenantSessionPolicyUpdated => "tenant.session_policy.updated",
                AuditLogEventType.TenantSessionRevocationStarted => "tenant.session_revocation.started",
                AuditLogEventType.TenantSsoMigrated => "tenant.sso.migrated",
                AuditLogEventType.TenantSsoConnectionCreated => "tenant.sso_connection.created",
                AuditLogEventType.TenantSsoConnectionDeleted => "tenant.sso_connection.deleted",
                AuditLogEventType.TenantSsoConnectionSetupStarted => "tenant.sso_connection.setup.started",
                AuditLogEventType.TenantSsoConnectionUpdated => "tenant.sso_connection.updated",
                AuditLogEventType.TenantThirdPartyAppPolicyUpdated => "tenant.third_party_app_policy.updated",
                AuditLogEventType.TenantUsageLimitGroupUpdated => "tenant.usage_limit.group.updated",
                AuditLogEventType.TenantUsageLimitIncreaseRequestResolved => "tenant.usage_limit.increase_request.resolved",
                AuditLogEventType.TenantUsageLimitIncreaseRequestUpdated => "tenant.usage_limit.increase_request.updated",
                AuditLogEventType.TenantUsageLimitUserUpdated => "tenant.usage_limit.user.updated",
                AuditLogEventType.TenantUsageLimitWorkspaceUpdated => "tenant.usage_limit.workspace.updated",
                AuditLogEventType.TenantUserAdded => "tenant.user.added",
                AuditLogEventType.TenantUserInvited => "tenant.user.invited",
                AuditLogEventType.TenantUserLookedUp => "tenant.user.looked_up",
                AuditLogEventType.TenantUserRemoved => "tenant.user.removed",
                AuditLogEventType.TenantUserUpdated => "tenant.user.updated",
                AuditLogEventType.TenantWorkloadIdentityBindingCreated => "tenant.workload_identity.binding.created",
                AuditLogEventType.TenantWorkloadIdentityMappingArchived => "tenant.workload_identity.mapping.archived",
                AuditLogEventType.TenantWorkloadIdentityMappingCreated => "tenant.workload_identity.mapping.created",
                AuditLogEventType.TenantWorkloadIdentityMappingUpdated => "tenant.workload_identity.mapping.updated",
                AuditLogEventType.TenantWorkloadIdentityPrincipalProvisioned => "tenant.workload_identity.principal.provisioned",
                AuditLogEventType.TenantWorkloadIdentityProviderArchived => "tenant.workload_identity.provider.archived",
                AuditLogEventType.TenantWorkloadIdentityProviderCreated => "tenant.workload_identity.provider.created",
                AuditLogEventType.TenantWorkloadIdentityProviderUpdated => "tenant.workload_identity.provider.updated",
                AuditLogEventType.TenantWorkspaceInviteEmailSettingsUpdated => "tenant.workspace_invite_email_settings.updated",
                AuditLogEventType.TunnelCreated => "tunnel.created",
                AuditLogEventType.TunnelDeleted => "tunnel.deleted",
                AuditLogEventType.TunnelUpdated => "tunnel.updated",
                AuditLogEventType.UserAdded => "user.added",
                AuditLogEventType.UserDeleted => "user.deleted",
                AuditLogEventType.UserUpdated => "user.updated",
                AuditLogEventType.WorkloadIdentityProviderCreated => "workload_identity_provider.created",
                AuditLogEventType.WorkloadIdentityProviderDeleted => "workload_identity_provider.deleted",
                AuditLogEventType.WorkloadIdentityProviderUpdated => "workload_identity_provider.updated",
                AuditLogEventType.WorkloadIdentityProviderMappingCreated => "workload_identity_provider_mapping.created",
                AuditLogEventType.WorkloadIdentityProviderMappingDeleted => "workload_identity_provider_mapping.deleted",
                AuditLogEventType.WorkloadIdentityProviderMappingUpdated => "workload_identity_provider_mapping.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEventType? ToEnum(string value)
        {
            return value switch
            {
                "api_key.created" => AuditLogEventType.ApiKeyCreated,
                "api_key.deleted" => AuditLogEventType.ApiKeyDeleted,
                "api_key.updated" => AuditLogEventType.ApiKeyUpdated,
                "certificate.created" => AuditLogEventType.CertificateCreated,
                "certificate.deleted" => AuditLogEventType.CertificateDeleted,
                "certificate.updated" => AuditLogEventType.CertificateUpdated,
                "certificates.activated" => AuditLogEventType.CertificatesActivated,
                "certificates.deactivated" => AuditLogEventType.CertificatesDeactivated,
                "checkpoint.permission.created" => AuditLogEventType.CheckpointPermissionCreated,
                "checkpoint.permission.deleted" => AuditLogEventType.CheckpointPermissionDeleted,
                "external_key.registered" => AuditLogEventType.ExternalKeyRegistered,
                "external_key.removed" => AuditLogEventType.ExternalKeyRemoved,
                "group.created" => AuditLogEventType.GroupCreated,
                "group.deleted" => AuditLogEventType.GroupDeleted,
                "group.updated" => AuditLogEventType.GroupUpdated,
                "invite.accepted" => AuditLogEventType.InviteAccepted,
                "invite.deleted" => AuditLogEventType.InviteDeleted,
                "invite.sent" => AuditLogEventType.InviteSent,
                "ip_allowlist.config.activated" => AuditLogEventType.IpAllowlistConfigActivated,
                "ip_allowlist.config.deactivated" => AuditLogEventType.IpAllowlistConfigDeactivated,
                "ip_allowlist.created" => AuditLogEventType.IpAllowlistCreated,
                "ip_allowlist.deleted" => AuditLogEventType.IpAllowlistDeleted,
                "ip_allowlist.updated" => AuditLogEventType.IpAllowlistUpdated,
                "login.failed" => AuditLogEventType.LoginFailed,
                "login.succeeded" => AuditLogEventType.LoginSucceeded,
                "logout.failed" => AuditLogEventType.LogoutFailed,
                "logout.succeeded" => AuditLogEventType.LogoutSucceeded,
                "organization.updated" => AuditLogEventType.OrganizationUpdated,
                "project.archived" => AuditLogEventType.ProjectArchived,
                "project.created" => AuditLogEventType.ProjectCreated,
                "project.deleted" => AuditLogEventType.ProjectDeleted,
                "project.updated" => AuditLogEventType.ProjectUpdated,
                "rate_limit.deleted" => AuditLogEventType.RateLimitDeleted,
                "rate_limit.updated" => AuditLogEventType.RateLimitUpdated,
                "resource.deleted" => AuditLogEventType.ResourceDeleted,
                "role.assignment.created" => AuditLogEventType.RoleAssignmentCreated,
                "role.assignment.deleted" => AuditLogEventType.RoleAssignmentDeleted,
                "role.bound_to_resource" => AuditLogEventType.RoleBoundToResource,
                "role.created" => AuditLogEventType.RoleCreated,
                "role.deleted" => AuditLogEventType.RoleDeleted,
                "role.unbound_from_resource" => AuditLogEventType.RoleUnboundFromResource,
                "role.updated" => AuditLogEventType.RoleUpdated,
                "scim.disabled" => AuditLogEventType.ScimDisabled,
                "scim.enabled" => AuditLogEventType.ScimEnabled,
                "service_account.created" => AuditLogEventType.ServiceAccountCreated,
                "service_account.deleted" => AuditLogEventType.ServiceAccountDeleted,
                "service_account.updated" => AuditLogEventType.ServiceAccountUpdated,
                "tenant.admin_api_key.created" => AuditLogEventType.TenantAdminApiKeyCreated,
                "tenant.admin_api_key.deleted" => AuditLogEventType.TenantAdminApiKeyDeleted,
                "tenant.admin_api_key.updated" => AuditLogEventType.TenantAdminApiKeyUpdated,
                "tenant.api_organization_invite.deleted" => AuditLogEventType.TenantApiOrganizationInviteDeleted,
                "tenant.api_organization_invite.upserted" => AuditLogEventType.TenantApiOrganizationInviteUpserted,
                "tenant.billing.alerts.updated" => AuditLogEventType.TenantBillingAlertsUpdated,
                "tenant.billing.info.updated" => AuditLogEventType.TenantBillingInfoUpdated,
                "tenant.billing.overage_limit.updated" => AuditLogEventType.TenantBillingOverageLimitUpdated,
                "tenant.chatgpt_access_token.revoked" => AuditLogEventType.TenantChatgptAccessTokenRevoked,
                "tenant.chatgpt_workspace_invite.upserted" => AuditLogEventType.TenantChatgptWorkspaceInviteUpserted,
                "tenant.custom_role.created" => AuditLogEventType.TenantCustomRoleCreated,
                "tenant.custom_role.deleted" => AuditLogEventType.TenantCustomRoleDeleted,
                "tenant.custom_role.updated" => AuditLogEventType.TenantCustomRoleUpdated,
                "tenant.domains.migrated" => AuditLogEventType.TenantDomainsMigrated,
                "tenant.group.created" => AuditLogEventType.TenantGroupCreated,
                "tenant.group.deleted" => AuditLogEventType.TenantGroupDeleted,
                "tenant.group.member.added" => AuditLogEventType.TenantGroupMemberAdded,
                "tenant.group.member.removed" => AuditLogEventType.TenantGroupMemberRemoved,
                "tenant.group.updated" => AuditLogEventType.TenantGroupUpdated,
                "tenant.membership.accepted" => AuditLogEventType.TenantMembershipAccepted,
                "tenant.membership.declined" => AuditLogEventType.TenantMembershipDeclined,
                "tenant.membership.revoked" => AuditLogEventType.TenantMembershipRevoked,
                "tenant.metadata.updated" => AuditLogEventType.TenantMetadataUpdated,
                "tenant.microsoft_entra_mapping.deleted" => AuditLogEventType.TenantMicrosoftEntraMappingDeleted,
                "tenant.microsoft_entra_mapping.upserted" => AuditLogEventType.TenantMicrosoftEntraMappingUpserted,
                "tenant.migration.completed" => AuditLogEventType.TenantMigrationCompleted,
                "tenant.migration_rollout.status.updated" => AuditLogEventType.TenantMigrationRolloutStatusUpdated,
                "tenant.migration_rollout.tier.updated" => AuditLogEventType.TenantMigrationRolloutTierUpdated,
                "tenant.policy.attached" => AuditLogEventType.TenantPolicyAttached,
                "tenant.policy.created" => AuditLogEventType.TenantPolicyCreated,
                "tenant.policy.deleted" => AuditLogEventType.TenantPolicyDeleted,
                "tenant.policy.detached" => AuditLogEventType.TenantPolicyDetached,
                "tenant.policy.updated" => AuditLogEventType.TenantPolicyUpdated,
                "tenant.principal_authentication_policy.resolved" => AuditLogEventType.TenantPrincipalAuthenticationPolicyResolved,
                "tenant.product_access_policy.updated" => AuditLogEventType.TenantProductAccessPolicyUpdated,
                "tenant.project_api_key.created" => AuditLogEventType.TenantProjectApiKeyCreated,
                "tenant.resource_access.deleted" => AuditLogEventType.TenantResourceAccessDeleted,
                "tenant.resource_access.updated" => AuditLogEventType.TenantResourceAccessUpdated,
                "tenant.resource_role_assignment.created" => AuditLogEventType.TenantResourceRoleAssignmentCreated,
                "tenant.resource_role_assignment.deleted" => AuditLogEventType.TenantResourceRoleAssignmentDeleted,
                "tenant.resource_share_grant.accepted" => AuditLogEventType.TenantResourceShareGrantAccepted,
                "tenant.resource_share_grant.created" => AuditLogEventType.TenantResourceShareGrantCreated,
                "tenant.resource_share_grant.declined" => AuditLogEventType.TenantResourceShareGrantDeclined,
                "tenant.resource_share_grant.deleted" => AuditLogEventType.TenantResourceShareGrantDeleted,
                "tenant.resource_share_grant.revoked" => AuditLogEventType.TenantResourceShareGrantRevoked,
                "tenant.resource_share_grant.updated" => AuditLogEventType.TenantResourceShareGrantUpdated,
                "tenant.role.metadata.updated" => AuditLogEventType.TenantRoleMetadataUpdated,
                "tenant.role_assignment.created" => AuditLogEventType.TenantRoleAssignmentCreated,
                "tenant.role_assignment.deleted" => AuditLogEventType.TenantRoleAssignmentDeleted,
                "tenant.scim.deletion.requested" => AuditLogEventType.TenantScimDeletionRequested,
                "tenant.scim.directory.created" => AuditLogEventType.TenantScimDirectoryCreated,
                "tenant.scim.setup.started" => AuditLogEventType.TenantScimSetupStarted,
                "tenant.service_account.deleted" => AuditLogEventType.TenantServiceAccountDeleted,
                "tenant.service_account.token.revoked" => AuditLogEventType.TenantServiceAccountTokenRevoked,
                "tenant.service_account.updated" => AuditLogEventType.TenantServiceAccountUpdated,
                "tenant.session_policy.created" => AuditLogEventType.TenantSessionPolicyCreated,
                "tenant.session_policy.deleted" => AuditLogEventType.TenantSessionPolicyDeleted,
                "tenant.session_policy.updated" => AuditLogEventType.TenantSessionPolicyUpdated,
                "tenant.session_revocation.started" => AuditLogEventType.TenantSessionRevocationStarted,
                "tenant.sso.migrated" => AuditLogEventType.TenantSsoMigrated,
                "tenant.sso_connection.created" => AuditLogEventType.TenantSsoConnectionCreated,
                "tenant.sso_connection.deleted" => AuditLogEventType.TenantSsoConnectionDeleted,
                "tenant.sso_connection.setup.started" => AuditLogEventType.TenantSsoConnectionSetupStarted,
                "tenant.sso_connection.updated" => AuditLogEventType.TenantSsoConnectionUpdated,
                "tenant.third_party_app_policy.updated" => AuditLogEventType.TenantThirdPartyAppPolicyUpdated,
                "tenant.usage_limit.group.updated" => AuditLogEventType.TenantUsageLimitGroupUpdated,
                "tenant.usage_limit.increase_request.resolved" => AuditLogEventType.TenantUsageLimitIncreaseRequestResolved,
                "tenant.usage_limit.increase_request.updated" => AuditLogEventType.TenantUsageLimitIncreaseRequestUpdated,
                "tenant.usage_limit.user.updated" => AuditLogEventType.TenantUsageLimitUserUpdated,
                "tenant.usage_limit.workspace.updated" => AuditLogEventType.TenantUsageLimitWorkspaceUpdated,
                "tenant.user.added" => AuditLogEventType.TenantUserAdded,
                "tenant.user.invited" => AuditLogEventType.TenantUserInvited,
                "tenant.user.looked_up" => AuditLogEventType.TenantUserLookedUp,
                "tenant.user.removed" => AuditLogEventType.TenantUserRemoved,
                "tenant.user.updated" => AuditLogEventType.TenantUserUpdated,
                "tenant.workload_identity.binding.created" => AuditLogEventType.TenantWorkloadIdentityBindingCreated,
                "tenant.workload_identity.mapping.archived" => AuditLogEventType.TenantWorkloadIdentityMappingArchived,
                "tenant.workload_identity.mapping.created" => AuditLogEventType.TenantWorkloadIdentityMappingCreated,
                "tenant.workload_identity.mapping.updated" => AuditLogEventType.TenantWorkloadIdentityMappingUpdated,
                "tenant.workload_identity.principal.provisioned" => AuditLogEventType.TenantWorkloadIdentityPrincipalProvisioned,
                "tenant.workload_identity.provider.archived" => AuditLogEventType.TenantWorkloadIdentityProviderArchived,
                "tenant.workload_identity.provider.created" => AuditLogEventType.TenantWorkloadIdentityProviderCreated,
                "tenant.workload_identity.provider.updated" => AuditLogEventType.TenantWorkloadIdentityProviderUpdated,
                "tenant.workspace_invite_email_settings.updated" => AuditLogEventType.TenantWorkspaceInviteEmailSettingsUpdated,
                "tunnel.created" => AuditLogEventType.TunnelCreated,
                "tunnel.deleted" => AuditLogEventType.TunnelDeleted,
                "tunnel.updated" => AuditLogEventType.TunnelUpdated,
                "user.added" => AuditLogEventType.UserAdded,
                "user.deleted" => AuditLogEventType.UserDeleted,
                "user.updated" => AuditLogEventType.UserUpdated,
                "workload_identity_provider.created" => AuditLogEventType.WorkloadIdentityProviderCreated,
                "workload_identity_provider.deleted" => AuditLogEventType.WorkloadIdentityProviderDeleted,
                "workload_identity_provider.updated" => AuditLogEventType.WorkloadIdentityProviderUpdated,
                "workload_identity_provider_mapping.created" => AuditLogEventType.WorkloadIdentityProviderMappingCreated,
                "workload_identity_provider_mapping.deleted" => AuditLogEventType.WorkloadIdentityProviderMappingDeleted,
                "workload_identity_provider_mapping.updated" => AuditLogEventType.WorkloadIdentityProviderMappingUpdated,
                _ => null,
            };
        }
    }
}