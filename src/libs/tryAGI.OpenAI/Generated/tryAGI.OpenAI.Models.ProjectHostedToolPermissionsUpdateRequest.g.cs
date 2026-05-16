
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectHostedToolPermissionsUpdateRequest
    {
        /// <summary>
        /// The file search permission update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? FileSearch { get; set; }

        /// <summary>
        /// The web search permission update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? WebSearch { get; set; }

        /// <summary>
        /// The image generation permission update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_generation")]
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? ImageGeneration { get; set; }

        /// <summary>
        /// The MCP permission update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? Mcp { get; set; }

        /// <summary>
        /// The code interpreter permission update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter")]
        public global::tryAGI.OpenAI.HostedToolPermissionUpdate? CodeInterpreter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectHostedToolPermissionsUpdateRequest" /> class.
        /// </summary>
        /// <param name="fileSearch">
        /// The file search permission update.
        /// </param>
        /// <param name="webSearch">
        /// The web search permission update.
        /// </param>
        /// <param name="imageGeneration">
        /// The image generation permission update.
        /// </param>
        /// <param name="mcp">
        /// The MCP permission update.
        /// </param>
        /// <param name="codeInterpreter">
        /// The code interpreter permission update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectHostedToolPermissionsUpdateRequest(
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? fileSearch,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? webSearch,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? imageGeneration,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? mcp,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? codeInterpreter)
        {
            this.FileSearch = fileSearch;
            this.WebSearch = webSearch;
            this.ImageGeneration = imageGeneration;
            this.Mcp = mcp;
            this.CodeInterpreter = codeInterpreter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectHostedToolPermissionsUpdateRequest" /> class.
        /// </summary>
        public ProjectHostedToolPermissionsUpdateRequest()
        {
        }

    }
}