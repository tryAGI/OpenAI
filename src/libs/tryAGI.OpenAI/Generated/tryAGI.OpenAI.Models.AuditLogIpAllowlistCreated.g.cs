
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogIpAllowlistCreated
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
        /// The IP addresses or CIDR ranges included in the configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_ips")]
        public global::System.Collections.Generic.IList<string>? AllowedIps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the IP allowlist configuration.
        /// </param>
        /// <param name="name">
        /// The name of the IP allowlist configuration.
        /// </param>
        /// <param name="allowedIps">
        /// The IP addresses or CIDR ranges included in the configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogIpAllowlistCreated(
            string? id,
            string? name,
            global::System.Collections.Generic.IList<string>? allowedIps)
        {
            this.Id = id;
            this.Name = name;
            this.AllowedIps = allowedIps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistCreated" /> class.
        /// </summary>
        public AuditLogIpAllowlistCreated()
        {
        }
    }
}