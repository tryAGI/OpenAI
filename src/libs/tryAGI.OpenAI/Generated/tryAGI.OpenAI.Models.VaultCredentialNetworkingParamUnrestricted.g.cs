
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allows substitution for destinations permitted by the environment network policy. Requires `environment.network.access` to be `restricted`, with explicit `allowed_domains`.
    /// </summary>
    public sealed partial class VaultCredentialNetworkingParamUnrestricted
    {
        /// <summary>
        /// The type of the object. Always `unrestricted`.<br/>
        /// Default Value: unrestricted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType.Unrestricted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamUnrestrictedTypeJsonConverter))]
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType Type { get; set; } = global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType.Unrestricted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialNetworkingParamUnrestricted" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `unrestricted`.<br/>
        /// Default Value: unrestricted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultCredentialNetworkingParamUnrestricted(
            global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType type = global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType.Unrestricted)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialNetworkingParamUnrestricted" /> class.
        /// </summary>
        public VaultCredentialNetworkingParamUnrestricted()
        {
        }

    }
}