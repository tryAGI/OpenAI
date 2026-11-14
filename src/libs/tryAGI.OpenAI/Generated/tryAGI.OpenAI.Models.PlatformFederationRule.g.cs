
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlatformFederationRule
    {
        /// <summary>
        /// Default Value: organization.workload_identity_federation_rule
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PlatformFederationRuleObject.OrganizationWorkloadIdentityFederationRule</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PlatformFederationRuleObjectJsonConverter))]
        public global::tryAGI.OpenAI.PlatformFederationRuleObject Object { get; set; } = global::tryAGI.OpenAI.PlatformFederationRuleObject.OrganizationWorkloadIdentityFederationRule;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_matchers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object AttributeMatchers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.DefaultPermissions, global::tryAGI.OpenAI.RestrictedPermissions>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissions, global::tryAGI.OpenAI.RestrictedPermissions> Permissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformFederationRule" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="projectId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="attributeMatchers"></param>
        /// <param name="permissions"></param>
        /// <param name="enabled"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="object">
        /// Default Value: organization.workload_identity_federation_rule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlatformFederationRule(
            string id,
            string workloadIdentityProviderId,
            string projectId,
            string serviceAccountId,
            object attributeMatchers,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissions, global::tryAGI.OpenAI.RestrictedPermissions> permissions,
            bool enabled,
            int createdAt,
            int updatedAt,
            string? name,
            string? description,
            global::tryAGI.OpenAI.PlatformFederationRuleObject @object = global::tryAGI.OpenAI.PlatformFederationRuleObject.OrganizationWorkloadIdentityFederationRule)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkloadIdentityProviderId = workloadIdentityProviderId ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProviderId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Name = name;
            this.Description = description;
            this.AttributeMatchers = attributeMatchers ?? throw new global::System.ArgumentNullException(nameof(attributeMatchers));
            this.Permissions = permissions;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformFederationRule" /> class.
        /// </summary>
        public PlatformFederationRule()
        {
        }

    }
}