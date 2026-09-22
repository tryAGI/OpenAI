
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The created Live session identifier and WebRTC answer. Apply transport.sdp as the peer's remote answer and wait for session.started on the data channel before sending commands.
    /// </summary>
    public sealed partial class LiveCreateResponse
    {
        /// <summary>
        /// The newly created Live session. Use its ID for session controls and sideband connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveCreateResponseSession Session { get; set; }

        /// <summary>
        /// WebRTC transport with the SDP answer.
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
        /// Initializes a new instance of the <see cref="LiveCreateResponse" /> class.
        /// </summary>
        /// <param name="session">
        /// The newly created Live session. Use its ID for session controls and sideband connections.
        /// </param>
        /// <param name="transport">
        /// WebRTC transport with the SDP answer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCreateResponse(
            global::tryAGI.OpenAI.LiveCreateResponseSession session,
            global::tryAGI.OpenAI.LiveWebRTCTransport transport)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCreateResponse" /> class.
        /// </summary>
        public LiveCreateResponse()
        {
        }

    }
}