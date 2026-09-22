
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for creating a vault to store credentials used by agent tools.
    /// </summary>
    public sealed partial class CreateVaultParams
    {
        /// <summary>
        /// The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Key-value pairs to associate with the vault, such as an application or team identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultParams" /> class.
        /// </summary>
        /// <param name="name">
        /// The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to associate with the vault, such as an application or team identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVaultParams(
            string? name,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultParams" /> class.
        /// </summary>
        public CreateVaultParams()
        {
        }

    }
}