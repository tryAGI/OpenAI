
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.update`.
    /// </summary>
    public enum RealtimeTranslationClientEventSessionUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationClientEventSessionUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationClientEventSessionUpdateType value)
        {
            return value switch
            {
                RealtimeTranslationClientEventSessionUpdateType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationClientEventSessionUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "session.update" => RealtimeTranslationClientEventSessionUpdateType.SessionUpdate,
                _ => null,
            };
        }
    }
}