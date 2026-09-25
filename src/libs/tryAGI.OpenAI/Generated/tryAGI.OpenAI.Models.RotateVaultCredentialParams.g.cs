
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Metadata, secret, expiry, and OAuth refresh scope updates for an existing vault credential. Supply at least one of `auth` or `metadata`.
    /// </summary>
    public sealed partial class RotateVaultCredentialParams
    {
        /// <summary>
        /// Replacement values for the credential's existing authentication method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamJsonConverter))]
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParam? Auth { get; set; }

        /// <summary>
        /// Replaces all metadata. Omit to preserve it, or pass {} to clear it. Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialParams" /> class.
        /// </summary>
        /// <param name="auth">
        /// Replacement values for the credential's existing authentication method.
        /// </param>
        /// <param name="metadata">
        /// Replaces all metadata. Omit to preserve it, or pass {} to clear it. Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateVaultCredentialParams(
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParam? auth,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Auth = auth;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialParams" /> class.
        /// </summary>
        public RotateVaultCredentialParams()
        {
        }

    }
}