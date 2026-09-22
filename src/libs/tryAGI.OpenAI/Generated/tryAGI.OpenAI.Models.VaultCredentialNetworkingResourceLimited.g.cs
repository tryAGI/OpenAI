
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allows substitution only for the listed hosts. The environment network policy must also allow these hosts.
    /// </summary>
    public sealed partial class VaultCredentialNetworkingResourceLimited
    {
        /// <summary>
        /// The type of the object. Always `limited`.<br/>
        /// Default Value: limited
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType.Limited</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceLimitedTypeJsonConverter))]
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType Type { get; set; } = global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType.Limited;

        /// <summary>
        /// The 1 to 16 distinct allowed hostnames or IPv4 addresses, normalized to lowercase. Entries contain no scheme, path, port, or wildcard. IPv6 addresses are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_hosts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedHosts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialNetworkingResourceLimited" /> class.
        /// </summary>
        /// <param name="allowedHosts">
        /// The 1 to 16 distinct allowed hostnames or IPv4 addresses, normalized to lowercase. Entries contain no scheme, path, port, or wildcard. IPv6 addresses are not supported.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `limited`.<br/>
        /// Default Value: limited
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultCredentialNetworkingResourceLimited(
            global::System.Collections.Generic.IList<string> allowedHosts,
            global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType type = global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType.Limited)
        {
            this.Type = type;
            this.AllowedHosts = allowedHosts ?? throw new global::System.ArgumentNullException(nameof(allowedHosts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialNetworkingResourceLimited" /> class.
        /// </summary>
        public VaultCredentialNetworkingResourceLimited()
        {
        }

    }
}