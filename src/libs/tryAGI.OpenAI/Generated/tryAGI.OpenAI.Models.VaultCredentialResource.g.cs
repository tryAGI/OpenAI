
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Metadata for a stored credential. Secret values are never returned.
    /// </summary>
    public sealed partial class VaultCredentialResource
    {
        /// <summary>
        /// The ID of the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `vault.credential`.<br/>
        /// Default Value: vault.credential
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultCredentialResourceObject.VaultCredential</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.VaultCredentialResourceObject Object { get; set; } = global::tryAGI.OpenAI.VaultCredentialResourceObject.VaultCredential;

        /// <summary>
        /// The ID of the vault containing this credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultId { get; set; }

        /// <summary>
        /// The human-readable name of the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The authentication method and non-secret configuration of the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VaultCredentialAuthResource Auth { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the credential was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the credential was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the credential.
        /// </param>
        /// <param name="vaultId">
        /// The ID of the vault containing this credential.
        /// </param>
        /// <param name="name">
        /// The human-readable name of the credential.
        /// </param>
        /// <param name="auth">
        /// The authentication method and non-secret configuration of the credential.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// The Unix timestamp, in seconds, when the credential was last updated.
        /// </param>
        /// <param name="object">
        /// The object type. Always `vault.credential`.<br/>
        /// Default Value: vault.credential
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultCredentialResource(
            string id,
            string vaultId,
            string name,
            global::tryAGI.OpenAI.VaultCredentialAuthResource auth,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset updatedAt,
            global::tryAGI.OpenAI.VaultCredentialResourceObject @object = global::tryAGI.OpenAI.VaultCredentialResourceObject.VaultCredential)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.VaultId = vaultId ?? throw new global::System.ArgumentNullException(nameof(vaultId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Auth = auth;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialResource" /> class.
        /// </summary>
        public VaultCredentialResource()
        {
        }

    }
}