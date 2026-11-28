
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlatformFederationRuleDeletedResource
    {
        /// <summary>
        /// Default Value: organization.workload_identity_federation_rule.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PlatformFederationRuleDeletedResourceObject.OrganizationWorkloadIdentityFederationRuleDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PlatformFederationRuleDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.PlatformFederationRuleDeletedResourceObject Object { get; set; } = global::tryAGI.OpenAI.PlatformFederationRuleDeletedResourceObject.OrganizationWorkloadIdentityFederationRuleDeleted;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformFederationRuleDeletedResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deleted"></param>
        /// <param name="object">
        /// Default Value: organization.workload_identity_federation_rule.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlatformFederationRuleDeletedResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.PlatformFederationRuleDeletedResourceObject @object = global::tryAGI.OpenAI.PlatformFederationRuleDeletedResourceObject.OrganizationWorkloadIdentityFederationRuleDeleted)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformFederationRuleDeletedResource" /> class.
        /// </summary>
        public PlatformFederationRuleDeletedResource()
        {
        }

    }
}