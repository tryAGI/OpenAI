
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// **WebRTC Only:** Emit to cut off the current audio response. This will trigger the server to<br/>
    /// stop generating audio and emit a `output_audio_buffer.cleared` event. This <br/>
    /// event should be preceded by a `response.cancel` client event to stop the <br/>
    /// generation of the current response.<br/>
    /// [Learn more](https://platform.openai.com/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
    /// </summary>
    public sealed partial class RealtimeBetaClientEventOutputAudioBufferClear
    {
        /// <summary>
        /// The unique ID of the client event used for error handling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `output_audio_buffer.clear`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventOutputAudioBufferClearTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClearType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaClientEventOutputAudioBufferClear" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the client event used for error handling.
        /// </param>
        /// <param name="type">
        /// The event type, must be `output_audio_buffer.clear`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaClientEventOutputAudioBufferClear(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeBetaClientEventOutputAudioBufferClearType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaClientEventOutputAudioBufferClear" /> class.
        /// </summary>
        public RealtimeBetaClientEventOutputAudioBufferClear()
        {
        }
    }
}