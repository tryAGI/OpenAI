
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The complete audio fixture has drained from the server mixer and normal inference has resumed. Transport buffers may still contain audio; this event does not prove listener-side completion. The optional client_event_id echoes the play command. This event is not emitted for canceled or failed playback.<br/>
    /// Example: {"type":"session.output_audio.fixture.played","event_id":"evt_played_001","client_event_id":"evt_play_001"}
    /// </summary>
    public sealed partial class LiveOutputAudioFixturePlayed
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
        /// Default Value: session.output_audio.fixture.played
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType.SessionOutputAudioFixturePlayed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveOutputAudioFixturePlayedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType Type { get; set; } = global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType.SessionOutputAudioFixturePlayed;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputAudioFixturePlayed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// Default Value: session.output_audio.fixture.played
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveOutputAudioFixturePlayed(
            string eventId,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType type = global::tryAGI.OpenAI.LiveOutputAudioFixturePlayedType.SessionOutputAudioFixturePlayed)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveOutputAudioFixturePlayed" /> class.
        /// </summary>
        public LiveOutputAudioFixturePlayed()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveOutputAudioFixturePlayed"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveOutputAudioFixturePlayed FromEventId(string eventId)
        {
            return new LiveOutputAudioFixturePlayed
            {
                EventId = eventId,
            };
        }

    }
}