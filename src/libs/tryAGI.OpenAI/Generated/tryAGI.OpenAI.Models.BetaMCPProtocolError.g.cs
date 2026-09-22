
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMCPProtocolError
    {
        /// <summary>
        /// Default Value: mcp_protocol_error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMCPProtocolErrorType.McpProtocolError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMCPProtocolErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMCPProtocolErrorType Type { get; set; } = global::tryAGI.OpenAI.BetaMCPProtocolErrorType.McpProtocolError;

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
        /// Initializes a new instance of the <see cref="BetaMCPProtocolError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="type">
        /// Default Value: mcp_protocol_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMCPProtocolError(
            int code,
            string message,
            global::tryAGI.OpenAI.BetaMCPProtocolErrorType type = global::tryAGI.OpenAI.BetaMCPProtocolErrorType.McpProtocolError)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPProtocolError" /> class.
        /// </summary>
        public BetaMCPProtocolError()
        {
        }

    }
}