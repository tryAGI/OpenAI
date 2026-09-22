
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A collection of credentials for MCP servers and OpenAI-hosted environments.
    /// </summary>
    public sealed partial class VaultResource
    {
        /// <summary>
        /// The ID of the vault.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `vault`.<br/>
        /// Default Value: vault
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultResourceObject.Vault</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.VaultResourceObject Object { get; set; } = global::tryAGI.OpenAI.VaultResourceObject.Vault;

        /// <summary>
        /// The human-readable name of the vault, if set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Key-value pairs associated with the vault, such as an application or team identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the vault was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the vault.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs associated with the vault, such as an application or team identifier.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, when the vault was created.
        /// </param>
        /// <param name="name">
        /// The human-readable name of the vault, if set.
        /// </param>
        /// <param name="object">
        /// The object type. Always `vault`.<br/>
        /// Default Value: vault
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultResource(
            string id,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTimeOffset createdAt,
            string? name,
            global::tryAGI.OpenAI.VaultResourceObject @object = global::tryAGI.OpenAI.VaultResourceObject.Vault)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultResource" /> class.
        /// </summary>
        public VaultResource()
        {
        }

    }
}