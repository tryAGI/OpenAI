
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerNetworkPolicyAllowlistParam
    {
        /// <summary>
        /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
        /// Default Value: allowlist
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType.Allowlist</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType Type { get; set; } = global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType.Allowlist;

        /// <summary>
        /// A list of allowed domains when type is `allowlist`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedDomains { get; set; }

        /// <summary>
        /// Optional domain-scoped secrets for allowlisted domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_secrets")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? DomainSecrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyAllowlistParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
        /// Default Value: allowlist
        /// </param>
        /// <param name="allowedDomains">
        /// A list of allowed domains when type is `allowlist`.
        /// </param>
        /// <param name="domainSecrets">
        /// Optional domain-scoped secrets for allowlisted domains.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerNetworkPolicyAllowlistParam(
            global::System.Collections.Generic.IList<string> allowedDomains,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>? domainSecrets,
            global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType type = global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType.Allowlist)
        {
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.Type = type;
            this.DomainSecrets = domainSecrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyAllowlistParam" /> class.
        /// </summary>
        public ContainerNetworkPolicyAllowlistParam()
        {
        }
    }
}