
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: session.output_audio.fixture.play
    /// </summary>
    public enum LiveOutputAudioFixturePlayParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionOutputAudioFixturePlay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveOutputAudioFixturePlayParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveOutputAudioFixturePlayParamType value)
        {
            return value switch
            {
                LiveOutputAudioFixturePlayParamType.SessionOutputAudioFixturePlay => "session.output_audio.fixture.play",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveOutputAudioFixturePlayParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.output_audio.fixture.play" => LiveOutputAudioFixturePlayParamType.SessionOutputAudioFixturePlay,
                _ => null,
            };
        }
    }
}