
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Connects to an MCP server over HTTP.
    /// </summary>
    public sealed partial class McpTransportResourceHttp
    {
        /// <summary>
        /// The type of the object. Always `http`.<br/>
        /// Default Value: http
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpTransportResourceHttpType.Http</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpTransportResourceHttpTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpTransportResourceHttpType Type { get; set; } = global::tryAGI.OpenAI.McpTransportResourceHttpType.Http;

        /// <summary>
        /// The URL of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpTransportResourceHttp" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The URL of the MCP server.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `http`.<br/>
        /// Default Value: http
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpTransportResourceHttp(
            string serverUrl,
            global::tryAGI.OpenAI.McpTransportResourceHttpType type = global::tryAGI.OpenAI.McpTransportResourceHttpType.Http)
        {
            this.Type = type;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpTransportResourceHttp" /> class.
        /// </summary>
        public McpTransportResourceHttp()
        {
        }

        /// <summary>
        /// Creates a new <see cref="McpTransportResourceHttp"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static McpTransportResourceHttp FromServerUrl(string serverUrl)
        {
            return new McpTransportResourceHttp
            {
                ServerUrl = serverUrl,
            };
        }

    }
}