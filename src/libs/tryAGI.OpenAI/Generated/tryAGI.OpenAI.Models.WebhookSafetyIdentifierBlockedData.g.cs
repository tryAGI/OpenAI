
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event data payload.
    /// </summary>
    public sealed partial class WebhookSafetyIdentifierBlockedData
    {
        /// <summary>
        /// The stable safety identifier associated with the blocked request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SafetyIdentifier { get; set; }

        /// <summary>
        /// The safety category that triggered the block, such as `bio` or `cyber`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SafetyCategory { get; set; }

        /// <summary>
        /// The OpenAI request ID for the blocked request, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The project associated with the blocked request, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The model used for the blocked request, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSafetyIdentifierBlockedData" /> class.
        /// </summary>
        /// <param name="safetyIdentifier">
        /// The stable safety identifier associated with the blocked request.
        /// </param>
        /// <param name="safetyCategory">
        /// The safety category that triggered the block, such as `bio` or `cyber`.
        /// </param>
        /// <param name="requestId">
        /// The OpenAI request ID for the blocked request, if available.
        /// </param>
        /// <param name="projectId">
        /// The project associated with the blocked request, if available.
        /// </param>
        /// <param name="model">
        /// The model used for the blocked request, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSafetyIdentifierBlockedData(
            string safetyIdentifier,
            string safetyCategory,
            string? requestId,
            string? projectId,
            string? model)
        {
            this.SafetyIdentifier = safetyIdentifier ?? throw new global::System.ArgumentNullException(nameof(safetyIdentifier));
            this.SafetyCategory = safetyCategory ?? throw new global::System.ArgumentNullException(nameof(safetyCategory));
            this.RequestId = requestId;
            this.ProjectId = projectId;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSafetyIdentifierBlockedData" /> class.
        /// </summary>
        public WebhookSafetyIdentifierBlockedData()
        {
        }

    }
}