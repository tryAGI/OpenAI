
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Hosted environment selection with confidential setup commands and variables omitted.
    /// </summary>
    public sealed partial class AutomationEnvironmentResourceOpenaiHosted
    {
        /// <summary>
        /// The type of the object. Always `openai_hosted`.<br/>
        /// Default Value: openai_hosted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHostedType.OpenaiHosted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationEnvironmentResourceOpenaiHostedTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHostedType Type { get; set; } = global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHostedType.OpenaiHosted;

        /// <summary>
        /// An existing environment reference, or null when provisioning a new environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// A template reference, or null when no template is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_template_id")]
        public string? EnvironmentTemplateId { get; set; }

        /// <summary>
        /// The configured container size, or null to use the creation default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_size")]
        public global::tryAGI.OpenAI.ContainerSizeResource? ContainerSize { get; set; }

        /// <summary>
        /// Package overrides, or null to inherit the template or creation default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::tryAGI.OpenAI.EnvironmentPackagesResource? Packages { get; set; }

        /// <summary>
        /// Network overrides, or null to inherit the template or creation default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::tryAGI.OpenAI.NetworkPolicyResource? Network { get; set; }

        /// <summary>
        /// Desktop overrides, or null to inherit the template or creation default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desktop")]
        public global::tryAGI.OpenAI.DesktopResource? Desktop { get; set; }

        /// <summary>
        /// Directory overrides, or null to inherit the template or creation default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_directories")]
        public global::System.Collections.Generic.IList<string>? CapabilityDirectories { get; set; }

        /// <summary>
        /// Skill overrides, excluding archive contents, or null to inherit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>? Skills { get; set; }

        /// <summary>
        /// Plugin overrides, excluding archive contents, or null to inherit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>? Plugins { get; set; }

        /// <summary>
        /// File overrides, excluding contents, or null to inherit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEnvironmentResourceOpenaiHosted" /> class.
        /// </summary>
        /// <param name="environmentId">
        /// An existing environment reference, or null when provisioning a new environment.
        /// </param>
        /// <param name="environmentTemplateId">
        /// A template reference, or null when no template is selected.
        /// </param>
        /// <param name="containerSize">
        /// The configured container size, or null to use the creation default.
        /// </param>
        /// <param name="packages">
        /// Package overrides, or null to inherit the template or creation default.
        /// </param>
        /// <param name="network">
        /// Network overrides, or null to inherit the template or creation default.
        /// </param>
        /// <param name="desktop">
        /// Desktop overrides, or null to inherit the template or creation default.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directory overrides, or null to inherit the template or creation default.
        /// </param>
        /// <param name="skills">
        /// Skill overrides, excluding archive contents, or null to inherit.
        /// </param>
        /// <param name="plugins">
        /// Plugin overrides, excluding archive contents, or null to inherit.
        /// </param>
        /// <param name="files">
        /// File overrides, excluding contents, or null to inherit.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `openai_hosted`.<br/>
        /// Default Value: openai_hosted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationEnvironmentResourceOpenaiHosted(
            string? environmentId,
            string? environmentTemplateId,
            global::tryAGI.OpenAI.ContainerSizeResource? containerSize,
            global::tryAGI.OpenAI.EnvironmentPackagesResource? packages,
            global::tryAGI.OpenAI.NetworkPolicyResource? network,
            global::tryAGI.OpenAI.DesktopResource? desktop,
            global::System.Collections.Generic.IList<string>? capabilityDirectories,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>? skills,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>? plugins,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>? files,
            global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHostedType type = global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHostedType.OpenaiHosted)
        {
            this.Type = type;
            this.EnvironmentId = environmentId;
            this.EnvironmentTemplateId = environmentTemplateId;
            this.ContainerSize = containerSize;
            this.Packages = packages;
            this.Network = network;
            this.Desktop = desktop;
            this.CapabilityDirectories = capabilityDirectories;
            this.Skills = skills;
            this.Plugins = plugins;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEnvironmentResourceOpenaiHosted" /> class.
        /// </summary>
        public AutomationEnvironmentResourceOpenaiHosted()
        {
        }

    }
}