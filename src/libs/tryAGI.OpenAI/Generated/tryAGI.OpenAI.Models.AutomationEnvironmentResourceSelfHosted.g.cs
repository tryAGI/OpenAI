
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationEnvironmentResourceSelfHosted
    {
        /// <summary>
        /// The type of the object. Always `self_hosted`.<br/>
        /// Default Value: self_hosted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHostedType.SelfHosted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationEnvironmentResourceSelfHostedTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHostedType Type { get; set; } = global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHostedType.SelfHosted;

        /// <summary>
        /// An existing registration, or null to create a session-owned environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// The absolute project directory in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_directory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceDirectory { get; set; }

        /// <summary>
        /// Directories that expose capabilities to the agent.
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
        /// Initializes a new instance of the <see cref="AutomationEnvironmentResourceSelfHosted" /> class.
        /// </summary>
        /// <param name="workspaceDirectory">
        /// The absolute project directory in the environment.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that expose capabilities to the agent.
        /// </param>
        /// <param name="environmentId">
        /// An existing registration, or null to create a session-owned environment.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `self_hosted`.<br/>
        /// Default Value: self_hosted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationEnvironmentResourceSelfHosted(
            string workspaceDirectory,
            global::System.Collections.Generic.IList<string> capabilityDirectories,
            string? environmentId,
            global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHostedType type = global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHostedType.SelfHosted)
        {
            this.Type = type;
            this.EnvironmentId = environmentId;
            this.WorkspaceDirectory = workspaceDirectory ?? throw new global::System.ArgumentNullException(nameof(workspaceDirectory));
            this.CapabilityDirectories = capabilityDirectories ?? throw new global::System.ArgumentNullException(nameof(capabilityDirectories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEnvironmentResourceSelfHosted" /> class.
        /// </summary>
        public AutomationEnvironmentResourceSelfHosted()
        {
        }

    }
}