
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Play one complete audio fixture through the session output. Send this event over the primary WebSocket or a server sideband. Audio must be raw mono PCM16 little-endian at 24 kHz, regardless of the session audio format, and at most 30 seconds. The entire payload is validated before model speech is interrupted and input is muted. Only one fixture can be active. fixture.playing acknowledges acceptance and fixture.played reports server mixer drain. These notifications are not exact transport-media boundaries. Input arriving during playback is dropped and not replayed.<br/>
    /// Example: {"type":"session.output_audio.fixture.play","event_id":"evt_play_001","audio":"AAAAAA=="}
    /// </summary>
    public sealed partial class LiveOutputAudioFixturePlayParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Default Value: session.output_audio.fixture.play
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType.SessionOutputAudioFixturePlay</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveOutputAudioFixturePlayParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType Type { get; set; } = global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType.SessionOutputAudioFixturePlay;

        /// <summary>
        /// Base64-encoded raw mono PCM16 audio, little-endian, at 24 kHz. Do not include a WAV or other container header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputAudioFixturePlayParam" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded raw mono PCM16 audio, little-endian, at 24 kHz. Do not include a WAV or other container header.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// Default Value: session.output_audio.fixture.play
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveOutputAudioFixturePlayParam(
            string audio,
            string? eventId,
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType type = global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParamType.SessionOutputAudioFixturePlay)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputAudioFixturePlayParam" /> class.
        /// </summary>
        public LiveOutputAudioFixturePlayParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveOutputAudioFixturePlayParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveOutputAudioFixturePlayParam FromAudio(string audio)
        {
            return new LiveOutputAudioFixturePlayParam
            {
                Audio = audio,
            };
        }

    }
}