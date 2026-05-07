
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.close`.
    /// </summary>
    public enum RealtimeTranslationClientEventSessionCloseType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionClose,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationClientEventSessionCloseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationClientEventSessionCloseType value)
        {
            return value switch
            {
                RealtimeTranslationClientEventSessionCloseType.SessionClose => "session.close",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationClientEventSessionCloseType? ToEnum(string value)
        {
            return value switch
            {
                "session.close" => RealtimeTranslationClientEventSessionCloseType.SessionClose,
                _ => null,
            };
        }
    }
}