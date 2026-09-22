
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPProtocolError
    {
        /// <summary>
        /// Default Value: mcp_protocol_error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.MCPProtocolErrorType.McpProtocolError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MCPProtocolErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.MCPProtocolErrorType Type { get; set; } = global::tryAGI.OpenAI.MCPProtocolErrorType.McpProtocolError;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProtocolError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="type">
        /// Default Value: mcp_protocol_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPProtocolError(
            int code,
            string message,
            global::tryAGI.OpenAI.MCPProtocolErrorType type = global::tryAGI.OpenAI.MCPProtocolErrorType.McpProtocolError)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProtocolError" /> class.
        /// </summary>
        public MCPProtocolError()
        {
        }

    }
}