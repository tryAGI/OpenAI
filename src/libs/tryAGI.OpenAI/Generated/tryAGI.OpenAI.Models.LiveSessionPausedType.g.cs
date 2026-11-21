
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: session.paused
    /// </summary>
    public enum LiveSessionPausedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionPaused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionPausedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionPausedType value)
        {
            return value switch
            {
                LiveSessionPausedType.SessionPaused => "session.paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionPausedType? ToEnum(string value)
        {
            return value switch
            {
                "session.paused" => LiveSessionPausedType.SessionPaused,
                _ => null,
            };
        }
    }
}