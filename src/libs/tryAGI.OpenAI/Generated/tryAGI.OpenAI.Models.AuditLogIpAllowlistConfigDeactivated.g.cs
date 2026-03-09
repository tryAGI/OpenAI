
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogIpAllowlistConfigDeactivated
    {
        /// <summary>
        /// The configurations that were deactivated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistConfigDeactivated" /> class.
        /// </summary>
        /// <param name="configs">
        /// The configurations that were deactivated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogIpAllowlistConfigDeactivated(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>? configs)
        {
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogIpAllowlistConfigDeactivated" /> class.
        /// </summary>
        public AuditLogIpAllowlistConfigDeactivated()
        {
        }
    }
}