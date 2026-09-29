
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Respond to a computer-use request.
    /// </summary>
    public sealed partial class SessionRequiredActionResourceComputerUseApprovalRequest
    {
        /// <summary>
        /// The type of the object. Always `computer_use_approval_request`.<br/>
        /// Default Value: computer_use_approval_request
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType.ComputerUseApprovalRequest</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceComputerUseApprovalRequestTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType Type { get; set; } = global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType.ComputerUseApprovalRequest;

        /// <summary>
        /// The turn that requested approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The registered request ID to echo when responding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The information needed to render the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceComputerUseApprovalRequest" /> class.
        /// </summary>
        /// <param name="turnId">
        /// The turn that requested approval.
        /// </param>
        /// <param name="requestId">
        /// The registered request ID to echo when responding.
        /// </param>
        /// <param name="request">
        /// The information needed to render the request.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `computer_use_approval_request`.<br/>
        /// Default Value: computer_use_approval_request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionRequiredActionResourceComputerUseApprovalRequest(
            string turnId,
            string requestId,
            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource request,
            global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType type = global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType.ComputerUseApprovalRequest)
        {
            this.Type = type;
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceComputerUseApprovalRequest" /> class.
        /// </summary>
        public SessionRequiredActionResourceComputerUseApprovalRequest()
        {
        }

    }
}