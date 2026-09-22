
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An environment hosted by the application.
    /// </summary>
    public sealed partial class EnvironmentResourceSelfHosted
    {
        /// <summary>
        /// The type of the object. Always `self_hosted`.<br/>
        /// Default Value: self_hosted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType.SelfHosted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceSelfHostedTypeJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType Type { get; set; } = global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType.SelfHosted;

        /// <summary>
        /// Pass this URL unchanged to `codex exec-server --remote` when connecting this environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteUrl { get; set; }

        /// <summary>
        /// The public ID of the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The absolute project directory inside the environment. Defaults to `/workspace`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_directory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceDirectory { get; set; }

        /// <summary>
        /// Directories that contain capabilities exposed to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_directories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CapabilityDirectories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResourceSelfHosted" /> class.
        /// </summary>
        /// <param name="remoteUrl">
        /// Pass this URL unchanged to `codex exec-server --remote` when connecting this environment.
        /// </param>
        /// <param name="id">
        /// The public ID of the environment.
        /// </param>
        /// <param name="workspaceDirectory">
        /// The absolute project directory inside the environment. Defaults to `/workspace`.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that contain capabilities exposed to the agent.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `self_hosted`.<br/>
        /// Default Value: self_hosted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentResourceSelfHosted(
            string remoteUrl,
            string id,
            string workspaceDirectory,
            global::System.Collections.Generic.IList<string> capabilityDirectories,
            global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType type = global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType.SelfHosted)
        {
            this.Type = type;
            this.RemoteUrl = remoteUrl ?? throw new global::System.ArgumentNullException(nameof(remoteUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkspaceDirectory = workspaceDirectory ?? throw new global::System.ArgumentNullException(nameof(workspaceDirectory));
            this.CapabilityDirectories = capabilityDirectories ?? throw new global::System.ArgumentNullException(nameof(capabilityDirectories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResourceSelfHosted" /> class.
        /// </summary>
        public EnvironmentResourceSelfHosted()
        {
        }

    }
}