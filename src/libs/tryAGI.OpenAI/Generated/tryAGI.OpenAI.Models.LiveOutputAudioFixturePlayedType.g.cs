
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: session.output_audio.fixture.played
    /// </summary>
    public enum LiveOutputAudioFixturePlayedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionOutputAudioFixturePlayed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveOutputAudioFixturePlayedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveOutputAudioFixturePlayedType value)
        {
            return value switch
            {
                LiveOutputAudioFixturePlayedType.SessionOutputAudioFixturePlayed => "session.output_audio.fixture.played",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveOutputAudioFixturePlayedType? ToEnum(string value)
        {
            return value switch
            {
                "session.output_audio.fixture.played" => LiveOutputAudioFixturePlayedType.SessionOutputAudioFixturePlayed,
                _ => null,
            };
        }
    }
}