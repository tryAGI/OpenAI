
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePlatformWorkloadIdentityFederationRuleBody
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.DefaultPermissionsParam, global::tryAGI.OpenAI.RestrictedPermissionsParam>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissionsParam, global::tryAGI.OpenAI.RestrictedPermissionsParam>? Permissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlatformWorkloadIdentityFederationRuleBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="attributeMatchers"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="permissions"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePlatformWorkloadIdentityFederationRuleBody(
            string projectId,
            string serviceAccountId,
            object attributeMatchers,
            string? name,
            string? description,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissionsParam, global::tryAGI.OpenAI.RestrictedPermissionsParam>? permissions,
            bool? enabled)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Name = name;
            this.Description = description;
            this.AttributeMatchers = attributeMatchers ?? throw new global::System.ArgumentNullException(nameof(attributeMatchers));
            this.Permissions = permissions;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlatformWorkloadIdentityFederationRuleBody" /> class.
        /// </summary>
        public CreatePlatformWorkloadIdentityFederationRuleBody()
        {
        }

    }
}