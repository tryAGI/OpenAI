
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A credential-free history record of the emitted login request.
    /// </summary>
    public sealed partial class BrowserAuthenticationRequestItemResource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication Request { get; set; }

        /// <summary>
        /// The stable history item ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The item type. Always computer_use_approval_request.<br/>
        /// Default Value: computer_use_approval_request
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType.ComputerUseApprovalRequest</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BrowserAuthenticationRequestItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType Type { get; set; } = global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType.ComputerUseApprovalRequest;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationRequestItemResource" /> class.
        /// </summary>
        /// <param name="turnId"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="id">
        /// The stable history item ID.
        /// </param>
        /// <param name="type">
        /// The item type. Always computer_use_approval_request.<br/>
        /// Default Value: computer_use_approval_request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserAuthenticationRequestItemResource(
            string turnId,
            string requestId,
            global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication request,
            string id,
            global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType type = global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType.ComputerUseApprovalRequest)
        {
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationRequestItemResource" /> class.
        /// </summary>
        public BrowserAuthenticationRequestItemResource()
        {
        }

    }
}