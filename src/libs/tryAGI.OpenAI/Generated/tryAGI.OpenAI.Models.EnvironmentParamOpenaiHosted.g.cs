
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An existing OpenAI-hosted environment or new inline/template-based hosted configuration.
    /// </summary>
    public sealed partial class EnvironmentParamOpenaiHosted
    {
        /// <summary>
        /// The type of the object. Always `openai_hosted`.<br/>
        /// Default Value: openai_hosted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType.OpenaiHosted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentParamOpenaiHostedTypeJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType Type { get; set; } = global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType.OpenaiHosted;

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
        /// Network access policy for the environment. If omitted, the API version determines whether network access is enabled or disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::tryAGI.OpenAI.NetworkPolicyParam? Network { get; set; }

        /// <summary>
        /// Desktop provisioning. Omission or null inherits the template setting, or defaults to disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desktop")]
        public global::tryAGI.OpenAI.DesktopParam? Desktop { get; set; }

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
        /// An existing prewarmed environment. Cannot be combined with a template or inline configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// A reusable hosted template applied before inline session configuration. Omitted fields inherit the template; network overrides cannot broaden its policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_template_id")]
        public string? EnvironmentTemplateId { get; set; }

        /// <summary>
        /// The hosted container size. Omission selects the medium tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerSizeParamJsonConverter))]
        public global::tryAGI.OpenAI.ContainerSizeParam? ContainerSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentParamOpenaiHosted" /> class.
        /// </summary>
        /// <param name="packages">
        /// Packages to install in the environment. Defaults to empty package lists.
        /// </param>
        /// <param name="setupCommands">
        /// Ordered, confidential setup commands. Command bodies are never returned.
        /// </param>
        /// <param name="network">
        /// Network access policy for the environment. If omitted, the API version determines whether network access is enabled or disabled.
        /// </param>
        /// <param name="desktop">
        /// Desktop provisioning. Omission or null inherits the template setting, or defaults to disabled.
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
        /// <param name="environmentId">
        /// An existing prewarmed environment. Cannot be combined with a template or inline configuration.
        /// </param>
        /// <param name="environmentTemplateId">
        /// A reusable hosted template applied before inline session configuration. Omitted fields inherit the template; network overrides cannot broaden its policy.
        /// </param>
        /// <param name="containerSize">
        /// The hosted container size. Omission selects the medium tier.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `openai_hosted`.<br/>
        /// Default Value: openai_hosted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentParamOpenaiHosted(
            global::tryAGI.OpenAI.EnvironmentPackagesParam? packages,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? setupCommands,
            global::tryAGI.OpenAI.NetworkPolicyParam? network,
            global::tryAGI.OpenAI.DesktopParam? desktop,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.IList<string>? capabilityDirectories,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? skills,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? plugins,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? files,
            string? environmentId,
            string? environmentTemplateId,
            global::tryAGI.OpenAI.ContainerSizeParam? containerSize,
            global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType type = global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType.OpenaiHosted)
        {
            this.Type = type;
            this.Packages = packages;
            this.SetupCommands = setupCommands;
            this.Network = network;
            this.Desktop = desktop;
            this.Env = env;
            this.CapabilityDirectories = capabilityDirectories;
            this.Skills = skills;
            this.Plugins = plugins;
            this.Files = files;
            this.EnvironmentId = environmentId;
            this.EnvironmentTemplateId = environmentTemplateId;
            this.ContainerSize = containerSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentParamOpenaiHosted" /> class.
        /// </summary>
        public EnvironmentParamOpenaiHosted()
        {
        }

    }
}