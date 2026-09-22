
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Fork a stored Live session onto a new WebRTC connection. Omit session or send an empty object to inherit its configuration.
    /// </summary>
    public sealed partial class LiveForkRequest
    {
        /// <summary>
        /// Optional configuration overrides for the new Live session. Omit this object or send an empty object to inherit the stored session's settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::tryAGI.OpenAI.LiveMediaSessionForkParams? Session { get; set; }

        /// <summary>
        /// WebRTC transport with an SDP offer for the new connection to the forked session.
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
        /// Initializes a new instance of the <see cref="LiveForkRequest" /> class.
        /// </summary>
        /// <param name="transport">
        /// WebRTC transport with an SDP offer for the new connection to the forked session.
        /// </param>
        /// <param name="session">
        /// Optional configuration overrides for the new Live session. Omit this object or send an empty object to inherit the stored session's settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveForkRequest(
            global::tryAGI.OpenAI.LiveWebRTCTransport transport,
            global::tryAGI.OpenAI.LiveMediaSessionForkParams? session)
        {
            this.Session = session;
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkRequest" /> class.
        /// </summary>
        public LiveForkRequest()
        {
        }

    }
}