
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents hosted tool permissions for a project.
    /// </summary>
    public sealed partial class ProjectHostedToolPermissions
    {
        /// <summary>
        /// Permission state for a single hosted tool on a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.HostedToolPermission FileSearch { get; set; }

        /// <summary>
        /// Permission state for a single hosted tool on a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.HostedToolPermission WebSearch { get; set; }

        /// <summary>
        /// Permission state for a single hosted tool on a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_generation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.HostedToolPermission ImageGeneration { get; set; }

        /// <summary>
        /// Permission state for a single hosted tool on a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.HostedToolPermission Mcp { get; set; }

        /// <summary>
        /// Permission state for a single hosted tool on a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.HostedToolPermission CodeInterpreter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectHostedToolPermissions" /> class.
        /// </summary>
        /// <param name="fileSearch">
        /// Permission state for a single hosted tool on a project.
        /// </param>
        /// <param name="webSearch">
        /// Permission state for a single hosted tool on a project.
        /// </param>
        /// <param name="imageGeneration">
        /// Permission state for a single hosted tool on a project.
        /// </param>
        /// <param name="mcp">
        /// Permission state for a single hosted tool on a project.
        /// </param>
        /// <param name="codeInterpreter">
        /// Permission state for a single hosted tool on a project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectHostedToolPermissions(
            global::tryAGI.OpenAI.HostedToolPermission fileSearch,
            global::tryAGI.OpenAI.HostedToolPermission webSearch,
            global::tryAGI.OpenAI.HostedToolPermission imageGeneration,
            global::tryAGI.OpenAI.HostedToolPermission mcp,
            global::tryAGI.OpenAI.HostedToolPermission codeInterpreter)
        {
            this.FileSearch = fileSearch ?? throw new global::System.ArgumentNullException(nameof(fileSearch));
            this.WebSearch = webSearch ?? throw new global::System.ArgumentNullException(nameof(webSearch));
            this.ImageGeneration = imageGeneration ?? throw new global::System.ArgumentNullException(nameof(imageGeneration));
            this.Mcp = mcp ?? throw new global::System.ArgumentNullException(nameof(mcp));
            this.CodeInterpreter = codeInterpreter ?? throw new global::System.ArgumentNullException(nameof(codeInterpreter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectHostedToolPermissions" /> class.
        /// </summary>
        public ProjectHostedToolPermissions()
        {
        }

    }
}