
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Resume audio input to a Live model after muting it. The server acknowledges with `session.input_audio.unmuted`.<br/>
    /// Example: {"type":"session.input_audio.unmute","event_id":"evt_unmute_001"}
    /// </summary>
    public sealed partial class LiveInputAudioUnmuteParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.input_audio.unmute`.<br/>
        /// Default Value: session.input_audio.unmute
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType.SessionInputAudioUnmute</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInputAudioUnmuteParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType Type { get; set; } = global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType.SessionInputAudioUnmute;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioUnmuteParam" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.input_audio.unmute`.<br/>
        /// Default Value: session.input_audio.unmute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInputAudioUnmuteParam(
            string? eventId,
            global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType type = global::tryAGI.OpenAI.LiveInputAudioUnmuteParamType.SessionInputAudioUnmute)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioUnmuteParam" /> class.
        /// </summary>
        public LiveInputAudioUnmuteParam()
        {
        }

    }
}