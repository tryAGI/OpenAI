
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Packages installed in an OpenAI-hosted environment.
    /// </summary>
    public sealed partial class EnvironmentPackagesResource
    {
        /// <summary>
        /// Python packages installed in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Python { get; set; }

        /// <summary>
        /// System packages installed in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> System { get; set; }

        /// <summary>
        /// npm packages installed globally in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Npm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentPackagesResource" /> class.
        /// </summary>
        /// <param name="python">
        /// Python packages installed in the environment.
        /// </param>
        /// <param name="system">
        /// System packages installed in the environment.
        /// </param>
        /// <param name="npm">
        /// npm packages installed globally in the environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentPackagesResource(
            global::System.Collections.Generic.IList<string> python,
            global::System.Collections.Generic.IList<string> system,
            global::System.Collections.Generic.IList<string> npm)
        {
            this.Python = python ?? throw new global::System.ArgumentNullException(nameof(python));
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.Npm = npm ?? throw new global::System.ArgumentNullException(nameof(npm));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentPackagesResource" /> class.
        /// </summary>
        public EnvironmentPackagesResource()
        {
        }

    }
}