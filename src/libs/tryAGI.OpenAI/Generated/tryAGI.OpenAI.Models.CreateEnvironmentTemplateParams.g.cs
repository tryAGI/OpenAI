
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for creating a reusable, project-scoped OpenAI-hosted environment template.
    /// </summary>
    public sealed partial class CreateEnvironmentTemplateParams
    {
        /// <summary>
        /// Packages to install in the environment. Defaults to empty package lists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::tryAGI.OpenAI.EnvironmentPackagesParam? Packages { get; set; }

        /// <summary>
        /// Ordered, confidential setup commands. Command bodies are never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup_commands")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? SetupCommands { get; set; }

        /// <summary>
        /// Network access policy for the environment. Defaults to disabled for GA requests and enabled for alpha/beta requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::tryAGI.OpenAI.NetworkPolicyParam? Network { get; set; }

        /// <summary>
        /// Environment variables made available to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Directories that contain capabilities exposed to the agent. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_directories")]
        public global::System.Collections.Generic.IList<string>? CapabilityDirectories { get; set; }

        /// <summary>
        /// Skills referenced by ID or provided as inline ZIP archives. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? Skills { get; set; }

        /// <summary>
        /// Plugins provided as inline ZIP archives. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? Plugins { get; set; }

        /// <summary>
        /// Files available before the agent starts. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? Files { get; set; }

        /// <summary>
        /// An optional human-readable display name for the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentTemplateParams" /> class.
        /// </summary>
        /// <param name="packages">
        /// Packages to install in the environment. Defaults to empty package lists.
        /// </param>
        /// <param name="setupCommands">
        /// Ordered, confidential setup commands. Command bodies are never returned.
        /// </param>
        /// <param name="network">
        /// Network access policy for the environment. Defaults to disabled for GA requests and enabled for alpha/beta requests.
        /// </param>
        /// <param name="env">
        /// Environment variables made available to the agent.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that contain capabilities exposed to the agent. Defaults to an empty list.
        /// </param>
        /// <param name="skills">
        /// Skills referenced by ID or provided as inline ZIP archives. Defaults to an empty list.
        /// </param>
        /// <param name="plugins">
        /// Plugins provided as inline ZIP archives. Defaults to an empty list.
        /// </param>
        /// <param name="files">
        /// Files available before the agent starts. Defaults to an empty list.
        /// </param>
        /// <param name="name">
        /// An optional human-readable display name for the template.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentTemplateParams(
            global::tryAGI.OpenAI.EnvironmentPackagesParam? packages,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? setupCommands,
            global::tryAGI.OpenAI.NetworkPolicyParam? network,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.IList<string>? capabilityDirectories,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? skills,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? plugins,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? files,
            string? name)
        {
            this.Packages = packages;
            this.SetupCommands = setupCommands;
            this.Network = network;
            this.Env = env;
            this.CapabilityDirectories = capabilityDirectories;
            this.Skills = skills;
            this.Plugins = plugins;
            this.Files = files;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentTemplateParams" /> class.
        /// </summary>
        public CreateEnvironmentTemplateParams()
        {
        }

    }
}