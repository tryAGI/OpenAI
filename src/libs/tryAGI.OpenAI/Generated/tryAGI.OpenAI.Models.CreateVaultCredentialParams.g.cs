
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for storing a credential for an MCP server or an OpenAI-hosted environment.
    /// </summary>
    public sealed partial class CreateVaultCredentialParams
    {
        /// <summary>
        /// The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The authentication method and write-only secret values to store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateVaultCredentialAuthParam Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialParams" /> class.
        /// </summary>
        /// <param name="name">
        /// The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.
        /// </param>
        /// <param name="auth">
        /// The authentication method and write-only secret values to store.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVaultCredentialParams(
            string name,
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParam auth)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialParams" /> class.
        /// </summary>
        public CreateVaultCredentialParams()
        {
        }

    }
}