
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.updated`.
    /// </summary>
    public enum RealtimeTranslationServerEventSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventSessionUpdatedType value)
        {
            return value switch
            {
                RealtimeTranslationServerEventSessionUpdatedType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => RealtimeTranslationServerEventSessionUpdatedType.SessionUpdated,
                _ => null,
            };
        }
    }
}