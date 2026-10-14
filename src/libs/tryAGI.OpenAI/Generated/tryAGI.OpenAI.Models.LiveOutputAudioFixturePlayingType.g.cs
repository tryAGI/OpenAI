
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: session.output_audio.fixture.playing
    /// </summary>
    public enum LiveOutputAudioFixturePlayingType
    {
        /// <summary>
        ///
        /// </summary>
        SessionOutputAudioFixturePlaying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveOutputAudioFixturePlayingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveOutputAudioFixturePlayingType value)
        {
            return value switch
            {
                LiveOutputAudioFixturePlayingType.SessionOutputAudioFixturePlaying => "session.output_audio.fixture.playing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveOutputAudioFixturePlayingType? ToEnum(string value)
        {
            return value switch
            {
                "session.output_audio.fixture.playing" => LiveOutputAudioFixturePlayingType.SessionOutputAudioFixturePlaying,
                _ => null,
            };
        }
    }
}