
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The effective desktop configuration for an OpenAI-hosted environment.
    /// </summary>
    public sealed partial class DesktopResource
    {
        /// <summary>
        /// Whether the environment provisions a desktop and browser proxy.
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
        /// Initializes a new instance of the <see cref="DesktopResource" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the environment provisions a desktop and browser proxy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesktopResource(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopResource" /> class.
        /// </summary>
        public DesktopResource()
        {
        }

    }
}