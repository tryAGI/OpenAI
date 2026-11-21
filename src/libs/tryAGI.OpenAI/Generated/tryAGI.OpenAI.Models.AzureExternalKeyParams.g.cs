
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AzureExternalKeyParams
    {
        /// <summary>
        /// A friendly name to identify this config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: azure
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AzureExternalKeyParamsType.Azure</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AzureExternalKeyParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.AzureExternalKeyParamsType Type { get; set; } = global::tryAGI.OpenAI.AzureExternalKeyParamsType.Azure;

        /// <summary>
        /// Your Azure tenant UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// The URI of the Azure vault containing the master key you manage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultUri { get; set; }

        /// <summary>
        /// The name of the Azure Key Vault master key that you manage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExternalKeyPurposeJsonConverter))]
        public global::tryAGI.OpenAI.ExternalKeyPurpose? Purpose { get; set; }

        /// <summary>
        /// An exact Azure Key Vault key version. Required for PSP decryption; not accepted for EKM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_version")]
        public string? KeyVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureExternalKeyParams" /> class.
        /// </summary>
        /// <param name="name">
        /// A friendly name to identify this config
        /// </param>
        /// <param name="tenantId">
        /// Your Azure tenant UUID
        /// </param>
        /// <param name="vaultUri">
        /// The URI of the Azure vault containing the master key you manage
        /// </param>
        /// <param name="keyName">
        /// The name of the Azure Key Vault master key that you manage
        /// </param>
        /// <param name="purpose"></param>
        /// <param name="keyVersion">
        /// An exact Azure Key Vault key version. Required for PSP decryption; not accepted for EKM.
        /// </param>
        /// <param name="type">
        /// Default Value: azure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureExternalKeyParams(
            string name,
            string tenantId,
            string vaultUri,
            string keyName,
            global::tryAGI.OpenAI.ExternalKeyPurpose? purpose,
            string? keyVersion,
            global::tryAGI.OpenAI.AzureExternalKeyParamsType type = global::tryAGI.OpenAI.AzureExternalKeyParamsType.Azure)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.VaultUri = vaultUri ?? throw new global::System.ArgumentNullException(nameof(vaultUri));
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
            this.Purpose = purpose;
            this.KeyVersion = keyVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureExternalKeyParams" /> class.
        /// </summary>
        public AzureExternalKeyParams()
        {
        }

    }
}