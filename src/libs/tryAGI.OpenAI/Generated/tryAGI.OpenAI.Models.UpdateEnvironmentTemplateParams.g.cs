
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Fields to replace on an existing reusable OpenAI-hosted environment template.
    /// </summary>
    public sealed partial class UpdateEnvironmentTemplateParams
    {
        /// <summary>
        /// A replacement human-readable display name, or `null` to clear the name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Packages installed before the runtime network policy applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::tryAGI.OpenAI.EnvironmentPackagesParam? Packages { get; set; }

        /// <summary>
        /// Replacement confidential setup commands, never included in returned resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup_commands")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? SetupCommands { get; set; }

        /// <summary>
        /// Network access available after setup completes. Omit to preserve the current policy, or pass `null` to reset to disabled for GA requests or enabled for alpha/beta requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::tryAGI.OpenAI.NetworkPolicyParam? Network { get; set; }

        /// <summary>
        /// Replacement confidential environment values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Directories that expose capabilities to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_directories")]
        public global::System.Collections.Generic.IList<string>? CapabilityDirectories { get; set; }

        /// <summary>
        /// Replacement skill configuration installed for each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? Skills { get; set; }

        /// <summary>
        /// Replacement plugin configuration installed for each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? Plugins { get; set; }

        /// <summary>
        /// Replacement file configuration materialized for each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentTemplateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// A replacement human-readable display name, or `null` to clear the name.
        /// </param>
        /// <param name="packages">
        /// Packages installed before the runtime network policy applies.
        /// </param>
        /// <param name="setupCommands">
        /// Replacement confidential setup commands, never included in returned resources.
        /// </param>
        /// <param name="network">
        /// Network access available after setup completes. Omit to preserve the current policy, or pass `null` to reset to disabled for GA requests or enabled for alpha/beta requests.
        /// </param>
        /// <param name="env">
        /// Replacement confidential environment values.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that expose capabilities to the agent.
        /// </param>
        /// <param name="skills">
        /// Replacement skill configuration installed for each new session.
        /// </param>
        /// <param name="plugins">
        /// Replacement plugin configuration installed for each new session.
        /// </param>
        /// <param name="files">
        /// Replacement file configuration materialized for each new session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentTemplateParams(
            string? name,
            global::tryAGI.OpenAI.EnvironmentPackagesParam? packages,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? setupCommands,
            global::tryAGI.OpenAI.NetworkPolicyParam? network,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.IList<string>? capabilityDirectories,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? skills,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? plugins,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? files)
        {
            this.Name = name;
            this.Packages = packages;
            this.SetupCommands = setupCommands;
            this.Network = network;
            this.Env = env;
            this.CapabilityDirectories = capabilityDirectories;
            this.Skills = skills;
            this.Plugins = plugins;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentTemplateParams" /> class.
        /// </summary>
        public UpdateEnvironmentTemplateParams()
        {
        }

    }
}