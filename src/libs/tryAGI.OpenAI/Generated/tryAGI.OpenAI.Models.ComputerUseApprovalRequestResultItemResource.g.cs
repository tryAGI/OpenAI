
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A credential-free record of an admitted response, not proof of completion.
    /// </summary>
    public sealed partial class ComputerUseApprovalRequestResultItemResource
    {
        /// <summary>
        /// The stable history item ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: computer_use_approval_request_result
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType.ComputerUseApprovalRequestResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestResultItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType.ComputerUseApprovalRequestResult;

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The registered request answered by this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The admitted response, without submitted credential values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalRequestResultItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The stable history item ID.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="requestId">
        /// The registered request answered by this item.
        /// </param>
        /// <param name="response">
        /// The admitted response, without submitted credential values.
        /// </param>
        /// <param name="type">
        /// Default Value: computer_use_approval_request_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalRequestResultItemResource(
            string id,
            string turnId,
            string requestId,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource response,
            global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType type = global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType.ComputerUseApprovalRequestResult)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalRequestResultItemResource" /> class.
        /// </summary>
        public ComputerUseApprovalRequestResultItemResource()
        {
        }

    }
}