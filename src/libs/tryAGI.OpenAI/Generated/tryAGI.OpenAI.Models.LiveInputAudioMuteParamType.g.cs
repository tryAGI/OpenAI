
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.input_audio.mute`.<br/>
    /// Default Value: session.input_audio.mute
    /// </summary>
    public enum LiveInputAudioMuteParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioMute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInputAudioMuteParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInputAudioMuteParamType value)
        {
            return value switch
            {
                LiveInputAudioMuteParamType.SessionInputAudioMute => "session.input_audio.mute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInputAudioMuteParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_audio.mute" => LiveInputAudioMuteParamType.SessionInputAudioMute,
                _ => null,
            };
        }
    }
}