
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Packages to install in an OpenAI-hosted environment.
    /// </summary>
    public sealed partial class EnvironmentPackagesParam
    {
        /// <summary>
        /// Python packages to install. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python")]
        public global::System.Collections.Generic.IList<string>? Python { get; set; }

        /// <summary>
        /// System packages to install. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::System.Collections.Generic.IList<string>? System { get; set; }

        /// <summary>
        /// npm packages to install globally. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm")]
        public global::System.Collections.Generic.IList<string>? Npm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentPackagesParam" /> class.
        /// </summary>
        /// <param name="python">
        /// Python packages to install. Defaults to an empty list.
        /// </param>
        /// <param name="system">
        /// System packages to install. Defaults to an empty list.
        /// </param>
        /// <param name="npm">
        /// npm packages to install globally. Defaults to an empty list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentPackagesParam(
            global::System.Collections.Generic.IList<string>? python,
            global::System.Collections.Generic.IList<string>? system,
            global::System.Collections.Generic.IList<string>? npm)
        {
            this.Python = python;
            this.System = system;
            this.Npm = npm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentPackagesParam" /> class.
        /// </summary>
        public EnvironmentPackagesParam()
        {
        }

    }
}