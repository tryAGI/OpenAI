
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.input_audio.unmuted`.<br/>
    /// Default Value: session.input_audio.unmuted
    /// </summary>
    public enum LiveInputAudioUnmutedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioUnmuted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInputAudioUnmutedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInputAudioUnmutedType value)
        {
            return value switch
            {
                LiveInputAudioUnmutedType.SessionInputAudioUnmuted => "session.input_audio.unmuted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInputAudioUnmutedType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_audio.unmuted" => LiveInputAudioUnmutedType.SessionInputAudioUnmuted,
                _ => null,
            };
        }
    }
}