
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OciExternalKeyParams
    {
        /// <summary>
        /// A friendly name to identify this config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: oci
        /// </summary>
        /// <default>global::tryAGI.OpenAI.OciExternalKeyParamsType.Oci</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OciExternalKeyParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.OciExternalKeyParamsType Type { get; set; } = global::tryAGI.OpenAI.OciExternalKeyParamsType.Oci;

        /// <summary>
        /// The OCI region containing the vault
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// The customer OCI Vault OCID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ocid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultOcid { get; set; }

        /// <summary>
        /// The OCI Vault key OCID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ocid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyOcid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExternalKeyPurposeJsonConverter))]
        public global::tryAGI.OpenAI.ExternalKeyPurpose? Purpose { get; set; }

        /// <summary>
        /// The exact OCI key version OCID for PSP decryption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_version_ocid")]
        public string? KeyVersionOcid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OciExternalKeyParams" /> class.
        /// </summary>
        /// <param name="name">
        /// A friendly name to identify this config
        /// </param>
        /// <param name="region">
        /// The OCI region containing the vault
        /// </param>
        /// <param name="vaultOcid">
        /// The customer OCI Vault OCID
        /// </param>
        /// <param name="keyOcid">
        /// The OCI Vault key OCID
        /// </param>
        /// <param name="purpose"></param>
        /// <param name="keyVersionOcid">
        /// The exact OCI key version OCID for PSP decryption.
        /// </param>
        /// <param name="type">
        /// Default Value: oci
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OciExternalKeyParams(
            string name,
            string region,
            string vaultOcid,
            string keyOcid,
            global::tryAGI.OpenAI.ExternalKeyPurpose? purpose,
            string? keyVersionOcid,
            global::tryAGI.OpenAI.OciExternalKeyParamsType type = global::tryAGI.OpenAI.OciExternalKeyParamsType.Oci)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.VaultOcid = vaultOcid ?? throw new global::System.ArgumentNullException(nameof(vaultOcid));
            this.KeyOcid = keyOcid ?? throw new global::System.ArgumentNullException(nameof(keyOcid));
            this.Purpose = purpose;
            this.KeyVersionOcid = keyVersionOcid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OciExternalKeyParams" /> class.
        /// </summary>
        public OciExternalKeyParams()
        {
        }

    }
}