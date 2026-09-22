
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The configuration for the external storage.
    /// </summary>
    public sealed partial class AuditLogExternalStorageRegisteredData
    {
        /// <summary>
        /// The external storage provider configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProviderJsonConverter))]
        public global::tryAGI.OpenAI.Provider? Provider { get; set; }

        /// <summary>
        /// The OpenAI geography derived from the storage region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geography")]
        public string? Geography { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogExternalStorageRegisteredData" /> class.
        /// </summary>
        /// <param name="provider">
        /// The external storage provider configuration.
        /// </param>
        /// <param name="geography">
        /// The OpenAI geography derived from the storage region.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogExternalStorageRegisteredData(
            global::tryAGI.OpenAI.Provider? provider,
            string? geography)
        {
            this.Provider = provider;
            this.Geography = geography;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogExternalStorageRegisteredData" /> class.
        /// </summary>
        public AuditLogExternalStorageRegisteredData()
        {
        }

    }
}