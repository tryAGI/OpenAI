
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An environment hosted by OpenAI.
    /// </summary>
    public sealed partial class EnvironmentResourceOpenaiHosted
    {
        /// <summary>
        /// The type of the object. Always `openai_hosted`.<br/>
        /// Default Value: openai_hosted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType.OpenaiHosted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceOpenaiHostedTypeJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType Type { get; set; } = global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType.OpenaiHosted;

        /// <summary>
        /// The public ID of the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Packages installed in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EnvironmentPackagesResource Packages { get; set; }

        /// <summary>
        /// The effective network access policy for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.NetworkPolicyResource Network { get; set; }

        /// <summary>
        /// Directories that contain capabilities exposed to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_directories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CapabilityDirectories { get; set; }

        /// <summary>
        /// Skills installed in the environment, excluding their archive contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource> Skills { get; set; }

        /// <summary>
        /// Plugins installed in the environment, excluding their archive contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource> Plugins { get; set; }

        /// <summary>
        /// Files available in the environment, excluding their contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResourceOpenaiHosted" /> class.
        /// </summary>
        /// <param name="id">
        /// The public ID of the environment.
        /// </param>
        /// <param name="packages">
        /// Packages installed in the environment.
        /// </param>
        /// <param name="network">
        /// The effective network access policy for the environment.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that contain capabilities exposed to the agent.
        /// </param>
        /// <param name="skills">
        /// Skills installed in the environment, excluding their archive contents.
        /// </param>
        /// <param name="plugins">
        /// Plugins installed in the environment, excluding their archive contents.
        /// </param>
        /// <param name="files">
        /// Files available in the environment, excluding their contents.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `openai_hosted`.<br/>
        /// Default Value: openai_hosted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentResourceOpenaiHosted(
            string id,
            global::tryAGI.OpenAI.EnvironmentPackagesResource packages,
            global::tryAGI.OpenAI.NetworkPolicyResource network,
            global::System.Collections.Generic.IList<string> capabilityDirectories,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource> skills,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource> plugins,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource> files,
            global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType type = global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType.OpenaiHosted)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Packages = packages ?? throw new global::System.ArgumentNullException(nameof(packages));
            this.Network = network ?? throw new global::System.ArgumentNullException(nameof(network));
            this.CapabilityDirectories = capabilityDirectories ?? throw new global::System.ArgumentNullException(nameof(capabilityDirectories));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
            this.Plugins = plugins ?? throw new global::System.ArgumentNullException(nameof(plugins));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResourceOpenaiHosted" /> class.
        /// </summary>
        public EnvironmentResourceOpenaiHosted()
        {
        }

    }
}