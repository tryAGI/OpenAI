
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Fields to replace on an active vault.
    /// </summary>
    public sealed partial class UpdateVaultParams
    {
        /// <summary>
        /// Replaces all metadata. Omit to leave unchanged, or pass {} to clear it. Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// A replacement name. Omit to leave unchanged, or pass null to clear it. The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVaultParams" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Replaces all metadata. Omit to leave unchanged, or pass {} to clear it. Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters.
        /// </param>
        /// <param name="name">
        /// A replacement name. Omit to leave unchanged, or pass null to clear it. The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVaultParams(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? name)
        {
            this.Metadata = metadata;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVaultParams" /> class.
        /// </summary>
        public UpdateVaultParams()
        {
        }

    }
}