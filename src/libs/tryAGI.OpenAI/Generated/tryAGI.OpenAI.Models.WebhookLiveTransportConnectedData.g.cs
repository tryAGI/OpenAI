
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookLiveTransportConnectedData
    {
        /// <summary>
        /// The session transport.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookLiveTransportConnectedDataTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookLiveTransportConnectedDataType Type { get; set; }

        /// <summary>
        /// The Live session ID to use with the sideband attach endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportConnectedData" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The Live session ID to use with the sideband attach endpoint.
        /// </param>
        /// <param name="type">
        /// The session transport.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookLiveTransportConnectedData(
            string sessionId,
            global::tryAGI.OpenAI.WebhookLiveTransportConnectedDataType type)
        {
            this.Type = type;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportConnectedData" /> class.
        /// </summary>
        public WebhookLiveTransportConnectedData()
        {
        }

    }
}