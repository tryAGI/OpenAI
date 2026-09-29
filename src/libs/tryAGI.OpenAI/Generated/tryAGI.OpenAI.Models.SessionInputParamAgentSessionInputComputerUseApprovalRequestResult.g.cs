
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Responds to a pending Computer Use approval request.
    /// </summary>
    public sealed partial class SessionInputParamAgentSessionInputComputerUseApprovalRequestResult
    {
        /// <summary>
        /// The type of the object. Always `agent.session.input.computer_use_approval_request_result`.<br/>
        /// Default Value: agent.session.input.computer_use_approval_request_result
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType.AgentSessionInputComputerUseApprovalRequestResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType Type { get; set; } = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType.AgentSessionInputComputerUseApprovalRequestResult;

        /// <summary>
        /// The registered request ID from the required action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The response for this request type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerUseApprovalResponseParam Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputComputerUseApprovalRequestResult" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The registered request ID from the required action.
        /// </param>
        /// <param name="response">
        /// The response for this request type.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.input.computer_use_approval_request_result`.<br/>
        /// Default Value: agent.session.input.computer_use_approval_request_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInputParamAgentSessionInputComputerUseApprovalRequestResult(
            string requestId,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParam response,
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType type = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType.AgentSessionInputComputerUseApprovalRequestResult)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputComputerUseApprovalRequestResult" /> class.
        /// </summary>
        public SessionInputParamAgentSessionInputComputerUseApprovalRequestResult()
        {
        }

    }
}