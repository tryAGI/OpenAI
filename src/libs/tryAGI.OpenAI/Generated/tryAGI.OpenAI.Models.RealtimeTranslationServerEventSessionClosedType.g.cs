
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.closed`.
    /// </summary>
    public enum RealtimeTranslationServerEventSessionClosedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventSessionClosedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventSessionClosedType value)
        {
            return value switch
            {
                RealtimeTranslationServerEventSessionClosedType.SessionClosed => "session.closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventSessionClosedType? ToEnum(string value)
        {
            return value switch
            {
                "session.closed" => RealtimeTranslationServerEventSessionClosedType.SessionClosed,
                _ => null,
            };
        }
    }
}