
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Audio format for the new WebSocket connection to a forked Live session. The stored voice is preserved.
    /// </summary>
    public sealed partial class LiveForkAudioParam
    {
        /// <summary>
        /// Audio encoding and sample rate for audio sent and received over a Live WebSocket connection. WebRTC and SIP negotiate their media format separately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.LiveAudioFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkAudioParam" /> class.
        /// </summary>
        /// <param name="format">
        /// Audio encoding and sample rate for audio sent and received over a Live WebSocket connection. WebRTC and SIP negotiate their media format separately.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveForkAudioParam(
            global::tryAGI.OpenAI.LiveAudioFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkAudioParam" /> class.
        /// </summary>
        public LiveForkAudioParam()
        {
        }

    }
}