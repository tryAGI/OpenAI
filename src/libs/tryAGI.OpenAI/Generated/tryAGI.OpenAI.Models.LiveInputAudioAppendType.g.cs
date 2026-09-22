
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.input_audio.append`.<br/>
    /// Default Value: session.input_audio.append
    /// </summary>
    public enum LiveInputAudioAppendType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInputAudioAppendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInputAudioAppendType value)
        {
            return value switch
            {
                LiveInputAudioAppendType.SessionInputAudioAppend => "session.input_audio.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInputAudioAppendType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_audio.append" => LiveInputAudioAppendType.SessionInputAudioAppend,
                _ => null,
            };
        }
    }
}