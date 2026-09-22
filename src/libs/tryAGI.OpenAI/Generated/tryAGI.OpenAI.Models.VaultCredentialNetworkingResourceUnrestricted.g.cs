
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allows substitution for destinations permitted by the environment network policy. Requires `environment.network.access` to be `restricted`, with explicit `allowed_domains`.
    /// </summary>
    public sealed partial class VaultCredentialNetworkingResourceUnrestricted
    {
        /// <summary>
        /// The type of the object. Always `unrestricted`.<br/>
        /// Default Value: unrestricted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType.Unrestricted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceUnrestrictedTypeJsonConverter))]
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType Type { get; set; } = global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType.Unrestricted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialNetworkingResourceUnrestricted" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `unrestricted`.<br/>
        /// Default Value: unrestricted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultCredentialNetworkingResourceUnrestricted(
            global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType type = global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType.Unrestricted)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialNetworkingResourceUnrestricted" /> class.
        /// </summary>
        public VaultCredentialNetworkingResourceUnrestricted()
        {
        }

    }
}