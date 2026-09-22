
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// WebRTC transport carrying the offer SDP in a creation request or answer SDP in its response.
    /// </summary>
    public sealed partial class LiveWebRTCTransport
    {
        /// <summary>
        /// The transport used for the Live session. Always `webrtc`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveWebRTCTransportTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveWebRTCTransportType Type { get; set; }

        /// <summary>
        /// Session Description Protocol message for the WebRTC connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sdp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveWebRTCTransport" /> class.
        /// </summary>
        /// <param name="sdp">
        /// Session Description Protocol message for the WebRTC connection.
        /// </param>
        /// <param name="type">
        /// The transport used for the Live session. Always `webrtc`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveWebRTCTransport(
            string sdp,
            global::tryAGI.OpenAI.LiveWebRTCTransportType type)
        {
            this.Type = type;
            this.Sdp = sdp ?? throw new global::System.ArgumentNullException(nameof(sdp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveWebRTCTransport" /> class.
        /// </summary>
        public LiveWebRTCTransport()
        {
        }

    }
}