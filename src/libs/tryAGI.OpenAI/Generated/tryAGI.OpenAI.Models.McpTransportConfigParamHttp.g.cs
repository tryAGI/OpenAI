
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Connects to an MCP server over HTTP.
    /// </summary>
    public sealed partial class McpTransportConfigParamHttp
    {
        /// <summary>
        /// The type of the object. Always `http`.<br/>
        /// Default Value: http
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpTransportConfigParamHttpType.Http</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamHttpTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpTransportConfigParamHttpType Type { get; set; } = global::tryAGI.OpenAI.McpTransportConfigParamHttpType.Http;

        /// <summary>
        /// The URL of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// The authorization value sent to the MCP server, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// Additional HTTP headers sent to the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpTransportConfigParamHttp" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The URL of the MCP server.
        /// </param>
        /// <param name="authorization">
        /// The authorization value sent to the MCP server, if any.
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers sent to the MCP server.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `http`.<br/>
        /// Default Value: http
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpTransportConfigParamHttp(
            string serverUrl,
            string? authorization,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::tryAGI.OpenAI.McpTransportConfigParamHttpType type = global::tryAGI.OpenAI.McpTransportConfigParamHttpType.Http)
        {
            this.Type = type;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.Authorization = authorization;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpTransportConfigParamHttp" /> class.
        /// </summary>
        public McpTransportConfigParamHttp()
        {
        }

        /// <summary>
        /// Creates a new <see cref="McpTransportConfigParamHttp"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static McpTransportConfigParamHttp FromServerUrl(string serverUrl)
        {
            return new McpTransportConfigParamHttp
            {
                ServerUrl = serverUrl,
            };
        }

    }
}