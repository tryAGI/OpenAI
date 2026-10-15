
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The existing playback path has accepted the validated audio fixture. This acknowledgment does not identify when the listener receives the first sample. The optional client_event_id echoes the play command.<br/>
    /// Example: {"type":"session.output_audio.fixture.playing","event_id":"evt_playing_001","client_event_id":"evt_play_001"}
    /// </summary>
    public sealed partial class LiveOutputAudioFixturePlaying
    {
        /// <summary>
        /// The unique ID of the Live server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event_id of the client command associated with this server event, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// Default Value: session.output_audio.fixture.playing
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType.SessionOutputAudioFixturePlaying</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveOutputAudioFixturePlayingTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType Type { get; set; } = global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType.SessionOutputAudioFixturePlaying;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputAudioFixturePlaying" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// Default Value: session.output_audio.fixture.playing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveOutputAudioFixturePlaying(
            string eventId,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType type = global::tryAGI.OpenAI.LiveOutputAudioFixturePlayingType.SessionOutputAudioFixturePlaying)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputAudioFixturePlaying" /> class.
        /// </summary>
        public LiveOutputAudioFixturePlaying()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveOutputAudioFixturePlaying"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveOutputAudioFixturePlaying FromEventId(string eventId)
        {
            return new LiveOutputAudioFixturePlaying
            {
                EventId = eventId,
            };
        }

    }
}