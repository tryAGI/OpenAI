
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a Live WebRTC session with JSON session configuration and an SDP offer. Follow the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) before choosing frontend and backend instructions. The request starts the session; do not send session.start on the data channel.
    /// </summary>
    public sealed partial class LiveCreateRequest
    {
        /// <summary>
        /// Startup configuration for the Live session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveMediaSessionCreateParams Session { get; set; }

        /// <summary>
        /// WebRTC transport with the browser's SDP offer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveWebRTCTransport Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCreateRequest" /> class.
        /// </summary>
        /// <param name="session">
        /// Startup configuration for the Live session.
        /// </param>
        /// <param name="transport">
        /// WebRTC transport with the browser's SDP offer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCreateRequest(
            global::tryAGI.OpenAI.LiveMediaSessionCreateParams session,
            global::tryAGI.OpenAI.LiveWebRTCTransport transport)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCreateRequest" /> class.
        /// </summary>
        public LiveCreateRequest()
        {
        }

    }
}