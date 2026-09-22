
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.input_audio.unmute`.<br/>
    /// Default Value: session.input_audio.unmute
    /// </summary>
    public enum LiveInputAudioUnmuteParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioUnmute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInputAudioUnmuteParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInputAudioUnmuteParamType value)
        {
            return value switch
            {
                LiveInputAudioUnmuteParamType.SessionInputAudioUnmute => "session.input_audio.unmute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInputAudioUnmuteParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_audio.unmute" => LiveInputAudioUnmuteParamType.SessionInputAudioUnmute,
                _ => null,
            };
        }
    }
}