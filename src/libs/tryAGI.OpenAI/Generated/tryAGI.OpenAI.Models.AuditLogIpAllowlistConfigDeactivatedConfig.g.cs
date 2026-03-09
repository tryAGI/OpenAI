
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditLogIpAllowlistConfigDeactivatedConfig
    {
        /// <summary>
        /// The ID of the IP allowlist configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the IP allowlist configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistConfigDeactivatedConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the IP allowlist configuration.
        /// </param>
        /// <param name="name">
        /// The name of the IP allowlist configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogIpAllowlistConfigDeactivatedConfig(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistConfigDeactivatedConfig" /> class.
        /// </summary>
        public AuditLogIpAllowlistConfigDeactivatedConfig()
        {
        }
    }
}