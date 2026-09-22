
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.input_audio.muted`.<br/>
    /// Default Value: session.input_audio.muted
    /// </summary>
    public enum LiveInputAudioMutedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioMuted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInputAudioMutedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInputAudioMutedType value)
        {
            return value switch
            {
                LiveInputAudioMutedType.SessionInputAudioMuted => "session.input_audio.muted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInputAudioMutedType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_audio.muted" => LiveInputAudioMutedType.SessionInputAudioMuted,
                _ => null,
            };
        }
    }
}