
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
        /// <default>"webrtc"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "webrtc";

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
            string type = "webrtc")
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

        /// <summary>
        /// Creates a new <see cref="LiveWebRTCTransport"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveWebRTCTransport FromSdp(string sdp)
        {
            return new LiveWebRTCTransport
            {
                Sdp = sdp,
            };
        }

    }
}