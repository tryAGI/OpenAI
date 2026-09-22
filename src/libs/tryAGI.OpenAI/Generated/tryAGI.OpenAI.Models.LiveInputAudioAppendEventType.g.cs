
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.input_audio.append`.<br/>
    /// Default Value: session.input_audio.append
    /// </summary>
    public enum LiveInputAudioAppendEventType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInputAudioAppendEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInputAudioAppendEventType value)
        {
            return value switch
            {
                LiveInputAudioAppendEventType.SessionInputAudioAppend => "session.input_audio.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInputAudioAppendEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_audio.append" => LiveInputAudioAppendEventType.SessionInputAudioAppend,
                _ => null,
            };
        }
    }
}