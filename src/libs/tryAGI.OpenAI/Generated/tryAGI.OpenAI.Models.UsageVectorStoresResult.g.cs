
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated vector stores usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageVectorStoresResult
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"organization.usage.vector_stores.result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "organization.usage.vector_stores.result";

        /// <summary>
        /// The vector stores usage in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UsageBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVectorStoresResult" /> class.
        /// </summary>
        /// <param name="usageBytes">
        /// The vector stores usage in bytes.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageVectorStoresResult(
            long usageBytes,
            string? projectId,
            string @object = "organization.usage.vector_stores.result")
        {
            this.Object = @object;
            this.UsageBytes = usageBytes;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVectorStoresResult" /> class.
        /// </summary>
        public UsageVectorStoresResult()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UsageVectorStoresResult"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UsageVectorStoresResult FromUsageBytes(long usageBytes)
        {
            return new UsageVectorStoresResult
            {
                UsageBytes = usageBytes,
            };
        }

    }
}