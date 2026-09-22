
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Submits the result of a function call.
    /// </summary>
    public sealed partial class SessionInputParamAgentSessionInputToolResult
    {
        /// <summary>
        /// The type of the object. Always `agent.session.input.tool_result`.<br/>
        /// Default Value: agent.session.input.tool_result
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType.AgentSessionInputToolResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputToolResultTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType Type { get; set; } = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType.AgentSessionInputToolResult;

        /// <summary>
        /// The ID of the turn that requested the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The ID of the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Whether the function call succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The function result when the call succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.FunctionCallOutputParam? Output { get; set; }

        /// <summary>
        /// The error message when the call failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputToolResult" /> class.
        /// </summary>
        /// <param name="turnId">
        /// The ID of the turn that requested the function call.
        /// </param>
        /// <param name="callId">
        /// The ID of the function call.
        /// </param>
        /// <param name="success">
        /// Whether the function call succeeded.
        /// </param>
        /// <param name="output">
        /// The function result when the call succeeded.
        /// </param>
        /// <param name="error">
        /// The error message when the call failed.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.input.tool_result`.<br/>
        /// Default Value: agent.session.input.tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInputParamAgentSessionInputToolResult(
            string turnId,
            string callId,
            bool success,
            global::tryAGI.OpenAI.FunctionCallOutputParam? output,
            string? error,
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType type = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType.AgentSessionInputToolResult)
        {
            this.Type = type;
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Success = success;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputToolResult" /> class.
        /// </summary>
        public SessionInputParamAgentSessionInputToolResult()
        {
        }

    }
}