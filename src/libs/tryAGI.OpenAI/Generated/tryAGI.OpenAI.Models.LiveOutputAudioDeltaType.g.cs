
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.output_audio.delta`.<br/>
    /// Default Value: session.output_audio.delta
    /// </summary>
    public enum LiveOutputAudioDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        SessionOutputAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveOutputAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveOutputAudioDeltaType value)
        {
            return value switch
            {
                LiveOutputAudioDeltaType.SessionOutputAudioDelta => "session.output_audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveOutputAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "session.output_audio.delta" => LiveOutputAudioDeltaType.SessionOutputAudioDelta,
                _ => null,
            };
        }
    }
}