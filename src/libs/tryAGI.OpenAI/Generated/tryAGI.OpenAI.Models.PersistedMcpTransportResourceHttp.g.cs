
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Connects to an MCP server over HTTP.
    /// </summary>
    public sealed partial class PersistedMcpTransportResourceHttp
    {
        /// <summary>
        /// The type of the object. Always `http`.<br/>
        /// Default Value: http
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType.Http</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceHttpTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType Type { get; set; } = global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType.Http;

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedMcpTransportResourceHttp" /> class.
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
        public PersistedMcpTransportResourceHttp(
            string serverUrl,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType type = global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType.Http)
        {
            this.Type = type;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedMcpTransportResourceHttp" /> class.
        /// </summary>
        public PersistedMcpTransportResourceHttp()
        {
        }

    }
}