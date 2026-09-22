
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Secret, expiry, and OAuth refresh scope updates for an existing vault credential.
    /// </summary>
    public sealed partial class RotateVaultCredentialParams
    {
        /// <summary>
        /// Replacement values for the credential's existing authentication method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RotateVaultCredentialAuthParam Auth { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateVaultCredentialParams(
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParam auth)
        {
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialParams" /> class.
        /// </summary>
        public RotateVaultCredentialParams()
        {
        }

    }
}