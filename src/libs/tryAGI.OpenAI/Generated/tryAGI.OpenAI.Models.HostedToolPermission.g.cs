
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Permission state for a single hosted tool on a project.
    /// </summary>
    public sealed partial class HostedToolPermission
    {
        /// <summary>
        /// Whether the hosted tool is enabled for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedToolPermission" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the hosted tool is enabled for the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedToolPermission(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedToolPermission" /> class.
        /// </summary>
        public HostedToolPermission()
        {
        }

    }
}