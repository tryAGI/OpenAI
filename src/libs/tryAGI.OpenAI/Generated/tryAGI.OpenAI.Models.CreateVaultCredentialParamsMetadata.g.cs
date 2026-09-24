
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Defaults to an empty map.
    /// </summary>
    public sealed partial class CreateVaultCredentialParamsMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}