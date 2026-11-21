
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePlatformWorkloadIdentityFederationRuleBody
    {
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
        public object? AttributeMatchers { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdatePlatformWorkloadIdentityFederationRuleBody" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="attributeMatchers"></param>
        /// <param name="permissions"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePlatformWorkloadIdentityFederationRuleBody(
            string? name,
            string? description,
            object? attributeMatchers,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissionsParam, global::tryAGI.OpenAI.RestrictedPermissionsParam>? permissions,
            bool? enabled)
        {
            this.Name = name;
            this.Description = description;
            this.AttributeMatchers = attributeMatchers;
            this.Permissions = permissions;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlatformWorkloadIdentityFederationRuleBody" /> class.
        /// </summary>
        public UpdatePlatformWorkloadIdentityFederationRuleBody()
        {
        }

    }
}