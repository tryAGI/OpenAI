
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Desktop configuration for an OpenAI-hosted environment.
    /// </summary>
    public sealed partial class DesktopParam
    {
        /// <summary>
        /// Whether to provision the desktop and its browser proxy.
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
        /// Initializes a new instance of the <see cref="DesktopParam" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to provision the desktop and its browser proxy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesktopParam(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopParam" /> class.
        /// </summary>
        public DesktopParam()
        {
        }

    }
}