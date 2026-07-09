
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContainerNetworkPolicyAllowlistParam
    {
        /// <summary>
        /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
        /// Default Value: allowlist
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType.Allowlist</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyAllowlistParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType Type { get; set; } = global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType.Allowlist;

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
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? DomainSecrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainerNetworkPolicyAllowlistParam" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// A list of allowed domains when type is `allowlist`.
        /// </param>
        /// <param name="domainSecrets">
        /// Optional domain-scoped secrets for allowlisted domains.
        /// </param>
        /// <param name="type">
        /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
        /// Default Value: allowlist
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContainerNetworkPolicyAllowlistParam(
            global::System.Collections.Generic.IList<string> allowedDomains,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>? domainSecrets,
            global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType type = global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType.Allowlist)
        {
            this.Type = type;
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.DomainSecrets = domainSecrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainerNetworkPolicyAllowlistParam" /> class.
        /// </summary>
        public BetaContainerNetworkPolicyAllowlistParam()
        {
        }

    }
}