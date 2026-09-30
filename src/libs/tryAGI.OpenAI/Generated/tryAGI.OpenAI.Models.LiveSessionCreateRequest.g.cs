
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a Live session with a WebRTC SDP offer or place an outbound SIP call. Follow the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) before choosing frontend and backend instructions. The request starts the session; do not send session.start again on the data channel or sideband.
    /// </summary>
    public sealed partial class LiveSessionCreateRequest
    {
        /// <summary>
        /// Startup configuration for the Live session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveMediaSessionCreateParams Session { get; set; }

        /// <summary>
        /// WebRTC transport with an SDP offer, or SIP transport with a destination and per-call trunk credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Transport Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCreateRequest" /> class.
        /// </summary>
        /// <param name="session">
        /// Startup configuration for the Live session.
        /// </param>
        /// <param name="transport">
        /// WebRTC transport with an SDP offer, or SIP transport with a destination and per-call trunk credentials.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionCreateRequest(
            global::tryAGI.OpenAI.LiveMediaSessionCreateParams session,
            global::tryAGI.OpenAI.Transport transport)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCreateRequest" /> class.
        /// </summary>
        public LiveSessionCreateRequest()
        {
        }

    }
}