
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation that a vault credential was deleted.
    /// </summary>
    public sealed partial class DeletedVaultCredentialResource
    {
        /// <summary>
        /// The ID of the deleted credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `vault.credential.deleted`.<br/>
        /// Default Value: vault.credential.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject.VaultCredentialDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedVaultCredentialResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject.VaultCredentialDeleted;

        /// <summary>
        /// Whether the resource was deleted. Always `true`.
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
        /// Initializes a new instance of the <see cref="DeletedVaultCredentialResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted credential.
        /// </param>
        /// <param name="deleted">
        /// Whether the resource was deleted. Always `true`.
        /// </param>
        /// <param name="object">
        /// The object type. Always `vault.credential.deleted`.<br/>
        /// Default Value: vault.credential.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedVaultCredentialResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject @object = global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject.VaultCredentialDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedVaultCredentialResource" /> class.
        /// </summary>
        public DeletedVaultCredentialResource()
        {
        }

    }
}