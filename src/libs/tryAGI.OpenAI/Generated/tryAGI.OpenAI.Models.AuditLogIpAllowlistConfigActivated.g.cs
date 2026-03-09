
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogIpAllowlistConfigActivated
    {
        /// <summary>
        /// The configurations that were activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistConfigActivated" /> class.
        /// </summary>
        /// <param name="configs">
        /// The configurations that were activated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogIpAllowlistConfigActivated(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>? configs)
        {
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistConfigActivated" /> class.
        /// </summary>
        public AuditLogIpAllowlistConfigActivated()
        {
        }
    }
}