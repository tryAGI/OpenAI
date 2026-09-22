
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Connects to an MCP server over HTTP.
    /// </summary>
    public sealed partial class PersistedMcpTransportConfigParamHttp
    {
        /// <summary>
        /// The type of the object. Always `http`.<br/>
        /// Default Value: http
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType.Http</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamHttpTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType Type { get; set; } = global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType.Http;

        /// <summary>
        /// The URL of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// Non-secret HTTP headers sent to the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedMcpTransportConfigParamHttp" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The URL of the MCP server.
        /// </param>
        /// <param name="headers">
        /// Non-secret HTTP headers sent to the MCP server.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `http`.<br/>
        /// Default Value: http
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedMcpTransportConfigParamHttp(
            string serverUrl,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType type = global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType.Http)
        {
            this.Type = type;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedMcpTransportConfigParamHttp" /> class.
        /// </summary>
        public PersistedMcpTransportConfigParamHttp()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PersistedMcpTransportConfigParamHttp"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PersistedMcpTransportConfigParamHttp FromServerUrl(string serverUrl)
        {
            return new PersistedMcpTransportConfigParamHttp
            {
                ServerUrl = serverUrl,
            };
        }

    }
}