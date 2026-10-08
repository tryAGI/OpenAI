
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OciExternalStorageProviderParams
    {
        /// <summary>
        /// Default Value: oci
        /// </summary>
        /// <default>global::tryAGI.OpenAI.OciExternalStorageProviderParamsType.Oci</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OciExternalStorageProviderParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.OciExternalStorageProviderParamsType Type { get; set; } = global::tryAGI.OpenAI.OciExternalStorageProviderParamsType.Oci;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenancy_ocid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenancyOcid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OciExternalStorageProviderParams" /> class.
        /// </summary>
        /// <param name="tenancyOcid"></param>
        /// <param name="region"></param>
        /// <param name="bucket"></param>
        /// <param name="type">
        /// Default Value: oci
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OciExternalStorageProviderParams(
            string tenancyOcid,
            string region,
            string bucket,
            global::tryAGI.OpenAI.OciExternalStorageProviderParamsType type = global::tryAGI.OpenAI.OciExternalStorageProviderParamsType.Oci)
        {
            this.Type = type;
            this.TenancyOcid = tenancyOcid ?? throw new global::System.ArgumentNullException(nameof(tenancyOcid));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OciExternalStorageProviderParams" /> class.
        /// </summary>
        public OciExternalStorageProviderParams()
        {
        }

    }
}