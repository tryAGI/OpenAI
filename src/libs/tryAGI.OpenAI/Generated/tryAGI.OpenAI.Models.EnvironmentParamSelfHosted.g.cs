
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An application-hosted environment configured inline.
    /// </summary>
    public sealed partial class EnvironmentParamSelfHosted
    {
        /// <summary>
        /// The type of the object. Always `self_hosted`.<br/>
        /// Default Value: self_hosted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentParamSelfHostedType.SelfHosted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentParamSelfHostedTypeJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentParamSelfHostedType Type { get; set; } = global::tryAGI.OpenAI.EnvironmentParamSelfHostedType.SelfHosted;

        /// <summary>
        /// Absolute project directory inside the self-hosted environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_directory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceDirectory { get; set; }

        /// <summary>
        /// Directories that contain capabilities exposed to the agent. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_directories")]
        public global::System.Collections.Generic.IList<string>? CapabilityDirectories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentParamSelfHosted" /> class.
        /// </summary>
        /// <param name="workspaceDirectory">
        /// Absolute project directory inside the self-hosted environment.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that contain capabilities exposed to the agent. Defaults to an empty list.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `self_hosted`.<br/>
        /// Default Value: self_hosted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentParamSelfHosted(
            string workspaceDirectory,
            global::System.Collections.Generic.IList<string>? capabilityDirectories,
            global::tryAGI.OpenAI.EnvironmentParamSelfHostedType type = global::tryAGI.OpenAI.EnvironmentParamSelfHostedType.SelfHosted)
        {
            this.Type = type;
            this.WorkspaceDirectory = workspaceDirectory ?? throw new global::System.ArgumentNullException(nameof(workspaceDirectory));
            this.CapabilityDirectories = capabilityDirectories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentParamSelfHosted" /> class.
        /// </summary>
        public EnvironmentParamSelfHosted()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EnvironmentParamSelfHosted"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EnvironmentParamSelfHosted FromWorkspaceDirectory(string workspaceDirectory)
        {
            return new EnvironmentParamSelfHosted
            {
                WorkspaceDirectory = workspaceDirectory,
            };
        }

    }
}