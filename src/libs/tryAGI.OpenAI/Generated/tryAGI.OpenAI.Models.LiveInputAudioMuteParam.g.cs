
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Mute audio input to the Live model without closing the session. The server acknowledges with `session.input_audio.muted`.<br/>
    /// Example: {"type":"session.input_audio.mute","event_id":"evt_mute_001"}
    /// </summary>
    public sealed partial class LiveInputAudioMuteParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.input_audio.mute`.<br/>
        /// Default Value: session.input_audio.mute
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInputAudioMuteParamType.SessionInputAudioMute</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInputAudioMuteParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInputAudioMuteParamType Type { get; set; } = global::tryAGI.OpenAI.LiveInputAudioMuteParamType.SessionInputAudioMute;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioMuteParam" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.input_audio.mute`.<br/>
        /// Default Value: session.input_audio.mute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInputAudioMuteParam(
            string? eventId,
            global::tryAGI.OpenAI.LiveInputAudioMuteParamType type = global::tryAGI.OpenAI.LiveInputAudioMuteParamType.SessionInputAudioMute)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioMuteParam" /> class.
        /// </summary>
        public LiveInputAudioMuteParam()
        {
        }

    }
}