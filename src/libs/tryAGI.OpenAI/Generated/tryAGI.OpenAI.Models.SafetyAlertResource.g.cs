
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SafetyAlertResource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: safety.alert
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SafetyAlertResourceObject.SafetyAlert</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SafetyAlertResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SafetyAlertResourceObject Object { get; set; } = global::tryAGI.OpenAI.SafetyAlertResourceObject.SafetyAlert;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Whether block registration succeeded for this request. This does not confirm that response execution stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_paused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequestPaused { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SafetyAlertErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SafetyAlertErrorType ErrorType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyAlertResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="requestId"></param>
        /// <param name="responseId"></param>
        /// <param name="model"></param>
        /// <param name="requestPaused">
        /// Whether block registration succeeded for this request. This does not confirm that response execution stopped.
        /// </param>
        /// <param name="errorType"></param>
        /// <param name="reason"></param>
        /// <param name="object">
        /// Default Value: safety.alert
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyAlertResource(
            string id,
            int createdAt,
            string requestId,
            string responseId,
            string model,
            bool requestPaused,
            global::tryAGI.OpenAI.SafetyAlertErrorType errorType,
            string? reason,
            global::tryAGI.OpenAI.SafetyAlertResourceObject @object = global::tryAGI.OpenAI.SafetyAlertResourceObject.SafetyAlert)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.RequestPaused = requestPaused;
            this.ErrorType = errorType;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyAlertResource" /> class.
        /// </summary>
        public SafetyAlertResource()
        {
        }

    }
}